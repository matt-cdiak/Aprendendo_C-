using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace T_Systems.ProjectMatBD.WindowsFormsUI
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection;
        private SqlDataAdapter sqlDataAdapter;
        private DataTable dataTable;
        private DataGridViewRow dataGridValores;
        private Boolean verificarSelect;
        private String insertQuery;
        private String NomeCompleto;
        private String CPF;
        private String RG;

        public Form1()
        {
            InitializeComponent();
            InitializeSqlConnection();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
        private void InitializeSqlConnection()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "CTS1A519426\\SQLEXPRESS";
            builder.InitialCatalog = "Clientes";
            builder.IntegratedSecurity = true;

            string connectionString = builder.ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
        }

        private void LoadData()
        {
            try
            {
                sqlConnection.Open();
                string query = "SELECT * FROM dbo.Dados_Clientes";
                sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        private void ExecuteQuery()
        {
            try
            {
                InitializeSqlConnection();
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(insertQuery, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@nomeCompleto", NomeCompleto);
                sqlCommand.Parameters.AddWithValue("@CPF", CPF);
                sqlCommand.Parameters.AddWithValue("@RG", RG);

                if (insertQuery.TrimStart().StartsWith("SELECT", StringComparison.OrdinalIgnoreCase))
                {
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    verificarSelect = reader.HasRows;
                }
                else
                {
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
            LoadData();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeSqlConnection();
            LoadData();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            this.Click += Form1_Click;
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridValores = this.dataGridView1.Rows[e.RowIndex];
            }
        }
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    dataGridValores = this.dataGridView1.Rows[e.RowIndex];

                    NomeCompleto = dataGridValores.Cells[0].Value.ToString();
                    CPF = dataGridValores.Cells[1].Value.ToString();
                    RG = dataGridValores.Cells[2].Value.ToString();
                }
            }
        }
        private void ButtonExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridValores != null)
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esta linha?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    NomeCompleto = dataGridValores.Cells[0].Value.ToString();
                    CPF = dataGridValores.Cells[1].Value.ToString();
                    RG = dataGridValores.Cells[2].Value.ToString();

                    insertQuery = "Delete FROM Dados_Clientes Where NomeCompleto = @nomeCompleto and CPF = @CPF and RG = @RG;";
                    ExecuteQuery();
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ButtonSalvar_Click(object sender, EventArgs e)
        {
            var cliente = RetornarFornecedor(new Cliente());

            NomeCompleto = cliente.NomeCompleto;
            CPF = cliente.CPF;
            RG = cliente.RG;

            if (NomeCompleto != null && CPF != null && RG != null)
            {
                insertQuery = "SELECT * From dbo.Dados_Clientes Where CPF = @CPF Or RG = @RG;";
                ExecuteQuery();
                if (verificarSelect == false)
                {
                    insertQuery = "INSERT INTO dbo.Dados_Clientes (NomeCompleto, CPF, RG) VALUES (@nomeCompleto, @CPF, @RG)";
                    ExecuteQuery();
                }
                else
                {
                    MessageBox.Show("O CPF ou RG já foi cadastrado.");
                }
            }
        }
        private Cliente RetornarFornecedor(Cliente cliente)
        {
            if (textBoxNomeCompleto.Text != string.Empty)
            {
                cliente.NomeCompleto = textBoxNomeCompleto.Text;
            }
            else
            {
                MessageBox.Show("Você não digitou o seu nome completo.");
            }

            if (textBoxCPF.Text != string.Empty)
            {
                cliente.CPF = textBoxCPF.Text;
            }
            else
            {
                MessageBox.Show("Você não digitou o CPF.");
            }

            if (textBoxRG.Text != string.Empty)
            {
                cliente.RG = textBoxRG.Text;
            }
            else
            {
                MessageBox.Show("Você não digitou o nome do contato.");
            }
            return cliente;
        }

        private void TextBoxCPF_TextChanged(object sender, EventArgs e)
        {
            string texto = textBoxCPF.Text;
            string textoFormatado = "";

            foreach (char caractere in texto)
            {
                int tamanhoTexto = textoFormatado.Length;

                if (char.IsDigit(caractere) && tamanhoTexto <= 13)
                {
                    if (tamanhoTexto == 3)
                    {
                        textoFormatado += ".";
                        textoFormatado += caractere;
                    }
                    else if (caractere == '.' && texto[3] == '.')
                    {
                        textoFormatado += caractere;
                    }
                    else if (tamanhoTexto == 7)
                    {
                        textoFormatado += ".";
                        textoFormatado += caractere;
                    }
                    else if (caractere == '.' && texto[7] == '.')
                    {
                        textoFormatado += caractere;
                    }
                    else if (tamanhoTexto == 11)
                    {
                        textoFormatado += "-";
                        textoFormatado += caractere;
                    }
                    else if (caractere == '.' && texto[11] == '-')
                    {
                        textoFormatado += caractere;
                    }
                    else
                    {
                        textoFormatado += caractere;
                    }
                }
            }
            textBoxCPF.Text = textoFormatado;
            textBoxCPF.SelectionStart = textBoxCPF.Text.Length;
        }

        private void TextBoxRG_TextChanged(object sender, EventArgs e)
        {
            string texto = textBoxRG.Text;
            string textoFormatado = "";

            foreach (char caractere in texto)
            {
                int tamanhoTexto = textoFormatado.Length;

                if (char.IsDigit(caractere) && tamanhoTexto <= 11)
                {
                    if (tamanhoTexto == 2)
                    {
                        textoFormatado += ".";
                        textoFormatado += caractere;
                    }
                    else if (caractere == '.' && texto[2] == '.')
                    {
                        textoFormatado += caractere;
                    }
                    else if (tamanhoTexto == 6)
                    {
                        textoFormatado += ".";
                        textoFormatado += caractere;
                    }
                    else if (caractere == '.' && texto[6] == '.')
                    {
                        textoFormatado += caractere;
                    }
                    else if (tamanhoTexto == 10)
                    {
                        textoFormatado += "-";
                        textoFormatado += caractere;
                    }
                    else if (caractere == '.' && texto[10] == '-')
                    {
                        textoFormatado += caractere;
                    }
                    else
                    {
                        textoFormatado += caractere;
                    }
                }
            }
            textBoxRG.Text = textoFormatado;
            textBoxRG.SelectionStart = textBoxRG.Text.Length;
        }
    }
}