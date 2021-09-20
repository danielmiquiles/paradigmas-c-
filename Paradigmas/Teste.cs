using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paradigmas
{
	class Teste
	{
		public static void Main(String[] args)
		{
			// TODO Auto-generated method stub

			int escolha;

			do
			{
				Console.WriteLine("Escolha a questão:");
				Console.WriteLine("1 - Questão 1: ");
				Console.WriteLine("2 - Questão 2: ");
				Console.WriteLine("3 - Questão 3: ");
				Console.WriteLine("4 - Questão 4: ");
				Console.WriteLine("5 - Questão 5: ");
				Console.WriteLine("6 - Sair: ");

				escolha = int.Parse(Console.ReadLine());

				switch (escolha)
				{
					case 1:
						{
							questao1();
							break;
						}
					case 2:
						{
							questao2();
							break;
						}
					case 3:
						{
							questao3();
							break;
						}
					case 4:
						{
							questao4();
							break;
						}
					case 5:
						{
							questao5();
							break;
						}
				}

			} while (escolha != 6);

		}

		public static void questao1()
		{


			Pessoa pessoa1 = new Pessoa();
			Console.WriteLine("Dados da primeira pessoa:");
			Console.WriteLine("Nome: ");
			pessoa1.setNome(Console.ReadLine());

			Console.Write("Idade: ");
			pessoa1.setIdade(int.Parse(Console.ReadLine()));

			Pessoa pessoa2 = new Pessoa();
			Console.WriteLine("Dados da segunda pessoa:");
			Console.Write("Nome: ");
			pessoa2.setNome(Console.ReadLine());

			Console.Write("Idade: ");
			pessoa2.setIdade(int.Parse(Console.ReadLine()));

			Console.Write(Pessoa.idoso(pessoa1, pessoa2));
		}

		public static void questao2()
		{
			Funcionario funcionario1 = new Funcionario();
			Console.WriteLine("Dados do primeiro funcionário:");
			Console.Write("Nome: ");
			funcionario1.setNome(Console.ReadLine());

			Console.Write("Salário: ");
			funcionario1.setSalario(double.Parse(Console.ReadLine()));

			Funcionario funcionario2 = new Funcionario();
			Console.WriteLine("Dados do segundo funcionário:");
			Console.Write("Nome: ");
			funcionario2.setNome(Console.ReadLine());

			Console.Write("Salário: ");
			funcionario2.setSalario(double.Parse(Console.ReadLine()));

			Console.Write("Salário médio: ");
			Console.Write(Funcionario.media(funcionario1.getSalario(), funcionario2.getSalario()));
		}

		public static void questao3()
		{
			Retangulo retangulo = new Retangulo();
			Console.WriteLine("Entre com a largura do retângulo: ");
			retangulo.setLargura(double.Parse(Console.ReadLine()));
			Console.WriteLine("Entre com a altura do retângulo: ");
			retangulo.setAltura(double.Parse(Console.ReadLine()));

			Console.WriteLine("ÁREA: {0:0.00} \n", retangulo.area());
			Console.WriteLine("PERÍMETRO: {0:0.00} \n", retangulo.perimetro());
			Console.WriteLine("DIAGONAL: {0:0.00} \n", retangulo.diagonal());
		}

		public static void questao4()
		{
			Funcionario funcionario = new Funcionario();
			Console.Write("Nome: ");
			funcionario.setNome(Console.ReadLine());


			Console.Write("Salário bruto: ");
			funcionario.setSalarioBruto(double.Parse(Console.ReadLine()));


			Console.Write("\nFuncionário: {0}, R$ {1:0.00}\n", funcionario.getNome(), funcionario.salarioLiquido());

			Console.Write("Digite a porcentagem para aumentar o salário: ");
			funcionario.aumentarSalario(double.Parse(Console.ReadLine()));

			Console.Write("\n");

			Console.Write("Dados atualizados: {0}, R$ {1:0.00}", funcionario.getNome(), funcionario.salarioLiquido());
		}

		public static void questao5()
		{
			double alvo = 60;

			Aluno aluno = new Aluno();
			Console.Write("Nome do Aluno: ");
			aluno.setNome(Console.ReadLine());


			Console.Write("Nota do primeiro trimestre: ");
			aluno.setNota1(double.Parse(Console.ReadLine()));

			Console.Write("Nota do segundo trimestre: ");
			aluno.setNota2(double.Parse(Console.ReadLine()));

			Console.Write("Nota do terceiro trimestre: ");
			aluno.setNota3(double.Parse(Console.ReadLine()));

			double notaFinal = aluno.notaFinal();

			Console.Write("\n", notaFinal);


			Console.Write("NOTA FINAL = {0:0.00}\n", notaFinal);
			aluno.setStatus();

			Console.Write(aluno.getStatus());

			if (notaFinal < alvo)
			{
				Console.Write("\nFALTARAM {0:0.00} PONTOS", aluno.notaFaltante(notaFinal));
			}
		}


	}
}
