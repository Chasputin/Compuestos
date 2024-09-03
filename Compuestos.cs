//Daniel Cardona Carvajal
//Juan Diego Ramirez Moreno 
//Christian Camilo Pereira 
//Laura Valentina Herrera

using System;

namespace ConsoleApp1.Compuestos
{
    public class Clientes
    {
        private int id = 0;
        private string cedula = "";
        private string nombre = "";
        private int contacto = 0;
        private string direccion = "";

        public int Id { get => this.id; set => this.id = value; }
        public string Cedula { get => this.cedula; set => this.cedula = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public int Contacto { get => this.contacto; set => this.contacto = value; }
        public string Direccion { get => this.direccion; set => this.direccion = value; }
    }

    public class Tipos_Productos
    {
        private int id = 0;
        private int cod_tipo = 0;
        private string nom_tipo = "";

        public int Id { get => this.id; set => this.id = value; }
        public int Cod_tipo { get => this.cod_tipo; set => this.cod_tipo = value; }
        public string Nom_tipo { get => this.nom_tipo; set => this.nom_tipo = value; }
    }

    public class Estados
    {
        private int id = 0;
        private string nombre = "";
        private int grupo = 0;

        public int Id { get => this.id; set => this.id = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public int Grupo { get => this.grupo; set => this.grupo = value; }
         
    }
     public class Ordenes
    {
        private int id = 0;
        private Clientes? cliente = null;
        private Compuestos? compuesto = null;
        private Estados? estado = null;
        private DateTime? fecha_pedido = null;
        private int total_pagar = 0;
        private int cant_compuesto = 0;

        public int Id { get => this.id; set => this.id = value; }
        public Clientes? Cliente { get => this.cliente; set => this.cliente = value; }
        public Compuestos? Compuesto { get => this.compuesto; set => this.compuesto = value; }
        public Estados? Estado { get => this.estado; set => this.estado = value; }
        
        public DateTime? Fecha_pedido { get => this.fecha_pedido; set => this.fecha_pedido = value; }
        public int Total_pagar { get => this.total_pagar; set => this.total_pagar = value; }
        public int Cant_compuesto { get => this.cant_compuesto; set => this.cant_compuesto = value; }

        
    }
         public class Compuestos
    {
        private int id = 0;
        private int cod_compuesto = 0;
        private string nombre_composicion = "";
        private Productos? producto = null;

        public int Id { get => this.id; set => this.id = value; }
        public int Cod_compuesto { get => this.cod_compuesto; set => this.cod_compuesto = value; }
        public string Nombre_composicion { get => this.nombre_composicion; set => this.nombre_composicion = value; }
        public Productos? Producto { get => this.producto; set => this.producto = value; }
        
    }

    public class Productos
    {
        private int id = 0;
        private Tipos_Productos? tipo_producto = null;
        private int cod_producto = 0;
        private string nombre_producto = "";
        private Estados? estado = null;
        private int cantidad_producto = 0;

        public int Id { get => this.id; set => this.id = value; }
        public Tipos_Productos? Tipo_producto { get => this.tipo_producto; set => this.tipo_producto = value; }
        public int Cod_producto { get => this.cod_producto; set => this.cod_producto = value; }
        public string Nombre_producto { get => this.nombre_producto; set => this.nombre_producto = value; }
        public Estados? Estado { get => this.estado; set => this.estado = value; }
        public int Cantidad_producto { get => this.cantidad_producto; set => this.cantidad_producto = value; }

    }
        public class Inventarios
    {
        private int id = 0;
        private Productos? producto = null;
        private int cantidad_afectar = 0;

        public int Id { get => this.id; set => this.id = value; }
        public Productos? Producto { get => this.producto; set => this.producto = value; }
        public int Cantidad_afectar { get => this.cantidad_afectar; set => this.cantidad_afectar = value; }

    }

        public class Program 
    {
        static void Main(string[] args)
        {
            Clientes clientes= new Clientes
            {
                Id = 1,
                Cedula = "123456789",
                Nombre = "Juan Pérez",
                Contacto = 987654321,
                Direccion = "Calle Falsa 123"
            };
            Console.WriteLine($"Cliente: {clientes.Nombre}");
        }
      
    }
    
}
