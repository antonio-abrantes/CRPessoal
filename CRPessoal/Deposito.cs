using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRPessoal
{
    public partial class Deposito : Form
    {
        decimal despesa;
        public Deposito(decimal soma)
        {
            InitializeComponent();
            despesa = soma;
            //MessageBox.Show(soma.ToString());
        }

        private void Deposito_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baseDadosDataSet.Saldo' table. You can move, or remove it, as needed.
            this.saldoTableAdapter.Fill(this.baseDadosDataSet.Saldo);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txbDeposito.Text == "")
            {
                MessageBox.Show("Campro obrigatorio vazio...");
            }
            else
            {
                if(DialogResult.Yes == MessageBox.Show("Tem certeza que efetuar o deposito?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)){
                    decimal deposito = Convert.ToDecimal(txbDeposito.Text);
                    decimal saldo = Convert.ToDecimal(saldoTextBox.Text);
                    decimal soma = deposito + saldo;
                    btnDeposito.Enabled = false;

                    saldoTextBox.Text = soma.ToString("c");
                    this.Validate();
                    this.saldoBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.baseDadosDataSet);
                    txbDeposito.Text = "";
                    MessageBox.Show("Deposito realizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }

        }
    }
}
