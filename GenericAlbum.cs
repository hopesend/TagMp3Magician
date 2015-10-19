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

        /// <summary>
        /// valor tipo Image con la caratula del album
        /// </summary>
        private Image caratulaAlbum;
        /// <summary>
        /// Obtiene la caratula del album
        /// </summary>
        /// <value>
        /// valor tipo Image con la caratula del album
        /// </value>
        public Image CaratulaAlbum
        {
            get { return caratulaAlbum; }
            set { caratulaAlbum = value; }
        }

        /// <summary>
        /// valor tipo string con el estilo del album
        /// </summary>
        private string estilo;
        /// <summary>
        /// Obtiene el estilo del album
        /// </summary>
        /// <value>
        /// valor tipo string con el estilo del album
        /// </value>
        public string Estilo
        {
            get { return estilo; }
            set { estilo = value; }
        }

        /// <summary>
        /// valor tipo string con el comentario del album
        /// </summary>
        private string comentario;
        /// <summary>
        /// Obtiene el comentario del album
        /// </summary>
        /// <value>
        /// valor tipo string con el comentario del album
        /// </value>
        public string Comentario
        {
            get { return comentario; }
            set { comentario = value; }
        }

        /// <summary>
        /// valor tipo int con el bitrate de compresion medio del album
        /// </summary>
        private int bitrate;
        /// <summary>
        /// Obtiene el bitrate medio dle album
        /// </summary>
        /// <value>
        /// valor tipo int con el bitrate de compresion medio del album
        /// </value>
        public int Bitrate
        {
            get { return bitrate; }
            set { bitrate = value; }
        }

        /// <summary>
        /// valor tipo ListaGenerica con las GenericSong que componen el album
        /// </summary>
        private List<GenericSong> listaCanciones;
        /// <summary>
        /// Obtiene la lista de canciones que componen el album
        /// </summary>
        /// <value>
        /// valor tipo ListaGenerica con las GenericSong que componen el album
        /// </value>
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
                listaCanciones.Add(new GenericSong(Path.GetFileName(archivoAlbum), archivoAlbum));
            }

            if(Artista == null)
                Artista = (listaCanciones.FindAll(x => x.tagCancion.FirstPerformer == listaCanciones[0].tagCancion.FirstPerformer).Count().Equals(listaCanciones.Count())) ? listaCanciones[0].tagCancion.FirstPerformer : "<Desconocido>";

            if(AnyoGrabacion.Equals(0))
                AnyoGrabacion = (listaCanciones.FindAll(x => (int)x.tagCancion.Year == (int)listaCanciones[0].tagCancion.Year).Count().Equals(listaCanciones.Count())) ? (int)listaCanciones[0].tagCancion.Year : 0;

            if(Titulo.Equals(string.Empty))
                Titulo = (listaCanciones.FindAll(x => x.tagCancion.Album == listaCanciones[0].tagCancion.Album).Count().Equals(listaCanciones.Count())) ? listaCanciones[0].tagCancion.Album : "<Desconocido>";

            try
            {
                CaratulaAlbum = (listaCanciones.FindAll(x => x.CaratulaAlbum.ToString() == listaCanciones[0].CaratulaAlbum.ToString()).Count().Equals(listaCanciones.Count())) ? listaCanciones[0].CaratulaAlbum : null;
            }
            catch
            {
                CaratulaAlbum = null;
            }

            Comentario = (listaCanciones.FindAll(x => x.tagCancion.Comment == listaCanciones[0].tagCancion.Comment).Count().Equals(listaCanciones.Count())) ? listaCanciones[0].tagCancion.Comment : "<Desconocido>";

            Estilo = (listaCanciones.FindAll(x => x.tagCancion.FirstGenre == listaCanciones[0].tagCancion.FirstGenre).Count().Equals(listaCanciones.Count())) ? listaCanciones[0].tagCancion.FirstGenre : "<Desconocido>";

            Bitrate = (listaCanciones.FindAll(x => x.propiedades.AudioBitrate == listaCanciones[0].propiedades.AudioBitrate).Count().Equals(listaCanciones.Count())) ? listaCanciones[0].propiedades.AudioBitrate : 0;
        }

        private void Desglosar_Nombre(string nombre)
        {
            string[] aux = nombre.Split('-');

            switch(aux.Length)
            {
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
