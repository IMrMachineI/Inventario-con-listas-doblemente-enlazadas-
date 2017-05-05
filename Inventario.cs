using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeInventarios
{
    class Inventario
    {
        Producto producto;
        private Producto[] _Inventario;
        private int _contador;
        Producto auxiliar;
        //int dato;
        //Producto siguiente;
        Producto cabeza;
        Producto cola;

        public Inventario()
        {
            cabeza = null;
            cola = null;
        }

        public bool vacia()
        {
            if (cabeza == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void agregarProducto(Producto producto)
        {
            Producto tmp = producto;

            if (vacia())
            {
                cabeza = tmp;
                cola = tmp;
            }
            else
            {
                cola.siguiente = tmp;
                tmp.anterior = cola;
                cola = tmp;
            }
        }

        public void agregarInicio(Producto producto)
        {
            Producto tmp = producto;

            tmp.siguiente = cabeza;
            cabeza.anterior = tmp;
            cabeza = tmp;
        }

        public void eliminarProducto(int posicion)
        {
            Producto anterior = cabeza;
            Producto actual = cabeza;

            int cont = 0;

            if (posicion == 1)
            {
                cabeza = cabeza.siguiente;
                cabeza.anterior = null;
            }
            else if (posicion > cont)
            {
                while (posicion != cont && actual.siguiente != null)
                {
                    anterior = actual;
                    actual = actual.siguiente;
                    cont++;
                }
                anterior.siguiente = actual.siguiente;
            }
            //Producto tmp = inicio;
            //bool existe = true;

            //if (tmp != null)
            //{
            //    if (tmp.codigo == posicion)
            //    {
            //        inicio = tmp.siguiente;
            //        tmp = inicio;
            //    }
            //    else
            //    {
            //        while (tmp.siguiente != null)
            //        {
            //            tmp = tmp.siguiente;
            //        }
            //    }
            //}

            //for (int i = 0; i < _contador; i++)
            //{
            //    if (_Inventario[i].codigo == posicion)
            //    {
            //        while (i < _contador)
            //        {
            //            _Inventario[i] = _Inventario[i + 1];
            //            i++;
            //        }
            //        _Inventario[_contador] = null;
            //        _contador--;
            //    }
            //    else
            //    {
            //        existe = false;
            //    }
            //}
            //return existe;
        }

        public void eliminarPrimerProducto()
        {
            cabeza = cabeza.siguiente;
            cabeza.anterior = null;
        } 

        public void eliminarUltimoProducto()
        {
                cola = cola.anterior;
                cola.siguiente = null;
        }

        public Producto buscarProducto(int posicion)
        {
            Producto tmp = cabeza;

            while (tmp != null && tmp.codigo != posicion)
            {
                tmp = tmp.siguiente;
            }

            return tmp;
        }

        public void insertarProducto(Producto producto, int posicion)
        {
            int cont = 1;
            Producto tmp = producto;

            if(posicion == 1)
            {
                tmp.siguiente = cabeza;
                cabeza.anterior = tmp;
                cabeza = tmp;
            }
            else
            {
                while(cont != posicion && cabeza.siguiente != null)
                {
                    cont++;
                    cabeza = cabeza.siguiente;
                }
                tmp.siguiente = cabeza;
                cabeza.anterior = tmp;
                tmp.anterior = cabeza.anterior;
                cabeza = tmp;
            }

            //int cont = 2;
            //Producto tmp = inicio;

            //tmp = inicio;

            //if (posicion == 1)
            //{
            //    producto.siguiente = tmp;
            //    inicio = producto;
            //}
            //else
            //{
            //    while (tmp.siguiente != null && cont != posicion)
            //    {
            //        cont++;
            //        tmp = tmp.siguiente;
            //    }
            //    producto.siguiente = tmp.siguiente;
            //    tmp.siguiente = producto;
            //}
            //Producto producto2;
            //posicion = posicion - 1;
            //_contador++;

            //for (int i = posicion; i < _contador; i++)
            //{
            //    //_Inventario[i] = _Inventario[i - 1];
            //    auxiliar = _Inventario[i];
            //    _Inventario[i] = producto;
            //    producto = auxiliar;
            //}
            ////_contador++;
            ////_Inventario[posicion] = producto;
        }

        public string reporteInverso()
        {
            string mostrar = "";
            Producto tmp = cola;

            while (tmp != null)
            {
                mostrar += tmp.ToString();
                tmp = tmp.anterior;
            }
            return mostrar;
        }

        public override string ToString()
        {
            string mostrar = "";
            Producto tmp = cabeza;

            while (tmp != null)
            {
                mostrar += tmp.ToString();
                tmp = tmp.siguiente;
            }
            return mostrar;
        }
    }
}
