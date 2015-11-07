using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.IO;
using Google.API.Search;

namespace TagMp3Magician
{
    public class BusquedaImagenesUrl
    {
        #region VARIABLES PUBLICAS

        private WebClient cliente;
        private List<Image> ImagenesRescatadas;

        private BackgroundWorker hiloGoogle;

        #endregion

        #region CONSTRUCTORES

        public BusquedaImagenesUrl()
        {
            cliente = new WebClient();
            ImagenesRescatadas = new List<Image>();
        }

        #endregion

        #region EVENTOS

        /// <summary>
        /// Datos del evento StartReadEvent.
        /// </summary>
        public class StartReadEventArgs : EventArgs
        {
            /// <summary>
            /// Inicializa una instancia a la clase <see cref="StarReadEventArgs"/>.
            /// </summary>
            /// <param name="totalImages">number total of images gets in GoogleImage</param>
            public StartReadEventArgs()
            {
            }
        }
        /// <summary>
        /// Delegado del evento StartRead
        /// </summary>
        /// <param name="sender">this</param>
        /// <param name="e">La instancia <see cref="StartReadEventArgs"/> contiene los datos del evento</param>
        public delegate void StartReadHandler(object sender, StartReadEventArgs e);
        /// <summary>
        /// Evento que se produce al mandar la peticion a Google Images
        /// </summary>
        public event StartReadHandler StartGooglePetition;

        /// <summary>
        /// Datos del evento StopReadEvent.
        /// </summary>
        public class StopReadEventArgs : EventArgs
        {
            /// <summary>
            /// Imagenes descargadas de google
            /// </summary>
            /// <value>
            /// imagenes descargadas de google
            /// </value>
            public Image[] totalImages { get; set; }
            /// <summary>
            /// Inicializa una instancia a la clase <see cref="StopReadEventArgs"/>.
            /// <param name="totalImages">imagenes descargadas de google</param>
            /// </summary>
            public StopReadEventArgs(Image[] totalImages)
            {
                this.totalImages = totalImages;
            }
        }
        /// <summary>
        /// Delegado del evento StopRead
        /// </summary>
        /// <param name="sender">this</param>
        /// <param name="e">La instancia <see cref="StoptReadEventArgs"/> contiene los datos del evento</param>
        public delegate void StopReadHandler(object sender, StopReadEventArgs e);
        /// <summary>
        /// Evento que se produce al finalizar la descarga de imagenes
        /// </summary>
        public event StopReadHandler FinishGooglePetition;

        /// <summary>
        /// Datos del evento GetImages
        /// </summary>
        public class GetImagesEventArgs : EventArgs
        {
            /// <summary>
            /// Numero de Imagen en la descarga
            /// </summary>
            /// <value>
            /// Numero de indice de la imagen el el total de Imagenes
            /// </value>
            public int newImage { get; set; }

            /// <summary>
            /// Inicializa una instancia a la clase <see cref="GetImagesEventArgs"/>.
            /// </summary>
            /// <param name="newImage">index of new image in totalImages</param>
            public GetImagesEventArgs(int newImage)
            {
                this.newImage = newImage;
            }
        }
        /// <summary>
        /// Delegado del evento GetImages
        /// </summary>
        /// <param name="sender">this</param>
        /// <param name="e">La instancia <see cref="GetImagesPdfEventArgs"/> contiene los datos del evento</param>
        public delegate void GetImagesHandler(object sender, GetImagesEventArgs e);
        /// <summary>
        /// Ocurre cuando una nueva imagen es descargada
        /// </summary>
        public event GetImagesHandler NewImageRead;

        #endregion

        #region METODOS GOOGLE

        public void BusquedaGoogle(string patronBusqueda, int numeroBusqueda)
        {
            ImagenesRescatadas.Clear();

            //Lanzamos el Evento de Comienzo de lectura de Pdf
            StartReadEventArgs StartEvento = new StartReadEventArgs();
            StartGooglePetition(this, StartEvento);

            hiloGoogle = new BackgroundWorker();
            hiloGoogle.WorkerReportsProgress = true;
            hiloGoogle.DoWork += hiloGoogle_DoWork;
            hiloGoogle.ProgressChanged += hiloGoogle_ProgressChanged;
            hiloGoogle.RunWorkerCompleted += hiloGoogle_RunWorkerCompleted;
            hiloGoogle.RunWorkerAsync(new string[] { patronBusqueda, numeroBusqueda.ToString() });
        }

        void hiloGoogle_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //Lanzamos el Evento de Nueva Imagen Leida
            GetImagesEventArgs NewImageEvent = new GetImagesEventArgs(e.ProgressPercentage);
            NewImageRead(this, NewImageEvent);
        }

        void hiloGoogle_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] argumentos = (string[])e.Argument;
            GimageSearchClient client = new GimageSearchClient("http://www.google.com");
            IList<IImageResult> results = client.Search(argumentos[0], int.Parse(argumentos[1]));

            int cont = 1;
            foreach (IImageResult result in results)
            {
                try
                {
                    ImagenesRescatadas.Add(new Bitmap(cliente.OpenRead(result.Url)));
                }
                catch { };

                hiloGoogle.ReportProgress(cont);
                cont++;
            }
        }

        void hiloGoogle_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Lanzamos el Evento de Comienzo de lectura de Pdf
            StopReadEventArgs FinishEvento = new StopReadEventArgs(Devolver_Imagenes());
            FinishGooglePetition(this, FinishEvento);
        }

        #endregion

        #region METODOS AMAZON

        public Image[] Amazon(String PatronBusqueda)
        {
            ImagenesRescatadas.Clear();

            PatronBusqueda = PatronBusqueda.Replace(' ', '+');

            string htmlString = cliente.DownloadString("http://www.amazon.com/s/ref=nb_sb_noss?url=search-alias%3Dpopular&field-keywords=" + PatronBusqueda);

            foreach (string Url in ObtenerImagenes(htmlString))
            {
                // Buscamos la url que enlaza con la imagen
                string UrlImagen = Url.Remove(0, Url.IndexOf("http"));
                UrlImagen = UrlImagen.Remove(UrlImagen.IndexOf("&amp"));
                try
                {
                    // La Añadimos al ImageList
                    ImagenesRescatadas.Add(new Bitmap(cliente.OpenRead(UrlImagen)));
                }
                catch
                {
                    // Lo que carga no es una imagen
                }
            }
            return Devolver_Imagenes();
        }

        #endregion

        #region METODOS COMPARTIDOS

        private List<string> ObtenerImagenes(string htmlString)
        {
            List<string> Imagenes = new List<string>();
            string PatronBusqueda = @"(imgurl).*?(&amp)";

            Regex rgx = new Regex(PatronBusqueda, RegexOptions.IgnoreCase);
            MatchCollection Coincidencias = rgx.Matches(htmlString);

            for (int i = 0, l = Coincidencias.Count; i < l; i++)
            {
                Imagenes.Add(Coincidencias[i].Value);
            }

            return Imagenes;
        }

        private Image[] Devolver_Imagenes()
        {
            return ImagenesRescatadas.ToArray();
        }

        #endregion
    }
}
