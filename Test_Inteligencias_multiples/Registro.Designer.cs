namespace Test_Inteligencias_multiples
{
    partial class Registro
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
            this.Nombrelabel = new MaterialSkin.Controls.MaterialLabel();
            this.Nacimientolabel = new MaterialSkin.Controls.MaterialLabel();
            this.Correolabel = new MaterialSkin.Controls.MaterialLabel();
            this.Celularlabel = new MaterialSkin.Controls.MaterialLabel();
            this.TextNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TextCorreo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TextCelular = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.fn = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Nombrelabel
            // 
            this.Nombrelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Nombrelabel.AutoSize = true;
            this.Nombrelabel.BackColor = System.Drawing.Color.Transparent;
            this.Nombrelabel.Depth = 0;
            this.Nombrelabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.Nombrelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Nombrelabel.Location = new System.Drawing.Point(38, 98);
            this.Nombrelabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.Nombrelabel.Name = "Nombrelabel";
            this.Nombrelabel.Size = new System.Drawing.Size(133, 19);
            this.Nombrelabel.TabIndex = 0;
            this.Nombrelabel.Text = "Nombre Completo";
            // 
            // Nacimientolabel
            // 
            this.Nacimientolabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Nacimientolabel.AutoSize = true;
            this.Nacimientolabel.BackColor = System.Drawing.Color.Transparent;
            this.Nacimientolabel.Depth = 0;
            this.Nacimientolabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.Nacimientolabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Nacimientolabel.Location = new System.Drawing.Point(38, 139);
            this.Nacimientolabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.Nacimientolabel.Name = "Nacimientolabel";
            this.Nacimientolabel.Size = new System.Drawing.Size(151, 19);
            this.Nacimientolabel.TabIndex = 1;
            this.Nacimientolabel.Text = "Fecha de Nacimiento";
            // 
            // Correolabel
            // 
            this.Correolabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Correolabel.AutoSize = true;
            this.Correolabel.BackColor = System.Drawing.Color.Transparent;
            this.Correolabel.Depth = 0;
            this.Correolabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.Correolabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Correolabel.Location = new System.Drawing.Point(38, 181);
            this.Correolabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.Correolabel.Name = "Correolabel";
            this.Correolabel.Size = new System.Drawing.Size(55, 19);
            this.Correolabel.TabIndex = 2;
            this.Correolabel.Text = "Correo";
            // 
            // Celularlabel
            // 
            this.Celularlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Celularlabel.AutoSize = true;
            this.Celularlabel.BackColor = System.Drawing.Color.Transparent;
            this.Celularlabel.Depth = 0;
            this.Celularlabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.Celularlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Celularlabel.Location = new System.Drawing.Point(38, 223);
            this.Celularlabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.Celularlabel.Name = "Celularlabel";
            this.Celularlabel.Size = new System.Drawing.Size(56, 19);
            this.Celularlabel.TabIndex = 3;
            this.Celularlabel.Text = "Celular";
            // 
            // TextNombre
            // 
            this.TextNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextNombre.Depth = 0;
            this.TextNombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TextNombre.Hint = "Ingresa tu nombre completo";
            this.TextNombre.Location = new System.Drawing.Point(217, 94);
            this.TextNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextNombre.Name = "TextNombre";
            this.TextNombre.PasswordChar = '\0';
            this.TextNombre.SelectedText = "";
            this.TextNombre.SelectionLength = 0;
            this.TextNombre.SelectionStart = 0;
            this.TextNombre.Size = new System.Drawing.Size(288, 23);
            this.TextNombre.TabIndex = 4;
            this.TextNombre.UseSystemPasswordChar = false;
            // 
            // TextCorreo
            // 
            this.TextCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextCorreo.Depth = 0;
            this.TextCorreo.Hint = "Ingresa tu correo electrónico";
            this.TextCorreo.Location = new System.Drawing.Point(217, 177);
            this.TextCorreo.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextCorreo.Name = "TextCorreo";
            this.TextCorreo.PasswordChar = '\0';
            this.TextCorreo.SelectedText = "";
            this.TextCorreo.SelectionLength = 0;
            this.TextCorreo.SelectionStart = 0;
            this.TextCorreo.Size = new System.Drawing.Size(288, 23);
            this.TextCorreo.TabIndex = 6;
            this.TextCorreo.UseSystemPasswordChar = false;
            // 
            // TextCelular
            // 
            this.TextCelular.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextCelular.Depth = 0;
            this.TextCelular.Hint = "Ingresa tu número de teléfono";
            this.TextCelular.Location = new System.Drawing.Point(217, 219);
            this.TextCelular.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextCelular.Name = "TextCelular";
            this.TextCelular.PasswordChar = '\0';
            this.TextCelular.SelectedText = "";
            this.TextCelular.SelectionLength = 0;
            this.TextCelular.SelectionStart = 0;
            this.TextCelular.Size = new System.Drawing.Size(288, 23);
            this.TextCelular.TabIndex = 7;
            this.TextCelular.UseSystemPasswordChar = false;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton1.BackColor = System.Drawing.Color.Transparent;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(376, 273);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(129, 29);
            this.materialRaisedButton1.TabIndex = 9;
            this.materialRaisedButton1.Text = "Comenzar";
            this.materialRaisedButton1.UseVisualStyleBackColor = false;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // fn
            // 
            this.fn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fn.Location = new System.Drawing.Point(217, 139);
            this.fn.Name = "fn";
            this.fn.Size = new System.Drawing.Size(288, 20);
            this.fn.TabIndex = 10;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 332);
            this.Controls.Add(this.fn);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.TextCelular);
            this.Controls.Add(this.TextCorreo);
            this.Controls.Add(this.TextNombre);
            this.Controls.Add(this.Celularlabel);
            this.Controls.Add(this.Correolabel);
            this.Controls.Add(this.Nacimientolabel);
            this.Controls.Add(this.Nombrelabel);
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registro_FormClosed);
            this.Load += new System.EventHandler(this.Registro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel Nombrelabel;
        private MaterialSkin.Controls.MaterialLabel Nacimientolabel;
        private MaterialSkin.Controls.MaterialLabel Correolabel;
        private MaterialSkin.Controls.MaterialLabel Celularlabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextNombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextCorreo;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextCelular;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.DateTimePicker fn;
    }
}

