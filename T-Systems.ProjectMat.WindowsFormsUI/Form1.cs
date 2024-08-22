using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace T_Systems.ProjectMat.WindowsFormsUI
{
    public partial class FFormularioInicial : Form
    {
        private List<Fornecedor> ListaFornecedores;
        public FFormularioInicial()
        {
            InitializeComponent();
            ListaFornecedores = new List<Fornecedor>();
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            var getFornecedor = RetornarFornecedor(new Fornecedor());

            if (getFornecedor.Endereco != null && getFornecedor.NomeDoContato != null && getFornecedor.NomeDoFornecedor != null && getFornecedor.NumeroTelefone != null)
            {
                if (ListaFornecedores.Count > 0)
                {
                    foreach (var fornecedor in ListaFornecedores)
                    {
                        if (getFornecedor.Endereco == fornecedor.Endereco && getFornecedor.NomeDoContato == fornecedor.NomeDoContato &&
                            getFornecedor.NomeDoFornecedor == fornecedor.NomeDoFornecedor && getFornecedor.NumeroTelefone == fornecedor.NumeroTelefone)
                        {
                            MessageBox.Show("Já existe o cadastro deste fornecedor.");
                            return;
                        }
                    }
                    ListaFornecedores.Add(getFornecedor);
                    dgvFornecedor.DataSource = null;
                    dgvFornecedor.DataSource = ListaFornecedores;
                }
                else
                {
                    ListaFornecedores.Add(getFornecedor);
                    dgvFornecedor.DataSource = null;
                    dgvFornecedor.DataSource = ListaFornecedores;
                }
            }
        }
        private Fornecedor RetornarFornecedor(Fornecedor fornecedor)
        {
            if (txtNomeFornecedor.Text != string.Empty)
            {
                fornecedor.NomeDoFornecedor = txtNomeFornecedor.Text;
            }
            else
            {
                MessageBox.Show("Você não digitou o nome do fornecedor.");
            }

            if (txtEndereco.Text != string.Empty)
            {
                fornecedor.Endereco = txtEndereco.Text;
            }
            else
            {
                MessageBox.Show("Você não digitou o endereço.");
            }

            if (txtNomeContato.Text != string.Empty)
            {
                fornecedor.NomeDoContato = txtNomeContato.Text;
            }
            else
            {
                MessageBox.Show("Você não digitou o nome do contato.");
            }

            if (txtTelefone.Text != string.Empty)
            {
                fornecedor.NumeroTelefone = txtTelefone.Text;
            }
            else
            {
                MessageBox.Show("Você não digitou o numero de telefone.");
            }

            return fornecedor;
        }
        private void TxtTelefone_TextChanged(object sender, EventArgs e)
        {
            string texto = txtTelefone.Text;
            string textoFormatado = "";

            foreach (char c in texto)
            {
                if (char.IsDigit(c))
                {
                    int tamanhoTexto = textoFormatado.Length;

                    if (textoFormatado == "")
                    {
                        textoFormatado = "(";
                        textoFormatado += c;
                    }
                    else if (textoFormatado == textoFormatado.Substring(0, 2))
                    {
                        textoFormatado += c;
                        textoFormatado += ") ";
                    }
                    else if (tamanhoTexto == 9)
                    {
                        textoFormatado += c;
                        textoFormatado += "-";
                    }
                    else
                    {
                        textoFormatado += c;
                    }
                }
            }
            txtTelefone.Text = textoFormatado;
            txtTelefone.SelectionStart = txtTelefone.Text.Length;
        }
    }
}
