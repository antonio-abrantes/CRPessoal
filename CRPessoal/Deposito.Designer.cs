namespace CRPessoal
{
    partial class Deposito
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
            System.Windows.Forms.Label saldoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deposito));
            this.baseDadosDataSet = new CRPessoal.BaseDadosDataSet();
            this.saldoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saldoTableAdapter = new CRPessoal.BaseDadosDataSetTableAdapters.SaldoTableAdapter();
            this.tableAdapterManager = new CRPessoal.BaseDadosDataSetTableAdapters.TableAdapterManager();
            this.saldoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbDeposito = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeposito = new System.Windows.Forms.Button();
            saldoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.baseDadosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saldoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saldoLabel
            // 
            saldoLabel.AutoSize = true;
            saldoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            saldoLabel.Location = new System.Drawing.Point(78, 83);
            saldoLabel.Name = "saldoLabel";
            saldoLabel.Size = new System.Drawing.Size(133, 31);
            saldoLabel.TabIndex = 4;
            saldoLabel.Text = "Saldo: R$";
            // 
            // baseDadosDataSet
            // 
            this.baseDadosDataSet.DataSetName = "BaseDadosDataSet";
            this.baseDadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saldoBindingSource
            // 
            this.saldoBindingSource.DataMember = "Saldo";
            this.saldoBindingSource.DataSource = this.baseDadosDataSet;
            // 
            // saldoTableAdapter
            // 
            this.saldoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MovimentoTableAdapter = null;
            this.tableAdapterManager.SaldoTableAdapter = this.saldoTableAdapter;
            this.tableAdapterManager.UpdateOrder = CRPessoal.BaseDadosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // saldoTextBox
            // 
            this.saldoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.saldoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saldoBindingSource, "Saldo", true));
            this.saldoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saldoTextBox.ForeColor = System.Drawing.Color.Green;
            this.saldoTextBox.Location = new System.Drawing.Point(212, 80);
            this.saldoTextBox.Name = "saldoTextBox";
            this.saldoTextBox.ReadOnly = true;
            this.saldoTextBox.Size = new System.Drawing.Size(127, 38);
            this.saldoTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valor: R$";
            // 
            // txbDeposito
            // 
            this.txbDeposito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txbDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDeposito.ForeColor = System.Drawing.Color.Green;
            this.txbDeposito.Location = new System.Drawing.Point(132, 23);
            this.txbDeposito.Name = "txbDeposito";
            this.txbDeposito.Size = new System.Drawing.Size(127, 38);
            this.txbDeposito.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(saldoLabel);
            this.groupBox1.Controls.Add(this.saldoTextBox);
            this.groupBox1.Controls.Add(this.btnDeposito);
            this.groupBox1.Controls.Add(this.txbDeposito);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 138);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Incluir Deposito";
            // 
            // btnDeposito
            // 
            this.btnDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposito.Image = global::CRPessoal.Properties.Resources.Botoes_Site_5745_Knob_Valid_Green;
            this.btnDeposito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeposito.Location = new System.Drawing.Point(265, 21);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(136, 40);
            this.btnDeposito.TabIndex = 2;
            this.btnDeposito.Text = "Confirmar";
            this.btnDeposito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.button1_Click);
            // 
            // Deposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 159);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Deposito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fazer deposito";
            this.Load += new System.EventHandler(this.Deposito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baseDadosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saldoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BaseDadosDataSet baseDadosDataSet;
        private System.Windows.Forms.BindingSource saldoBindingSource;
        private BaseDadosDataSetTableAdapters.SaldoTableAdapter saldoTableAdapter;
        private BaseDadosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox saldoTextBox;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.TextBox txbDeposito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}