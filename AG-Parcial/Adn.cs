using AG_Parcial.Utils;

namespace AG_Parcial
{
    public class Adn
    {
        private const string letras = " 012345678ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz!'#$%&\\/()=¿?¡ÁÉÍÓÚáéíóú.,;:\"";
        public char[] genes { get; set; }
        public double fitness { get; set; }

        //Constructor clase ADN
        public Adn(int num)
        {
            genes = new char[num];
            for (int i = 0; i < genes.Length; i++)
            {
                genes[i] = letras[RandomGenerator.Random_entero(0, letras.Length)];
            }
        }

        //Convertimos nuestra cadena de caracteres a string
        public string ConseguirADN()
        {
            return new string(genes);
        }

        //Calculamos la aptitud comparando elemento a elemento el string del ADN con el objetivo
        public double Fitness(string objetivo)
        {
            int puntos = 0;
            for (int i = 0; i < genes.Length; i++) 
            {
                if (genes[i] == objetivo[i]) 
                    puntos++;
            } 
            fitness = (double)puntos / (double)objetivo.Length;
            return fitness;
        }

        //Se mezcla la información entre dos ADN  para crear un hijo
        public Adn Reproduccion(Adn padre)
        {
            int punto_cruce = RandomGenerator.Random_entero(0, genes.Length);
            Adn hijo = new Adn(genes.Length);
            for (int i = 0; i < genes.Length; i++)
            {
                if (i < punto_cruce)
                {
                    hijo.genes[i] = genes[i];
                }
                else
                {
                    hijo.genes[i] = padre.genes[i];
                }
            }
            return hijo;
        }

        //Se muta(modifica) el elemento del ADN si el numero obtenido aleatoriamente es menor que la tasa de mutación
        public void Mutacion(double tasa_mutacion)
        {
            for (int i = 0; i < genes.Length; i++)
            {
                if (RandomGenerator.Random_decimal() < tasa_mutacion)
                {
                    genes[i] = letras[RandomGenerator.Random_entero(0, letras.Length)];
                }
            }
        }

    }
}
