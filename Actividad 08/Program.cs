using Actividad_08;

internal partial class Program
{
    private static void Main(string[] args)
    {
        var continuar = true;

        List<recetasCulinarias> recetas = new List<recetasCulinarias>();

        static void obtenerDatos(List<recetasCulinarias> recetas)
        {
            Console.WriteLine("Cuantos datos deseas agregar");
            var cantidadRecetas = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidadRecetas; i++)
            {
                Console.WriteLine($"Ingresa el nombre de la receta No.{i + 1}");
                var nombre = Console.ReadLine();

                Console.WriteLine("Cuantos Ingredientes utiliza la receta");
                var ingredientesCantidad = int.Parse(Console.ReadLine());

                Console.WriteLine($"Ingresa los nombres de los ingredientes de la receta No.{i + 1}");
                var ingredientes = Console.ReadLine();

                Console.WriteLine($"Ingresa la cantidad de cada ingrediente de la receta No.{i + 1}");
                string cantidadIngredientes = (Console.ReadLine());

                Console.WriteLine($"Ingresa el nombre de los utensilios de la receta No.{i + 1}");
                var nombreUtensilios = Console.ReadLine();

                Console.WriteLine($"Ingresa el tiempo de coccion de la receta No.{i + 1}");
                var tiempoCoccion = int.Parse(Console.ReadLine());

                recetas.Add(new recetasCulinarias(nombre,ingredientes,cantidadIngredientes,nombreUtensilios,tiempoCoccion));
            }

        }
        static void buscarReceta(List<recetasCulinarias>recetas) 
        {
         Console.WriteLine("escribe el nombre de la receta que deseas buscar");
         var buscarReceta = Console.ReadLine();
            foreach (var r in recetas)
            {
                if (buscarReceta == r.Nombre)
                {
                    Console.WriteLine("La receta existe");
                    Console.WriteLine(r.Nombre);
                    Console.WriteLine(r.Ingredientes);
                    Console.WriteLine(r.CantidadPorIngrediente);
                    Console.WriteLine(r.Utensilios);
                    Console.WriteLine(r.TiempoDeCoccion);
                }
                else 
                {
                    Console.WriteLine("No existe la receta en la base de datos");
                }
            }

        }
        static void presentarRecetas(List<recetasCulinarias> recetas)
        {
            foreach (var r in recetas)
            {
                    Console.WriteLine("\n La receta existe");
                    Console.WriteLine(r.Nombre);
                    Console.WriteLine(r.Ingredientes);
                    Console.WriteLine(r.CantidadPorIngrediente);
                    Console.WriteLine(r.Utensilios);
                    Console.WriteLine(r.TiempoDeCoccion);
                
            }

        }
        do
        {
            Console.WriteLine("--MENU--");
            Console.WriteLine("1. AGREGAR RECETA");
            Console.WriteLine("2. BUSCAR RECETAS");
            Console.WriteLine("3. MOSTRAR TODAS LAS RECETAS\n");
            Console.WriteLine("4. SALIR");
            Console.WriteLine("Selecciona la opcion que deseas ejecutar");
            var opcionMenu = int.Parse(Console.ReadLine());
            switch (opcionMenu)
            {
                case 1:
                    obtenerDatos(recetas);
                    break;
                case 2:
                    buscarReceta(recetas);
                    break;
                case 3:
                    presentarRecetas(recetas);
                    break;
                case 4:
                    Console.WriteLine("Gracias por usar el programa");
                    continuar = false;
                    break;
            }
        } while (continuar);
    }
}

