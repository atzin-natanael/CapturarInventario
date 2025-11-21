namespace Inventario
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            titulo = new Label();
            TxtCodigo = new TextBox();
            label1 = new Label();
            DataSet = new DataGridView();
            ColumnID = new DataGridViewTextBoxColumn();
            Columna1 = new DataGridViewTextBoxColumn();
            Columna2 = new DataGridViewTextBoxColumn();
            Columna3 = new DataGridViewTextBoxColumn();
            Columna4 = new DataGridViewTextBoxColumn();
            Cb_Zonas = new ComboBox();
            label2 = new Label();
            Enviar = new Button();
            Cb_Colector = new ComboBox();
            label3 = new Label();
            panel1 = new Panel();
            Dark = new Button();
            panelMenu = new Panel();
            panelSubmenu = new Panel();
            Cargar = new Button();
            Actualizar = new Button();
            Send = new Button();
            btnMenu = new Button();
            paneltabla = new Panel();
            TimeMenu = new System.Windows.Forms.Timer(components);
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)DataSet).BeginInit();
            panel1.SuspendLayout();
            panelMenu.SuspendLayout();
            panelSubmenu.SuspendLayout();
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.Anchor = AnchorStyles.Top;
            titulo.AutoSize = true;
            titulo.BackColor = Color.Transparent;
            titulo.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titulo.ForeColor = Color.Black;
            titulo.Location = new Point(534, 9);
            titulo.Name = "titulo";
            titulo.Size = new Size(302, 31);
            titulo.TabIndex = 1;
            titulo.Text = "Control de Inventarios";
            // 
            // TxtCodigo
            // 
            TxtCodigo.Anchor = AnchorStyles.Top;
            TxtCodigo.BorderStyle = BorderStyle.FixedSingle;
            TxtCodigo.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtCodigo.Location = new Point(548, 144);
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.Size = new Size(306, 29);
            TxtCodigo.TabIndex = 3;
            TxtCodigo.KeyDown += TxtCodigo_KeyDown;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(459, 145);
            label1.Name = "label1";
            label1.Size = new Size(83, 24);
            label1.TabIndex = 4;
            label1.Text = "Código:";
            // 
            // DataSet
            // 
            DataSet.AllowUserToAddRows = false;
            DataSet.AllowUserToResizeColumns = false;
            DataSet.AllowUserToResizeRows = false;
            DataSet.BackgroundColor = Color.Beige;
            DataSet.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            DataSet.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle1.Font = new Font("Arial", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataSet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataSet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataSet.Columns.AddRange(new DataGridViewColumn[] { ColumnID, Columna1, Columna2, Columna3, Columna4 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Beige;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.WindowFrame;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DataSet.DefaultCellStyle = dataGridViewCellStyle2;
            DataSet.Dock = DockStyle.Fill;
            DataSet.EnableHeadersVisualStyles = false;
            DataSet.GridColor = Color.Navy;
            DataSet.Location = new Point(0, 278);
            DataSet.Name = "DataSet";
            DataSet.RowHeadersVisible = false;
            DataSet.Size = new Size(1350, 451);
            DataSet.TabIndex = 0;
            DataSet.CellEndEdit += DataSet_CellEndEdit;
            DataSet.KeyDown += DataSet_KeyDown;
            // 
            // ColumnID
            // 
            ColumnID.HeaderText = "ID";
            ColumnID.Name = "ColumnID";
            // 
            // Columna1
            // 
            Columna1.HeaderText = "Clave";
            Columna1.Name = "Columna1";
            Columna1.ReadOnly = true;
            // 
            // Columna2
            // 
            Columna2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Columna2.HeaderText = "Descripcion";
            Columna2.Name = "Columna2";
            Columna2.ReadOnly = true;
            // 
            // Columna3
            // 
            Columna3.HeaderText = "Existencia";
            Columna3.Name = "Columna3";
            Columna3.ReadOnly = true;
            // 
            // Columna4
            // 
            Columna4.HeaderText = "Piezas contadas";
            Columna4.Name = "Columna4";
            Columna4.Resizable = DataGridViewTriState.True;
            // 
            // Cb_Zonas
            // 
            Cb_Zonas.Anchor = AnchorStyles.Top;
            Cb_Zonas.FlatStyle = FlatStyle.Flat;
            Cb_Zonas.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            Cb_Zonas.FormattingEnabled = true;
            Cb_Zonas.Location = new Point(182, 99);
            Cb_Zonas.Name = "Cb_Zonas";
            Cb_Zonas.Size = new Size(132, 24);
            Cb_Zonas.TabIndex = 2;
            Cb_Zonas.KeyDown += Cb_Zonas_KeyDown;
            Cb_Zonas.KeyPress += Cb_Zonas_KeyPress;
            Cb_Zonas.Leave += Cb_Zonas_Leave;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(121, 99);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 6;
            label2.Text = "Zona:";
            // 
            // Enviar
            // 
            Enviar.BackColor = Color.Silver;
            Enviar.Cursor = Cursors.Hand;
            Enviar.Dock = DockStyle.Right;
            Enviar.FlatAppearance.BorderSize = 0;
            Enviar.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 50);
            Enviar.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            Enviar.FlatStyle = FlatStyle.Flat;
            Enviar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            Enviar.ForeColor = Color.Black;
            Enviar.Location = new Point(1179, 0);
            Enviar.Margin = new Padding(0);
            Enviar.Name = "Enviar";
            Enviar.Size = new Size(108, 56);
            Enviar.TabIndex = 0;
            Enviar.Text = "Guardar Zona";
            Enviar.UseVisualStyleBackColor = false;
            Enviar.Click += Enviar_Click;
            Enviar.MouseEnter += Enviar_MouseEnter;
            Enviar.MouseLeave += Enviar_MouseLeave;
            // 
            // Cb_Colector
            // 
            Cb_Colector.Anchor = AnchorStyles.Top;
            Cb_Colector.FlatStyle = FlatStyle.Flat;
            Cb_Colector.Font = new Font("Arial", 12F, FontStyle.Bold);
            Cb_Colector.FormattingEnabled = true;
            Cb_Colector.Location = new Point(182, 51);
            Cb_Colector.Name = "Cb_Colector";
            Cb_Colector.Size = new Size(288, 27);
            Cb_Colector.TabIndex = 1;
            Cb_Colector.KeyDown += Cb_Colector_KeyDown;
            Cb_Colector.KeyPress += Cb_Colector_KeyPress;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(95, 53);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 10;
            label3.Text = "Colector:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(Dark);
            panel1.Controls.Add(Cb_Colector);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(titulo);
            panel1.Controls.Add(TxtCodigo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Cb_Zonas);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1350, 184);
            panel1.TabIndex = 12;
            // 
            // Dark
            // 
            Dark.BackColor = Color.Beige;
            Dark.Cursor = Cursors.Hand;
            Dark.Dock = DockStyle.Right;
            Dark.FlatAppearance.BorderSize = 0;
            Dark.FlatAppearance.MouseDownBackColor = Color.Silver;
            Dark.FlatAppearance.MouseOverBackColor = Color.Silver;
            Dark.FlatStyle = FlatStyle.Flat;
            Dark.Font = new Font("Calibri", 14F, FontStyle.Bold);
            Dark.ForeColor = Color.Black;
            Dark.Image = (Image)resources.GetObject("Dark.Image");
            Dark.Location = new Point(1287, 0);
            Dark.Margin = new Padding(0);
            Dark.Name = "Dark";
            Dark.Size = new Size(63, 184);
            Dark.TabIndex = 11;
            Dark.TextAlign = ContentAlignment.MiddleRight;
            Dark.UseVisualStyleBackColor = false;
            Dark.Click += Dark_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Beige;
            panelMenu.Controls.Add(panelSubmenu);
            panelMenu.Controls.Add(btnMenu);
            panelMenu.Dock = DockStyle.Top;
            panelMenu.Location = new Point(0, 184);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(1350, 56);
            panelMenu.TabIndex = 13;
            // 
            // panelSubmenu
            // 
            panelSubmenu.BackColor = Color.Silver;
            panelSubmenu.Controls.Add(Cargar);
            panelSubmenu.Controls.Add(Actualizar);
            panelSubmenu.Controls.Add(Send);
            panelSubmenu.Controls.Add(Enviar);
            panelSubmenu.Dock = DockStyle.Fill;
            panelSubmenu.Location = new Point(0, 0);
            panelSubmenu.Name = "panelSubmenu";
            panelSubmenu.Size = new Size(1287, 56);
            panelSubmenu.TabIndex = 13;
            panelSubmenu.Resize += panelSubmenu_Resize;
            // 
            // Cargar
            // 
            Cargar.BackColor = Color.Silver;
            Cargar.Cursor = Cursors.Hand;
            Cargar.Dock = DockStyle.Right;
            Cargar.FlatAppearance.BorderSize = 0;
            Cargar.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 50);
            Cargar.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            Cargar.FlatStyle = FlatStyle.Flat;
            Cargar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            Cargar.ForeColor = Color.Black;
            Cargar.Location = new Point(855, 0);
            Cargar.Margin = new Padding(0);
            Cargar.Name = "Cargar";
            Cargar.Size = new Size(108, 56);
            Cargar.TabIndex = 0;
            Cargar.Text = "Recuperar";
            Cargar.UseVisualStyleBackColor = false;
            Cargar.Click += Cargar_Click;
            Cargar.MouseEnter += Cargar_MouseEnter;
            Cargar.MouseLeave += Cargar_MouseLeave;
            // 
            // Actualizar
            // 
            Actualizar.BackColor = Color.Silver;
            Actualizar.Cursor = Cursors.Hand;
            Actualizar.Dock = DockStyle.Right;
            Actualizar.FlatAppearance.BorderSize = 0;
            Actualizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 50);
            Actualizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            Actualizar.FlatStyle = FlatStyle.Flat;
            Actualizar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            Actualizar.ForeColor = Color.Black;
            Actualizar.Location = new Point(963, 0);
            Actualizar.Margin = new Padding(0);
            Actualizar.Name = "Actualizar";
            Actualizar.Size = new Size(108, 56);
            Actualizar.TabIndex = 0;
            Actualizar.Text = "Actualizar Códigos";
            Actualizar.UseVisualStyleBackColor = false;
            Actualizar.Click += Actualizar_Click;
            Actualizar.MouseEnter += Actualizar_MouseEnter;
            Actualizar.MouseLeave += Actualizar_MouseLeave;
            // 
            // Send
            // 
            Send.BackColor = Color.Silver;
            Send.Cursor = Cursors.Hand;
            Send.Dock = DockStyle.Right;
            Send.FlatAppearance.BorderSize = 0;
            Send.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 50);
            Send.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            Send.FlatStyle = FlatStyle.Flat;
            Send.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            Send.ForeColor = Color.Black;
            Send.Location = new Point(1071, 0);
            Send.Margin = new Padding(0);
            Send.Name = "Send";
            Send.Size = new Size(108, 56);
            Send.TabIndex = 0;
            Send.Text = "Enviar Correo";
            Send.UseVisualStyleBackColor = false;
            Send.Click += Send_Click;
            Send.MouseEnter += Send_MouseEnter;
            Send.MouseLeave += Send_MouseLeave;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.FromArgb(50, 50, 50);
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.Dock = DockStyle.Right;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnMenu.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Calibri", 14F, FontStyle.Bold);
            btnMenu.ForeColor = Color.Black;
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.Location = new Point(1287, 0);
            btnMenu.Margin = new Padding(0);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(63, 56);
            btnMenu.TabIndex = 4;
            btnMenu.TextAlign = ContentAlignment.MiddleRight;
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            btnMenu.MouseEnter += btnMenu_MouseEnter;
            // 
            // paneltabla
            // 
            paneltabla.Location = new Point(664, 464);
            paneltabla.Name = "paneltabla";
            paneltabla.Size = new Size(1046, 388);
            paneltabla.TabIndex = 14;
            // 
            // TimeMenu
            // 
            TimeMenu.Interval = 3000;
            TimeMenu.Tick += TimeMenu_Tick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Beige;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 240);
            panel2.Name = "panel2";
            panel2.Size = new Size(1350, 38);
            panel2.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 19, 19);
            ClientSize = new Size(1350, 729);
            Controls.Add(DataSet);
            Controls.Add(panel2);
            Controls.Add(paneltabla);
            Controls.Add(panelMenu);
            Controls.Add(panel1);
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DataSet).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelMenu.ResumeLayout(false);
            panelSubmenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label titulo;
        private TextBox TxtCodigo;
        private Label label1;
        private DataGridView DataSet;
        private ComboBox Cb_Zonas;
        private Label label2;
        private Button Enviar;
        private ComboBox Cb_Colector;
        private Label label3;
        private Panel panel1;
        private Panel panelMenu;
        private Panel paneltabla;
        private Button btnMenu;
        private Panel panelSubmenu;
        private Button Actualizar;
        private Button Send;
        private System.Windows.Forms.Timer TimeMenu;
        private Panel panel2;
        private Button Cargar;
        private Button Dark;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn Columna1;
        private DataGridViewTextBoxColumn Columna2;
        private DataGridViewTextBoxColumn Columna3;
        private DataGridViewTextBoxColumn Columna4;
    }
}