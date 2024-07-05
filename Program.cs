using System;
using System.Collections.Generic;
using System.Linq;

namespace VenAutos
{
    class Fabrizio_Enyell_Diego
    {
        //Se crea el acumulador para definir todos los autos que manejan las sucursales
        static int totalCarros;
        
        //Se crea la lista predefinida de los autos que maneja venAutos
        public static List<Carros> CarrosDisponibles = new List<Carros>
        {
            new Carros() { Marca = "Volkswagen", Modelo = "Golf", Precio = 25000, Ventas = 50, Vendedor = "Alex Martinez", Sucursal = "Caracas" },
            new Carros() { Marca = "Chevrolet", Modelo = "Aveo", Precio = 18000, Ventas = 30, Vendedor = "Julia Gonzalez", Sucursal = "Caracas" },
            new Carros() { Marca = "Fiat", Modelo = "500", Precio = 15000, Ventas = 40, Vendedor = "David Torrealba", Sucursal = "Caracas" },
            new Carros() { Marca = "Dodge", Modelo = "Charger", Precio = 40000, Ventas = 20, Vendedor = "Pedro Gómez", Sucursal = "Caracas" },
            new Carros() { Marca = "Volkswagen", Modelo = "Passat", Precio = 28000, Ventas = 18, Vendedor = "Rafael Perez", Sucursal = "Maracaibo" },
            new Carros() { Marca = "Chevrolet", Modelo = "Camaro", Precio = 50000, Ventas = 22, Vendedor = "Roger Oropeza", Sucursal = "Maracaibo" },
            new Carros() { Marca = "Fiat", Modelo = "500X", Precio = 20000, Ventas = 15, Vendedor = "Orlando Rodriguez", Sucursal = "Maracaibo" },
            new Carros() { Marca = "Dodge", Modelo = "Challenger", Precio = 45000, Ventas = 8, Vendedor = "Katherine Olivera", Sucursal = "Maracaibo" },
            new Carros() { Marca = "Volkswagen", Modelo = "Tiguan", Precio = 32000, Ventas = 14, Vendedor = "Jennifer Toledo", Sucursal = "Barcelona" },
            new Carros() { Marca = "Chevrolet", Modelo = "Captiva", Precio = 30000, Ventas = 17, Vendedor = "Angelica Belanova", Sucursal = "Barcelona" },
            new Carros() { Marca = "Fiat", Modelo = "Panda", Precio = 13000, Ventas = 26, Vendedor = "Paola Suarez", Sucursal = "Barcelona" },
            new Carros() { Marca = "Dodge", Modelo = "Durango", Precio = 35000, Ventas = 5, Vendedor = "Patrick Ramírez", Sucursal = "Barcelona" },
            new Carros() { Marca = "Volkswagen", Modelo = "Jetta", Precio = 22000, Ventas = 30, Vendedor = "Tomas Mazza", Sucursal = "Merida" },
            new Carros() { Marca = "Chevrolet", Modelo = "Corvette", Precio = 80000, Ventas = 18, Vendedor = "Carlos Belcasth", Sucursal = "Merida" },
            new Carros() { Marca = "Fiat", Modelo = "Tipo", Precio = 18000, Ventas = 35, Vendedor = "Kamila Orellana", Sucursal = "Merida" },
            new Carros() { Marca = "Dodge", Modelo = "Hornet", Precio = 55000, Ventas = 16, Vendedor = "Juanito Alcachofa", Sucursal = "Merida" },
        };

        //Se crea la clase Carros en donde se almacenaran los datos en distintas variables con los nombres de los atributos que están en la lista
        public class Carros
        {
            //Se crean las funciones constructoras para poder almacenar los datos en variables con el nombre de los atributos de la lista global
            public string Marca { get; set; }
            public string Modelo { get; set; }
            public decimal Precio { get; set; }
            public int Ventas { get; set; }
            public string Vendedor { get; set; }
            public string Sucursal { get; set; }
        }

        public abstract class VenAutos
        {
            //Se crea una clase abstracta debido a que al ser la clase de las sucursales no se modifican en todo el proceso del programa.
            public string Nombre { get; set; }
            public string Ubicacion { get; set; }

            //Se hace la lectura de los elementos dentro de la lista.
            public abstract List<Carros> CarrosVendidos { get; }
            
            public Carros ObtenerAutoMasVendido()
            {
                return CarrosVendidos.OrderByDescending(c => c.Ventas).FirstOrDefault();
            }

            public Carros ObtenerMayorVendedor()
            {
                return CarrosVendidos.OrderByDescending(c => c.Ventas).FirstOrDefault();
            }

            public Carros ObtenerMenorVendedor()
            {
                return CarrosVendidos.OrderBy(c => c.Ventas).FirstOrDefault();
            }

