namespace LabBBDD.presentación
{
    partial class FormPaises
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
            lstPaises = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            numBaseImpuestos = new NumericUpDown();
            btnInsertar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)numBaseImpuestos).BeginInit();
            SuspendLayout();
            // 
            // lstPaises
            // 
            lstPaises.FormattingEnabled = true;
            lstPaises.Location = new Point(12, 12);
            lstPaises.Name = "lstPaises";
            lstPaises.Size = new Size(189, 274);
            lstPaises.TabIndex = 0;
            lstPaises.SelectedIndexChanged += this.lstPaises_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(234, 48);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 1;
            label1.Text = "ID:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(234, 122);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(234, 199);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 3;
            label3.Text = "Base de Impuestos:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(394, 45);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(394, 119);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 6;
            // 
            // numBaseImpuestos
            // 
            numBaseImpuestos.DecimalPlaces = 2;
            numBaseImpuestos.Location = new Point(394, 191);
            numBaseImpuestos.Name = "numBaseImpuestos";
            numBaseImpuestos.Size = new Size(100, 23);
            numBaseImpuestos.TabIndex = 7;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(281, 245);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(75, 23);
            btnInsertar.TabIndex = 8;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(394, 245);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(281, 288);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(394, 288);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // FormPaises
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 338);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnInsertar);
            Controls.Add(numBaseImpuestos);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstPaises);
            Name = "FormPaises";
            Text = "Form1";
            Load += this.FormPaises_Load;
            ((System.ComponentModel.ISupportInitialize)numBaseImpuestos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstPaises;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtId;
        private TextBox txtNombre;
        private NumericUpDown numBaseImpuestos;
        private Button btnInsertar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnLimpiar;
    }
}