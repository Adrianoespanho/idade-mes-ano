using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace idade_mes_ano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxDIA.Text = DateTime.Now.Day.ToString();
            textBoxMES.Text = Convert.ToString(DateTime.Now.Month);
            textBoxANO.Text = Convert.ToString((DateTime.Now.Year);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxDIA.Text == " ")
            {
                MessageBox.Show("informe o dia de nascimento", "ops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxDIA.Focus();
            }
            else if (Convert.ToInt32(textBoxDia.text) < 1 || Convert.ToInt32(textBoxDIA.Text) > 31)
            {
                MessageBox.Show("o dia de nascimento deve ser maior que 1 e igual ou inferior a  31","ops",MessageBoxButtons.OK)
                    TextBoxDia.Focus();

            }  
        }

          
    }
}
