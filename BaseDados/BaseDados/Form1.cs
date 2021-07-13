using System;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlServerCe; //SQL Server Compact Edition (CE)
using System.Data.SQLite; //SQLite
using MySql.Data.MySqlClient; //MySQL
using System.Data;

namespace BaseDados {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e) {
            #region SQL Server CE
            /*string baseDados = Application.StartupPath + @"\db\dbSQLServer.sdf";
            string strConnection = @"DataSource = " + baseDados + "; Password = '123456789'";

            SqlCeEngine db = new SqlCeEngine(strConnection);

            if (!File.Exists(baseDados)) {
                db.CreateDatabase();
            }

            db.Dispose();

            SqlCeConnection conexao = new SqlCeConnection(strConnection);
            try {
                conexao.Open();
                lblResult.Text = "Conectado ao SQL Server CE!";
            } catch (Exception ex) {
                MessageBox.Show("Erro ao conectar: " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                conexao.Close();
            }*/
            #endregion

            #region SQLite
            /*string baseDados = Application.StartupPath + @"\db\DBSQLite.sdf";
            string strConnection = @"Data Source = " + baseDados + "; Version = 3";

            if (!File.Exists(baseDados)) {
                SQLiteConnection.CreateFile(baseDados);
            }

            SQLiteConnection conexao = new SQLiteConnection(strConnection);

            try {
                conexao.Open();
                lblResult.Text = "Conectado ao SQLite!";
            } catch (Exception ex) {
                MessageBox.Show("Erro ao conectar: " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                conexao.Close();
            }
            */
            #endregion

            #region MySQL
            //string strConnection = "server=localhost;uid=root;port=3306;pwd=123456789"; //Sem DB criado
            string strConnection = "server=localhost;port=3306;uid=root;database=teste_db;pwd=123456789"; //Com DB criado

            MySqlConnection conexao = new MySqlConnection();
            conexao.ConnectionString = strConnection;

            try {
                conexao.Open();
                lblResult.Text = "Conectado ao MySQL!";

                MySqlCommand comando = new MySqlCommand();

                comando.CommandText = "CREATE DATABASE IF NOT EXISTS teste_db";
                comando.Connection = conexao;

                comando.ExecuteNonQuery();
                lblResult.Text = "Base de dados criada com sucesso.";
                comando.Dispose();

            } catch (Exception ex) {
                MessageBox.Show("Erro ao conectar: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                conexao.Close();
            }
            #endregion
        }

