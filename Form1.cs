using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.Data.Sqlite;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Net.Mail;
using System.Net;
using DocumentFormat.OpenXml.Drawing.Diagrams;

namespace Inventario
{
    public partial class Form1 : Form
    {

        List<string> nombresArray = new List<string>();
        public Form1()
        {
            InitializeComponent();
            GlobalSettings.Instance.Ruta = "C:\\Inventario\\Inv.xlsx";
            Config();
            Zonas();
            Cb_Zonas.SelectedIndex = -1;
            Cb_Zonas.Select();
        }
        public void Zonas()
        {

            string zona = "C:\\Inventario\\Zonas.xlsx";
            // string filePath = "C:\\clavesSurtido\\Claves.xlsx";
            using (var workbook = new XLWorkbook(zona))
            {
                // Seleccionar la primera hoja del archivo
                var worksheet = workbook.Worksheet(1);
                int filas = worksheet.LastRowUsed().RowNumber();
                for (int i = 1; i < filas + 1; ++i)
                {
                    string name = worksheet.Row(i).Cell(1).Value.ToString();
                    nombresArray.Add(name);
                }
            }
            Cb_Zonas.DataSource = nombresArray;
            Cb_Zonas.AutoCompleteMode = AutoCompleteMode.Append;
            Cb_Zonas.AutoCompleteSource = AutoCompleteSource.CustomSource;
            Cb_Zonas.AutoCompleteCustomSource.AddRange(nombresArray.ToArray());
        }


