namespace TagMp3Magician
{
    partial class fmTagMp3Magician
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmTagMp3Magician));
            this.pnPrimario = new System.Windows.Forms.Panel();
            this.pnDerecha = new System.Windows.Forms.Panel();
            this.pnImagenes = new System.Windows.Forms.Panel();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.gbBusqueda = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudTotalResultados = new System.Windows.Forms.NumericUpDown();
            this.cbAmazon = new System.Windows.Forms.CheckBox();
            this.cbGoogle = new System.Windows.Forms.CheckBox();
            this.lvImagenes = new System.Windows.Forms.ListView();
            this.listaImagenesLittle = new System.Windows.Forms.ImageList(this.components);
            this.pbImagen1 = new System.Windows.Forms.PictureBox();
            this.pnIzquierda = new System.Windows.Forms.Panel();
            this.pnPistas = new System.Windows.Forms.Panel();
            this.cbUnidadesDisco = new System.Windows.Forms.ComboBox();
            this.btModificar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbModificar = new System.Windows.Forms.TextBox();
            this.tvDirectorioMp3 = new System.Windows.Forms.TreeView();
            this.lvPistas = new System.Windows.Forms.ListView();
            this.pnCambios = new System.Windows.Forms.Panel();
            this.cbEstilo = new System.Windows.Forms.ComboBox();
            this.btTransformar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btCambiar = new System.Windows.Forms.Button();
            this.tbCaracterAntes = new System.Windows.Forms.TextBox();
            this.tbCaracterDespues = new System.Windows.Forms.TextBox();
            this.laAlbum = new System.Windows.Forms.Label();
            this.tbAlbum = new System.Windows.Forms.TextBox();
            this.tbBitrate = new System.Windows.Forms.TextBox();
            this.tbComentario = new System.Windows.Forms.TextBox();
            this.pgCanciones = new System.Windows.Forms.ProgressBar();
            this.tbAnyo = new System.Windows.Forms.TextBox();
            this.tbArtista = new System.Windows.Forms.TextBox();
            this.laBitrate = new System.Windows.Forms.Label();
            this.laAnyo = new System.Windows.Forms.Label();
            this.laEstilo = new System.Windows.Forms.Label();
            this.laComentario = new System.Windows.Forms.Label();
            this.laArtista = new System.Windows.Forms.Label();
            this.bgwGrabacionMp3 = new System.ComponentModel.BackgroundWorker();
            this.pnPrimario.SuspendLayout();
            this.pnDerecha.SuspendLayout();
            this.pnImagenes.SuspendLayout();
            this.gbBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen1)).BeginInit();
            this.pnIzquierda.SuspendLayout();
            this.pnPistas.SuspendLayout();
            this.pnCambios.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnPrimario
            // 
            this.pnPrimario.Controls.Add(this.pnDerecha);
            this.pnPrimario.Controls.Add(this.pnIzquierda);
            this.pnPrimario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPrimario.Location = new System.Drawing.Point(0, 0);
            this.pnPrimario.Name = "pnPrimario";
            this.pnPrimario.Size = new System.Drawing.Size(1078, 589);
            this.pnPrimario.TabIndex = 0;
            // 
            // pnDerecha
            // 
            this.pnDerecha.Controls.Add(this.pnImagenes);
            this.pnDerecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDerecha.Location = new System.Drawing.Point(573, 0);
            this.pnDerecha.Name = "pnDerecha";
            this.pnDerecha.Size = new System.Drawing.Size(505, 589);
            this.pnDerecha.TabIndex = 2;
            // 
            // pnImagenes
            // 
            this.pnImagenes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnImagenes.Controls.Add(this.btGuardar);
            this.pnImagenes.Controls.Add(this.btBuscar);
            this.pnImagenes.Controls.Add(this.gbBusqueda);
            this.pnImagenes.Controls.Add(this.lvImagenes);
            this.pnImagenes.Controls.Add(this.pbImagen1);
            this.pnImagenes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnImagenes.Enabled = false;
            this.pnImagenes.Location = new System.Drawing.Point(0, 0);
            this.pnImagenes.Name = "pnImagenes";
            this.pnImagenes.Size = new System.Drawing.Size(505, 589);
            this.pnImagenes.TabIndex = 91;
            // 
            // btGuardar
            // 
            this.btGuardar.Enabled = false;
            this.btGuardar.Location = new System.Drawing.Point(424, 561);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 31;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btBuscar.Image")));
            this.btBuscar.Location = new System.Drawing.Point(445, 108);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(54, 44);
            this.btBuscar.TabIndex = 16;
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.Controls.Add(this.label4);
            this.gbBusqueda.Controls.Add(this.nudTotalResultados);
            this.gbBusqueda.Controls.Add(this.cbAmazon);
            this.gbBusqueda.Controls.Add(this.cbGoogle);
            this.gbBusqueda.Location = new System.Drawing.Point(159, 82);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Size = new System.Drawing.Size(280, 70);
            this.gbBusqueda.TabIndex = 15;
            this.gbBusqueda.TabStop = false;
            this.gbBusqueda.Text = "Seleccion de Busqueda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Resultados";
            // 
            // nudTotalResultados
            // 
            this.nudTotalResultados.Location = new System.Drawing.Point(6, 47);
            this.nudTotalResultados.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTotalResultados.Name = "nudTotalResultados";
            this.nudTotalResultados.Size = new System.Drawing.Size(40, 20);
            this.nudTotalResultados.TabIndex = 2;
            this.nudTotalResultados.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // cbAmazon
            // 
            this.cbAmazon.AutoSize = true;
            this.cbAmazon.Location = new System.Drawing.Point(92, 19);
            this.cbAmazon.Name = "cbAmazon";
            this.cbAmazon.Size = new System.Drawing.Size(64, 17);
            this.cbAmazon.TabIndex = 1;
            this.cbAmazon.Text = "Amazon";
            this.cbAmazon.UseVisualStyleBackColor = true;
            // 
            // cbGoogle
            // 
            this.cbGoogle.AutoSize = true;
            this.cbGoogle.Location = new System.Drawing.Point(6, 19);
            this.cbGoogle.Name = "cbGoogle";
            this.cbGoogle.Size = new System.Drawing.Size(60, 17);
            this.cbGoogle.TabIndex = 0;
            this.cbGoogle.Text = "Google";
            this.cbGoogle.UseVisualStyleBackColor = true;
            // 
            // lvImagenes
            // 
            this.lvImagenes.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.lvImagenes.LargeImageList = this.listaImagenesLittle;
            this.lvImagenes.Location = new System.Drawing.Point(3, 160);
            this.lvImagenes.Name = "lvImagenes";
            this.lvImagenes.Size = new System.Drawing.Size(496, 395);
            this.lvImagenes.TabIndex = 12;
            this.lvImagenes.UseCompatibleStateImageBehavior = false;
            this.lvImagenes.ItemActivate += new System.EventHandler(this.lvImagenes_ItemActivate);
            // 
            // listaImagenesLittle
            // 
            this.listaImagenesLittle.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.listaImagenesLittle.ImageSize = new System.Drawing.Size(90, 90);
            this.listaImagenesLittle.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pbImagen1
            // 
            this.pbImagen1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagen1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbImagen1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbImagen1.ErrorImage")));
            this.pbImagen1.Location = new System.Drawing.Point(3, 3);
            this.pbImagen1.Name = "pbImagen1";
            this.pbImagen1.Size = new System.Drawing.Size(150, 150);
            this.pbImagen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen1.TabIndex = 7;
            this.pbImagen1.TabStop = false;
            // 
            // pnIzquierda
            // 
            this.pnIzquierda.Controls.Add(this.pnPistas);
            this.pnIzquierda.Controls.Add(this.pnCambios);
            this.pnIzquierda.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnIzquierda.Location = new System.Drawing.Point(0, 0);
            this.pnIzquierda.Name = "pnIzquierda";
            this.pnIzquierda.Size = new System.Drawing.Size(573, 589);
            this.pnIzquierda.TabIndex = 0;
            // 
            // pnPistas
            // 
            this.pnPistas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnPistas.Controls.Add(this.cbUnidadesDisco);
            this.pnPistas.Controls.Add(this.btModificar);
            this.pnPistas.Controls.Add(this.label3);
            this.pnPistas.Controls.Add(this.tbModificar);
            this.pnPistas.Controls.Add(this.tvDirectorioMp3);
            this.pnPistas.Controls.Add(this.lvPistas);
            this.pnPistas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPistas.Location = new System.Drawing.Point(0, 157);
            this.pnPistas.Name = "pnPistas";
            this.pnPistas.Size = new System.Drawing.Size(573, 432);
            this.pnPistas.TabIndex = 92;
            // 
            // cbUnidadesDisco
            // 
            this.cbUnidadesDisco.FormattingEnabled = true;
            this.cbUnidadesDisco.Location = new System.Drawing.Point(3, 3);
            this.cbUnidadesDisco.Name = "cbUnidadesDisco";
            this.cbUnidadesDisco.Size = new System.Drawing.Size(199, 21);
            this.cbUnidadesDisco.TabIndex = 98;
            this.cbUnidadesDisco.SelectionChangeCommitted += new System.EventHandler(this.cbUnidadesDisco_SelectionChangeCommitted);
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(495, 404);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(75, 23);
            this.btModificar.TabIndex = 96;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 95;
            this.label3.Text = "Pista a Modificar";
            // 
            // tbModificar
            // 
            this.tbModificar.Location = new System.Drawing.Point(330, 383);
            this.tbModificar.Name = "tbModificar";
            this.tbModificar.Size = new System.Drawing.Size(240, 20);
            this.tbModificar.TabIndex = 94;
            // 
            // tvDirectorioMp3
            // 
            this.tvDirectorioMp3.Location = new System.Drawing.Point(3, 30);
            this.tvDirectorioMp3.Name = "tvDirectorioMp3";
            this.tvDirectorioMp3.Size = new System.Drawing.Size(230, 398);
            this.tvDirectorioMp3.TabIndex = 1;
            this.tvDirectorioMp3.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvDirectorioMp3_NodeMouseDoubleClick);
            // 
            // lvPistas
            // 
            this.lvPistas.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvPistas.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.lvPistas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPistas.Location = new System.Drawing.Point(239, 4);
            this.lvPistas.Name = "lvPistas";
            this.lvPistas.Size = new System.Drawing.Size(334, 368);
            this.lvPistas.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvPistas.TabIndex = 0;
            this.lvPistas.UseCompatibleStateImageBehavior = false;
            this.lvPistas.View = System.Windows.Forms.View.List;
            this.lvPistas.ItemActivate += new System.EventHandler(this.lvPistas_ItemActivate);
            this.lvPistas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvPistas_KeyDown);
            // 
            // pnCambios
            // 
            this.pnCambios.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnCambios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnCambios.Controls.Add(this.cbEstilo);
            this.pnCambios.Controls.Add(this.btTransformar);
            this.pnCambios.Controls.Add(this.panel2);
            this.pnCambios.Controls.Add(this.laAlbum);
            this.pnCambios.Controls.Add(this.tbAlbum);
            this.pnCambios.Controls.Add(this.tbBitrate);
            this.pnCambios.Controls.Add(this.tbComentario);
            this.pnCambios.Controls.Add(this.pgCanciones);
            this.pnCambios.Controls.Add(this.tbAnyo);
            this.pnCambios.Controls.Add(this.tbArtista);
            this.pnCambios.Controls.Add(this.laBitrate);
            this.pnCambios.Controls.Add(this.laAnyo);
            this.pnCambios.Controls.Add(this.laEstilo);
            this.pnCambios.Controls.Add(this.laComentario);
            this.pnCambios.Controls.Add(this.laArtista);
            this.pnCambios.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCambios.Enabled = false;
            this.pnCambios.Location = new System.Drawing.Point(0, 0);
            this.pnCambios.Name = "pnCambios";
            this.pnCambios.Size = new System.Drawing.Size(573, 157);
            this.pnCambios.TabIndex = 83;
            // 
            // cbEstilo
            // 
            this.cbEstilo.FormattingEnabled = true;
            this.cbEstilo.Items.AddRange(new object[] {
            "Blues",
            "Classic Rock",
            "Country",
            "Dance",
            "Disco",
            "Funk",
            "Grunge",
            "Hip-Hop",
            "Jazz",
            "Metal",
            "New Age",
            "Oldies",
            "Other",
            "Pop",
            "R&B",
            "Rap",
            "Reggae",
            "Rock",
            "Techno",
            "Industrial",
            "Alternative",
            "Ska",
            "Death Metal",
            "Pranks",
            "Soundtrack",
            "Euro-Techno",
            "Ambient",
            "Trip-Hop",
            "Vocal",
            "Jazz+Funk",
            "Fusion",
            "Trance",
            "Classical",
            "Instrumental",
            "Acid",
            "House",
            "Game",
            "Sound Clip",
            "Gospel",
            "Noise",
            "Alternative Rock",
            "Bass",
            "Soul",
            "Punk",
            "Space",
            "Meditative",
            "Instrumental Pop",
            "Instrumental Rock",
            "Ethnic",
            "Gothic",
            "Darkwave",
            "Techno-Industrial",
            "Electronic",
            "Pop-Folk",
            "Eurodance",
            "Dream",
            "Southern Rock",
            "Comedy",
            "Cult",
            "Gangsta",
            "Top 40",
            "Christian Rap",
            "Pop/Funk",
            "Jungle",
            "Native US",
            "Cabaret",
            "New Wave",
            "Psychadelic",
            "Rave",
            "Showtunes",
            "Trailer",
            "Lo-Fi",
            "Tribal",
            "Acid Punk",
            "Acid Jazz",
            "Polka",
            "Retro",
            "Musical",
            "Rock & Roll",
            "Hard Rock",
            "Folk",
            "Folk-Rock",
            "National Folk",
            "Swing",
            "Fast Fusion",
            "Bebob",
            "Latin",
            "Revival",
            "Celtic",
            "Bluegrass",
            "Avantgarde",
            "Gothic Rock",
            "Progressive Rock",
            "Psychedelic Rock",
            "Symphonic Rock",
            "Slow Rock",
            "Big Band",
            "Chorus",
            "Easy Listening",
            "Acoustic",
            "Humour",
            "Speech",
            "Chanson",
            "Opera",
            "Chamber Music",
            "Sonata",
            "Symphony",
            "Booty Bass",
            "Primus",
            "Porn Groove",
            "Satire",
            "Slow Jam",
            "Club",
            "Tango",
            "Samba",
            "Folklore",
            "Ballad",
            "Power Ballad",
            "Rhytmic Soul",
            "Freestyle",
            "Duet",
            "Punk Rock",
            "Drum Solo",
            "Acapella",
            "Euro-House",
            "Dance Hall",
            "Goa",
            "Drum & Bass",
            "Club-House",
            "Hardcore",
            "Terror",
            "Indie",
            "BritPop",
            "Negerpunk",
            "Polsk Punk",
            "Beat",
            "Christian Gangsta",
            "Heavy Metal",
            "Black Metal",
            "Crossover",
            "Contemporary C",
            "Christian Rock",
            "Merengue",
            "Salsa",
            "Thrash Metal",
            "Anime",
            "JPop",
            "SynthPop"});
            this.cbEstilo.Location = new System.Drawing.Point(65, 81);
            this.cbEstilo.Name = "cbEstilo";
            this.cbEstilo.Size = new System.Drawing.Size(207, 21);
            this.cbEstilo.TabIndex = 63;
            // 
            // btTransformar
            // 
            this.btTransformar.Image = ((System.Drawing.Image)(resources.GetObject("btTransformar.Image")));
            this.btTransformar.Location = new System.Drawing.Point(428, 2);
            this.btTransformar.Name = "btTransformar";
            this.btTransformar.Size = new System.Drawing.Size(134, 126);
            this.btTransformar.TabIndex = 80;
            this.btTransformar.UseVisualStyleBackColor = true;
            this.btTransformar.Click += new System.EventHandler(this.btTransformar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btCambiar);
            this.panel2.Controls.Add(this.tbCaracterAntes);
            this.panel2.Controls.Add(this.tbCaracterDespues);
            this.panel2.Location = new System.Drawing.Point(278, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 126);
            this.panel2.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Texto Nuevo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Texto a Cambiar";
            // 
            // btCambiar
            // 
            this.btCambiar.Location = new System.Drawing.Point(11, 92);
            this.btCambiar.Name = "btCambiar";
            this.btCambiar.Size = new System.Drawing.Size(75, 23);
            this.btCambiar.TabIndex = 60;
            this.btCambiar.Text = "Cambiar";
            this.btCambiar.UseVisualStyleBackColor = true;
            this.btCambiar.Click += new System.EventHandler(this.btCambiar_Click);
            // 
            // tbCaracterAntes
            // 
            this.tbCaracterAntes.Location = new System.Drawing.Point(11, 21);
            this.tbCaracterAntes.Name = "tbCaracterAntes";
            this.tbCaracterAntes.Size = new System.Drawing.Size(125, 20);
            this.tbCaracterAntes.TabIndex = 58;
            // 
            // tbCaracterDespues
            // 
            this.tbCaracterDespues.Location = new System.Drawing.Point(11, 66);
            this.tbCaracterDespues.Name = "tbCaracterDespues";
            this.tbCaracterDespues.Size = new System.Drawing.Size(125, 20);
            this.tbCaracterDespues.TabIndex = 59;
            // 
            // laAlbum
            // 
            this.laAlbum.AutoSize = true;
            this.laAlbum.Location = new System.Drawing.Point(3, 30);
            this.laAlbum.Name = "laAlbum";
            this.laAlbum.Size = new System.Drawing.Size(36, 13);
            this.laAlbum.TabIndex = 78;
            this.laAlbum.Text = "Album";
            // 
            // tbAlbum
            // 
            this.tbAlbum.Location = new System.Drawing.Point(65, 27);
            this.tbAlbum.Name = "tbAlbum";
            this.tbAlbum.Size = new System.Drawing.Size(207, 20);
            this.tbAlbum.TabIndex = 77;
            // 
            // tbBitrate
            // 
            this.tbBitrate.Location = new System.Drawing.Point(65, 132);
            this.tbBitrate.Name = "tbBitrate";
            this.tbBitrate.ReadOnly = true;
            this.tbBitrate.Size = new System.Drawing.Size(52, 20);
            this.tbBitrate.TabIndex = 71;
            // 
            // tbComentario
            // 
            this.tbComentario.Location = new System.Drawing.Point(65, 108);
            this.tbComentario.Name = "tbComentario";
            this.tbComentario.Size = new System.Drawing.Size(207, 20);
            this.tbComentario.TabIndex = 70;
            // 
            // pgCanciones
            // 
            this.pgCanciones.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pgCanciones.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.pgCanciones.Location = new System.Drawing.Point(123, 132);
            this.pgCanciones.Name = "pgCanciones";
            this.pgCanciones.Size = new System.Drawing.Size(439, 20);
            this.pgCanciones.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgCanciones.TabIndex = 0;
            this.pgCanciones.Visible = false;
            // 
            // tbAnyo
            // 
            this.tbAnyo.Location = new System.Drawing.Point(65, 54);
            this.tbAnyo.Name = "tbAnyo";
            this.tbAnyo.Size = new System.Drawing.Size(207, 20);
            this.tbAnyo.TabIndex = 68;
            // 
            // tbArtista
            // 
            this.tbArtista.Location = new System.Drawing.Point(65, 2);
            this.tbArtista.Name = "tbArtista";
            this.tbArtista.Size = new System.Drawing.Size(207, 20);
            this.tbArtista.TabIndex = 67;
            // 
            // laBitrate
            // 
            this.laBitrate.AutoSize = true;
            this.laBitrate.Location = new System.Drawing.Point(3, 135);
            this.laBitrate.Name = "laBitrate";
            this.laBitrate.Size = new System.Drawing.Size(37, 13);
            this.laBitrate.TabIndex = 76;
            this.laBitrate.Text = "Bitrate";
            // 
            // laAnyo
            // 
            this.laAnyo.AutoSize = true;
            this.laAnyo.Location = new System.Drawing.Point(3, 57);
            this.laAnyo.Name = "laAnyo";
            this.laAnyo.Size = new System.Drawing.Size(26, 13);
            this.laAnyo.TabIndex = 75;
            this.laAnyo.Text = "Año";
            // 
            // laEstilo
            // 
            this.laEstilo.AutoSize = true;
            this.laEstilo.Location = new System.Drawing.Point(3, 84);
            this.laEstilo.Name = "laEstilo";
            this.laEstilo.Size = new System.Drawing.Size(32, 13);
            this.laEstilo.TabIndex = 74;
            this.laEstilo.Text = "Estilo";
            // 
            // laComentario
            // 
            this.laComentario.AutoSize = true;
            this.laComentario.Location = new System.Drawing.Point(3, 111);
            this.laComentario.Name = "laComentario";
            this.laComentario.Size = new System.Drawing.Size(60, 13);
            this.laComentario.TabIndex = 73;
            this.laComentario.Text = "Comentario";
            // 
            // laArtista
            // 
            this.laArtista.AutoSize = true;
            this.laArtista.Location = new System.Drawing.Point(3, 6);
            this.laArtista.Name = "laArtista";
            this.laArtista.Size = new System.Drawing.Size(36, 13);
            this.laArtista.TabIndex = 72;
            this.laArtista.Text = "Artista";
            // 
            // bgwGrabacionMp3
            // 
            this.bgwGrabacionMp3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwGrabacionMp3_DoWork);
            this.bgwGrabacionMp3.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwGrabacionMp3_ProgressChanged);
            this.bgwGrabacionMp3.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwGrabacionMp3_RunWorkerCompleted);
            // 
            // fmTagMp3Magician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 589);
            this.Controls.Add(this.pnPrimario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmTagMp3Magician";
            this.Text = "Tag Mp3 Magician v1.0.0";
            this.Load += new System.EventHandler(this.fmTagMp3Magician_Load);
            this.pnPrimario.ResumeLayout(false);
            this.pnDerecha.ResumeLayout(false);
            this.pnImagenes.ResumeLayout(false);
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen1)).EndInit();
            this.pnIzquierda.ResumeLayout(false);
            this.pnPistas.ResumeLayout(false);
            this.pnPistas.PerformLayout();
            this.pnCambios.ResumeLayout(false);
            this.pnCambios.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnPrimario;
        private System.Windows.Forms.Panel pnDerecha;
        private System.Windows.Forms.Panel pnIzquierda;
        private System.Windows.Forms.Panel pnPistas;
        private System.Windows.Forms.ComboBox cbUnidadesDisco;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbModificar;
        private System.Windows.Forms.TreeView tvDirectorioMp3;
        private System.Windows.Forms.ListView lvPistas;
        private System.Windows.Forms.Panel pnCambios;
        private System.Windows.Forms.Button btTransformar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCambiar;
        private System.Windows.Forms.TextBox tbCaracterAntes;
        private System.Windows.Forms.TextBox tbCaracterDespues;
        private System.Windows.Forms.Label laAlbum;
        private System.Windows.Forms.TextBox tbAlbum;
        private System.Windows.Forms.TextBox tbBitrate;
        private System.Windows.Forms.TextBox tbComentario;
        private System.Windows.Forms.ProgressBar pgCanciones;
        private System.Windows.Forms.TextBox tbAnyo;
        private System.Windows.Forms.TextBox tbArtista;
        private System.Windows.Forms.Label laBitrate;
        private System.Windows.Forms.Label laAnyo;
        private System.Windows.Forms.Label laEstilo;
        private System.Windows.Forms.Label laComentario;
        private System.Windows.Forms.Label laArtista;
        private System.Windows.Forms.ImageList listaImagenesLittle;
        private System.Windows.Forms.Panel pnImagenes;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.GroupBox gbBusqueda;
        private System.Windows.Forms.CheckBox cbAmazon;
        private System.Windows.Forms.CheckBox cbGoogle;
        private System.Windows.Forms.ListView lvImagenes;
        private System.Windows.Forms.PictureBox pbImagen1;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudTotalResultados;
        private System.ComponentModel.BackgroundWorker bgwGrabacionMp3;
        private System.Windows.Forms.ComboBox cbEstilo;
    }
}

