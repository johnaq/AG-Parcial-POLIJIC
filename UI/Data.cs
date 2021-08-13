using System.ComponentModel;

namespace UI
{
    public class Data
    {
        [DisplayName("Generación")]
        public int Generacion { get; set; }

        [DisplayName("Mejor Individuo")]
        public string Mejor_Individuo { get; set; }

        [DisplayName("Fitness")]
        public double Fitness { get; set; }
    }
}
