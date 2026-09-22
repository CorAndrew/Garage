namespace Garage
{
    public partial class Form1 : Form
    {
        private Garage garage = new Garage();
        public Form1()
        {
            InitializeComponent();


        }

        private void cmbTipoVeicolo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = cmbTipoVeicolo.SelectedItem.ToString();
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPosto.Text, out int posto))
            {
                MessageBox.Show("Inserisci un numero valido per il posto");
                return;
            }
            string marca = txtMarca.Text;
            if (string.IsNullOrWhiteSpace(marca))
            {
                MessageBox.Show("Inserisci la marca del veicolo");
                return;
            }
            if (!int.TryParse(txtAnno.Text, out int anno))
            {
                MessageBox.Show("Inserisci un anno valido!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(txtCilindrata.Text, out int cyl))
            {
                MessageBox.Show("Inserisci una cilindrata valida!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Veicolo nuovoVeicolo = null;
            string tipo = cmbTipoVeicolo.SelectedItem.ToString();
            string alimentazione = txtAlimentazione.Text;

            if (tipo == "Auto")
            {
                if (!int.TryParse(txtPorte.Text, out int porte))
                {
                    MessageBox.Show("Inserisci un numero di porte valido!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(alimentazione))
                {
                    MessageBox.Show("Inserisci l'alimentazione del veicolo");
                    return;
                }
                nuovoVeicolo = new Auto(posto, marca, anno, cyl, porte, alimentazione);
            }
            else if (tipo == "Moto")
            {
                if (!int.TryParse(txtTempi.Text, out int tempi))
                {
                    MessageBox.Show("Inserisci un valore valido per i tempi del motore");
                    return;
                }
                nuovoVeicolo = new Moto(posto, marca, anno, cyl, tempi);
            }
            else if (tipo == "Furgone")
            {
                if (!int.TryParse(txtCapacita.Text, out int capacita))
                {
                    MessageBox.Show("Inserisci un numero valido per la capacità");
                    return;
                }
                nuovoVeicolo = new Furgone(posto, marca, anno, cyl, capacita);
            }
            int esito = garage.ImmettiVeicolo(posto, nuovoVeicolo);

            if (esito == 0)
            {
                MessageBox.Show($"Veicolo inserito con successo nel posto {posto}!", "Operazione Completata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMarca.Clear();
                AggiornaListaGarage();
            }
            else if (esito == -1)
            {
                MessageBox.Show("Il numero del posto deve essere compreso tra 0 e 14!", "Errore Posto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (esito == -2)
            {
                MessageBox.Show($"Il posto {posto} è già occupato!", "Errore Inserimento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AggiornaListaGarage()
        {
            string[] situazione = garage.OttieniSituazioneGarage();
        }

        private void btnEstrai_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtEstrai.Text, out int posto))
            {
                MessageBox.Show("Inserisci un numero di posto valido da estrarre");
                return;
            }

            Veicolo estratto = garage.EstraiVeicolo(posto);

            if (estratto != null)
            {
                MessageBox.Show($"Veicolo estratto dal posto {posto}:\n\n{estratto.stampa()}");
                AggiornaListaGarage();
            }
            else
            {
                MessageBox.Show($"il numero non e valido");
            }
        }
    }
}}