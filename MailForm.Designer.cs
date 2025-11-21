namespace Inventario
{
    partial class MailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailForm));
            panel1 = new Panel();
            label4 = new Label();
            Exit = new Button();
            panel2 = new Panel();
            Asunto = new TextBox();
            label5 = new Label();
            label3 = new Label();
            PwCorreo = new TextBox();
            Enviar = new Button();
            CorreoDestino = new TextBox();
            label2 = new Label();
            CorreoRemitente = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(Exit);
            panel1.Cursor = Cursors.Hand;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(793, 52);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(321, 9);
            label4.Name = "label4";
            label4.Size = new Size(156, 29);
            label4.TabIndex = 1;
            label4.Text = "Enviar correo";
            label4.MouseDown += label4_MouseDown;
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
            Exit.Location = new Point(711, 0);
            Exit.Name = "Exit";
            Exit.Size = new Size(82, 52);
            Exit.TabIndex = 0;
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(Asunto);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(PwCorreo);
            panel2.Controls.Add(Enviar);
            panel2.Controls.Add(CorreoDestino);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(CorreoRemitente);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(793, 376);
            panel2.TabIndex = 1;
            // 
            // Asunto
            // 
            Asunto.Location = new Point(316, 230);
            Asunto.Multiline = true;
            Asunto.Name = "Asunto";
            Asunto.Size = new Size(362, 50);
            Asunto.TabIndex = 4;
            Asunto.KeyDown += Asunto_KeyDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(182, 236);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 7;
            label5.Text = "Asunto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(206, 92);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 6;
            label3.Text = "Contraseña";
            // 
            // PwCorreo
            // 
            PwCorreo.Location = new Point(316, 92);
            PwCorreo.Name = "PwCorreo";
            PwCorreo.Size = new Size(362, 26);
            PwCorreo.TabIndex = 2;
            PwCorreo.UseSystemPasswordChar = true;
            PwCorreo.KeyDown += PwCorreo_KeyDown;
            // 
            // Enviar
            // 
            Enviar.Cursor = Cursors.Hand;
            Enviar.Location = new Point(344, 304);
            Enviar.Name = "Enviar";
            Enviar.Size = new Size(133, 50);
            Enviar.TabIndex = 5;
            Enviar.Text = "Enviar";
            Enviar.UseVisualStyleBackColor = true;
            Enviar.Click += Enviar_Click;
            // 
            // CorreoDestino
            // 
            CorreoDestino.Location = new Point(316, 156);
            CorreoDestino.Name = "CorreoDestino";
            CorreoDestino.Size = new Size(362, 26);
            CorreoDestino.TabIndex = 3;
            CorreoDestino.KeyDown += CorreoDestino_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(182, 162);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 2;
            label2.Text = "Correo Destino";
            // 
            // CorreoRemitente
            // 
            CorreoRemitente.Location = new Point(316, 38);
            CorreoRemitente.Name = "CorreoRemitente";
            CorreoRemitente.Size = new Size(362, 26);
            CorreoRemitente.TabIndex = 1;
            CorreoRemitente.KeyDown += CorreoRemitente_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(163, 38);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 0;
            label1.Text = "Correo Remitente";
            // 
            // MailForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            ClientSize = new Size(793, 428);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "MailForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MailForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button Exit;
        private Panel panel2;
        private Button Enviar;
        private TextBox CorreoDestino;
        private Label label2;
        private TextBox CorreoRemitente;
        private Label label1;
        private Label label3;
        private TextBox PwCorreo;
        private Label label4;
        private TextBox Asunto;
        private Label label5;
    }
}