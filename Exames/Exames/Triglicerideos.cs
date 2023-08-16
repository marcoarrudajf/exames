using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExameMedico
{
    internal class Triglicerideos : Exame
    {
        private double triglicerideos;
        private String ResultadoTriglicerideos = "";

        public double getTriglicerideos()
        {
            return triglicerideos;
        }
        public void setTriglicerideos(double triglicervideos)
        {
            this.triglicerideos = triglicervideos;
        }

        public String getResultadoTriglicerideos()
        {
            return ResultadoTriglicerideos;
        }
        public void setResultadoTriglicerideos(String resultadoTriglicervideos)
        {
            this.ResultadoTriglicerideos = resultadoTriglicervideos;
        }

        public void realizarExameTriglicerideos()
        {
            base.realizarExame();
            Console.WriteLine("Digite a quantidade de triglicérides por mg/l: ");
            double qtdTriglicerides = double.Parse(Console.ReadLine());
            setTriglicerideos(qtdTriglicerides);
        }
        public void validarCriterios()
        {
            if (base.getIdade() <= 9 && this.getTriglicerideos() < 75)
            {
                this.setResultadoTriglicerideos("triglicerideos - BOM");
            }
            else if ((base.getIdade() > 9 && base.getIdade() <= 19) && this.getTriglicerideos() < 90)
            {
                this.setResultadoTriglicerideos("Triglicerideos - BOM");
            }
            else if (base.getIdade() > 19 && this.getTriglicerideos() < 150)
            {
                this.setResultadoTriglicerideos("Triglicerideos - BOM");
            }
            else
            {
                this.setResultadoTriglicerideos("Triglicerideos - RUIM");
            }
        }

        public void mostrarExame()
        {
            validarCriterios();
            Console.WriteLine("\n----------------------------------\n");
            Console.WriteLine($"Nome do paciente: {base.GetNome()}\nTipo sanguíneo: {base.GetTSangue()}\nAno de nascimento: {base.getAnoNasc()} \nIdade: {this.getIdade()} anos. " +
                $"\nQuantidade de triglicérides: {this.getTriglicerideos()} mg/l\nResultado do exame de Triglicerideos: {this.getResultadoTriglicerideos()}");
            Console.WriteLine("\n----------------------------------\n");
        }

    }
}
