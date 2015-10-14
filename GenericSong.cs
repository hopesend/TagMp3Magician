using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TagMp3Magician
{
    public class GenericSong
    {
        //Contenedor del nuevo nombre de la Cancion
        private string nombreCancionNuevo;
        public string NombreCancionNuevo
        {
            get { return nombreCancionNuevo; }
            set { nombreCancionNuevo = value; }
        }

        //Contenedor del nombre del Archivo Inicial
        private string nombreCancionAnterior;
        public string NombreCancionAnterior
        {
            get { return nombreCancionAnterior; }
            set { nombreCancionAnterior = value; }
        }

        //Contenedor del indice de la cancion
        private int indiceCancion;
        public int IndiceCancion
        {
            get { return indiceCancion; }
            set { indiceCancion = value; }
        }

        //Contenedor de booleana para diferenciar pistas mp3
        private bool esMp3;
        public bool EsMp3
        {
            get { return esMp3; }
            set { esMp3 = value; }
        }

        public GenericSong()
        {
        }

        public GenericSong(string nombreCancion, int indice)
        {
            NombreCancionAnterior = nombreCancion;
            NombreCancionNuevo = nombreCancion;
            IndiceCancion = indice;

            if (Path.GetExtension(nombreCancion).Equals(".mp3"))
                EsMp3 = true;
            else
                EsMp3 = false;
        }
    }
}
