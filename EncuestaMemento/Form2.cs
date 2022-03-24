using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncuestaMemento
{
    public partial class Form2 : Form
    {

      
        public Form2(List<int> respuestas)
        {
            InitializeComponent();
           
            progressBar1.Value =respuestas[0];
            progressBar2.Value = respuestas[1]; 
            progressBar3.Value = respuestas[2];
            progressBar4.Value = respuestas[3];
            progressBar5.Value = respuestas[4];

            lbl1.Text = Convert.ToString(respuestas[0]);
            lbl2.Text = Convert.ToString(respuestas[1]);
            lbl3.Text = Convert.ToString(respuestas[2]);
            lbl4.Text = Convert.ToString(respuestas[3]);
            lbl5.Text = Convert.ToString(respuestas[4]);



        }   

        
        private void progressBar1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