            public int vendedores()
            {
                return CarrosVendidos.Select(c => c.Vendedor).Distinct().Count();
            }

            public double CalcularPromedioVentas()
            {
                return CarrosVendidos.Average(c => c.Ventas);
            }

            public decimal CalcularMontoTotalVentas()
            {
                return CarrosVendidos.Sum(c => c.Ventas * c.Precio);
            }
        }

        class Sucursal_Caracas : VenAutos
        {
            public override List<Carros> CarrosVendidos => CarrosDisponibles.Where(c => c.Sucursal == "Caracas").ToList();
            public Sucursal_Caracas()
            {
                Nombre = "VenAutos Caracas";
                Ubicacion = "Caracas, Distrito Capital";
            }
        }

        class Sucursal_Maracaibo : VenAutos
        {
            public override List<Carros> CarrosVendidos => CarrosDisponibles.Where(c => c.Sucursal == "Maracaibo").ToList();
            public Sucursal_Maracaibo()
            {
                Nombre = "VenAutos Maracaibo";
                Ubicacion = "Maracaibo, Estado Zulia";
            }
        }

        class Sucursal_Barcelona : VenAutos
        {
            public override List<Carros> CarrosVendidos => CarrosDisponibles.Where(c => c.Sucursal == "Barcelona").ToList();
            public Sucursal_Barcelona()
            {
                Nombre = "VenAutos Barcelona";
                Ubicacion = "Barcelona, Estado Anzoátegui";
            }
        }

        class Sucursal_Merida : VenAutos
        {
            public override List<Carros> CarrosVendidos => CarrosDisponibles.Where(c => c.Sucursal == "Merida").ToList();
            public Sucursal_Merida()
            {
                Nombre = "VenAutos Mérida";
                Ubicacion = "Mérida, Estado Mérida";
            }
        }

        class TodasLasSucursales
        {
            public List<Carros> autosMasVendidosEnTodasLasSucursales { get; set; }

            public TodasLasSucursales()
            {
                var sucursales = new List<VenAutos>
                {
                    new Sucursal_Caracas(),
                    new Sucursal_Maracaibo(),
                    new Sucursal_Barcelona(),
                    new Sucursal_Merida()
                };

                autosMasVendidosEnTodasLasSucursales = sucursales.Select(s => s.ObtenerAutoMasVendido()).ToList();
            }

            public Carros autoMasVendidoDeLaEmpresa()
            {
                return autosMasVendidosEnTodasLasSucursales.OrderByDescending(c => c.Ventas).FirstOrDefault();
            }

            public decimal CalcularMontoTotalVentasEmpresa()
            {
                return autosMasVendidosEnTodasLasSucursales.Sum(c => c.Ventas * c.Precio);
            }
        }

        static void Main(string[] args)
        {
            menu();
        }

        static void menu()
        {

            Console.Clear();
            Console.WriteLine("//------------Bienvenidos a la Concesionaria VenAutos------------//\n");
            Console.WriteLine("1. El carro más vendido en cada sucursal.");
            Console.WriteLine("2. El carro más vendido en la empresa.");
            Console.WriteLine("3. Cantidad de vendedores por sucursal.");
            Console.WriteLine("4. Cantidad de vendedores de la Empresa.");
            Console.WriteLine("5. Determinar el vendedor con la mayor venta en cada sucursal.");
            Console.WriteLine("6. Identificar el vendedor con la menor venta en cada sucursal.");
            Console.WriteLine("7. Calcular el promedio de ventas en cada sucursal.");
            Console.WriteLine("8. Calcular el promedio general de ventas de la empresa.");
            Console.WriteLine("9. Calcular el monto total de ventas de la empresa.");

            Console.Write("\nElija una opción: ");
            int opciones = int.Parse(Console.ReadLine());

            switch (opciones)
            {
                case 1:
                    carroMasVendidoPorSucursal();
                    break;
                case 2:
                    carroMasVendidoEnLaEmpresa();
                    break;
                case 3:
                    vendedoresEnCadaSucursal();
                    break;
                case 4:
                    vendedoresEnLaEmpresa();
                    break;
                case 5:
                    mayoresVendedoresEnCadaSucursal();
                    break;
                case 6:
                    menoresVendedoresEnCadaSucursal();
                    break;
                case 7:
                    promedioVentasPorSucursal();
                    break;
                case 8:
                    promedioGeneralVentasEmpresa();
                    break;
                case 9:
                    montoTotalVentasEmpresa();
                    break;
                default:
                    Console.WriteLine("\nSaliendo del sistema...");
                    return;
            }
        }

