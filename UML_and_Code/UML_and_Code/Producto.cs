using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace UML_and_Code
{
    internal class Producto
    {
        public int numeroproductos;
        public int id;
        public bool visible;
        public string nombre;
        public string marca;
        public ArrayList imagenes = new ArrayList();
        public string descripcion;
        public int preciobase;
        public bool descuento;
        public string categoria;
        public string subcategoria;

        public Producto_Item producto;
        public Reseña reseña;
    }
}
