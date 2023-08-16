using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ExameMedico
{
    internal class Glicemia : Exame
    {
        private double glicemia;
        private string resultadoGlicemico = "";

        public double getGlicemia()
        {
            return glicemia;
        }
        public void setGlicemia(double glicemia)
        {
            this.glicemia = glicemia;
        }

        public string getResultadoGlicemico()
        {
            return resultadoGlicemico;
        }
        public void setResultadoGlicemico(string resultadoGlicemico)
        {
            this.resultadoGlicemico = resultadoGlicemico;
        }

       
        public void realizarExameGlicemia()
        {
            base.realizarExame();
            Console.WriteLine("Digite a quantidade de glicemia por mg/l: ");
            double qtdGlicemia = double.Parse(Console.ReadLine());
            setGlicemia(qtdGlicemia);
        }

        public void validarCriterios()
        {
            int maiorValorNormal = 100;
            int maiorValorPreDiabetes = 126;

            if(this.getGlicemia() < maiorValorNormal)
            {
               this.setResultadoGlicemico("Classificação Normoglicemia");
            } else if(this.getGlicemia() < maiorValorPreDiabetes)
            {
                this.setResultadoGlicemico("Classificação Pré-diabetes");
            }
            else
            {
                this.setResultadoGlicemico("Classificação Diabetes estabelicida");
            }
        }

        public void mostrarExame()
        {
            validarCriterios();

            Console.WriteLine("\n----------------------------------\n");
            Console.WriteLine($"Nome do paciente: {base.GetNome()}\nTipo sanguíneo: {base.GetTSangue()}\nAno de nascimento: {base.getAnoNasc()} " +
                $"\nIdade: {this.getIdade()} anos. \nQuantidade de glicemia: {this.getGlicemia()} mg/l \nResultado do exame de glicemia: {this.getResultadoGlicemico()}");
            Console.WriteLine("\n----------------------------------\n");
        }


    }
}