        static void carroMasVendidoPorSucursal()
        {
            Console.Clear();
            var sucursales = new List<VenAutos>
            {
                new Sucursal_Caracas(),
                new Sucursal_Maracaibo(),
                new Sucursal_Barcelona(),
                new Sucursal_Merida()
            };

            foreach (var sucursal in sucursales)
            {
                var autoMasVendido = sucursal.ObtenerAutoMasVendido();
                Console.WriteLine($"El auto más vendido en {sucursal.Nombre} es: {autoMasVendido.Marca} {autoMasVendido.Modelo} con un total de: {autoMasVendido.Ventas} ventas.");
            }
            volver();
        }

        static void carroMasVendidoEnLaEmpresa()
        {
            Console.Clear();
            var todasLasSucursales = new TodasLasSucursales();
            var autoMasVendido = todasLasSucursales.autoMasVendidoDeLaEmpresa();
            Console.WriteLine($"El auto más vendido en la empresa es: {autoMasVendido.Marca} {autoMasVendido.Modelo} con un total de: {autoMasVendido.Ventas} ventas.");
            volver();
        }

        static void vendedoresEnCadaSucursal()
        {
            Console.Clear();
            var sucursales = new List<VenAutos>
            {
                new Sucursal_Caracas(),
                new Sucursal_Maracaibo(),
                new Sucursal_Barcelona(),
                new Sucursal_Merida()
            };

            foreach (var sucursal in sucursales)
            {
                Console.WriteLine($"La cantidad de vendedores en {sucursal.Nombre} es de: {sucursal.vendedores()} vendedores.");
            }
            volver();
        }

        static void vendedoresEnLaEmpresa()
        {
            Console.Clear();
            var sucursales = new List<VenAutos>
            {
                new Sucursal_Caracas(),
                new Sucursal_Maracaibo(),
                new Sucursal_Barcelona(),
                new Sucursal_Merida()
            };

            int totalVendedores = sucursales.SelectMany(s => s.CarrosVendidos.Select(c => c.Vendedor)).Distinct().Count();
            Console.WriteLine($"El total de vendedores en la empresa es de: {totalVendedores} vendedores.");
            volver();
        }

        static void mayoresVendedoresEnCadaSucursal()
        {
            Console.Clear();
            var sucursales = new List<VenAutos>
            {
                new Sucursal_Caracas(),
                new Sucursal_Maracaibo(),
                new Sucursal_Barcelona(),
                new Sucursal_Merida()
            };

            foreach (var sucursal in sucursales)
            {
                var mayorVendedor = sucursal.ObtenerMayorVendedor();
                Console.WriteLine($"El mayor vendedor en {sucursal.Nombre} es: {mayorVendedor.Vendedor} con un total de: {mayorVendedor.Ventas} ventas.");
            }
            volver();
        }

        static void menoresVendedoresEnCadaSucursal()
        {
            Console.Clear();
            var sucursales = new List<VenAutos>
            {
                new Sucursal_Caracas(),
                new Sucursal_Maracaibo(),
                new Sucursal_Barcelona(),
                new Sucursal_Merida()
            };

            foreach (var sucursal in sucursales)
            {
                var menorVendedor = sucursal.ObtenerMenorVendedor();
                Console.WriteLine($"El menor vendedor en {sucursal.Nombre} es: {menorVendedor.Vendedor} con un total de: {menorVendedor.Ventas} ventas.");
            }
            volver();
        }

        static void promedioVentasPorSucursal()
        {
            Console.Clear();
            var sucursales = new List<VenAutos>
            {
                new Sucursal_Caracas(),
                new Sucursal_Maracaibo(),
                new Sucursal_Barcelona(),
                new Sucursal_Merida()
            };

            foreach (var sucursal in sucursales)
            {
                var promedio = sucursal.CalcularPromedioVentas();
                Console.WriteLine($"El promedio de ventas en {sucursal.Nombre} es de: {promedio} ventas por carro.");
            }
            volver();
        }

        static void promedioGeneralVentasEmpresa()
        {
            Console.Clear();
            var totalVentas = CarrosDisponibles.Sum(c => c.Ventas);
            var totalCarros = CarrosDisponibles.Count;
            var promedio = (double)totalVentas / totalCarros;
            Console.WriteLine($"El promedio general de ventas de la empresa es de: {promedio} ventas por carro.");
            volver();
        }

        static void montoTotalVentasEmpresa()
        {
            Console.Clear();
            var todasLasSucursales = new TodasLasSucursales();
            var montoTotal = todasLasSucursales.CalcularMontoTotalVentasEmpresa();
            Console.WriteLine($"El monto total de ventas de la empresa es de: {montoTotal:C}");
            volver();
        }

        static void volver()
        {
            Console.Write("\n¿Desea Volver al menú de opciones? S/N: ");
            char volver = char.Parse(Console.ReadLine());

            if (char.ToUpper(volver) == 'S')
            {
                menu();
            }
            else
            {
                return;
            }
        }
    }
}