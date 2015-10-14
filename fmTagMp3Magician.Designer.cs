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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmTagMp3Magician));
            this.pnPrimario = new System.Windows.Forms.Panel();
            this.pnDerecha = new System.Windows.Forms.Panel();
            this.pnCentro = new System.Windows.Forms.Panel();
            this.btMostrarImagenes = new System.Windows.Forms.Button();
            this.pnIzquierda = new System.Windows.Forms.Panel();
            this.pnPistas = new System.Windows.Forms.Panel();
            this.cbUnidadesDisco = new System.Windows.Forms.ComboBox();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbModificar = new System.Windows.Forms.TextBox();
            this.tvDirectorioMp3 = new System.Windows.Forms.TreeView();
            this.lvPistas = new System.Windows.Forms.ListView();
            this.pnCambios = new System.Windows.Forms.Panel();
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
            this.tbEstilo = new System.Windows.Forms.TextBox();
            this.tbAnyo = new System.Windows.Forms.TextBox();
            this.tbArtista = new System.Windows.Forms.TextBox();
            this.laBitrate = new System.Windows.Forms.Label();
            this.laAnyo = new System.Windows.Forms.Label();
            this.laEstilo = new System.Windows.Forms.Label();
            this.laComentario = new System.Windows.Forms.Label();
            this.laArtista = new System.Windows.Forms.Label();
            this.pnPrimario.SuspendLayout();
            this.pnCentro.SuspendLayout();
            this.pnIzquierda.SuspendLayout();
            this.pnPistas.SuspendLayout();
            this.pnCambios.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnPrimario
            // 
            this.pnPrimario.Controls.Add(this.pnDerecha);
            this.pnPrimario.Controls.Add(this.pnCentro);
            this.pnPrimario.Controls.Add(this.pnIzquierda);
            this.pnPrimario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPrimario.Location = new System.Drawing.Point(0, 0);
            this.pnPrimario.Name = "pnPrimario";
            this.pnPrimario.Size = new System.Drawing.Size(941, 589);
            this.pnPrimario.TabIndex = 0;
            // 
            // pnDerecha
            // 
            this.pnDerecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDerecha.Location = new System.Drawing.Point(613, 0);
            this.pnDerecha.Name = "pnDerecha";
            this.pnDerecha.Size = new System.Drawing.Size(328, 589);
            this.pnDerecha.TabIndex = 2;
            // 
            // pnCentro
            // 
            this.pnCentro.Controls.Add(this.btMostrarImagenes);
            this.pnCentro.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnCentro.Location = new System.Drawing.Point(573, 0);
            this.pnCentro.Name = "pnCentro";
            this.pnCentro.Size = new System.Drawing.Size(40, 589);
            this.pnCentro.TabIndex = 1;
            // 
            // btMostrarImagenes
            // 
            this.btMostrarImagenes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btMostrarImagenes.Image = ((System.Drawing.Image)(resources.GetObject("btMostrarImagenes.Image")));
            this.btMostrarImagenes.Location = new System.Drawing.Point(0, 0);
            this.btMostrarImagenes.Name = "btMostrarImagenes";
            this.btMostrarImagenes.Size = new System.Drawing.Size(40, 589);
            this.btMostrarImagenes.TabIndex = 0;
            this.btMostrarImagenes.UseVisualStyleBackColor = true;
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
            this.pnPistas.Controls.Add(this.btBorrar);
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
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(411, 404);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(75, 23);
            this.btBorrar.TabIndex = 97;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(330, 404);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(75, 23);
            this.btModificar.TabIndex = 96;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
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
            this.tbModificar.Size = new System.Drawing.Size(234, 20);
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
            this.lvPistas.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.lvPistas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPistas.Location = new System.Drawing.Point(239, 4);
            this.lvPistas.Name = "lvPistas";
            this.lvPistas.Size = new System.Drawing.Size(325, 368);
            this.lvPistas.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvPistas.TabIndex = 0;
            this.lvPistas.UseCompatibleStateImageBehavior = false;
            this.lvPistas.View = System.Windows.Forms.View.List;
            // 
            // pnCambios
            // 
            this.pnCambios.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnCambios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnCambios.Controls.Add(this.btTransformar);
            this.pnCambios.Controls.Add(this.panel2);
            this.pnCambios.Controls.Add(this.laAlbum);
            this.pnCambios.Controls.Add(this.tbAlbum);
            this.pnCambios.Controls.Add(this.tbBitrate);
            this.pnCambios.Controls.Add(this.tbComentario);
            this.pnCambios.Controls.Add(this.pgCanciones);
            this.pnCambios.Controls.Add(this.tbEstilo);
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
            // btTransformar
            // 
            this.btTransformar.Image = ((System.Drawing.Image)(resources.GetObject("btTransformar.Image")));
            this.btTransformar.Location = new System.Drawing.Point(428, 2);
            this.btTransformar.Name = "btTransformar";
            this.btTransformar.Size = new System.Drawing.Size(134, 126);
            this.btTransformar.TabIndex = 80;
            this.btTransformar.UseVisualStyleBackColor = true;
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
            this.tbComentario.ReadOnly = true;
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
            // tbEstilo
            // 
            this.tbEstilo.Location = new System.Drawing.Point(65, 81);
            this.tbEstilo.Name = "tbEstilo";
            this.tbEstilo.Size = new System.Drawing.Size(207, 20);
            this.tbEstilo.TabIndex = 69;
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
            // fmTagMp3Magician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 589);
            this.Controls.Add(this.pnPrimario);
            this.Name = "fmTagMp3Magician";
            this.Text = "Tag Mp3 Magician v1.0.0";
            this.Load += new System.EventHandler(this.fmTagMp3Magician_Load);
            this.pnPrimario.ResumeLayout(false);
            this.pnCentro.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnCentro;
        private System.Windows.Forms.Button btMostrarImagenes;
        private System.Windows.Forms.Panel pnIzquierda;
        private System.Windows.Forms.Panel pnPistas;
        private System.Windows.Forms.ComboBox cbUnidadesDisco;
        private System.Windows.Forms.Button btBorrar;
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
        private System.Windows.Forms.TextBox tbEstilo;
        private System.Windows.Forms.TextBox tbAnyo;
        private System.Windows.Forms.TextBox tbArtista;
        private System.Windows.Forms.Label laBitrate;
        private System.Windows.Forms.Label laAnyo;
        private System.Windows.Forms.Label laEstilo;
        private System.Windows.Forms.Label laComentario;
        private System.Windows.Forms.Label laArtista;
    }
}

