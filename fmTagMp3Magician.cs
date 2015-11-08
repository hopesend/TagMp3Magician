using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace TagMp3Magician
{
    public partial class fmTagMp3Magician : Form
    {

        #region VARIABLES

        public GenericAlbum album;

        #endregion

        #region CONSTRUCTOR

        public fmTagMp3Magician()
        {
            InitializeComponent();
        }

        #endregion

        #region EVENTOS FORMULARIO

        private void fmTagMp3Magician_Load(object sender, EventArgs e)
        {
            // Cargamos todas la unidades de Disco de la maquina en un ComboBox
            foreach (string Unidad in Directory.GetLogicalDrives())
            {
                cbUnidadesDisco.Items.Add(Unidad);
            }

            // Buscamos la que esta disponible para mostrarla
            foreach (string UnidadComboBox in cbUnidadesDisco.Items)
            {
                if (UnidadDisponible(UnidadComboBox))
                {
                    cbUnidadesDisco.SelectedIndex = cbUnidadesDisco.FindStringExact(UnidadComboBox);
                    cbUnidadesDisco.Focus();
                    cbUnidadesDisco_SelectionChangeCommitted(this, new EventArgs());
                    break;
                }
            }
        }

        private void cbUnidadesDisco_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Vaciamos el TreeView para recibir la nueva unidad
            tvDirectorioMp3.Nodes.Clear();

            // Si la unidad esta disponible dibujamos el treeview si no lanzamos un mensaje de error y devolvemos el control al combobox
            if (UnidadDisponible(cbUnidadesDisco.SelectedItem.ToString()))
            {
                TreeNode nodo = new TreeNode();
                nodo.Text = cbUnidadesDisco.SelectedItem.ToString();
                nodo.Tag = cbUnidadesDisco.SelectedItem.ToString();
                tvDirectorioMp3.Nodes.Add(nodo);

                RellenarTreeViewMp3(nodo);
            }
            else
            {
                MessageBox.Show("Dispositivo No Disponible", "Error de Dispositivo");
                cbUnidadesDisco.Focus();
            }
        }

        private void tvDirectorioMp3_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // Si ese Directorio tiene Archivos los muestro
            if (Directory.Exists(tvDirectorioMp3.SelectedNode.Tag.ToString()))
            {
                if (Contiene_Mp3(tvDirectorioMp3.SelectedNode.Tag.ToString()))
                {
                    //Obtenemos el album segun el path seleccionado
                    Capturar_Album(@tvDirectorioMp3.SelectedNode.Tag.ToString());
                    //Buscamos las imagenes en disco y en el tag
                    Capturar_Imagenes_Album();
                    //Insertamos si existe la caratula en el picturebox
                    pbImagen1.Image = album.CaratulaAlbum == null ? pbImagen1.ErrorImage : album.CaratulaAlbum;
                    //Activamos Zona de Imagenes
                    pnImagenes.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("El Directorio " + tvDirectorioMp3.SelectedNode.Tag.ToString() + " no existe");
            }

            // Si No tiene nodos Colgantes, le añadimos los directorios del seleccionado
            if (e.Node.Nodes.Count == 0)
            {
                tvDirectorioMp3.SelectedNode = e.Node;
                RellenarTreeViewMp3(e.Node);
                e.Node.Expand();
            }

            btGuardar.Enabled = true;
        }

        private void lvPistas_ItemActivate(object sender, EventArgs e)
        {
            tbModificar.Text = lvPistas.SelectedItems[0].Text;
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            lvPistas.SelectedItems[0].Text = tbModificar.Text;
        }
        
        private void lvPistas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                foreach (ListViewItem item in lvPistas.SelectedItems)
                {
                    GenericSong cancion = (GenericSong)item.Tag;
                    File.Delete(cancion.Ruta);
                    lvPistas.Items.Remove(item);
                }
            }
        }

        private void btCambiar_Click(object sender, EventArgs e)
        {
            if (tbCaracterAntes.Text == "" && tbCaracterDespues.Text == "")
            {
                //Si pulsamos el boton cambiar y los textbox asociados estan vacios lanzo mensaje de error
                MessageBox.Show("Valores No Introducidos");
                tbCaracterAntes.Focus();
            }
            else
            {
                //Si no hago el cambio de caracteres segun las pautas de los textbox
                foreach (ListViewItem item in lvPistas.Items)
                {
                    if(item.Text.Contains(tbCaracterAntes.Text))
                        item.Text = item.Text.Replace(tbCaracterAntes.Text, tbCaracterDespues.Text);
                }
            }
        }

        private void btTransformar_Click(object sender, EventArgs e)
        {
            PonerPunto();
            PonerMayusculas();
        }

        private void lvImagenes_ItemActivate(object sender, EventArgs e)
        {
            pbImagen1.Image = (Image)lvImagenes.SelectedItems[0].Tag;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (cbGoogle.Checked || cbAmazon.Checked)
            {
                if (cbGoogle.Checked)
                {
                    BusquedaImagenesUrl nuevaBusqueda = new BusquedaImagenesUrl();
                    nuevaBusqueda.StartGooglePetition += nuevaBusqueda_StartGooglePetition;
                    nuevaBusqueda.FinishGooglePetition += nuevaBusqueda_FinishGooglePetition;
                    nuevaBusqueda.NewImageRead += nuevaBusqueda_NewImageRead;

                    nuevaBusqueda.BusquedaGoogle(tbArtista.Text + "+" + tbAlbum.Text, (int)nudTotalResultados.Value);
                }
            }
        }

        private void nuevaBusqueda_NewImageRead(object sender, BusquedaImagenesUrl.GetImagesEventArgs e)
        {
            pgCanciones.Value = e.newImage;
        }

        private void nuevaBusqueda_FinishGooglePetition(object sender, BusquedaImagenesUrl.StopReadEventArgs e)
        {
            pgCanciones.Visible = false;
            Insertar_Imagenes(e.totalImages);
        }

        private void nuevaBusqueda_StartGooglePetition(object sender, BusquedaImagenesUrl.StartReadEventArgs e)
        {
            pgCanciones.Visible = true;
            pgCanciones.Maximum = (int)nudTotalResultados.Value;
            pgCanciones.Step = 1;
            pgCanciones.Minimum = 1;
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            bgwGrabacionMp3.WorkerReportsProgress = true;
            pgCanciones.Visible = true;
            pgCanciones.Maximum = lvPistas.Items.Count;
            pgCanciones.Step = 1;
            pgCanciones.Minimum = 1;
            bgwGrabacionMp3.RunWorkerAsync();
        }

        private void bgwGrabacionMp3_DoWork(object sender, DoWorkEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            GenericSong cancionAux;
            int cont = 1;
            foreach (ListViewItem item in lvPistas.Items)
            {
                cancionAux = (GenericSong)item.Tag;

                cancionAux.Artista = tbArtista.Text;
                cancionAux.Album = tbAlbum.Text;
                cancionAux.Anyo = Convert.ToUInt16(tbAnyo.Text);
                cancionAux.Genero = tbEstilo.Text;
                cancionAux.Comentario = tbComentario.Text;
                cancionAux.Titulo = Path.GetFileNameWithoutExtension(item.Text.Remove(0, item.Text.IndexOf(".") + 2));
                cancionAux.Indice = int.Parse(item.Text.Remove(item.Text.IndexOf(".")));
                cancionAux.CaratulaAlbum = pbImagen1.Image;

                if (!cancionAux.Guardar_Pista())
                    MessageBox.Show("La Pista \"" + item.Text + "\" no a podido grabarse correctamente");

                bgwGrabacionMp3.ReportProgress(cont++);
            }
        }

        private void bgwGrabacionMp3_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pgCanciones.Value = e.ProgressPercentage;
        }

        private void bgwGrabacionMp3_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pgCanciones.Visible = false;
        }


        #endregion

        #region METODOS PROPIOS

        private bool UnidadDisponible(string unidad)
        {
            // Funcion para checkear si la unidad esta lista o no
             return new DriveInfo(unidad).IsReady;
        }

        private void RellenarTreeViewMp3(TreeNode nodoSeleccionado)
        {
            // Cargamos todos los directorios colgantes de ese directorio
            DirectoryInfo[] info2 = new DirectoryInfo(nodoSeleccionado.Tag.ToString()).GetDirectories();

            // Ordenamos alfabeticamente el directoryinfo
            Array.Sort(info2, delegate(DirectoryInfo f1, DirectoryInfo f2)
            {
                return f1.Name.CompareTo(f2.Name);
            });

            if (info2.Count() > 0)
            {
                // Pasamos por cada directorio colgante y cogemos su informacion
                foreach (DirectoryInfo Directorio in info2)
                {
                    if (!Directorio.Attributes.ToString().Contains("Hidden"))
                    {
                        // Creamos un nodo con esa informacion
                        TreeNode nuevoNodo = new TreeNode();

                        nuevoNodo.Text = Directorio.Name;
                        nuevoNodo.Tag = Directorio.FullName;
                        nodoSeleccionado.Nodes.Add(nuevoNodo);
                    }
                }

                nodoSeleccionado.Expand();
            }
        }

        private bool Contiene_Mp3(string path)
        {
            return (Directory.GetFiles(path, "*.*", SearchOption.TopDirectoryOnly).Where(s => s.EndsWith(".mp3")).Count() > 0);
        }

        private void PonerPunto()
        {
            // Recorremos la lista del Archivos en el ListView
            foreach (ListViewItem item in lvPistas.Items)
            {
                // Comprobamos que tenga un punto tras el numero de pista, si no lo tiene lo inserta
                if (item.Text[2] != '.')
                {
                    // Insertamos el Punto
                    item.Text = item.Text.Insert(2, ".");
                }
            }
        }

        private void PonerMayusculas()
        {
            //Buscamos en la Lista del directorio
            foreach (ListViewItem item in lvPistas.Items)
            {
                //Recorremos el string caracter a caracter
                for (int cont2 = 0; cont2 < item.Text.Length; cont2++)
                {
                    switch (item.Text[cont2])
                    {
                        case ' ':
                        case '(':
                        case '[':
                        case '-':
                            {
                                string CaracterMinuscula = item.Text[cont2] + item.Text[cont2 + 1].ToString();
                                string CaracterMayuscula = item.Text[cont2] + item.Text[cont2 + 1].ToString().ToUpper();
                                item.Text = item.Text.Replace(CaracterMinuscula, CaracterMayuscula);
                                break;
                            }
                    }
                }
            }
        }

        private void Capturar_Album(string path)
        {
            album = new GenericAlbum(path);

            tbArtista.Text = album.Artista;
            tbAlbum.Text = album.Titulo;
            tbAnyo.Text = album.AnyoGrabacion.ToString();
            tbEstilo.Text = album.Estilo;
            tbComentario.Text = album.Comentario;
            tbBitrate.Text = album.Bitrate.ToString();

            pnCambios.Enabled = true;
            lvPistas.Items.Clear();
            foreach (GenericSong cancion in album.Devolver_Canciones())
            {
                ListViewItem item = new ListViewItem();
                item.Text = cancion.Pista;
                item.Tag = cancion;
                lvPistas.Items.Add(item);
            }
        }

        private void Capturar_Imagenes_Album()
        {
            List<Image> listaAux = new List<Image>();
            listaImagenesLittle.Images.Clear();
            lvImagenes.Items.Clear();

            //Capturamos en el Tag
            foreach(ListViewItem item in lvPistas.Items)
            {
                GenericSong aux = (GenericSong)item.Tag;
                if (listaAux.FindAll(x => CompararBitmaps(x, aux.CaratulaAlbum)).Count().Equals(0))
                    if(aux.CaratulaAlbum != null)
                        listaAux.Add(aux.CaratulaAlbum);
            }

            //Capturamos en el Directorio
            foreach(Image imagenDirectorio in Capturar_Imagenes_Directorio(album.RutaAlbum))
            {
                if (listaAux.FindAll(x => CompararBitmaps(x, imagenDirectorio)).Count().Equals(0))
                    if(imagenDirectorio != null)
                        listaAux.Add(imagenDirectorio);
            }

            Insertar_Imagenes(listaAux.ToArray());
        }

        private Image[] Capturar_Imagenes_Directorio(string path)
        {
            List<Image> aux = new List<Image>();
            string[] extensiones = { ".jpg", ".JPG", ".jpeg", ".JPEG", ".gif", ".GIF", ".bmp", ".BMP", ".png", ".PNG" };

            foreach (string pathArchivo in Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories).Where(s => extensiones.Any(ext => ext == Path.GetExtension(s))))
            {
                aux.Add(Image.FromFile(pathArchivo));
            }

            return aux.ToArray();
        }

        private bool CompararBitmaps(Image imagen1, Image imagen2)
        {
            if (object.Equals(imagen1, imagen2))
                return true;
            if (imagen1 == null || imagen2 == null)
                return false;
            if (!imagen1.Size.Equals(imagen2.Size) || !imagen1.PixelFormat.Equals(imagen2.PixelFormat))
                return false;

            Bitmap imagen1Bitmap = new Bitmap(imagen1);
            Bitmap imagen2Bitmap = new Bitmap(imagen2);
            if (imagen1Bitmap == null || imagen2Bitmap == null)
                return true;

            int bytes = imagen1.Width * imagen1.Height * (Image.GetPixelFormatSize(imagen1.PixelFormat) / 8);

            bool result = true;
            byte[] b1bytes = new byte[bytes];
            byte[] b2bytes = new byte[bytes];

            BitmapData bmd1 = imagen1Bitmap.LockBits(new Rectangle(0, 0, imagen1Bitmap.Width - 1, imagen1Bitmap.Height - 1), ImageLockMode.ReadOnly, imagen1Bitmap.PixelFormat);
            BitmapData bmd2 = imagen2Bitmap.LockBits(new Rectangle(0, 0, imagen2Bitmap.Width - 1, imagen2Bitmap.Height - 1), ImageLockMode.ReadOnly, imagen2Bitmap.PixelFormat);

            Marshal.Copy(bmd1.Scan0, b1bytes, 0, bytes);
            Marshal.Copy(bmd2.Scan0, b2bytes, 0, bytes);

            for (int n = 0; n <= bytes - 1; n++)
            {
                if (b1bytes[n] != b2bytes[n])
                {
                    result = false;
                    break;
                }
            }

            imagen1Bitmap.UnlockBits(bmd1);
            imagen2Bitmap.UnlockBits(bmd2);

            return result;
        }

        private void Insertar_Imagenes(Image[] imagenes)
        {
            int finContador = (listaImagenesLittle.Images.Count + imagenes.Length);
            int totalImagenes = listaImagenesLittle.Images.Count;

            for (int cont = listaImagenesLittle.Images.Count; cont < finContador; cont++)
            {
                ListViewItem itemImagen = new ListViewItem();
                itemImagen.Text = imagenes[cont-totalImagenes].Width.ToString() + "x" + imagenes[cont-totalImagenes].Height.ToString();
                itemImagen.ImageIndex = cont;
                itemImagen.Tag = imagenes[cont-totalImagenes];
                lvImagenes.Items.Add(itemImagen);

                listaImagenesLittle.Images.Add(imagenes[cont-totalImagenes]);
            }
        }
        #endregion


        
    }
}
