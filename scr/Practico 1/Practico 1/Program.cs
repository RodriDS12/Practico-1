using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practico_1
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Empresa Nuevo = new Empresa();

            

            Nuevo.Catalogo();

            Console.WriteLine();

            Console.WriteLine("Los productos son para una Empresa(0) o Particular(1)?");

            var comprobar = Int32.Parse(Console.ReadLine());

            Console.WriteLine();

            if (comprobar == 0)
            {
                Console.WriteLine("Nombre de la Empresa?");
                var NombreEmp =  Console.ReadLine();

                Console.Clear();    
                Console.WriteLine("//Boleta//");
                Console.WriteLine();
                Console.WriteLine("Nombre de la Empresa: " + NombreEmp);
                Console.WriteLine();
                Console.WriteLine("La cantidad de productos en total es: " + Nuevo.getCantidad());
                Console.WriteLine("El precio total de todos los productos es de: " + Nuevo.getPrecioTotal());
                var fecha = DateTime.Now;
                Console.WriteLine("Fecha de Compra: " + fecha);
                Console.WriteLine();
                
            }

            Nuevo.MandarProductos();

        }



    }

    class Empresa
    {

        private int producto;
        private int Cantidad;
        private int PrecioTotal;


        public Empresa()
        {
            this.producto = 0;
            this.Cantidad = 0;
            this.PrecioTotal = 0;
        }

        public Empresa(int producto, int Cantidad, int PrecioTotal)
        {

            this.producto = producto;
            this.Cantidad = Cantidad;
            this.PrecioTotal = PrecioTotal;
        }

        public int getCantidad()
        {

            return (Cantidad);

        }

        public void setCantidad(int Cantidad)
        {
            this.Cantidad = Cantidad;

        }

        public int getPrecioTotal()
        {

            return (PrecioTotal);

        }

        public void setPrecioTotal(int PrecioTotal)
        {

            this.PrecioTotal = PrecioTotal;

        }

        public void Catalogo()
        {

            var seguir = 1;

            while (seguir == 1)
            {
                Console.WriteLine("//CATALOGO//");
                Console.WriteLine();



                Console.WriteLine("1 - Hamburguesa - 1x10$");
                Console.WriteLine("2 - Botella de Agua - 1x5$");
                Console.WriteLine("3 - Tomate - 1x3$");
                Console.WriteLine("4 - Queso - 1x16$");
                Console.WriteLine();



                Console.WriteLine("Seleccione el numero del producto: ");

                producto = Int32.Parse(Console.ReadLine());






                switch (producto)
                {

                    case 1:

                        Console.WriteLine("Cuantas Hamburguesas necesitas?");
                        var NuevaCantidad = Int32.Parse(Console.ReadLine());
                        Cantidad = Cantidad + NuevaCantidad;
                        var Precio = (Cantidad) * 10;
                        PrecioTotal = PrecioTotal + Precio;
                        break;


                    case 2:

                        Console.WriteLine("Cuantas Botellas de Agua necesitas?");
                        var NuevaCantidad2 = Int32.Parse(Console.ReadLine());
                        Cantidad = Cantidad + NuevaCantidad2;
                        var Precio2 = (Cantidad) * 5;
                        PrecioTotal = PrecioTotal + Precio2;

                        break;

                    case 3:

                        Console.WriteLine("Cuantas Tomate necesitas?");
                        var NuevaCantidad3 = Int32.Parse(Console.ReadLine());
                        Cantidad = Cantidad + NuevaCantidad3;
                        var Precio3 = (Cantidad) * 3;
                        PrecioTotal = PrecioTotal + Precio3;

                        break;

                    case 4:

                        Console.WriteLine("Cuantas Queso necesitas?");
                        var NuevaCantidad4 = Int32.Parse(Console.ReadLine());
                        Cantidad = Cantidad + NuevaCantidad4;
                        var Precio4 = (Cantidad) * 16;
                        PrecioTotal = PrecioTotal + Precio4;

                        break;
                }

                Console.WriteLine("Quiere seguir agregando productos? 1/SI, 2/NO");
                seguir = Int32.Parse(Console.ReadLine());
                Console.Clear();
            }

            
        }

        public void MandarProductos() { 
        
        Console.WriteLine("Se llevan los productos a su direccion correspondiente...");
        }

    }
}