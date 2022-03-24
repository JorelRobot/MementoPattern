using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncuestaMemento
{
    public interface Originador
    {
        IMemento Save();

        void Restore(IMemento memento);
        


    }
}
