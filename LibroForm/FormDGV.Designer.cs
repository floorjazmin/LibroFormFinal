
namespace LibroForm
{
    partial class FormDGV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GridLibros = new System.Windows.Forms.DataGridView();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.botBuscar = new System.Windows.Forms.Button();
            this.botAgregar = new System.Windows.Forms.Button();
            this.Título = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Páginas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edición = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CiudadyPaís = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDeEdición = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // GridLibros
            // 
            this.GridLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Título,
            this.Autor,
            this.ISBN,
            this.Páginas,
            this.Edición,
            this.Editorial,
            this.CiudadyPaís,
            this.FechaDeEdición,
            this.Editar,
            this.Eliminar});
            this.GridLibros.Location = new System.Drawing.Point(23, 93);
            this.GridLibros.Name = "GridLibros";
            this.GridLibros.Size = new System.Drawing.Size(1044, 448);
            this.GridLibros.TabIndex = 0;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(116, 41);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(74, 24);
            this.lblBuscar.TabIndex = 1;
            this.lblBuscar.Text = "Buscar";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(212, 45);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(432, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // botBuscar
            // 
            this.botBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botBuscar.Location = new System.Drawing.Point(684, 39);
            this.botBuscar.Name = "botBuscar";
            this.botBuscar.Size = new System.Drawing.Size(86, 32);
            this.botBuscar.TabIndex = 3;
            this.botBuscar.Text = "Buscar";
            this.botBuscar.UseVisualStyleBackColor = true;
            this.botBuscar.Click += new System.EventHandler(this.botBuscar_Click);
            // 
            // botAgregar
            // 
            this.botAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botAgregar.Location = new System.Drawing.Point(805, 41);
            this.botAgregar.Name = "botAgregar";
            this.botAgregar.Size = new System.Drawing.Size(86, 32);
            this.botAgregar.TabIndex = 4;
            this.botAgregar.Text = "Agregar";
            this.botAgregar.UseVisualStyleBackColor = true;
            this.botAgregar.Click += new System.EventHandler(this.botAgregar_Click);
            // 
            // Título
            // 
            this.Título.HeaderText = "Título";
            this.Título.Name = "Título";
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            // 
            // Páginas
            // 
            this.Páginas.HeaderText = "Páginas";
            this.Páginas.Name = "Páginas";
            // 
            // Edición
            // 
            this.Edición.HeaderText = "Edición";
            this.Edición.Name = "Edición";
            // 
            // Editorial
            // 
            this.Editorial.HeaderText = "Editorial";
            this.Editorial.Name = "Editorial";
            // 
            // CiudadyPaís
            // 
            this.CiudadyPaís.HeaderText = "CiudadyPaís";
            this.CiudadyPaís.Name = "CiudadyPaís";
            // 
            // FechaDeEdición
            // 
            this.FechaDeEdición.HeaderText = "FechaDeEdición";
            this.FechaDeEdición.Name = "FechaDeEdición";
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FormDGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1099, 581);
            this.Controls.Add(this.botAgregar);
            this.Controls.Add(this.botBuscar);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.GridLibros);
            this.Name = "FormDGV";
            this.Text = "FormDGV";
            ((System.ComponentModel.ISupportInitialize)(this.GridLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridLibros;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button botBuscar;
        private System.Windows.Forms.Button botAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Título;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Páginas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edición;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn CiudadyPaís;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeEdición;
        private System.Windows.Forms.DataGridViewLinkColumn Editar;
        private System.Windows.Forms.DataGridViewLinkColumn Eliminar;
    }
}

