using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace UML_and_Code
{
    internal class Usuario
    {
        private string DNI;
        private string Nombre;
        private string Apellido;
        public string Correoelectronico;
        private string contraseña;
        private int telefono;
        private string direccion;
        public ArrayList listadeseos = new ArrayList();
        private ArrayList carritodecompra = new ArrayList();

        public Pedido pedido;
        public Reseña reseña;
    }
}
