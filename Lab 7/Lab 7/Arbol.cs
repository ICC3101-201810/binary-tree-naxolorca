using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    public class Arbol<T>
    {
        Nodo<T> fin;
        public void RetornarArbol()
        {
            fin = null;
        }
        public void Agregar(int numero)
        {
            Nodo<T> nuevo = new Nodo<T>();
            nuevo.izquierda = null;
            nuevo.derecha = null;
            nuevo.numero = numero;
            if(fin == null) { fin = nuevo; }
            else
            {



            }
        


        }
    }
}
