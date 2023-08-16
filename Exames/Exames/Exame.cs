using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExameMedico
{
    public class Exame

    {
        DateTime dataAtual = DateTime.Now;
        private string nome;
        private string tSangue;
        private int anoNasc;
        private int idade;


        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome.ToUpper();
        }

        public string GetTSangue()
        {
            return tSangue;
        }

        public void setTSangue(string tSangue)
        {
            this.tSangue = tSangue.ToUpper();
        }

        public int getAnoNasc()
        {
            return anoNasc;
        }
        public int getIdade()
        {
            return idade;
        }
        public void setAnoNasc(int anoNasc)
        {
            this.idade = dataAtual.Year - anoNasc;
            this.anoNasc = anoNasc;
        }

        public void realizarExame()
        {
            Console.WriteLine("Digite o nome do paciente: ");
            string nomePaciente = Console.ReadLine();
            SetNome(nomePaciente);

            Console.WriteLine("Digite o tipo sanguíneo: ");
            string tipoSanguineo = Console.ReadLine();
            setTSangue(tipoSanguineo);

            Console.WriteLine("Ano de nascimento:");
            int anoNascimento = int.Parse(Console.ReadLine());
            setAnoNasc(anoNascimento);

        }

        public void escolherExame()
        {
            int opcao;
            do
            {
                Console.WriteLine("\tEscolha o tipo de exame: \n\t1 - Exame de Glicemia: \n\t2 - Exame de Colesterol: \n\t3 - Exame de Triglicerídeos: \n\t0 - Sair");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Glicemia glicemia = new Glicemia();
                        glicemia.realizarExameGlicemia();
                        glicemia.mostrarExame();
                        break;
                    case 2:
                        Colesterol colesterol = new Colesterol();
                        colesterol.realizarExameColesterol();
                        colesterol.mostrarExame();
                        break;
                    case 3:
                        Triglicerideos triglicerideos = new Triglicerideos();
                        triglicerideos.realizarExameTriglicerideos();
                        triglicerideos.mostrarExame();
                        break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Obrigado por usar nossos serviços!");

                        break;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                        break;
                }

            } while (opcao != 0);
        }
    }
}