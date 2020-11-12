using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcolo_frazionario
{
    public partial class frmMain : Form
    {
        int primo_num = 0;
        int primo_den = 0;
        int secondo_num = 0;
        int secondo_den = 0;
        int risultato_num = 0;
        int risultato_den = 0;
        string segno = "";
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
          
            lstSegno.Items.Add("+");
            lstSegno.Items.Add("-");
            lstSegno.Items.Add("x");
            lstSegno.Items.Add("/");
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            


            //Controlli nel caso la TextBox fosse vuota
            if (txtPrimoNum.Text.ToString() != "")         
                primo_num = Convert.ToInt16(txtPrimoNum.Text);
            else
                MessageBox.Show("Primo Numeratore non valido", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            if (txtPrimoDen.Text.ToString() != "")             
                primo_den = Convert.ToInt16(txtPrimoDen.Text);
            else 
                MessageBox.Show("Primo Denominatore non valido", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            if (txtSecNum.Text.ToString() != "")
                secondo_num = Convert.ToInt16(txtSecNum.Text);
            else
                MessageBox.Show("Secondo Numeratore non valido", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            if (txtSecNum.Text.ToString() != "")                           
                secondo_den = Convert.ToInt16(txtSecDen.Text);
            else
                MessageBox.Show("Secondo Denominatore non valido", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            if (lstSegno.SelectedIndex == 0)
                segno = "+";
            if (lstSegno.SelectedIndex == 1)
                segno = "-";
            if (lstSegno.SelectedIndex == 2)
                segno = "*";
            if (lstSegno.SelectedIndex == 3)
                segno = "/";


            switch (segno)
            {
                case "+":
                    risultato_den = primo_den * secondo_den;
                    risultato_num = primo_num * secondo_den + primo_den * secondo_num; break;
                case "-":
                    risultato_den = primo_den * secondo_den;
                    risultato_num = primo_num * secondo_den - primo_den * secondo_num; break;
                case "*":
                    risultato_den = primo_den * secondo_den;
                    risultato_num = primo_num * secondo_den * primo_den * secondo_num; break;
                case "/":
                    risultato_den = primo_den * secondo_den;
                    risultato_num = primo_num * secondo_den / primo_den * secondo_num; break;
                
            }
            

            txtRisNum.Text = risultato_num.ToString();
            txtRisDen.Text = risultato_den.ToString();
             



        }

        private void btnSemplifica_Click(object sender, EventArgs e)
        {
            if (risultato_num.ToString() == "") 
                MessageBox.Show("Risultato non valido", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            if (risultato_den.ToString() == "")
                MessageBox.Show("Risultato non valido", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            while (risultato_den%2==0&&risultato_num%2==0)
            {
                risultato_den /= 2;
                risultato_num /= 2;
            }

            while (risultato_den % 3 == 0 && risultato_num % 3 == 0)
            {
                risultato_den /= 3;
                risultato_num /= 3;
            }

            while (risultato_den % 7 == 0 && risultato_num % 7 == 0)
            {
                risultato_den /= 7;
                risultato_num /= 7;
            }

            while (risultato_den % 5 == 0 && risultato_num % 5 == 0)
            {
                risultato_den /= 5;
                risultato_num /= 5;
            }

            while (risultato_den % 11 == 0 && risultato_num % 11 == 0)
            {
                risultato_den /= 11;
                risultato_num /= 11;
            }

            while (risultato_den % 13 == 0 && risultato_num % 13 == 0)
            {
                risultato_den /= 13;
                risultato_num /= 13;
            }
            txtRisNum.Text = risultato_num.ToString();
            txtRisDen.Text = risultato_den.ToString();

        }
    }
}
