using System;
using System.Collections.Generic;

namespace ConsoleAplication
{
	class Fabrizio_Enyell_Diego
	{
		// Creamos el tipo de dato "Carros" para nuestra lista de autos
		public class Carros
		{
			public string Marca { get; set; }
			public string Modelo { get; set; }
			public decimal Precio { get; set; }
			public int Ventas { get; set; }
		}

		// Creamos una clase abstracta para que no se puedan crear objetos de ella y solo se pueda derivar
		public abstract class VenAutos
		{
			public string Nombre { get; set; }
			public string Ubicacion { get; set; }
		}

		// La clase Sucursal Caracas hereda las propiedades de la clase base VenAutos
		class Subcursal_Caracas : VenAutos
		{
			// Creamos una lista que almacenará los carros de la Sucursal Caracas
			public List<Carros> CarrosVendidos { get; set; }

			// Constructor de la clase Sucursal Caracas
			public Subcursal_Caracas()
			{
				// Aplicamos Polimorfismo para cambiar los valores de las propiedades heredadas
				Nombre = "VenAutos Caracas";
				Ubicacion = "Caracas, Distrito Capital";

				// Lista con todos los autos que la concecionaria VenAutos Caracas ofrece
				CarrosVendidos = new List<Carros>
				{
					new Carros() { Marca = "Volkswagen", Modelo = "Golf", Precio = 25000, Ventas = 50 },
					new Carros() { Marca = "Chevrolet", Modelo = "Aveo", Precio = 18000, Ventas = 30 },
					new Carros() { Marca = "Fiat", Modelo = "500", Precio = 15000, Ventas = 40 },
					new Carros() { Marca = "Dodge", Modelo = "Charger", Precio = 40000, Ventas = 20 },
				};
			}

			public Carros ObtenerAutoMasVendido()
			{
				// Limpiamos consola
				Console.Clear();

				/* Ordenamos en forma descendente con el método OrderByDescending() y luego
				tomamos el primer elemento con el método FirstOrDefault() que básicamente es
				el elemento con el número más alto y por ende se asume que es el mayor en ventas*/
				return CarrosVendidos.OrderByDescending(c => c.Ventas).FirstOrDefault();
			}
		}

		// La clase Sucursal Maracaibo hereda las propiedades de la clase base VenAutos
		class Sucursal_Maracaibo : VenAutos
		{
			// Creamos la lista que almacenará todos los carros de la Sucursal Maracaibo
			public List<Carros> CarrosVendidos { get; set; }

			// Constructor de la clase Sucursal Maracaibo
			public Sucursal_Maracaibo()
			{
				// Aplicamos Polimorfismo para cambiar los valores de las propiedades heredadas
				Nombre = "VenAutos Maracaibo";
				Ubicacion = "Maracaibo, Estado Zulia";

				// Agregamos todos los autos que la concesionaria VenAutos Maracaibo ofrece
				CarrosVendidos = new List<Carros>
				{
					new Carros() { Marca = "Volkswagen", Modelo = "Passat", Precio = 28000 },
					new Carros() { Marca = "Chevrolet", Modelo = "Camaro", Precio = 50000 },
					new Carros() { Marca = "Fiat", Modelo = "500X", Precio = 20000 },
					new Carros() { Marca = "Dodge", Modelo = "Challenger", Precio = 45000 },
				};
			}
		}

		// La clase Sucursal Barcelona hereda las propiedades de la clase base VenAutos
		class Sucursal_Barcelona : VenAutos
		{
			// Creamos la lista que almacenará todos los carros de la Sucursal Barcelona
			public List<Carros> CarrosVendidos { get; set; }

			public Sucursal_Barcelona()
			{
				// Aplicamos Polimorfismo para cambiar los valores de las propiedades heredadas
				Nombre = "VenAutos Barcelona";
				Ubicacion = "Barcelona, Estado Anzoátegui";

				// Agregamos todos los autos que la concesionaria VenAutos Barcelona ofrece
				CarrosVendidos = new List<Carros>
				{
					new Carros() { Marca = "Volkswagen", Modelo = "Tiguan", Precio = 32000 },
					new Carros() { Marca = "Chevrolet", Modelo = "Captiva", Precio = 30000 },
					new Carros() { Marca = "Fiat", Modelo = "Panda", Precio = 13000 },
					new Carros() { Marca = "Dodge", Modelo = "Durango", Precio = 35000 },
				};
			}
		}

		// La clase Sucursal Mérida hereda las propiedades de la clase base VenAutos
		class Sucursal_Merida : VenAutos
		{
			// Creamos la lista que almacenará todos los carros de la Sucursal Mérida
			public List<Carros> CarrosVendidos { get; set; }

			public Sucursal_Merida()
			{
				// Aplicamos Polimorfismo para cambiar los valores de las propiedades heredadas
				Nombre = "VenAutos Mérida";
				Ubicacion = "Mérida, Estado Mérida";

				// Agregamos todos los autos que la concesionaria VenAutos Mérida ofrece
				CarrosVendidos = new List<Carros>
				{
					new Carros() { Marca = "Volkswagen", Modelo = "Jetta", Precio = 22000 },
					new Carros() { Marca = "Chevrolet", Modelo = "Corvette", Precio = 80000 },
					new Carros() { Marca = "Fiat", Modelo = "Tipo", Precio = 18000 },
					new Carros() { Marca = "Dodge", Modelo = "Hornet", Precio = 55000 },
				};
			}
		}

		static void Main(string[] args)
		{
			menu();
		}

		static void menu()
		{
			Console.Clear();
			Console.WriteLine("1. El carro más vendido en cada sucursal.");
			Console.WriteLine("2. El carro mas vendido en la empresa");
			Console.WriteLine("3. Cantidad de vendedores por sucursal");
			Console.WriteLine("4. Cantidad de vendedores se la Empresa");
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
					// Creamos el objeto de la Sucursal Caracas
					var carrosEnCaracas = new Subcursal_Caracas();

					// Llamamos al metodo para obtener el auto más vendido de esa concecionaria
					var autoMasVendido = carrosEnCaracas.ObtenerAutoMasVendido();

					// Imprimimos un mensaje con el auto más vendido
					Console.WriteLine($"El auto más vendido en Caracas es: {autoMasVendido.Marca} {autoMasVendido.Modelo} con un número de {autoMasVendido.Ventas} Ventas");
					break;
				default:
					Console.WriteLine("\nSaliendo del sistema...");
					return;
			}
		}
	}
}