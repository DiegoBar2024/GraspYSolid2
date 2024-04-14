using System;
using Full_GRASP_And_SOLID.Library;

namespace Full_GRASP_And_SOLID
{
    // Clase ConsolePrinter
    // Responsabilidades: Imprimir una receta en la consola
    // Colaboraciones: Con la clase Recipe para conocer la receta
    public class ConsolePrinter
    {
        // Hago un método de clase que se encargue de efectuar la impresión
        public static void PrintRecipe(Recipe recipe)
        {
            // Hago el llamado al método GetRecipeText que me devuelve la cadena a imprimir
            Console.WriteLine(recipe.GetRecipeText());
        }
    }
}

/*
Para implementar éste cambio se utilizó el principio SRP (Single Responsibility Principle)
La responsabilidad de imprimir la receta que estaba asignada en principio a la clase Recipe fue reasignada a la clase ConsolePrinter
De éste modo, ConsolePrinter contiene un método de clase el cual implementa la impresión de la receta recibiendo como entrada un objeto receta de la clase Recipe
Como resultado, la responsabilidad de la impresión del ticket se redistribuyó de manera que ahora Recipe genera la cadena de texto y ConsolePrinter se encarga de imprimirla
Por otro lado se modificó la clase Step de manera que generara su propia cadena asociada al paso (patron Expert) y se la pasara a la clase Recipe para construir la cadena de la receta
De ésta manera, para construir la cadena asociada a la receta de cocina, la clase Recipe tiene que colaborar también con Step para obtener la cadena asociada a cada paso
*/