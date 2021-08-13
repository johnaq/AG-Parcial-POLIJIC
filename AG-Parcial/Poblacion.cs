using AG_Parcial.Utils;
using System.Collections.Generic;
using System.Linq;

namespace AG_Parcial
{
    public class Poblacion
    {
        public int generacion { get; set; } = 1;
        public Adn[] poblacion { get; set; }
        readonly List<Adn> contenedor;
        readonly double tasa_mutacion;
        readonly string objetivo;

        //Constructor de la población
        public Poblacion(double tm, int num, string objetivo)
        {
            this.objetivo = objetivo;
            tasa_mutacion = tm;
            poblacion = new Adn[num];

            for (int i = 0; i < poblacion.Length; i++)
            {
                poblacion[i] = new Adn(objetivo.Length);
            }

            contenedor = new List<Adn>();
            Calcular_funcion_fitness();
        }

        //Se calcula la función fitness de cada uno de los individuos de la población. La función fitness es de 0 a 1
        public void Calcular_funcion_fitness()
        {
            foreach (var item in poblacion)
            {
                item.Fitness(objetivo);
            }
        }

        //Se le asigna al contenedor cuantas veces sea un individuo en proporción a su aptitud. Mayor aptitud, mayor veces estará ese individuo en nuestro contenedor
        public void Seleccion()
        {
            double val_Max = 0;
            contenedor.Clear();

            val_Max = poblacion.Max(t => t.fitness);

            for (int i = 0; i < poblacion.Length; i++)
            {
                double map_aptitud = Map(poblacion[i].fitness, 0, val_Max, 0, 1);
                int numero = (int)(map_aptitud) * 100;

                for (int j = 0; j < numero; j++) 
                {
                    contenedor.Add(poblacion[i]);
                }
            }
        }

        /*Se selecciona al azar individuos de nuestro contenedor para realizar su cruce, obtener el hijo
        y remplazar la antigua generación con los nuevos hijos*/

        public void Cruce()
        {
            for (int i = 0; i < poblacion.Length; i++)
            {
                int A = RandomGenerator.Random_entero(0, contenedor.Count - 1);
                int B = RandomGenerator.Random_entero(0, contenedor.Count - 1);
                Adn madre = contenedor[A];
                Adn padre = contenedor[B];
                Adn hijo = madre.Reproduccion(padre);
                hijo.Mutacion(tasa_mutacion);
                poblacion[i] = hijo;
            }
            generacion++;
        }

        //Se selecciona el mejor individuo de la generación para retornar su string
        public string Mejor_individuo()
        {
            double max = poblacion.Max(t => t.fitness);
            var g = poblacion.First(t => t.fitness == max).genes;

            return new string(g);
        }

        // Se calcula el promedio de aptitud por generación
        public double Promedio()
        {
            double promedio = 0;
            for (int i = 0; i < poblacion.Length; i++) promedio += poblacion[i].fitness;
            return promedio / (poblacion.Length);
        }

        //Método de mapeo
        double Map(double val, double x1, double x2, double y1, double y2)
        {
            return ((val - x1) / (x2 - x1)) * (y2 - y1) + y1;
        }
    }
}
