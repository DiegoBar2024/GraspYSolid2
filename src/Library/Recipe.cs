//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;
using System.Text;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        public string GetRecipeText()
        {
            // Inicializo la variable en la cual voy a almacenar la cadena a retornar
            StringBuilder recipeText = new StringBuilder($"Receta de {this.FinalProduct.Description}:\n");

            // Itero para cada uno de los pasos
            foreach (Step step in this.steps)
            {
                // Concateno la cadena correspondiente con la cadena del paso correspondiente
                recipeText.AppendLine(step.GetStepText());
            }

            // Retorno la cadena correspondiente transformado a string
            return recipeText.ToString();
        }
    }
}