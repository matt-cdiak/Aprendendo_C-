namespace T_Systems.ProjectMatBD.WindowsFormsUI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.textBoxNomeCompleto = new System.Windows.Forms.TextBox();
            this.labelNomeCompleto = new System.Windows.Forms.Label();
            this.labelCPF = new System.Windows.Forms.Label();
            this.textBoxCPF = new System.Windows.Forms.TextBox();
            this.labelRG = new System.Windows.Forms.Label();
            this.textBoxRG = new System.Windows.Forms.TextBox();
            this.clientesDataSet = new T_Systems.ProjectMatBD.WindowsFormsUI.ClientesDataSet();
            this.dadosClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dados_ClientesTableAdapter = new T_Systems.ProjectMatBD.WindowsFormsUI.ClientesDataSetTableAdapters.Dados_ClientesTableAdapter();
            this.buttonExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosClientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(68, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(350, 167);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(68, 179);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(88, 27);
            this.buttonSalvar.TabIndex = 1;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.ButtonSalvar_Click);
            // 
            // textBoxNomeCompleto
            // 
            this.textBoxNomeCompleto.Location = new System.Drawing.Point(68, 25);
            this.textBoxNomeCompleto.Name = "textBoxNomeCompleto";
            this.textBoxNomeCompleto.Size = new System.Drawing.Size(350, 20);
            this.textBoxNomeCompleto.TabIndex = 2;
            // 
            // labelNomeCompleto
            // 
            this.labelNomeCompleto.AutoSize = true;
            this.labelNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeCompleto.Location = new System.Drawing.Point(65, 9);
            this.labelNomeCompleto.Name = "labelNomeCompleto";
            this.labelNomeCompleto.Size = new System.Drawing.Size(95, 13);
            this.labelNomeCompleto.TabIndex = 3;
            this.labelNomeCompleto.Text = "Nome Completo";
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPF.Location = new System.Drawing.Point(65, 59);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(30, 13);
            this.labelCPF.TabIndex = 5;
            this.labelCPF.Text = "CPF";
            // 
            // textBoxCPF
            // 
            this.textBoxCPF.Location = new System.Drawing.Point(68, 75);
            this.textBoxCPF.Name = "textBoxCPF";
            this.textBoxCPF.Size = new System.Drawing.Size(350, 20);
            this.textBoxCPF.TabIndex = 4;
            this.textBoxCPF.TextChanged += new System.EventHandler(this.TextBoxCPF_TextChanged);
            // 
            // labelRG
            // 
            this.labelRG.AutoSize = true;
            this.labelRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRG.Location = new System.Drawing.Point(65, 116);
            this.labelRG.Name = "labelRG";
            this.labelRG.Size = new System.Drawing.Size(25, 13);
            this.labelRG.TabIndex = 7;
            this.labelRG.Text = "RG";
            // 
            // textBoxRG
            // 
            this.textBoxRG.Location = new System.Drawing.Point(68, 132);
            this.textBoxRG.Name = "textBoxRG";
            this.textBoxRG.Size = new System.Drawing.Size(350, 20);
            this.textBoxRG.TabIndex = 6;
            this.textBoxRG.TextChanged += new System.EventHandler(this.TextBoxRG_TextChanged);
            // 
            // clientesDataSet
            // 
            this.clientesDataSet.DataSetName = "ClientesDataSet";
            this.clientesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dadosClientesBindingSource
            // 
            this.dadosClientesBindingSource.DataMember = "Dados_Clientes";
            this.dadosClientesBindingSource.DataSource = this.clientesDataSet;
            // 
            // dados_ClientesTableAdapter
            // 
            this.dados_ClientesTableAdapter.ClearBeforeFill = true;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonExcluir.Location = new System.Drawing.Point(330, 180);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(88, 25);
            this.buttonExcluir.TabIndex = 8;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.ButtonExcluir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 422);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.labelRG);
            this.Controls.Add(this.textBoxRG);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.textBoxCPF);
            this.Controls.Add(this.labelNomeCompleto);
            this.Controls.Add(this.textBoxNomeCompleto);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Tela de Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosClientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.TextBox textBoxNomeCompleto;
        private System.Windows.Forms.Label labelNomeCompleto;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.TextBox textBoxCPF;
        private System.Windows.Forms.Label labelRG;
        private System.Windows.Forms.TextBox textBoxRG;
        private ClientesDataSet clientesDataSet;
        private System.Windows.Forms.BindingSource dadosClientesBindingSource;
        private ClientesDataSetTableAdapters.Dados_ClientesTableAdapter dados_ClientesTableAdapter;
        private System.Windows.Forms.Button buttonExcluir;
    }
}

