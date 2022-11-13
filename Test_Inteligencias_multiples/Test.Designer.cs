namespace Test_Inteligencias_multiples
{
    partial class Test
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
            this.Next = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Verdadero = new MaterialSkin.Controls.MaterialRadioButton();
            this.Falso = new MaterialSkin.Controls.MaterialRadioButton();
            this.Preguntas = new MaterialSkin.Controls.MaterialLabel();
            this.Paginacion = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // Next
            // 
            this.Next.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Next.Depth = 0;
            this.Next.Location = new System.Drawing.Point(418, 234);
            this.Next.MouseState = MaterialSkin.MouseState.HOVER;
            this.Next.Name = "Next";
            this.Next.Primary = true;
            this.Next.Size = new System.Drawing.Size(100, 31);
            this.Next.TabIndex = 0;
            this.Next.Text = "Siguiente";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // Verdadero
            // 
            this.Verdadero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Verdadero.AutoSize = true;
            this.Verdadero.BackColor = System.Drawing.Color.White;
            this.Verdadero.Depth = 0;
            this.Verdadero.Font = new System.Drawing.Font("Roboto", 10F);
            this.Verdadero.Location = new System.Drawing.Point(32, 234);
            this.Verdadero.Margin = new System.Windows.Forms.Padding(0);
            this.Verdadero.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Verdadero.MouseState = MaterialSkin.MouseState.HOVER;
            this.Verdadero.Name = "Verdadero";
            this.Verdadero.Ripple = true;
            this.Verdadero.Size = new System.Drawing.Size(93, 30);
            this.Verdadero.TabIndex = 1;
            this.Verdadero.TabStop = true;
            this.Verdadero.Text = "Verdadero";
            this.Verdadero.UseVisualStyleBackColor = false;
            // 
            // Falso
            // 
            this.Falso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Falso.AutoSize = true;
            this.Falso.BackColor = System.Drawing.Color.White;
            this.Falso.Depth = 0;
            this.Falso.Font = new System.Drawing.Font("Roboto", 10F);
            this.Falso.Location = new System.Drawing.Point(149, 235);
            this.Falso.Margin = new System.Windows.Forms.Padding(0);
            this.Falso.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Falso.MouseState = MaterialSkin.MouseState.HOVER;
            this.Falso.Name = "Falso";
            this.Falso.Ripple = true;
            this.Falso.Size = new System.Drawing.Size(62, 30);
            this.Falso.TabIndex = 2;
            this.Falso.TabStop = true;
            this.Falso.Text = "Falso";
            this.Falso.UseVisualStyleBackColor = false;
            // 
            // Preguntas
            // 
            this.Preguntas.AutoSize = true;
            this.Preguntas.BackColor = System.Drawing.Color.Transparent;
            this.Preguntas.Depth = 0;
            this.Preguntas.Font = new System.Drawing.Font("Roboto", 11F);
            this.Preguntas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Preguntas.Location = new System.Drawing.Point(28, 89);
            this.Preguntas.MouseState = MaterialSkin.MouseState.HOVER;
            this.Preguntas.Name = "Preguntas";
            this.Preguntas.Size = new System.Drawing.Size(0, 19);
            this.Preguntas.TabIndex = 3;
            // 
            // Paginacion
            // 
            this.Paginacion.AutoSize = true;
            this.Paginacion.Depth = 0;
            this.Paginacion.Font = new System.Drawing.Font("Roboto", 11F);
            this.Paginacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Paginacion.Location = new System.Drawing.Point(32, 199);
            this.Paginacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.Paginacion.Name = "Paginacion";
            this.Paginacion.Size = new System.Drawing.Size(0, 19);
            this.Paginacion.TabIndex = 4;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 293);
            this.Controls.Add(this.Paginacion);
            this.Controls.Add(this.Preguntas);
            this.Controls.Add(this.Falso);
            this.Controls.Add(this.Verdadero);
            this.Controls.Add(this.Next);
            this.Name = "Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Formulario_FormClosed);
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton Next;
        private MaterialSkin.Controls.MaterialRadioButton Verdadero;
        private MaterialSkin.Controls.MaterialRadioButton Falso;
        private MaterialSkin.Controls.MaterialLabel Preguntas;
        private MaterialSkin.Controls.MaterialLabel Paginacion;
    }
}