using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace VenAutos
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
			public string Vendedor { get; set; }
		}

		// Creamos una clase abstracta para que no se puedan crear objetos de ella y solo se pueda derivar
		public abstract class VenAutos
		{
			public string Nombre { get; set; }
			public string Ubicacion { get; set; }
		}

		// La clase Sucursal Caracas hereda las propiedades de la clase base VenAutos
		class Sucursal_Caracas : VenAutos
		{
			// Creamos una lista que almacenará los carros de la Sucursal Caracas
			public List<Carros> CarrosVendidos { get; set; }

			// Constructor de la clase Sucursal Caracas
			public Sucursal_Caracas()
			{
				// Aplicamos Polimorfismo para cambiar los valores de las propiedades heredadas
				Nombre = "VenAutos Caracas";
				Ubicacion = "Caracas, Distrito Capital";

				// Lista con todos los autos que la concecionaria VenAutos Caracas ofrece
				CarrosVendidos = new List<Carros>
				{
					new Carros() { Marca = "Volkswagen", Modelo = "Golf", Precio = 25000, Ventas = 50, Vendedor = "Alex Martinez"},
					new Carros() { Marca = "Chevrolet", Modelo = "Aveo", Precio = 18000, Ventas = 30, Vendedor = "Julia Gonzalez" },
					new Carros() { Marca = "Fiat", Modelo = "500", Precio = 15000, Ventas = 40, Vendedor = "David Torrealba" },
					new Carros() { Marca = "Dodge", Modelo = "Charger", Precio = 40000, Ventas = 20, Vendedor = "Pedro Gómez" },
				};
			}

			public Carros ObtenerAutoMasVendidoEnCaracas()
			{
				// Limpiamos consola
				Console.Clear();

				/* Ordenamos en forma descendente con el método OrderByDescending() y luego
				tomamos el primer elemento con el método FirstOrDefault() que básicamente es
				el elemento con el número más alto y por ende se asume que es el mayor en ventas*/
				return CarrosVendidos.OrderByDescending(c => c.Ventas).FirstOrDefault();
			}

			// Creamos un método que contenga el mayor vendedor de la Sucursal
			public Carros ObtenerMayorVendedorEnCaracas()
			{
				return CarrosVendidos.OrderByDescending(c => c.Vendedor).LastOrDefault();
			}

			// Creamos una método que contenga al menor vendedor de la Sucursal
			public Carros ObtenerMenorVendedorEnCaracas()
			{
				return CarrosVendidos.OrderByDescending(c => c.Vendedor).FirstOrDefault();
			}

			// Creamos un método que retorne la cantidad de vendedores de la Sucursal
			public int vendedoresEnCaracas()
			{
				Console.Clear();
				return 4;
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
					new Carros() { Marca = "Volkswagen", Modelo = "Passat", Precio = 28000, Ventas = 18, Vendedor = "Rafael Perez" },
					new Carros() { Marca = "Chevrolet", Modelo = "Camaro", Precio = 50000, Ventas = 22, Vendedor = "Roger Oropeza" },
					new Carros() { Marca = "Fiat", Modelo = "500X", Precio = 20000, Ventas = 15, Vendedor = "Orlando Rodriguez" },	  
					new Carros() { Marca = "Dodge", Modelo = "Challenger", Precio = 45000, Ventas  = 8, Vendedor = "Katherine Olivera" },
				};
			}

			public Carros ObtenerAutoMasVendidoEnMaracaibo()
			{
				// Limpiamos consola
				Console.Clear();

				/* Ordenamos en forma descendente con el método OrderByDescending() y luego
				tomamos el primer elemento con el método FirstOrDefault() que básicamente es
				el elemento con el número más alto y por ende se asume que es el mayor en ventas*/
				return CarrosVendidos.OrderByDescending(c => c.Ventas).FirstOrDefault();
			}

			// Creamos el método para tener al mayor vendedor de la Sucursal
			public Carros ObtenerMayorVendedorEnMaracaibo()
			{
				return CarrosVendidos.OrderByDescending(c => c.Vendedor).FirstOrDefault();
			}

			// Creamos el método para tener al vendedor con menos ventas de la Sucursal
			public Carros ObtenerMenorVendedorEnMaracaibo()
			{
				return CarrosVendidos.OrderByDescending(c => c.Vendedor).LastOrDefault();
			}

			// Creamos un método que retorne la cantidad de vendedores de la Sucursal
			public int vendedoresEnMaracaibo()
			{
				Console.Clear();
				return 4;
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
					new Carros() { Marca = "Volkswagen", Modelo = "Tiguan", Precio = 32000, Ventas = 14, Vendedor = "Jennifer Toledo" },
					new Carros() { Marca = "Chevrolet", Modelo = "Captiva", Precio = 30000, Ventas = 17, Vendedor = "Angelica Belanova" },
					new Carros() { Marca = "Fiat", Modelo = "Panda", Precio = 13000, Ventas = 26, Vendedor = "Paola Suarez" },
					new Carros() { Marca = "Dodge", Modelo = "Durango", Precio = 35000, Ventas = 5, Vendedor = "Patrick Ramírez" },
				};
			}

			public Carros ObtenerAutoMasVendidoEnBarcelona()
			{
				// Limpiamos consola
				Console.Clear();

				/* Ordenamos en forma descendente con el método OrderByDescending() y luego
				tomamos el primer elemento con el método FirstOrDefault() que básicamente es
				el elemento con el número más alto y por ende se asume que es el mayor en ventas*/
				return CarrosVendidos.OrderByDescending(c => c.Ventas).FirstOrDefault();
			}

			// Creamos el método para obtener el mayor vendedor de la Sucursal
			public Carros ObtenerMayorVendedorEnBarcelona()
			{
				return CarrosVendidos.OrderByDescending(c => c.Vendedor).FirstOrDefault();
			}

			// Creamos el método para obtener al menor vendedor de la Sucursal
			public Carros ObtenerMenorVendedorEnBarcelona()
			{
				return CarrosVendidos.OrderByDescending(c => c.Vendedor).LastOrDefault();
			}

			// Creamos un método que retorne la cantidad de vendedores de la Sucursal
			public int vendedoresEnBarcelona()
			{
				Console.Clear();
				return 4;
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
					new Carros() { Marca = "Volkswagen", Modelo = "Jetta", Precio = 22000, Ventas = 30, Vendedor = "Tomas Mazza" },
					new Carros() { Marca = "Chevrolet", Modelo = "Corvette", Precio = 80000, Ventas = 18, Vendedor = "Carlos Belcasth" },
					new Carros() { Marca = "Fiat", Modelo = "Tipo", Precio = 18000, Ventas = 35, Vendedor = "Kamila Orellana" },
					new Carros() { Marca = "Dodge", Modelo = "Hornet", Precio = 55000, Ventas = 16, Vendedor = "Juanito Alcachofa" },
				};
			}

			public Carros ObtenerAutoMasVendidoEnMerida()
			{
				// Limpiamos consola
				Console.Clear();

				/* Ordenamos en forma descendente con el método OrderByDescending() y luego
				tomamos el primer elemento con el método FirstOrDefault() que básicamente es
				el elemento con el número más alto y por ende se asume que es el mayor en ventas*/
				return CarrosVendidos.OrderByDescending(c => c.Ventas).FirstOrDefault();
			}

			// Creamos un médoto que contiene al mayor vendedor de la Sucursal
			public Carros ObtenerMayorVendedorEnMerida()
			{
				return CarrosVendidos.OrderByDescending(c => c.Vendedor).FirstOrDefault();
			}

			// Creamos un método que va a contener al menor vendedor de la Sucursal
			public Carros ObtenerMenorVendedorEnMerida()
			{
				return CarrosVendidos.OrderByDescending(c => c.Vendedor).LastOrDefault();
			}

			// Creamos un método que retorne la cantidad de vendedores de la Sucursal
			public int vendedoresEnMerida()
			{
				Console.Clear();
				return 4;
			}
		}
		
		class TodasLasSucursales
		{
			// Creamos una lista que contendrá métodos
			public List<Carros> autosMasVendidosEnTodasLasSucursales { get; set; }

			public TodasLasSucursales()
			{
				// Creamos los objetos de cada Subcursal
				var carrosEnCaracas = new Sucursal_Caracas();
				var carrosEnMaracaibo = new Sucursal_Maracaibo();
				var carrosEnBarcelona = new Sucursal_Barcelona();
				var carrosEnMerida = new Sucursal_Merida();

				// Agregamos los métodos de los autos más vendidos de cada Sucursal
				autosMasVendidosEnTodasLasSucursales = new List<Carros>
				{
					carrosEnCaracas.ObtenerAutoMasVendidoEnCaracas(),
					carrosEnMaracaibo.ObtenerAutoMasVendidoEnMaracaibo(),
					carrosEnBarcelona.ObtenerAutoMasVendidoEnBarcelona(),
					carrosEnMerida.ObtenerAutoMasVendidoEnMerida(),
				};
			}

			public Carros autoMasVendidoDeLaEmpresa()
			{
				Console.Clear();

				// Cramos una función anónima y la ordenamos de forma decendente para luego tomar el valor más alto y retornarlo
				return autosMasVendidosEnTodasLasSucursales.OrderByDescending(c => c.Ventas).FirstOrDefault();
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
				default:
					Console.WriteLine("\nSaliendo del sistema...");
					return;
			}

			// 1- Creamos el método que contiene el auto más vendido en cada Sucursal
			static void carroMasVendidoPorSucursal()
			{
				Console.Clear();
				// Creamos el objeto de cada una de las Sucursales
				var carrosEnCaracas = new Sucursal_Caracas();
				var carrosEnMaracaibo = new Sucursal_Maracaibo();
				var carrosEnBarcelona = new Sucursal_Barcelona();
				var carrosEnMerida = new Sucursal_Merida();

				// Llamamos al metodo para obtener el auto más vendido de esa concecionaria
				var autoMasVendidoEnCaracas = carrosEnCaracas.ObtenerAutoMasVendidoEnCaracas();
				var autoMasVendidoEnMaracaibo = carrosEnMaracaibo.ObtenerAutoMasVendidoEnMaracaibo();
				var autoMasVendidoEnBarcelona = carrosEnBarcelona.ObtenerAutoMasVendidoEnBarcelona();
				var autoMasVendidoEnMerida = carrosEnMerida.ObtenerAutoMasVendidoEnMerida();

				// Imprimimos un mensaje con el auto más vendido en cada Sucursal
				Console.WriteLine($"El auto más vendido en Caracas es: {autoMasVendidoEnCaracas.Marca} {autoMasVendidoEnCaracas.Modelo} con un número de {autoMasVendidoEnCaracas.Ventas} Ventas.");
				Console.WriteLine($"El auto más vendido en Maracaibo es: {autoMasVendidoEnMaracaibo.Marca} {autoMasVendidoEnMaracaibo.Modelo} con un número de {autoMasVendidoEnMaracaibo.Ventas} Ventas.");
				Console.WriteLine($"El auto más vendido en Barcelona es: {autoMasVendidoEnBarcelona.Marca} {autoMasVendidoEnBarcelona.Modelo} con un número de {autoMasVendidoEnBarcelona.Ventas} Ventas.");
				Console.WriteLine($"El auto más vendido en Mérida es: {autoMasVendidoEnMerida.Marca} {autoMasVendidoEnMerida.Modelo} con un número de {autoMasVendidoEnMerida.Ventas} Ventas.");
			}

			// 2- Creamos el método que contiene el auto más vendido de la Empresa
			static void carroMasVendidoEnLaEmpresa()
			{
				Console.Clear();
				// Creamos el objeto de Todas las Sucursales
				var TodasLasSucursales = new TodasLasSucursales();

				// Creamos una variable y decimos que es igual al auto más vendido de la Empresa
				var MasVendido = TodasLasSucursales.autoMasVendidoDeLaEmpresa();

				// Imprimimos el mensaje del auto más vendido
				Console.WriteLine($"El auto más vendido de la Empresa es: {MasVendido.Marca} {MasVendido.Modelo} con un número de {MasVendido.Ventas} ventas.");
			}

			// 3- Creamos el método que contiene la cantidad de vendedores en cada Sucursal
			static void vendedoresEnCadaSucursal()
			{
				Console.Clear();
				// Creamos los objetos de todas las Sucursales
				var vendedoresCaracas = new Sucursal_Caracas();
				var vendedoresMaracaibo = new Sucursal_Maracaibo();
				var vendedoresBarcelona = new Sucursal_Barcelona();
				var vendedoresMerida = new Sucursal_Merida();

				// Creamos variables que serán iguales a los métodos de cada objeto
				var vendedoresEnCaracas = vendedoresCaracas.vendedoresEnCaracas();
				var vendedoresEnMaracaibo = vendedoresMaracaibo.vendedoresEnMaracaibo();
				var vendedoresEnBarcelona = vendedoresBarcelona.vendedoresEnBarcelona();
				var vendedoresEnMerida = vendedoresMerida.vendedoresEnMerida();

				// Imprimimos los mensajes de la cantidad de vendedores en cada Sucursal
				Console.WriteLine($"En Caracas hay {vendedoresEnCaracas} vendedores.");
				Console.WriteLine($"En Maracaibo hay {vendedoresEnMaracaibo} vendedores.");
				Console.WriteLine($"En Barcelona hay {vendedoresEnBarcelona} vendedores.");
				Console.WriteLine($"En Mérida hay {vendedoresEnMerida} vendedores.");
			}

			// 4- Creamos el método que contiene la cantidad de vendedores en total de la Empresa
			static void vendedoresEnLaEmpresa()
			{
				Console.Clear();
				// Creamos los objetos de todas las Sucursales
				var vendedoresCaracas = new Sucursal_Caracas();
				var vendedoresMaracaibo = new Sucursal_Maracaibo();
				var vendedoresBarcelona = new Sucursal_Barcelona();
				var vendedoresMerida = new Sucursal_Merida();

				// Llamamos a los métodos para obtener la cantidad de vendedores de cada sucursal
				var vendedoresEnCaracas = vendedoresCaracas.vendedoresEnCaracas();
				var vendedoresEnMaracaibo = vendedoresMaracaibo.vendedoresEnMaracaibo();
				var vendedoresEnBarcelona = vendedoresBarcelona.vendedoresEnBarcelona();
				var vendedoresEnMerida = vendedoresMerida.vendedoresEnMerida();

				// Creamos una variable y decimos que es igual a la suma de todos los resultados de cada método
				int vendedoresDeLaEmpresa = vendedoresEnCaracas + vendedoresEnMaracaibo + vendedoresEnBarcelona + vendedoresEnMerida;

				Console.WriteLine($"La Empresa VenAutos tiene un número de {vendedoresEnLaEmpresa} vendedores.");
			}

			// 5- Creamos el método que  contiene el mejor vendedor de cada Sucursal
			static void mayoresVendedoresEnCadaSucursal()
			{
				Console.Clear();
				// Creamos el objeto de cada una de las Sucursales
				var mayoresVendedoresEnCaracas = new Sucursal_Caracas();
				var mayoresVendedoresEnMaracaibo = new Sucursal_Maracaibo();
				var mayoresVendedoresEnBarcelona = new Sucursal_Barcelona();
				var mayoresVendedoresEnMerida = new Sucursal_Merida();

				// Llamamos al método para obtener el vendedor con más ventas de esa sucursal
				var mayorVendedorEnCaracas = mayoresVendedoresEnCaracas.ObtenerMayorVendedorEnCaracas();
				var mayorVendedorEnMaracaibo = mayoresVendedoresEnMaracaibo.ObtenerMayorVendedorEnMaracaibo();
				var mayorVendedorEnBarcelona = mayoresVendedoresEnBarcelona.ObtenerAutoMasVendidoEnBarcelona();
				var mayorVendedorEnMerida = mayoresVendedoresEnMerida.ObtenerMayorVendedorEnMerida();

				// Imprimos mensajes con el nombre de los mayores vendedores junto con su número total de ventas
				Console.WriteLine($"El mayor vendedor en Caracas es {mayorVendedorEnCaracas.Vendedor} con un número de {mayorVendedorEnCaracas.Ventas} ventas.");
				Console.WriteLine($"El mayor vendedor en Maracaibo es {mayorVendedorEnMaracaibo.Vendedor} con un número de {mayorVendedorEnMaracaibo.Ventas} ventas.");
				Console.WriteLine($"El mayor vendedor en Barcelona es {mayorVendedorEnBarcelona.Vendedor} con un número de {mayorVendedorEnBarcelona.Ventas} ventas.");
				Console.WriteLine($"El mayor vendedor en Merida es {mayorVendedorEnMerida.Vendedor} con un número de {mayorVendedorEnMerida.Ventas} ventas.");
			}

			// 6- Creamos el método que contiene al menor vendedor en cada Sucursal
			static void menoresVendedoresEnCadaSucursal()
			{
				Console.Clear();
				// Creamos los objetos de todas las Sucursales
				var menoresVendedoresEnCaracas = new Sucursal_Caracas();
				var menoresVendedoresEnMaracaibo = new Sucursal_Maracaibo();
				var menoresVendedoresEnBarcelona = new Sucursal_Barcelona();
				var menoresVendedoresEnMerida = new Sucursal_Merida();

				// Llamamos a los métodos para obtener la cantidad de vendedores con menor número de ventas
				var menorVendedorEnCaracas = menoresVendedoresEnCaracas.ObtenerMenorVendedorEnCaracas();
				var menorVendedorEnMaracaibo = menoresVendedoresEnMaracaibo.ObtenerMenorVendedorEnMaracaibo();
				var menorVendedorEnBarcelona = menoresVendedoresEnBarcelona.ObtenerMenorVendedorEnBarcelona();
				var menorVendedorEnMerida = menoresVendedoresEnMerida.ObtenerMenorVendedorEnMerida();

				// Imprimos mensajes con el nombre de los mayores vendedores junto con su número total de ventas
				Console.WriteLine($"El menor vendedor en Caracas es {menorVendedorEnCaracas.Vendedor} con un número de {menorVendedorEnCaracas.Ventas} ventas.");
				Console.WriteLine($"El menor vendedor en Maracaibo es {menorVendedorEnMaracaibo.Vendedor} con un número de {menorVendedorEnMaracaibo.Ventas} ventas.");
				Console.WriteLine($"El menor vendedor en Barcelona es {menorVendedorEnBarcelona.Vendedor} con un número de {menorVendedorEnBarcelona.Ventas} ventas.");
				Console.WriteLine($"El menor vendedor en Merida es {menorVendedorEnMerida.Vendedor} con un número de {menorVendedorEnMerida.Ventas} ventas.");
			}
		}
	}
}