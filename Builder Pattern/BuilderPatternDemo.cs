using Builder_Pattern.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    class BuilderPatternDemo
    {
        static void Main(string[] args)
        {
            MealBuilder mealBuilder = new MealBuilder();

            Meal vegMeal = mealBuilder.PrepareVegMeal();
            Console.WriteLine("Veg Meal");
            vegMeal.ShowItems();
            Console.WriteLine("Total Cost:" + vegMeal.GetCost());

            Console.WriteLine();

            Meal nonVegMeal = mealBuilder.PrepareNonVegMeal();
            Console.WriteLine("Non_Veg Meal");
            nonVegMeal.ShowItems();
            Console.WriteLine("Total Cost:" + nonVegMeal.GetCost());
        }
    }
}
