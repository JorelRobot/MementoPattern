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

    public partial class Form0 : Form,Caretaker
    {//cuidador 
        private Form1 form1;
        private Originador originador;
        private IMemento memento;


        public Form0()
        {
            InitializeComponent();
        }

        public void Undo()
        {
            originador.Restore(memento);
        }

        private void button1_Click(object sender, EventArgs e)
            //boton iniciar encuesta
        {

            //var Forminiciar = new Form1();
            //originador = Forminiciar;

            if (memento == null && form1==null)
            {
                form1 = new Form1(this);
                form1.Show();
                originador = form1;
            }
            else if (memento != null)
            {
                form1.Visible = true;
                this.Undo();
            }



    }

        private void button2_Click(object sender, EventArgs e)
        {
            if (memento == null)
            {
                MessageBox.Show("Memento Nulo");
            }
            else
            {
                MessageBox.Show("Memento");
            }
        }

        public void setMemento(IMemento memento)
        {
            this.memento = memento;
        }
    }
}
