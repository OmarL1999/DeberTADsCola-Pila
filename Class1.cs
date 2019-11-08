using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADs.clases
{
    class Class1
    {
        private int dato;
        private Class1 siguiente;
       
        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public Class1 Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }


    }
}
