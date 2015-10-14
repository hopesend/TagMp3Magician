using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;

namespace TagMp3Magician
{
    public class GenericAlbum
    {
        #region VARIABLES 

        //Contenedor de Ruta del Album
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

        //Contenedor de Nombre del Album
        private string nombreAlbum;
        public string NombreAlbum
        {
            get { return nombreAlbum; }
            set { nombreAlbum = value; }
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

            listaCanciones = new List<GenericSong>(Obtener_Canciones(RutaAlbum));
        }

        #endregion

        #region METODOS

        private List<GenericSong> Obtener_Canciones(string pathAlbum)
        {
            List<GenericSong> listaAux = new List<GenericSong>();

            int cont = 0;
            foreach (string archivoAlbum in Directory.GetFiles(pathAlbum, "*.*", SearchOption.TopDirectoryOnly).Where(s => s.EndsWith(".mp3")))
            {
                GenericSong nuevaCancion = new GenericSong(Path.GetFileName(archivoAlbum), cont);

                listaAux.Add(nuevaCancion);
                cont++;
            }

            return listaAux;
        }

        public List<GenericSong> Devolver_Canciones()
        {
            return listaCanciones;
        }

        public bool Borrar_Cancion(GenericSong cancionBorrar)
        {
            return listaCanciones.Remove(cancionBorrar);
        }

        #endregion
    }
}
