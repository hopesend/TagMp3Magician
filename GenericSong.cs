﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using TagLib;

namespace TagMp3Magician
{
    /// <summary>
    /// Clase Contenedora de la informacion de un archivo mp3 en un album especifico
    /// </summary>
    public class GenericSong
    {
        #region VARIABLES

        /// <summary>
        /// valor tipo string con el nombre completo de la pista
        /// </summary>
        private string pista;
        /// <summary>
        /// Obtiene el nombre completo de la pista
        /// </summary>
        /// <value>
        /// valor tipo string con el nombre completo de la pista
        /// </value>
        public string Pista
        {
            get { return pista; }
            set { pista = value; }
        }

        /// <summary>
        /// valor tipo string con la ruta de la pista
        /// </summary>
        private string ruta;
        /// <summary>
        /// Obtiene la ruta de la pista
        /// </summary>
        /// <value>
        /// valor tipo string con la ruta de la pista
        /// </value>
        public string Ruta
        {
            get { return ruta; }
            set { ruta = value; }
        }

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
            set { titulo = value; }
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

        public string Artista;
        public string Album;
        public int Anyo;
        public string Genero;
        public string Comentario;

        /// <summary>
        /// Objeto contenedor del tag de la cancion
        /// </summary>
        public Tag tagCancion;

        public TagLib.Properties propiedades;

        #endregion

        #region CONSTRUCTORES

        public GenericSong()
        {

        }

        public GenericSong(string nombreCancion, string ruta)
        {
            Pista = nombreCancion;
            this.ruta = ruta;
            Obtener_Tag(ruta);
        }

        #endregion

        #region METODOS

        private void Obtener_Indice(string titulo)
        {
            if(titulo != null)
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

        private void Obtener_Tag(string ruta)
        {
            TagLib.File PistaMp3 = TagLib.File.Create(ruta);

            try { indice = PistaMp3.Tag.Track.Equals(0) ? indice = Buscar_Indice(Titulo) : indice = (int)PistaMp3.Tag.Track; }
            catch { indice = 0; }

            try
            {
                if (!PistaMp3.Tag.Title.Equals(string.Empty))
                    Titulo = PistaMp3.Tag.Title;
            }
            catch
            {
                Titulo = string.Empty;
            }

            try 
            { 
                CaratulaAlbum = Image.FromStream(new MemoryStream(PistaMp3.Tag.Pictures.ToList().Find(x => x.Type.ToString() == "FrontCover").Data.Data)); 
            }
            catch
            {
                CaratulaAlbum = null;
            }

            tagCancion = PistaMp3.Tag;
            propiedades = PistaMp3.Properties;

            PistaMp3.Dispose();
        }

        public bool Guardar_Pista()
        {
            TagLib.File PistaMp3 = TagLib.File.Create(ruta);

            PistaMp3.Tag.Clear();

            PistaMp3.Tag.Performers = new string[] { Artista };
            PistaMp3.Tag.AlbumArtists = new string[] { Artista };
            PistaMp3.Tag.Album = Album;
            PistaMp3.Tag.Year = (uint) Anyo;
            PistaMp3.Tag.Genres = new string[] { Genero };
            PistaMp3.Tag.Comment = Comentario;
            PistaMp3.Tag.Title = Titulo;
            PistaMp3.Tag.Track = (uint)Indice;

            string rutaAuxiliar = Path.GetTempFileName();
            caratulaAlbum.Save(rutaAuxiliar, System.Drawing.Imaging.ImageFormat.Jpeg);
            TagLib.Picture myCover = new Picture(rutaAuxiliar);
            //Coloco el Picture en el FrameCorrespondiente
            TagLib.Id3v2.AttachedPictureFrame coverAlbumArt = new TagLib.Id3v2.AttachedPictureFrame(myCover);
            //Seteo el tipo Mime
            coverAlbumArt.MimeType = System.Net.Mime.MediaTypeNames.Image.Jpeg;
            //Seteo el tipo de imagen que estoy colocando
            coverAlbumArt.Type = TagLib.PictureType.FrontCover;
            //Agrego el frame a la coleccion de imagenes que corresponde
            TagLib.IPicture[] pictFrame = { coverAlbumArt };
            //Vuelco la coleccion de imagenes al Tag
            try
            {
                PistaMp3.Tag.Pictures = pictFrame;
            }
            catch
            {
                //MessageBox.Show("Imposible Insercion de Imagen en Tag. Posible Error de Archivo -" + new FileInfo(RutaArchivo).FullName + "-");
            }

            System.IO.File.Delete(rutaAuxiliar);

            try
            {
                PistaMp3.Save();
                PistaMp3.Dispose();
                return true;
            }
            catch
            {
                PistaMp3.Dispose();
                return false;
            }
        }

        #endregion
    }
}
