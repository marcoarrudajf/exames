using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExameMedico
{
    internal class Colesterol : Exame
    {
        private double hdl;
        private double ldl;
        private string riscoPac;
        private string classificaLDL;
        private string classificaHDL;

        public double getHdl() { return hdl; }
        public void setHdl(double hdl) { this.hdl = hdl; }
        public double getLdl() { return ldl; }

        public void setLdl(double ldl)
        {
            this.ldl = ldl;
        }

        public string getRiscoPac() { return riscoPac; }

        public void setRiscoPac(string riscoPac)
        {
            const string riscoAlto = "A";
            const string riscoMedio = "M";
            const string riscoBaixo = "B";

            switch (riscoPac.ToUpper())
            {
                case riscoAlto:
                case riscoMedio:
                case riscoBaixo:
                    this.riscoPac = riscoPac.ToUpper();
                    break;
                default:
                    Console.WriteLine("Por gentileza inserir a letra correta para o tipo de risco. A = Alto / B = Baixo / M = Médio");                    
                    this.setRiscoPac(Console.ReadLine());
                    break;
            }
        }

        public string getClassificaHDL()
        {
            return classificaHDL;
        }

        public void setClassificaHDL(string classificaHDL)
        {
            this.classificaHDL = classificaHDL;
        }
        public string getClassificaLDL()
        {
            return classificaLDL;
        }
        public void setClassificaLDL(string classificaLDL)
        {
            this.classificaLDL = classificaLDL;
        }

        public void realizarExameColesterol()
        {
            base.realizarExame();
            Console.WriteLine("Digite a quantidade de HDL por mg/l: ");
            double qtdHdl = double.Parse(Console.ReadLine());
            this.setHdl(qtdHdl);

            Console.WriteLine("Digite a quantidade de LDL por mg/l: ");
            double qtdLdl = double.Parse(Console.ReadLine());
            this.setLdl(qtdLdl);

            Console.WriteLine("Digite o tipo de risco do paciente: ");
            string risco = (Console.ReadLine());
            this.setRiscoPac(risco);
        }

        public void validarCriterios()
        {
            double maxLdlRiscoAlto = 50.0;
            double maxLdlRiscoMedio = 70.0;
            double maxLdlRiscoBaixo = 100.0;
            double minHdlAte19Anos = 45.0;
            double minHdlApos19Anos = 40.0;
            if (this.getLdl() < maxLdlRiscoAlto && this.getRiscoPac() == "A")
            {
               setClassificaLDL("Classificação: LDL BOM");
            }else if(this.getLdl() < maxLdlRiscoMedio && this.getRiscoPac() =="M")
            {
               setClassificaLDL("Classificação: LDL BOM");
            } else if(this.getLdl() < maxLdlRiscoBaixo && this.getRiscoPac() == "B")
            {
               setClassificaLDL("Classificação: LDL BOM");
            }
            else
            {
                setClassificaLDL("Classificação: LDL RUIM");
            } 
            
            if((base.getIdade() <= 19 && this.getHdl() > minHdlAte19Anos) || (base.getIdade() >= 20 && this.getHdl() > minHdlApos19Anos ))
            {
                setClassificaHDL("Classificação: HDL BOM");
            }
            else
            {
                setClassificaHDL("Classificação: HDL RUIM");
            }
        }

        public void mostrarExame()
        {
            validarCriterios();

            Console.WriteLine("\n----------------------------------\n");

            Console.WriteLine($"Nome do paciente: {base.GetNome()}\nTipo sanguíneo: {base.GetTSangue()}\nAno de nascimento: {base.getAnoNasc()} " +
                $"\nIdade: {this.getIdade()} anos. \nQuantidade de HDL: {this.getHdl()} mg/l \nQuantidade de LDL: {this.getLdl()} mg/l" +
                $"\nTipo de risco: {this.getRiscoPac()} \nResultado do exame de HDL:  {this.getClassificaHDL()} \nResultado do exame de LDL: {this.getClassificaLDL()}");

            Console.WriteLine("\n----------------------------------\n");
        }
    }
}
