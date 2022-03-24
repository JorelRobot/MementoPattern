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
{//originador
    public partial class Form1 : Form, Originador
    {

        private IMemento mementoCuidador;
        private Form0 mainForm;
      
        public List<int> respuestas;



        public Form1(Form0 form0)
        {//contructor
            InitializeComponent();

            this.mainForm = form0;
            //this.mementoCuidador = memento;

            if (respuestas == null)
            {
                respuestas = new List<int>(new int [5]);
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {//boton atras 
         this.Visible = false;



        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            var FormTerminar = new Form2(respuestas);
            FormTerminar.Show();
        }

        public IMemento Save()
        {
            MessageBox.Show("guardando respuesta");
            respuestas[0] = Convert.ToInt32(comboBox1.Text);
            respuestas[1] = Convert.ToInt32(comboBox2.Text);
            respuestas[2] = Convert.ToInt32(comboBox3.Text);
            respuestas[3] = Convert.ToInt32(comboBox4.Text);
            respuestas[4] = Convert.ToInt32(comboBox5.Text);

            IMemento snapshot = new RespuestasMemento(respuestas);
            return snapshot;

        }

        public void Restore(IMemento memento)
        {
            MessageBox.Show("restaurando respuesta");
            respuestas = memento.getState();

            comboBox1.Text = respuestas[0].ToString();
            comboBox2.Text = respuestas[1].ToString();
            comboBox3.Text = respuestas[2].ToString();
            comboBox4.Text = respuestas[3].ToString();
            comboBox5.Text = respuestas[4].ToString();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mementoCuidador = this.Save();

            mainForm.setMemento(mementoCuidador);
            string template = "";

            foreach (int r in mementoCuidador.getState())
            {
                template += $"{r}, ";
                
            }

            MessageBox.Show(template);
        }


       


    }
}