        private void btnCriarTabela_Click(object sender, EventArgs e) {
            #region SQL Server CE
            /*string baseDados = Application.StartupPath + @"\db\dbSQLServer.sdf";
            string strConnection = @"DataSource = " + baseDados + "; Password = '123456789'";

            SqlCeConnection conexao = new SqlCeConnection(strConnection);

            try {
                conexao.Open();

                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;
                comando.CommandText = "CREATE TABLE pessoas(id INT NOT NULL PRIMARY KEY, nome NVARCHAR(50), email NVARCHAR(50))";
                comando.ExecuteNonQuery();
                comando.Dispose();

                lblResult.Text = "Tabela Criada - SQL Server CE";
            } catch (Exception ex) {
                MessageBox.Show("Erro ao criar tabela: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                conexao.Close();
            }*/

            #endregion

            #region SQLite
            /*string baseDados = Application.StartupPath + @"\db\DBSQLite.sdf";
            string strConnection = @"Data Source = " + baseDados + "; Version = 3";


            SQLiteConnection conexao = new SQLiteConnection(strConnection);

            try {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;
                comando.CommandText = "CREATE TABLE pessoas(id INT NOT NULL PRIMARY KEY, nome NVARCHAR(50), email NVARCHAR(50))";
                comando.ExecuteNonQuery();
                comando.Dispose();

                lblResult.Text = "Tabela Criada - SQLite";
            } catch (Exception ex) {
                MessageBox.Show("Erro ao criar tabela: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                conexao.Close();
            }*/
            #endregion

            #region MySQL
            string strConnection = "server=localhost;port=3306;uid=root;database=teste_db;pwd=123456789"; //Com DB criado

            MySqlConnection conexao = new MySqlConnection();
            conexao.ConnectionString = strConnection;

            try {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "CREATE TABLE pessoas(id INT NOT NULL, nome VARCHAR(50), email VARCHAR(50), PRIMARY KEY(id))";
                comando.ExecuteNonQuery();
                comando.Dispose();

                lblResult.Text = "Tabela Criada - MySQL";

            } catch (Exception ex) {
                MessageBox.Show("Erro ao criar tabela: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                conexao.Close();
            }
            #endregion
        }

        private void btnInserir_Click(object sender, EventArgs e) {
            #region SQL Server CE
            /*string baseDados = Application.StartupPath + @"\db\dbSQLServer.sdf";
            string strConnection = @"DataSource = " + baseDados + "; Password = '123456789'";

            SqlCeConnection conexao = new SqlCeConnection(strConnection);

            try {
                conexao.Open();

                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;

                int id = new Random(DateTime.Now.Millisecond).Next(0, 1000);
                string nome = txtNome.Text;
                string email = txtEmail.Text;

                comando.CommandText = "INSERT INTO pessoas VALUES(" + id + ", '" + nome + "', '" + email + "')";
                
                comando.ExecuteNonQuery();
                comando.Dispose();

                lblResult.Text = "Registro inserido - SQL Server CE";
            } catch (Exception ex) {
                MessageBox.Show("Erro ao inserir na tabela: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                conexao.Close();
            }*/
            #endregion

            #region SQLite
            /*string baseDados = Application.StartupPath + @"\db\DBSQLite.sdf";
            string strConnection = @"Data Source = " + baseDados + "; Version = 3";


            SQLiteConnection conexao = new SQLiteConnection(strConnection);

            try {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                int id = new Random(DateTime.Now.Millisecond).Next(0, 1000);
                string nome = txtNome.Text;
                string email = txtEmail.Text;

                comando.CommandText = "INSERT INTO pessoas VALUES(" + id + ", '" + nome + "', '" + email + "')";
                comando.ExecuteNonQuery();
                comando.Dispose();

                lblResult.Text = "Registro Inserido - SQLite";
            } catch (Exception ex) {
                MessageBox.Show("Erro inserir na tabela: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                conexao.Close();
            }*/
            #endregion

            #region MySQL
            string strConnection = "server=localhost;port=3306;uid=root;database=teste_db;pwd=123456789"; //Com DB criado

            MySqlConnection conexao = new MySqlConnection();
            conexao.ConnectionString = strConnection;

            try {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;

                int id = new Random(DateTime.Now.Millisecond).Next(0, 1000);
                string nome = txtNome.Text;
                string email = txtEmail.Text;

                comando.CommandText = "INSERT INTO pessoas VALUES(" + id + ", '" + nome + "', '" + email + "')";
                comando.ExecuteNonQuery();
                comando.Dispose();

                lblResult.Text = "Registro Inserido - MySQL";

            } catch (Exception ex) {
                MessageBox.Show("Erro inserir registro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                conexao.Close();
            }
            #endregion
        }

        private void btnProcurar_Click(object sender, EventArgs e) {
            lblResult.Text = String.Empty;
            dgv.Rows.Clear();

            #region SQL Server CE
            /*string baseDados = Application.StartupPath + @"\db\dbSQLServer.sdf";
            string strConnection = @"DataSource = " + baseDados + "; Password = '123456789'";

            SqlCeConnection conexao = new SqlCeConnection(strConnection);

            try {
                string query = "SELECT * FROM pessoas";

                if (txtNome.Text != "") {
                    query = "SELECT * FROM pessoas WHERE nome LIKE '" + txtNome.Text + "'";
                }

                DataTable dados = new DataTable();

                SqlCeDataAdapter adaptador = new SqlCeDataAdapter(query, strConnection);

                conexao.Open();

                adaptador.Fill(dados);

                foreach (DataRow linha in dados.Rows) {
                    dgv.Rows.Add(linha.ItemArray);
                }

                lblResult.Text = "Procura realizada - SQL Server CE";
            } catch (Exception ex) {
                dgv.Rows.Clear();
                MessageBox.Show("Erro ao buscar dados: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                conexao.Close();
            }*/
            #endregion

            #region SQLite
            /*string baseDados = Application.StartupPath + @"\db\DBSQLite.sdf";
            string strConnection = @"Data Source = " + baseDados + "; Version = 3";


            SQLiteConnection conexao = new SQLiteConnection(strConnection);

            try {
                string query = "SELECT * FROM pessoas";

                if (txtNome.Text != "") {
                    query = "SELECT * FROM pessoas WHERE nome LIKE '" + txtNome.Text + "'";
                }

                DataTable dados = new DataTable();

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConnection);

                conexao.Open();

                adaptador.Fill(dados);

                foreach (DataRow linha in dados.Rows) {
                    dgv.Rows.Add(linha.ItemArray);
                }

                lblResult.Text = "Procura realizada - SQLite";
            } catch (Exception ex) {
                dgv.Rows.Clear();
                MessageBox.Show("Erro ao buscar dados: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                conexao.Close();
            }*/
            #endregion

            #region MySQL
            string strConnection = "server=localhost;port=3306;uid=root;database=teste_db;pwd=123456789"; //Com DB criado

            MySqlConnection conexao = new MySqlConnection();
            conexao.ConnectionString = strConnection;

            try {
                string query = "SELECT * FROM pessoas";

                if (txtNome.Text != "") {
                    query = "SELECT * FROM pessoas WHERE nome LIKE '" + txtNome.Text + "'";
                }

                DataTable dados = new DataTable();

                MySqlDataAdapter adaptador = new MySqlDataAdapter(query, strConnection);

                conexao.Open();

                adaptador.Fill(dados);

                foreach (DataRow linha in dados.Rows) {
                    dgv.Rows.Add(linha.ItemArray);
                }

                lblResult.Text = "Procura realizada - MySQL";
            } catch (Exception ex) {
                dgv.Rows.Clear();
                MessageBox.Show("Erro ao buscar dados: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                conexao.Close();
            }
            #endregion
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            #region SQL Server CE
            /*string baseDados = Application.StartupPath + @"\db\dbSQLServer.sdf";
            string strConnection = @"DataSource = " + baseDados + "; Password = '123456789'";

            SqlCeConnection conexao = new SqlCeConnection(strConnection);

            try {
                conexao.Open();

                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;

                int id = (int)dgv.SelectedRows[0].Cells["id"].Value;
                string nome = txtNome.Text;
                string email = txtEmail.Text;

                comando.CommandText = "UPDATE pessoas SET nome='" + nome + "', email='" + email + "' WHERE id='" + id + "'";

                comando.ExecuteNonQuery();
                comando.Dispose();

                lblResult.Text = "Registro editado - SQL Server CE";
            } catch (Exception ex) {
                dgv.Rows.Clear();
                MessageBox.Show("Erro ao editar registro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                conexao.Close();
            }*/
            #endregion

            #region SQLite
            /*string baseDados = Application.StartupPath + @"\db\DBSQLite.sdf";
            string strConnection = @"Data Source = " + baseDados + "; Version = 3";


            SQLiteConnection conexao = new SQLiteConnection(strConnection);

            try {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                int id = (int)dgv.SelectedRows[0].Cells["id"].Value;
                string nome = txtNome.Text;
                string email = txtEmail.Text;

                comando.CommandText = "UPDATE pessoas SET nome='" + nome + "', email='" + email + "' WHERE id='" + id + "'";

                comando.ExecuteNonQuery();
                comando.Dispose();

                lblResult.Text = "Registro editado - SQLite";
            } catch (Exception ex) {
                dgv.Rows.Clear();
                MessageBox.Show("Erro ao editar registro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                conexao.Close();
            }*/
            #endregion

            #region MySQL
            string strConnection = "server=localhost;port=3306;uid=root;database=teste_db;pwd=123456789"; //Com DB criado

            MySqlConnection conexao = new MySqlConnection();
            conexao.ConnectionString = strConnection;

            try {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;

                int id = (int)dgv.SelectedRows[0].Cells["id"].Value;
                string nome = txtNome.Text;
                string email = txtEmail.Text;

                comando.CommandText = "UPDATE pessoas SET nome='" + nome + "', email='" + email + "' WHERE id='" + id + "'";

                comando.ExecuteNonQuery();
                comando.Dispose();

                lblResult.Text = "Registro editado - MySQL";
            } catch (Exception ex) {
                dgv.Rows.Clear();
                MessageBox.Show("Erro ao editar registro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                conexao.Close();
            }
            #endregion
        }

        private void btnExcluir_Click(object sender, EventArgs e) {
            #region SQL Server CE
            /*string baseDados = Application.StartupPath + @"\db\dbSQLServer.sdf";
            string strConnection = @"DataSource = " + baseDados + "; Password = '123456789'";

            SqlCeConnection conexao = new SqlCeConnection(strConnection);

            try {
                conexao.Open();

                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;

                int id = (int)dgv.SelectedRows[0].Cells["id"].Value;

                comando.CommandText = "DELETE FROM pessoas WHERE id='" + id + "'";

                comando.ExecuteNonQuery();
                comando.Dispose();

                lblResult.Text = "Registro excluído - SQL Server CE";
            } catch (Exception ex) {
                dgv.Rows.Clear();
                MessageBox.Show("Erro ao excluir registro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                conexao.Close();
            }*/
            #endregion

            #region SQLite
            /*string baseDados = Application.StartupPath + @"\db\DBSQLite.sdf";
            string strConnection = @"Data Source = " + baseDados + "; Version = 3";


            SQLiteConnection conexao = new SQLiteConnection(strConnection);

            try {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                int id = (int)dgv.SelectedRows[0].Cells["id"].Value;

                comando.CommandText = "DELETE FROM pessoas WHERE id='" + id + "'";

                comando.ExecuteNonQuery();
                comando.Dispose();

                lblResult.Text = "Registro excluído - SQLite";
            } catch (Exception ex) {
                dgv.Rows.Clear();
                MessageBox.Show("Erro ao excluir registro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                conexao.Close();
            }*/
            #endregion

            #region MySQL
            string strConnection = "server=localhost;port=3306;uid=root;database=teste_db;pwd=123456789"; //Com DB criado

            MySqlConnection conexao = new MySqlConnection();
            conexao.ConnectionString = strConnection;

            try {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;

                int id = (int)dgv.SelectedRows[0].Cells["id"].Value;

                comando.CommandText = "DELETE FROM pessoas WHERE id='" + id + "'";

                comando.ExecuteNonQuery();
                comando.Dispose();
                lblResult.Text = "Registro excluído - MySQL";
            } catch (Exception ex) {
                dgv.Rows.Clear();
                MessageBox.Show("Erro ao excluir registro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                conexao.Close();
            }
            #endregion
        }
    }
}
