using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRPessoal
{
    public partial class Form1 : Form
    {
        public SqlConnection conexao;
        public Form1()
        {
            InitializeComponent();
            conexao = this.movimentoTableAdapter.Connection;
            //rdDespesa.Checked = true;                
        }
      
        private void movimentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.movimentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baseDadosDataSet);
            AtualizaCampos();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            // TODO: This line of code loads data into the 'baseDadosDataSet.Saldo' table. You can move, or remove it, as needed.
            //this.saldoTableAdapter.Fill(this.baseDadosDataSet.Saldo);
            // TODO: This line of code loads data into the 'baseDadosDataSet.Movimento' table. You can move, or remove it, as needed.
            this.movimentoTableAdapter.Fill(this.baseDadosDataSet.Movimento);

           
            DataTable saldo = filtro("Select * from Saldo");
            decimal sal = Convert.ToDecimal(saldo.Rows[0][1]);

            DataTable sumatorio = filtro("SELECT SUM(Valor) as sumatorio from Movimento where Tipo like '%Desp%'");

            decimal soma = Convert.ToDecimal(sumatorio.Rows[0]["sumatorio"]);
            decimal operacao = sal - soma;

           txbSaldo.Text = operacao.ToString();
            AtualizaSaldo();

            //movimentoBindingNavigator.
        }

        public DataTable filtro(string comando)
        {
            conexao.Open();
            SqlCommand sComando = new SqlCommand(comando, conexao);
            DataTable dados = new DataTable();
            dados.Load(sComando.ExecuteReader());
            conexao.Close();

            return dados;
        }

        public void AtualizaCampos()
        {
                DataTable saldo = filtro("Select * from Saldo");
                decimal sal = Convert.ToDecimal(saldo.Rows[0][1]);
                decimal soma;

                if (movimentoDataGridView.RowCount > 1)
                {
                    DataTable sumatorio = filtro("SELECT SUM(Valor) as sumatorio from Movimento where Tipo like '%Desp%'");
                    soma = Convert.ToDecimal(sumatorio.Rows[0]["sumatorio"]);
                }
                else
                {
                    soma = 0;
                }

                decimal operacao = sal - soma;

                // MessageBox.Show(.ToString());

                txbSaldo.Text = operacao.ToString();
                AtualizaSaldo();
                  
        }

        public void AtualizaSaldo()
        {
            decimal saldo = Convert.ToDecimal(txbSaldo.Text);
            if (saldo <= 0)
            {
                txbSaldo.ForeColor = Color.Red;
            }
            else
            {
                txbSaldo.ForeColor = Color.DarkGreen;
            }
        }


        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            rdDespesa.Checked = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tipoTextBox.Text = rdDespesa.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            decimal soma;
            if (movimentoDataGridView.RowCount > 1)
            {
                DataTable sumatorio = filtro("SELECT SUM(Valor) as sumatorio from Movimento where Tipo like '%Desp%'");
                soma = Convert.ToDecimal(sumatorio.Rows[0]["sumatorio"]);
            }
            else
            {
                soma = 0;
            }
            Deposito deposito = new Deposito(soma);
            deposito.ShowDialog();
            AtualizaCampos();
            AtualizaSaldo();
            deposito.Dispose();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {            
            this.Validate();
            this.movimentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baseDadosDataSet);
            AtualizaCampos();
            AtualizaSaldo();
        }
    }
}
