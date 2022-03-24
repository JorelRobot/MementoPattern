using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncuestaMemento
{
    public class RespuestasMemento : IMemento //cada que agregamos a la interfaz nos pide que implementemos los metodos 
    {
        private List<int> respuestas;

        public RespuestasMemento(List<int>respuestas)
        {//constructor 
            this.respuestas = respuestas;
        }



        public List<int> getState()  //metodo de IMemento 
        {
            return respuestas;
        }
    }
}