        public void Config()
        {
            string filePath = "C:\\ConfigDB\\DB.txt"; // Ruta de tu archivo de texto
            List<string> lineas = new List<string>();

            // Verificar si el archivo existe
            if (File.Exists(filePath))
            {
                // Leer todas las líneas del archivo
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        GlobalSettings.Instance.Config.Add(linea);
                    }

                }
                GlobalSettings.Instance.Ip = GlobalSettings.Instance.Config[0];
                GlobalSettings.Instance.Puerto = GlobalSettings.Instance.Config[1];
                GlobalSettings.Instance.Direccion = GlobalSettings.Instance.Config[2];
                GlobalSettings.Instance.User = GlobalSettings.Instance.Config[3];
                GlobalSettings.Instance.Pw = GlobalSettings.Instance.Config[4];
            }

        }
        public decimal Existencia(string articulo_id)
        {
            FbConnection con = new FbConnection("User=" + GlobalSettings.Instance.User + ";" + "Password=" + GlobalSettings.Instance.Pw + ";" + "Database=" + GlobalSettings.Instance.Direccion + ";" + "DataSource=" + GlobalSettings.Instance.Ip + ";" + "Port=" + GlobalSettings.Instance.Puerto + ";" + "Dialect=3;" + "Charset=UTF8;");
            try
            {
                con.Open();
                FbCommand command = new FbCommand("EXIVAL_ART", con);
                command.CommandType = CommandType.StoredProcedure;

                // Parámetros de entrada
                command.Parameters.Add("V_ARTICULO_ID", FbDbType.Integer).Value = articulo_id;
                command.Parameters.Add("V_ALMACEN_ID", FbDbType.Integer).Value = 108404; //peri
                //command.Parameters.Add("V_ALMACEN_ID", FbDbType.Integer).Value = 108405; culiacan
                command.Parameters.Add("V_FECHA", FbDbType.Date).Value = DateTime.Today;
                command.Parameters.Add("V_ES_ULTIMO_COSTO", FbDbType.Char).Value = 'S';
                command.Parameters.Add("V_SUCURSAL_ID", FbDbType.Integer).Value = 0;

                // Parámetro de salida
                FbParameter paramARTICULO = new FbParameter("ARTICULO_ID", FbDbType.Numeric);
                paramARTICULO.Direction = ParameterDirection.Output;
                command.Parameters.Add(paramARTICULO);
                FbParameter paramEXISTENCIA = new FbParameter("EXISTENCIAS", FbDbType.Numeric);
                paramEXISTENCIA.Direction = ParameterDirection.Output;
                command.Parameters.Add(paramEXISTENCIA);
                // Ejecutar el procedimiento almacenado
                command.ExecuteNonQuery();
                int Existencia = Convert.ToInt32(command.Parameters[6].Value);

                FbCommand command2 = new FbCommand("EXIVAL_ART", con);
                command2.CommandType = CommandType.StoredProcedure;

                // Parámetros de entrada
                command2.Parameters.Add("V_ARTICULO_ID", FbDbType.Integer).Value = articulo_id;
                command2.Parameters.Add("V_ALMACEN_ID", FbDbType.Integer).Value = 108403; //PERI
                //command2.Parameters.Add("V_ALMACEN_ID", FbDbType.Integer).Value = 108405; culiacan
                command2.Parameters.Add("V_FECHA", FbDbType.Date).Value = DateTime.Today;
                command2.Parameters.Add("V_ES_ULTIMO_COSTO", FbDbType.Char).Value = 'S';
                command2.Parameters.Add("V_SUCURSAL_ID", FbDbType.Integer).Value = 0;

                // Parámetro de salida
                FbParameter paramARTICULO2 = new FbParameter("ARTICULO_ID", FbDbType.Numeric);
                paramARTICULO2.Direction = ParameterDirection.Output;
                command2.Parameters.Add(paramARTICULO2);
                FbParameter paramEXISTENCIA2 = new FbParameter("EXISTENCIAS", FbDbType.Numeric);
                paramEXISTENCIA2.Direction = ParameterDirection.Output;
                command2.Parameters.Add(paramEXISTENCIA2);
                // Ejecutar el procedimiento almacenadoienda
                command2.ExecuteNonQuery();
                decimal ExistenciaTienda = Convert.ToInt32(command2.Parameters[6].Value);
                return ExistenciaTienda;
                //MessageBox.Show("ALMACÉN: "+ Existencia.ToString() +"\n TIENDA: "+ ExistenciaTienda.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se perdió la conexión :( , contacta a 06 o intenta de nuevo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.ToString());
                return 0;
            }
            finally
            {
                con.Close();
            }
        }
        string Descripciones(string articulo_id)
        {
            FbConnection con = new FbConnection("User=" + GlobalSettings.Instance.User + ";" + "Password=" + GlobalSettings.Instance.Pw + ";" + "Database=" + GlobalSettings.Instance.Direccion + ";" + "DataSource=" + GlobalSettings.Instance.Ip + ";" + "Port=" + GlobalSettings.Instance.Puerto + ";" + "Dialect=3;" + "Charset=UTF8;");
            try
            {
                con.Open();
                string query = "SELECT * FROM ARTICULOS WHERE ARTICULO_ID = '" + articulo_id + "'";
                FbCommand command = new FbCommand(query, con);
                FbDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string valor = reader.GetString(1);
                    reader.Close();
                    return valor;
                }
                return "fail";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se perdió la conexión :( , contacta a 06 o intenta de nuevo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.ToString());
                return "fail";
            }
            finally
            {
                con.Close();
            }
        }
        string Clave(string articulo_id)
        {
            FbConnection con = new FbConnection("User=" + GlobalSettings.Instance.User + ";" + "Password=" + GlobalSettings.Instance.Pw + ";" + "Database=" + GlobalSettings.Instance.Direccion + ";" + "DataSource=" + GlobalSettings.Instance.Ip + ";" + "Port=" + GlobalSettings.Instance.Puerto + ";" + "Dialect=3;" + "Charset=UTF8;");
            try
            {
                con.Open();
                string query = "SELECT * FROM CLAVES_ARTICULOS WHERE ARTICULO_ID = '" + articulo_id + "' AND ROL_CLAVE_ART_ID = '17' ";
                FbCommand command = new FbCommand(query, con);
                FbDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string valor = reader.GetString(1);
                    reader.Close();
                    return valor;
                }
                return "fail";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se perdió la conexión :( , contacta a 06 o intenta de nuevo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.ToString());
                return "fail";
            }
            finally
            {
                con.Close();
            }
        }
        private void Actualizar_Click(object sender, EventArgs e)
        {
            using (var workbook = new XLWorkbook())
            {
                // Crear una hoja de Excel
                var worksheet = workbook.Worksheets.Add("Inventario");
                //size
                worksheet.Column(1).Width = 30;
                worksheet.Column(2).Width = 50;
                worksheet.Column(3).Width = 20;
                worksheet.Column(4).Width = 20;
                worksheet.Column(5).Width = 15;
                // Insertar algunos datos
                worksheet.Cell(1, 1).Value = "Código de barras";
                worksheet.Cell(1, 2).Value = "Descripción";
                worksheet.Cell(1, 3).Value = "Clave Principal";
                worksheet.Cell(1, 4).Value = "Contenido";
                worksheet.Cell(1, 5).Value = "Existencia";
                FbConnection con = new FbConnection("User=" + GlobalSettings.Instance.User + ";" + "Password=" + GlobalSettings.Instance.Pw + ";" + "Database=" + GlobalSettings.Instance.Direccion + ";" + "DataSource=" + GlobalSettings.Instance.Ip + ";" + "Port=" + GlobalSettings.Instance.Puerto + ";" + "Dialect=3;" + "Charset=UTF8;");
                try
                {
                    con.Open();
                    string query = "SELECT * FROM CLAVES_ARTICULOS ORDER BY CLAVE_ARTICULO_ID";
                    FbCommand command = new FbCommand(query, con);
                    FbDataReader reader = command.ExecuteReader();
                    int i = 2;
                    while (reader.Read())
                    {

                        string valor = reader.GetString(1);
                        string articulo_id = reader.GetString(2);
                        string contenido = reader.GetString(4);
                        string Descripcion = Descripciones(articulo_id);
                        string clave = Clave(articulo_id);
                        decimal existencia = Existencia(articulo_id);
                        worksheet.Cell(i, 1).Value = valor;
                        worksheet.Cell(i, 2).Value = Descripcion;
                        worksheet.Cell(i, 3).Value = clave;
                        worksheet.Cell(i, 4).Value = contenido;
                        worksheet.Cell(i, 5).Value = existencia;
                        ++i;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se perdió la conexión :( , contacta a 06 o intenta de nuevo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.ToString());
                    return;
                }
                finally
                {
                    con.Close();
                }
                // Guardar el archivo Excel
                GlobalSettings.Instance.Ruta = "C:\\Inventario\\Inv.xlsx";
                workbook.SaveAs(GlobalSettings.Instance.Ruta);
            }
            MessageBox.Show("Listo");
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {

            if (TxtCodigo.Text != string.Empty && Cb_Colector.Text != string.Empty && Cb_Zonas.Text != string.Empty)
            {
                // Cadena de conexión para archivos .xlsx
                string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + GlobalSettings.Instance.Ruta + ";Extended Properties=\"Excel 12.0 Xml;HDR=NO\";";
                string hoja = "Inventario$";
                string Txt = "C:\\Inventario\\" + Cb_Zonas.Text + ".txt";
                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    // Abre la conexión
                    conexion.Open();

                    // Consulta SQL
                    string consulta = "SELECT * FROM [" + hoja + "] WHERE F1 = '" + TxtCodigo.Text + "'";

                    bool encontrado = false;
                    using (OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, conexion))
                    {
                        DataTable datos = new DataTable();
                        try
                        {
                            adaptador.Fill(datos);

                        }
                        catch
                        {
                            MessageBox.Show("Codigo no Valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            TxtCodigo.Focus();
                            TxtCodigo.Select(0, TxtCodigo.Text.Length);
                            return;
                        }
                    // Tabla para almacenar los datos
                    // Muestra los resultados
                    SQLitePCL.Batteries.Init();
                    foreach (DataRow fila in datos.Rows)
                    {
                        GlobalSettings.Instance.posicion += 1;
                        DataSet.Rows.Add(GlobalSettings.Instance.posicion, fila.ItemArray[2], fila.ItemArray[1], fila.ItemArray[4], fila.ItemArray[3]);
                        DataSet.Rows[GlobalSettings.Instance.posicion - 1].Height = 40;
                        encontrado = true;
                        string textoAAgregar = fila.ItemArray[2].ToString() + ", " + fila.ItemArray[3];
                        using (SqliteConnection conect = new SqliteConnection("Data Source=C:\\Inventario\\" + Cb_Zonas.Text + ".db;"))
                        {
                            conect.Open();
                            string crearTablaQuery = "CREATE TABLE IF NOT EXISTS Articulos (ID INTEGER, Codigo TEXT, Descripcion TEXT, Existencia NUMERIC, Cantidad INTEGER, Zona TEXT, Colector TEXT)";
                            SqliteCommand crearTablaCommand = new SqliteCommand(crearTablaQuery, conect);
                            crearTablaCommand.ExecuteNonQuery();

                            string query = "INSERT INTO Articulos (ID, Codigo, Descripcion, Existencia, Cantidad, Zona, Colector) VALUES (@posicion, @valor1, @valor2 , @valor3, @valor4, @valor5, @valor6)";
                            SqliteCommand command = new SqliteCommand(query, conect);
                            command.Parameters.AddWithValue("@posicion", GlobalSettings.Instance.posicion);
                            command.Parameters.AddWithValue("@valor1", fila.ItemArray[2].ToString());
                            command.Parameters.AddWithValue("@valor2", fila.ItemArray[1]);
                            command.Parameters.AddWithValue("@valor3", fila.ItemArray[4]);
                            command.Parameters.AddWithValue("@valor4", fila.ItemArray[3]);
                            command.Parameters.AddWithValue("@valor5", Cb_Zonas.Text);
                            command.Parameters.AddWithValue("@valor6", Cb_Colector.Text);
                            command.ExecuteNonQuery();
                            conect.Close();
                        }


                    }
                    }

                    if (DataSet.Rows.Count > 0)
                    {
                        Cb_Zonas.Enabled = false;
                        Cb_Colector.Enabled = false;
                    }
                    //TxtCodigo.Focus();
                    if (encontrado == false)
                    {
                        MessageBox.Show("Articulo no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        TxtCodigo.Focus();
                        TxtCodigo.Select(0, TxtCodigo.Text.Length);
                        return;
                    }
                    DataSet.Focus();
                    DataSet.CurrentCell = DataSet.Rows[DataSet.Rows.Count - 1].Cells[4];
                    DataSet.Rows[DataSet.Rows.Count - 1].Cells[4].Selected = true;
                    conexion.Close();
                }

            }
            else
            {
                MessageBox.Show("Completa todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                TxtCodigo.Focus();
                TxtCodigo.Select(0, TxtCodigo.Text.Length);
                return;
            }
        }

        private void TxtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita que se produzca el sonido de Windows al presionar Enter
                Ingresar.Focus();
            }

        }

        private void DataSet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Delete)
            {

                if (DataSet.CurrentCell.RowIndex >= 0)
                {
                    using (SqliteConnection conect = new SqliteConnection("Data Source=C:\\Inventario\\" + Cb_Zonas.Text + ".db;"))
                    {
                        conect.Open();
                        string query = "DELETE FROM Articulos WHERE ID = '" + DataSet.Rows[DataSet.CurrentCell.RowIndex].Cells[0].Value + "';";
                        SqliteCommand command = new SqliteCommand(query, conect);
                        command.ExecuteNonQuery();
                        conect.Close();
                    }
                    DataSet.Rows.RemoveAt(DataSet.CurrentCell.RowIndex);
                    GlobalSettings.Instance.posicion--;
                }

                if (DataSet.Rows.Count == 0)
                {
                    Cb_Zonas.Enabled = true;
                    Cb_Colector.Enabled = true;
                }

                // Opcional: impedir que se ejecute la acción predeterminada de la tecla Suprimir
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (DataSet.CurrentCell == DataSet.Rows[DataSet.Rows.Count - 1].Cells[4])
                {
                    TxtCodigo.Text = string.Empty;
                    TxtCodigo.Focus();
                }

            }

        }

        private void DataSet_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (decimal.TryParse(DataSet.Rows[DataSet.CurrentCell.RowIndex].Cells[4].Value.ToString(), out decimal temp))
            {
            }
            else
            {
                MessageBox.Show("Solo Digitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DataSet.Rows[DataSet.CurrentCell.RowIndex].Cells[4].Value = 0;
                DataSet.BeginEdit(true);
                return;
            }
            using (SqliteConnection conect = new SqliteConnection("Data Source=C:\\Inventario\\" + Cb_Zonas.Text + ".db;"))
            {
                conect.Open();
                if (DataSet.CurrentCell.RowIndex == GlobalSettings.Instance.posicion - 1)
                {
                    string query = "UPDATE Articulos SET Cantidad = @valor1 WHERE ID = '" + DataSet.Rows[GlobalSettings.Instance.posicion - 1].Cells[0].Value + "';";
                    SqliteCommand command = new SqliteCommand(query, conect);
                    command.Parameters.AddWithValue("@valor1", DataSet.Rows[GlobalSettings.Instance.posicion - 1].Cells[4].Value);
                    command.ExecuteNonQuery();

                }
                else
                {
                    string query = "UPDATE Articulos SET Cantidad = @valor1 WHERE ID = '" + DataSet.Rows[DataSet.CurrentCell.RowIndex].Cells[0].Value + "';";
                    SqliteCommand command = new SqliteCommand(query, conect);
                    command.Parameters.AddWithValue("@valor1", DataSet.Rows[DataSet.CurrentCell.RowIndex].Cells[4].Value);
                    command.ExecuteNonQuery();
                }
                conect.Close();
            }


            TxtCodigo.Text = String.Empty;
            TxtCodigo.Focus();
        }
        private void Cb_Zonas_Leave(object sender, EventArgs e)
        {
            if (!nombresArray.Contains(Cb_Zonas.Text) && Cb_Zonas.Text != "")
            {
                MessageBox.Show("Esta zona no está registrada", "¡Espera!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cb_Zonas.Text = "";
                Cb_Zonas.Focus();
            }
        }

        private void Cb_Zonas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLower(e.KeyChar))
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
            }
        }

        private void Cargar_Click(object sender, EventArgs e)
        {
            if (DataSet.Rows.Count == 0)
            {
                using (SqliteConnection conect = new SqliteConnection("Data Source=C:\\Inventario\\" + Cb_Zonas.Text + ".db;"))
                {
                    conect.Open();
                    string query = "SELECT *  FROM Articulos;";
                    SqliteCommand command = new SqliteCommand(query, conect);
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        string colector = "";
                        while (reader.Read())
                        {
                            string id = reader["ID"].ToString();
                            string codigo = reader["CODIGO"].ToString();
                            string descripcion = reader["DESCRIPCION"].ToString();
                            decimal existencia = Decimal.Parse(reader["EXISTENCIA"].ToString());
                            string piezas = reader["CANTIDAD"].ToString();
                            colector = reader["COLECTOR"].ToString();

                            DataSet.Rows.Add(id, codigo, descripcion, existencia, piezas);
                            DataSet.Rows[GlobalSettings.Instance.posicion].Height = 40;
                            GlobalSettings.Instance.posicion += 1;
                        }
                        Cb_Colector.Text = colector;
                        Cb_Zonas.Select(0, 0);
                        TxtCodigo.Focus();
                        if (DataSet.Rows.Count > 0)
                        {
                            Cb_Zonas.Enabled = false;
                            Cb_Colector.Enabled = false;
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("No tienes que tener datos en la tabla", "¡Espera!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Cb_Zonas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Cb_Colector.Focus();
            }
        }

        private void Cb_Colector_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtCodigo.Focus();
            }
        }

        private void Cb_Colector_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLower(e.KeyChar))
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
            }
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            if (DataSet.Rows.Count > 0)
            {
                using (var workbook = new XLWorkbook())
                {
                    // Crear una hoja de Excel
                    var worksheet = workbook.Worksheets.Add("Inventario");
                    //size
                    worksheet.Column(1).Width = 20;
                    worksheet.Column(2).Width = 40;
                    worksheet.Column(3).Width = 10;
                    worksheet.Column(4).Width = 10;
                    worksheet.Column(4).Width = 30;

                    // Insertar algunos datos
                    worksheet.Cell(1, 1).Value = "Código";
                    worksheet.Cell(1, 2).Value = "Descripción";
                    worksheet.Cell(1, 3).Value = "Contado";
                    worksheet.Cell(1, 4).Value = "Zona";
                    worksheet.Cell(1, 5).Value = "Responsable";
                    for (int i = 2; i < DataSet.Rows.Count + 2; ++i)
                    {
                        worksheet.Cell(i, 1).Value = DataSet.Rows[i - 2].Cells[1].Value.ToString();
                        worksheet.Cell(i, 2).Value = DataSet.Rows[i - 2].Cells[2].Value.ToString();
                        worksheet.Cell(i, 3).Value = DataSet.Rows[i - 2].Cells[4].Value.ToString();
                        worksheet.Cell(i, 4).Value = Cb_Zonas.Text;
                        worksheet.Cell(i, 5).Value = Cb_Colector.Text;
                    }
                    GlobalSettings.Instance.posicion = 0;
                    workbook.SaveAs("C:\\Inventario\\" + Cb_Zonas.Text + ".xlsx");
                }
                if (File.Exists("C:\\Inventario\\InventarioGeneral.xlsx"))
                {
                    using (var workbook = new XLWorkbook("C:\\Inventario\\InventarioGeneral.xlsx"))
                    {
                        // Crear una hoja de Excel
                        var worksheet = workbook.Worksheets.FirstOrDefault(ws => ws.Name == "Inventario General")
                    ?? workbook.Worksheets.Add("Inventario General");
                        int ultimaFila = worksheet.LastRowUsed().RowNumber();
                        for (int i = 0; i < DataSet.Rows.Count; ++i)
                        {
                            worksheet.Cell(i + ultimaFila + 1, 1).Value = DataSet.Rows[i].Cells[1].Value.ToString();
                            worksheet.Cell(i + ultimaFila + 1, 2).Value = DataSet.Rows[i].Cells[2].Value.ToString();
                            worksheet.Cell(i + ultimaFila + 1, 3).Value = DataSet.Rows[i].Cells[4].Value.ToString();
                            worksheet.Cell(i + ultimaFila + 1, 4).Value = Cb_Zonas.Text;
                            worksheet.Cell(i + ultimaFila + 1, 5).Value = Cb_Colector.Text;
                        }
                        workbook.Save();
                    }
                }
                else
                {
                    using (var workbook = new XLWorkbook())
                    {
                        // Crear una hoja de Excel
                        var worksheet = workbook.Worksheets.Add("Inventario General");
                        //size
                        worksheet.Column(1).Width = 20;
                        worksheet.Column(2).Width = 40;
                        worksheet.Column(3).Width = 10;
                        worksheet.Column(4).Width = 10;
                        worksheet.Column(5).Width = 30;
                        // Insertar algunos datos
                        worksheet.Cell(1, 1).Value = "Código";
                        worksheet.Cell(1, 2).Value = "Descripción";
                        worksheet.Cell(1, 3).Value = "Contado";
                        worksheet.Cell(1, 4).Value = "Zona";
                        worksheet.Cell(1, 5).Value = "Responsable";
                        for (int i = 2; i < DataSet.Rows.Count + 2; ++i)
                        {
                            worksheet.Cell(i, 1).Value = DataSet.Rows[i - 2].Cells[1].Value.ToString();
                            worksheet.Cell(i, 2).Value = DataSet.Rows[i - 2].Cells[2].Value.ToString();
                            worksheet.Cell(i, 3).Value = DataSet.Rows[i - 2].Cells[4].Value.ToString();
                            worksheet.Cell(i, 4).Value = Cb_Zonas.Text;
                            worksheet.Cell(i, 5).Value = Cb_Colector.Text;
                        }
                        workbook.SaveAs("C:\\Inventario\\InventarioGeneral.xlsx");
                    }
                }
                MessageBox.Show("Guardado con éxito");
                DataSet.Rows.Clear();
                Cb_Zonas.Enabled = true;
                Cb_Colector.Enabled = true;
                Cb_Zonas.Text = "";
                TxtCodigo.Text = string.Empty;
                Cb_Zonas.Focus();
            }
        }

        private void Send_Click(object sender, EventArgs e)
        {
            try
            {
                // Configura los detalles del remitente y destinatario
                MailMessage mensaje = new MailMessage();
                mensaje.From = new MailAddress("inventario@papeleriacornejo.com"); // Tu dirección de correo
                string Vendedor;
                mensaje.To.Add("sistemas@papeleriacornejo.com"); // Destinatario
                mensaje.Subject = "Inventario " + DateTime.Now.ToShortDateString;
                string Excel = "C:\\Inventario\\InventarioGeneral.xlsx";
                Attachment adjunto = new Attachment(Excel);
                mensaje.Attachments.Add(adjunto);
                // Desactiva la validación del certificado para pruebas (no recomendado para producción)
                System.Net.ServicePointManager.ServerCertificateValidationCallback =
                    (sender, certificate, chain, sslPolicyErrors) => true;

                // Configuración del cliente SMTP (usando Gmail como ejemplo)
                SmtpClient clienteSmtp = new SmtpClient("smtp.papeleriacornejo.com", 587); // Servidor SMTP y puerto
                clienteSmtp.Credentials = new NetworkCredential("inventario@papeleriacornejo.com", "Cornejo2024@"); // Credenciales
                clienteSmtp.EnableSsl = true; // SSL para una conexión segura
                                              // Envía el correo
                clienteSmtp.Send(mensaje);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.", ex.Message);
            }
        }

        private void DataSet_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            DataSet.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            try
            {
                string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + GlobalSettings.Instance.Ruta + ";Extended Properties=\"Excel 12.0 Xml;HDR=NO\";";
                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    conexion.Open(); // Precalienta la conexión
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el archivo de Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}