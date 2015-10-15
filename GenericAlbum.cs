using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;

namespace TagMp3Magician
{
    /// <summary>
    /// Clase contenedora de informacion sobre el album en MP3
    /// </summary>
    public class GenericAlbum
    {
        #region VARIABLES 

        /// <summary>
        /// valor tipo string con la ruta del album
        /// </summary>
        private string rutaAlbum;
        /// <summary>
        /// Obtiene la ruta del Album
        /// </summary>
        /// <value>
        /// valor tipo string con la ruta del album
        /// </value>
        public string RutaAlbum
        {
            get { return rutaAlbum; }
            set { rutaAlbum = value; }
        }

        /// <summary>
        /// valor tipo string con el nombre del Album
        /// </summary>
        private string nombreAlbum;
        /// <summary>
        /// Obtiene el nombre del Album
        /// </summary>
        /// <value>
        /// valor tipo string con el nombre del Album
        /// </value>
        public string NombreAlbum
        {
            get { return nombreAlbum; }
            set 
            { 
                nombreAlbum = value;
                Desglosar_Nombre(nombreAlbum);
            }
        }

        /// <summary>
        /// valor tipo string con el nombre del Artista del Album
        /// </summary>
        private string artista;
        /// <summary>
        /// Obtiene el nombre del Artista
        /// </summary>
        /// <value>
        /// valor tipo string con el nombre del Artista del Album
        /// </value>
        public string Artista
        {
            get { return artista; }
            set { artista = value; }
        }


        /// <summary>
        /// valor tipo int con el año de grabacion del album
        /// </summary>
        private int anyoGrabacion;
        /// <summary>
        /// Obtiene el año de grabacion
        /// </summary>
        /// <value>
        /// valor tipo int con el año de grabacion del album
        /// </value>
        public int AnyoGrabacion
        {
            get { return anyoGrabacion; }
            set { anyoGrabacion = value; }
        }


        /// <summary>
        /// valor tipo string con el titulo del album
        /// </summary>
        private string titulo;
        /// <summary>
        /// Obtiene el titulo del album
        /// </summary>
        /// <value>
        /// valor tipo string con el titulo del album
        /// </value>
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        private Image caratulaAlbum;
        public Image CaratulaAlbum
        {
            get { return caratulaAlbum; }
            set { caratulaAlbum = value; }
        }

        private List<GenericSong> listaCanciones;
        public List<GenericSong> ListaCanciones
        {
            get { return listaCanciones; }
            set { listaCanciones = value; }
        }

        #endregion

        #region CONSTRUCTORES

        public GenericAlbum()
        {
            listaCanciones = new List<GenericSong>();
        }

        public GenericAlbum(string pathAlbum)
        {
            RutaAlbum = pathAlbum;
            NombreAlbum = Path.GetFileName(RutaAlbum);

            listaCanciones = new List<GenericSong>();
            Obtener_Canciones(RutaAlbum);
        }

        #endregion

        #region METODOS

        private void Obtener_Canciones(string pathAlbum)
        {
            foreach (string archivoAlbum in Directory.GetFiles(pathAlbum, "*.*", SearchOption.TopDirectoryOnly).Where(s => s.EndsWith(".mp3")))
            {
                listaCanciones.Add(new GenericSong(Path.GetFileName(archivoAlbum)));
            }

            //Cotejar artista, año y titulo
        }

        private void Desglosar_Nombre(string nombre)
        {
            string[] aux = nombre.Split('-');

            switch(aux.Length)
            {
                case 1:
                    {
                        if(EsNumerico(aux[0].Trim()))
                            anyoGrabacion = int.Parse(aux[0].Trim());
                        else
                            Artista = aux[0].Trim();
                        break;
                    }

                case 2:
                    {
                        if (EsNumerico(aux[0].Trim()))
                        {
                            anyoGrabacion = int.Parse(aux[0].Trim());
                            Artista = aux[1].Trim();
                        }
                        else
                        {
                            if (EsNumerico(aux[1].Trim()))
                            {
                                anyoGrabacion = int.Parse(aux[1].Trim());
                                Artista = aux[0].Trim();
                            }
                            else
                            {
                                Artista = aux[0].Trim();
                                Titulo = aux[1].Trim();
                            }
                        }
                        break;
                    }

                case 3:
                    {
                        Artista = aux[0].Trim();
                        anyoGrabacion = EsNumerico(aux[1].Trim()) ? int.Parse(aux[1].Trim()) : 0;
                        Titulo = aux[2].Trim();
                        break;
                    } 

                case 0:
                default:
                    {
                        Artista = string.Empty;
                        Titulo = string.Empty;
                        AnyoGrabacion = 0;
                        break;
                    }
            }
        }

        public List<GenericSong> Devolver_Canciones()
        {
            return listaCanciones;
        }

        public bool Borrar_Cancion(GenericSong cancionBorrar)
        {
            return listaCanciones.Remove(cancionBorrar);
        }

        private bool EsNumerico(string numero)
        {
            return numero.All(char.IsDigit);
        }

        #endregion
    }
}
