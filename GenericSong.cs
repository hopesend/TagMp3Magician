using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;

namespace TagMp3Magician
{
    /// <summary>
    /// Clase Contenedora de la informacion de un archivo mp3 en un album especifico
    /// </summary>
    public class GenericSong
    {

        #region VARIABLES

        /// <summary>
        /// valor tipo string con el titulo de la pista
        /// </summary>
        private string titulo;
        /// <summary>
        /// Obtiene el titulo de la pista mp3
        /// </summary>
        /// <value>
        /// valor tipo string con el titulo de la pista
        /// </value>
        public string Titulo
        {
            get { return titulo; }
            set 
            { 
                titulo = value;
                Obtener_Indice(titulo);
            }
        }

        /// <summary>
        /// valor tipo int con la posicion de la cancion en el album (numero de pista)
        /// </summary>
        private int indice;
        /// <summary>
        /// Obtiene el numero de pista de la cancion
        /// </summary>
        /// <value>
        /// valor tipo int con la posicion de la cancion en el album (numero de pista)
        /// </value>
        public int Indice
        {
            get { return indice; }
            set { indice = value; }
        }

        /// <summary>
        /// valor tipo Image con la caratula de la cancion
        /// </summary>
        private Image caratulaAlbum;
        /// <summary>
        /// Obtiene la caratula de la cancion
        /// </summary>
        /// <value>
        /// valor tipo Image con la caratula de la cancion
        /// </value>
        public Image CaratulaAlbum
        {
            get { return caratulaAlbum; }
            set { caratulaAlbum = value; }
        }

        #endregion

        #region CONSTRUCTORES

        public GenericSong()
        {
        }

        public GenericSong(string nombreCancion)
        {
            Titulo = nombreCancion;

            //obtener tag
        }

        #endregion

        #region METODOS

        private void Obtener_Indice(string titulo)
        {
            Indice = Buscar_Indice(titulo);
        }

        private int Buscar_Indice (string texto)
        {
            for (int cont=0; cont < texto.Length; cont++)
            {
                if(!char.IsDigit(texto[cont]))
                    return (cont > 0 ? int.Parse(texto.Remove(cont)) : 0);
            }

            return 0;
        }

        #endregion
    }
}
