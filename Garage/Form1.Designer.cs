namespace Garage
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
            cmbTipoVeicolo = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtPosto = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btnInserisci = new Button();
            label7 = new Label();
            txtMarca = new TextBox();
            label8 = new Label();
            txtAnno = new TextBox();
            label9 = new Label();
            txtCilindrata = new TextBox();
            txtPorte = new TextBox();
            txtAlimentazione = new TextBox();
            txtTempi = new TextBox();
            txtCapacita = new TextBox();
            btnEstrai = new Button();
            txtEstrai = new TextBox();
            label10 = new Label();
            SuspendLayout();
            // 
            // cmbTipoVeicolo
            // 
            cmbTipoVeicolo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoVeicolo.FormattingEnabled = true;
            cmbTipoVeicolo.Items.AddRange(new object[] { "Auto", "Moto", "Furgone" });
            cmbTipoVeicolo.Location = new Point(25, 29);
            cmbTipoVeicolo.Name = "cmbTipoVeicolo";
            cmbTipoVeicolo.Size = new Size(121, 23);
            cmbTipoVeicolo.TabIndex = 0;
            cmbTipoVeicolo.SelectedIndexChanged += cmbTipoVeicolo_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(184, 29);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "Porte:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 73);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 3;
            label2.Text = "Alimentazione";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(184, 114);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 5;
            label3.Text = "Tempi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(184, 169);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 7;
            label4.Text = "capacita";
            // 
            // txtPosto
            // 
            txtPosto.Location = new Point(24, 90);
            txtPosto.Name = "txtPosto";
            txtPosto.Size = new Size(100, 23);
            txtPosto.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 9);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 10;
            label5.Text = "Tipo di veicolo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 65);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 11;
            label6.Text = "Inserisci posto";
            // 
            // btnInserisci
            // 
            btnInserisci.Location = new Point(184, 228);
            btnInserisci.Name = "btnInserisci";
            btnInserisci.Size = new Size(165, 80);
            btnInserisci.TabIndex = 12;
            btnInserisci.Text = "Inserisci";
            btnInserisci.UseVisualStyleBackColor = true;
            btnInserisci.Click += btnInserisci_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 136);
            label7.Name = "label7";
            label7.Size = new Size(85, 15);
            label7.TabIndex = 14;
            label7.Text = "Inserisci marca";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(24, 161);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(100, 23);
            txtMarca.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 207);
            label8.Name = "label8";
            label8.Size = new Size(79, 15);
            label8.TabIndex = 16;
            label8.Text = "Inserisci anno";
            // 
            // txtAnno
            // 
            txtAnno.Location = new Point(24, 232);
            txtAnno.Name = "txtAnno";
            txtAnno.Size = new Size(100, 23);
            txtAnno.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(28, 266);
            label9.Name = "label9";
            label9.Size = new Size(101, 15);
            label9.TabIndex = 18;
            label9.Text = "Inserisci cilindrata";
            // 
            // txtCilindrata
            // 
            txtCilindrata.Location = new Point(24, 291);
            txtCilindrata.Name = "txtCilindrata";
            txtCilindrata.Size = new Size(100, 23);
            txtCilindrata.TabIndex = 17;
            // 
            // txtPorte
            // 
            txtPorte.Location = new Point(273, 29);
            txtPorte.Name = "txtPorte";
            txtPorte.Size = new Size(100, 23);
            txtPorte.TabIndex = 19;
            // 
            // txtAlimentazione
            // 
            txtAlimentazione.Location = new Point(273, 73);
            txtAlimentazione.Name = "txtAlimentazione";
            txtAlimentazione.Size = new Size(100, 23);
            txtAlimentazione.TabIndex = 20;
            // 
            // txtTempi
            // 
            txtTempi.Location = new Point(273, 114);
            txtTempi.Name = "txtTempi";
            txtTempi.Size = new Size(100, 23);
            txtTempi.TabIndex = 21;
            // 
            // txtCapacita
            // 
            txtCapacita.Location = new Point(273, 161);
            txtCapacita.Name = "txtCapacita";
            txtCapacita.Size = new Size(100, 23);
            txtCapacita.TabIndex = 22;
            // 
            // btnEstrai
            // 
            btnEstrai.Location = new Point(527, 123);
            btnEstrai.Name = "btnEstrai";
            btnEstrai.Size = new Size(165, 80);
            btnEstrai.TabIndex = 23;
            btnEstrai.Text = "estrai";
            btnEstrai.UseVisualStyleBackColor = true;
            btnEstrai.Click += btnEstrai_Click;
            // 
            // txtEstrai
            // 
            txtEstrai.Location = new Point(592, 90);
            txtEstrai.Name = "txtEstrai";
            txtEstrai.Size = new Size(100, 23);
            txtEstrai.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(503, 98);
            label10.Name = "label10";
            label10.Size = new Size(85, 15);
            label10.TabIndex = 24;
            label10.Text = "estrai un posto";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtEstrai);
            Controls.Add(label10);
            Controls.Add(btnEstrai);
            Controls.Add(txtCapacita);
            Controls.Add(txtTempi);
            Controls.Add(txtAlimentazione);
            Controls.Add(txtPorte);
            Controls.Add(label9);
            Controls.Add(txtCilindrata);
            Controls.Add(label8);
            Controls.Add(txtAnno);
            Controls.Add(label7);
            Controls.Add(txtMarca);
            Controls.Add(btnInserisci);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtPosto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbTipoVeicolo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbTipoVeicolo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtPosto;
        private Label label5;
        private Label label6;
        private Button btnInserisci;
        private Label label7;
        private TextBox txtMarca;
        private Label label8;
        private TextBox txtAnno;
        private Label label9;
        private TextBox txtCilindrata;
        private TextBox txtPorte;
        private TextBox txtAlimentazione;
        private TextBox txtTempi;
        private TextBox txtCapacita;
        private Button btnEstrai;
        private TextBox txtEstrai;
        private Label label10;
    }
}
