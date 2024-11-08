namespace FormsApi
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGVAlumno = new System.Windows.Forms.DataGridView();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.TBEdad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BTNActualizar = new System.Windows.Forms.Button();
            this.DTPFecha = new System.Windows.Forms.DateTimePicker();
            this.TBID = new System.Windows.Forms.TextBox();
            this.BtnCargar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnAct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVAlumno
            // 
            this.DGVAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAlumno.Location = new System.Drawing.Point(316, 13);
            this.DGVAlumno.Name = "DGVAlumno";
            this.DGVAlumno.RowHeadersWidth = 51;
            this.DGVAlumno.RowTemplate.Height = 24;
            this.DGVAlumno.Size = new System.Drawing.Size(604, 450);
            this.DGVAlumno.TabIndex = 0;
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(43, 32);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(162, 22);
            this.TBNombre.TabIndex = 1;
            // 
            // TBEdad
            // 
            this.TBEdad.Location = new System.Drawing.Point(43, 101);
            this.TBEdad.Name = "TBEdad";
            this.TBEdad.Size = new System.Drawing.Size(162, 22);
            this.TBEdad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Edad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha de Nacimiento";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(34, 201);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(84, 32);
            this.BtnAgregar.TabIndex = 7;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BTNActualizar
            // 
            this.BTNActualizar.Location = new System.Drawing.Point(60, 431);
            this.BTNActualizar.Name = "BTNActualizar";
            this.BTNActualizar.Size = new System.Drawing.Size(123, 32);
            this.BTNActualizar.TabIndex = 8;
            this.BTNActualizar.Text = "Actualizar Tabla";
            this.BTNActualizar.UseVisualStyleBackColor = true;
            this.BTNActualizar.Click += new System.EventHandler(this.BTNActualizar_Click);
            // 
            // DTPFecha
            // 
            this.DTPFecha.Location = new System.Drawing.Point(13, 163);
            this.DTPFecha.Name = "DTPFecha";
            this.DTPFecha.Size = new System.Drawing.Size(276, 22);
            this.DTPFecha.TabIndex = 9;
            // 
            // TBID
            // 
            this.TBID.Location = new System.Drawing.Point(43, 279);
            this.TBID.Name = "TBID";
            this.TBID.Size = new System.Drawing.Size(162, 22);
            this.TBID.TabIndex = 10;
            // 
            // BtnCargar
            // 
            this.BtnCargar.Location = new System.Drawing.Point(13, 307);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(105, 25);
            this.BtnCargar.TabIndex = 11;
            this.BtnCargar.Text = "Cargar Alumno";
            this.BtnCargar.UseVisualStyleBackColor = true;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminar.Location = new System.Drawing.Point(143, 307);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(116, 25);
            this.BtnEliminar.TabIndex = 12;
            this.BtnEliminar.Text = "Eliminar Alumno";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "ID";
            // 
            // BtnAct
            // 
            this.BtnAct.Location = new System.Drawing.Point(143, 201);
            this.BtnAct.Name = "BtnAct";
            this.BtnAct.Size = new System.Drawing.Size(88, 32);
            this.BtnAct.TabIndex = 14;
            this.BtnAct.Text = "Actualizar";
            this.BtnAct.UseVisualStyleBackColor = true;
            this.BtnAct.Click += new System.EventHandler(this.BtnAct_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(930, 475);
            this.Controls.Add(this.BtnAct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnCargar);
            this.Controls.Add(this.TBID);
            this.Controls.Add(this.DTPFecha);
            this.Controls.Add(this.BTNActualizar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBEdad);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.DGVAlumno);
            this.Name = "Form1";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVAlumno;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.TextBox TBEdad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BTNActualizar;
        private System.Windows.Forms.DateTimePicker DTPFecha;
        private System.Windows.Forms.TextBox TBID;
        private System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnAct;
    }
}

