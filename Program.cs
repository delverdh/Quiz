using System;
using System.Collections.Generic;
using System.Linq;

namespace NameProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Allan", "Carlos", "Angela", "MQ", "Andres", "Esteban" };

            // a. Filtrar los nombres que comienzan con la letra 'A' y ordenarlos alfabéticamente
            var filteredNames = names.Where(name => name.StartsWith("A")).OrderBy(name => name).ToList();
            Console.WriteLine("Nombres que comienzan con 'A' ordenados alfabéticamente:");
            filteredNames.ForEach(Console.WriteLine);

            // b. Contar los nombres que tienen más de 4 letras
            var countMoreThan4Letters = names.Count(name => name.Length > 4);
            Console.WriteLine($"\nNúmero de nombres con más de 4 letras: {countMoreThan4Letters}");

            // c. Convertir todos los nombres a mayúsculas
            var upperCaseNames = names.Select(name => name.ToUpper()).ToList();
            Console.WriteLine("\nNombres en mayúsculas:");
            upperCaseNames.ForEach(Console.WriteLine);

            // d. Encontrar el nombre más largo de la lista
            var longestName = names.OrderByDescending(name => name.Length).First();
            Console.WriteLine($"\nEl nombre más largo es: {longestName}");

            // e. Agrupar los nombres por su longitud
            var groupedByLength = names.GroupBy(name => name.Length);
            Console.WriteLine("\nNombres agrupados por longitud:");
            foreach (var group in groupedByLength)
            {
                Console.WriteLine($"Longitud {group.Key}: {string.Join(", ", group)}");
            }

            // f. Obtener los primeros 3 nombres ordenados alfabéticamente
            var firstThreeNames = names.OrderBy(name => name).Take(3).ToList();
            Console.WriteLine("\nPrimeros 3 nombres ordenados alfabéticamente:");
            firstThreeNames.ForEach(Console.WriteLine);

            // g. Verificar si algún nombre contiene la letra 'e'
            var containsLetterE = names.Any(name => name.Contains('e'));
            Console.WriteLine($"\n¿Algún nombre contiene la letra 'e'? {containsLetterE}");

            // h. Encontrar el primer nombre que tenga exactamente 5 letras
            var firstNameWith5Letters = names.FirstOrDefault(name => name.Length == 5);
            Console.WriteLine($"\nEl primer nombre con exactamente 5 letras es: {firstNameWith5Letters}");
        }
    }
}
