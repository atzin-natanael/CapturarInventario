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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            Actualizar = new Button();
            titulo = new Label();
            Ingresar = new Button();
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
            Cargar = new Button();
            Cb_Colector = new ComboBox();
            label3 = new Label();
            Send = new Button();
            ((System.ComponentModel.ISupportInitialize)DataSet).BeginInit();
            SuspendLayout();
            // 
            // Actualizar
            // 
            Actualizar.Anchor = AnchorStyles.Top;
            Actualizar.BackColor = Color.SeaGreen;
            Actualizar.Cursor = Cursors.Hand;
            Actualizar.FlatStyle = FlatStyle.Popup;
            Actualizar.Location = new Point(697, 12);
            Actualizar.Name = "Actualizar";
            Actualizar.Size = new Size(91, 49);
            Actualizar.TabIndex = 0;
            Actualizar.Text = "Actualizar Articulos";
            Actualizar.UseVisualStyleBackColor = false;
            Actualizar.Visible = false;
            Actualizar.Click += Actualizar_Click;
            // 
            // titulo
            // 
            titulo.Anchor = AnchorStyles.Top;
            titulo.AutoSize = true;
            titulo.BackColor = Color.Transparent;
            titulo.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            titulo.ForeColor = Color.White;
            titulo.Location = new Point(259, 9);
            titulo.Name = "titulo";
            titulo.Size = new Size(269, 28);
            titulo.TabIndex = 1;
            titulo.Text = "Control de Inventarios";
            // 
            // Ingresar
            // 
            Ingresar.Anchor = AnchorStyles.Top;
            Ingresar.BackColor = Color.RoyalBlue;
            Ingresar.FlatStyle = FlatStyle.Flat;
            Ingresar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Ingresar.ForeColor = SystemColors.Control;
            Ingresar.Location = new Point(562, 67);
            Ingresar.Name = "Ingresar";
            Ingresar.Size = new Size(110, 43);
            Ingresar.TabIndex = 4;
            Ingresar.Text = "Ingresar";
            Ingresar.UseVisualStyleBackColor = false;
            Ingresar.Click += Ingresar_Click;
            // 
            // TxtCodigo
            // 
            TxtCodigo.Anchor = AnchorStyles.Top;
            TxtCodigo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TxtCodigo.Location = new Point(259, 84);
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.Size = new Size(288, 26);
            TxtCodigo.TabIndex = 3;
            TxtCodigo.KeyDown += TxtCodigo_KeyDown;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(154, 85);
            label1.Name = "label1";
            label1.Size = new Size(81, 22);
            label1.TabIndex = 4;
            label1.Text = "Código:";
            // 
            // DataSet
            // 
            DataSet.AllowUserToAddRows = false;
            DataSet.AllowUserToResizeColumns = false;
            DataSet.AllowUserToResizeRows = false;
            DataSet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataSet.BackgroundColor = SystemColors.ActiveCaption;
            DataSet.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            DataSet.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DataSet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DataSet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataSet.Columns.AddRange(new DataGridViewColumn[] { ColumnID, Columna1, Columna2, Columna3, Columna4 });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Arial Unicode MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.Yellow;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            DataSet.DefaultCellStyle = dataGridViewCellStyle6;
            DataSet.EnableHeadersVisualStyles = false;
            DataSet.GridColor = Color.Navy;
            DataSet.Location = new Point(12, 139);
            DataSet.Name = "DataSet";
            DataSet.RowHeadersVisible = false;
            DataSet.RowTemplate.Height = 25;
            DataSet.Size = new Size(776, 299);
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
            dataGridViewCellStyle5.ForeColor = Color.Black;
            Columna4.DefaultCellStyle = dataGridViewCellStyle5;
            Columna4.HeaderText = "Piezas contadas";
            Columna4.Name = "Columna4";
            Columna4.Resizable = DataGridViewTriState.True;
            // 
            // Cb_Zonas
            // 
            Cb_Zonas.Anchor = AnchorStyles.Top;
            Cb_Zonas.FlatStyle = FlatStyle.Flat;
            Cb_Zonas.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Cb_Zonas.FormattingEnabled = true;
            Cb_Zonas.Location = new Point(12, 38);
            Cb_Zonas.Name = "Cb_Zonas";
            Cb_Zonas.Size = new Size(132, 24);
            Cb_Zonas.TabIndex = 1;
            Cb_Zonas.KeyDown += Cb_Zonas_KeyDown;
            Cb_Zonas.KeyPress += Cb_Zonas_KeyPress;
            Cb_Zonas.Leave += Cb_Zonas_Leave;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 7);
            label2.Name = "label2";
            label2.Size = new Size(91, 28);
            label2.TabIndex = 6;
            label2.Text = "Zonas:";
            // 
            // Enviar
            // 
            Enviar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Enviar.BackColor = Color.FromArgb(192, 0, 0);
            Enviar.Cursor = Cursors.Hand;
            Enviar.FlatStyle = FlatStyle.Flat;
            Enviar.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Enviar.ForeColor = SystemColors.Control;
            Enviar.Location = new Point(678, 5);
            Enviar.Name = "Enviar";
            Enviar.Size = new Size(110, 56);
            Enviar.TabIndex = 0;
            Enviar.Text = "Guardar Zona";
            Enviar.UseVisualStyleBackColor = false;
            Enviar.Click += Enviar_Click;
            // 
            // Cargar
            // 
            Cargar.Anchor = AnchorStyles.Top;
            Cargar.BackColor = Color.Gray;
            Cargar.Cursor = Cursors.Hand;
            Cargar.FlatStyle = FlatStyle.Flat;
            Cargar.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Cargar.Location = new Point(12, 79);
            Cargar.Name = "Cargar";
            Cargar.Size = new Size(72, 29);
            Cargar.TabIndex = 8;
            Cargar.Text = "Cargar";
            Cargar.UseVisualStyleBackColor = false;
            Cargar.Click += Cargar_Click;
            // 
            // Cb_Colector
            // 
            Cb_Colector.Anchor = AnchorStyles.Top;
            Cb_Colector.FlatStyle = FlatStyle.Flat;
            Cb_Colector.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Cb_Colector.FormattingEnabled = true;
            Cb_Colector.Location = new Point(259, 41);
            Cb_Colector.Name = "Cb_Colector";
            Cb_Colector.Size = new Size(288, 27);
            Cb_Colector.TabIndex = 2;
            Cb_Colector.KeyDown += Cb_Colector_KeyDown;
            Cb_Colector.KeyPress += Cb_Colector_KeyPress;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(150, 41);
            label3.Name = "label3";
            label3.Size = new Size(94, 22);
            label3.TabIndex = 10;
            label3.Text = "Colector:";
            // 
            // Send
            // 
            Send.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Send.BackColor = Color.DarkOliveGreen;
            Send.Cursor = Cursors.Hand;
            Send.FlatStyle = FlatStyle.Flat;
            Send.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Send.ForeColor = SystemColors.Control;
            Send.Location = new Point(678, 85);
            Send.Name = "Send";
            Send.Size = new Size(110, 35);
            Send.TabIndex = 11;
            Send.Text = "Enviar";
            Send.UseVisualStyleBackColor = false;
            Send.Click += Send_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 19, 19);
            ClientSize = new Size(800, 450);
            Controls.Add(Send);
            Controls.Add(label3);
            Controls.Add(Cb_Colector);
            Controls.Add(Cargar);
            Controls.Add(Enviar);
            Controls.Add(label2);
            Controls.Add(Cb_Zonas);
            Controls.Add(DataSet);
            Controls.Add(label1);
            Controls.Add(TxtCodigo);
            Controls.Add(Ingresar);
            Controls.Add(titulo);
            Controls.Add(Actualizar);
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DataSet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Actualizar;
        private Label titulo;
        private Button Ingresar;
        private TextBox TxtCodigo;
        private Label label1;
        private DataGridView DataSet;
        private ComboBox Cb_Zonas;
        private Label label2;
        private Button Enviar;
        private Button Cargar;
        private ComboBox Cb_Colector;
        private Label label3;
        private Button Send;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn Columna1;
        private DataGridViewTextBoxColumn Columna2;
        private DataGridViewTextBoxColumn Columna3;
        private DataGridViewTextBoxColumn Columna4;
    }
}