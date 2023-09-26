using System;
using System.IO;
using System.Windows.Forms;

namespace ApplePrices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBox2.Text = string.Empty; // INICIAR O COMBOBOX SEM QUALQUER SELEÇÃO

            if (comboBox1.SelectedIndex == 0) // APLICAR MODELO COM BASE NA SELEÇÃO
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("iphone15");
                comboBox2.Items.Add("iphone15pro");
                comboBox2.Items.Add("iphone15promax");

            }
            else if (comboBox1.SelectedIndex == 1) //ESCALAR  ADICIONANDO NOVOS ITENS
            {
                comboBox2.Items.Clear();
                label4.Text = string.Empty;
                label5.Text = string.Empty;
                pictureBox2.Image = null;
            }
            else if (comboBox1.SelectedIndex == 2) //ESCALAR  ADICIONANDO NOVOS ITENS
            {
                comboBox2.Items.Clear();
                label4.Text = string.Empty;
                label5.Text = string.Empty;
                pictureBox2.Image = null;
            }
            else if (comboBox1.SelectedIndex == 3) //ESCALAR  ADICIONANDO NOVOS ITENS
            {
                comboBox2.Items.Clear();
                label4.Text = string.Empty;
                label5.Text = string.Empty;
                pictureBox2.Image = null;
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            string[] Prices =
              {
                    "A partir de R$ 7.299",
                    "A partir de R$ 9.299",
                    "A partir de R$ 10.999"
                };

            string[] devices = Directory.GetFiles(@"C:\Users\daila\OneDrive\Área de Trabalho\C#\img"); // A STRING SERÁ O CAMINHO DO ARQUIVO POR EX: C:/USER/PROGRAM/PHOTO.JPG


            foreach (string device in devices) // OBTER A ÚLTIMA PARTE DO NOME DO CAMINHO ARMAZENADO
            {
                string[] deviceName = device.Split('\\'); // SEPARA INDICES SEMPRE QUE HOUVER MA BARRA '/'

                string[] deviceName2 = deviceName[7].Split('.'); // SEPARA ÍNDIES SEMPRE QUE HOUVER PONTO '.'




                if (comboBox2.Text == deviceName2[0]) // DEFININDO A IMAGEM A SER MOSTRADA COM BASE NA SELEÇÃO COMBOBOX2
                {
                    pictureBox2.ImageLocation = "C:\\Users\\daila\\OneDrive\\Área de Trabalho\\C#\\img\\" + comboBox2.Text + ".png";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    label4.Text = "Preço: ";

                }
                else if (comboBox2.SelectedIndex == 0) // APLICAR PREÇOS COM BASE NA SELEÇÃO
                {
                    label5.Text = Prices[0];
                }
                else if (comboBox2.SelectedIndex == 1) // APLICAR PREÇOS COM BASE NA SELEÇÃO
                {
                    label5.Text = Prices[1];
                }
                else if (comboBox2.SelectedIndex == 2) // APLICAR PREÇOS COM BASE NA SELEÇÃO
                {
                    label5.Text = Prices[2];
                }

            }

        }
    }
}
