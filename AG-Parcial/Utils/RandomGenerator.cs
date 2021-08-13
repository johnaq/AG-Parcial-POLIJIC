using System;

namespace AG_Parcial.Utils
{
    public static class RandomGenerator
    {
        private static readonly Random random = new();

        //Generador de números aleatorios enteros entre n1 y n2-1
        public static int Random_entero(int n1, int n2)
        {
            return random.Next(n1, n2);
        }

        //Generador de números aleatorios decimales entre  0 y 1
        public static double Random_decimal()
        {
            return random.NextDouble();
        }
    }
}
