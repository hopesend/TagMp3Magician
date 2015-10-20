using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
                    album = new GenericAlbum(@tvDirectorioMp3.SelectedNode.Tag.ToString());

                    tbArtista.Text = album.Artista;
                    tbAlbum.Text = album.Titulo;
                    tbAnyo.Text = album.AnyoGrabacion.ToString();
                    tbEstilo.Text = album.Estilo;
                    tbComentario.Text = album.Comentario;
                    tbBitrate.Text = album.Bitrate.ToString();

                    pnCambios.Enabled = true;
                    lvPistas.Items.Clear();
                    foreach(GenericSong cancion in album.Devolver_Canciones())
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = cancion.Pista;
                        item.Tag = cancion;
                        lvPistas.Items.Add(item);
                    }
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

        #endregion
    }
}
