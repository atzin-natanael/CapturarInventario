namespace Inventario
{
    partial class MensajeOK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MensajeOK));
            panel2 = new Panel();
            OK = new Button();
            texto = new Label();
            panel1 = new Panel();
            Exit = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(OK);
            panel2.Controls.Add(texto);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 39);
            panel2.Name = "panel2";
            panel2.Size = new Size(543, 177);
            panel2.TabIndex = 3;
            // 
            // OK
            // 
            OK.Cursor = Cursors.Hand;
            OK.Location = new Point(210, 96);
            OK.Name = "OK";
            OK.Size = new Size(115, 34);
            OK.TabIndex = 4;
            OK.Text = "Aceptar";
            OK.UseVisualStyleBackColor = true;
            OK.Click += OK_Click;
            // 
            // texto
            // 
            texto.AutoSize = true;
            texto.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            texto.ForeColor = SystemColors.Control;
            texto.Location = new Point(157, 29);
            texto.Name = "texto";
            texto.Size = new Size(251, 25);
            texto.TabIndex = 2;
            texto.Text = "Zona guardada con éxito";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(Exit);
            panel1.Cursor = Cursors.Hand;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(543, 39);
            panel1.TabIndex = 2;
            // 
            // Exit
            // 
            Exit.BackColor = Color.Gray;
            Exit.Dock = DockStyle.Right;
            Exit.FlatAppearance.BorderColor = Color.Red;
            Exit.FlatAppearance.BorderSize = 0;
            Exit.FlatAppearance.MouseDownBackColor = Color.Red;
            Exit.FlatAppearance.MouseOverBackColor = Color.Red;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.ForeColor = SystemColors.Control;
            Exit.Image = (Image)resources.GetObject("Exit.Image");
            Exit.Location = new Point(494, 0);
            Exit.Name = "Exit";
            Exit.Size = new Size(49, 39);
            Exit.TabIndex = 0;
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // MensajeOK
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            ClientSize = new Size(543, 216);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "MensajeOK";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MensajeOK";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button OK;
        private Panel panel1;
        private Button Exit;
        public Label texto;
    }
}