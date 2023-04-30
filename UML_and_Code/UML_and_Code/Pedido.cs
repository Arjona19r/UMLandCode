using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace UML_and_Code
{
    internal class Pedido
    {
        public int numeropedidos;
        public int numeropedido;
        public DateTime fechapedido;
        public ArrayList productos = new ArrayList();
        public int cantidad;
        public float precio;
        public string sistemapago;

        public Producto_Item producto;
        public Usuario usuario;

        public void calcular_cantidad()
        {

        }

        public void calcular_precio()
        {

        }
    }
}
