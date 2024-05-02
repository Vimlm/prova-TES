using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace victor.Models;

public class Folha
{


	public Folha()
	{
	}

	public Folha(double valor, double quantidade, int mes, int ano, Funcionario funcionario)
	{
		Valor = valor;
		Quantidade = quantidade;
		Mes = mes;
		Ano = ano;
		Funcionario = funcionario;
	}


	[Key]
	public int Id { get; set; }
	public double Valor { get; set; }
	public double Quantidade { get; set; }
	public int Mes { get; set; }
	public int Ano { get; set; }

	[ForeignKey("Funcionario")]
	public int FuncionarioId { get; set; }
	public Funcionario Funcionario { get; private set; }


	double bruto;

	public double calcularBruto(double valor, double quantidade)
	{
		return bruto = valor * quantidade;
	}

	public double calcularIR(double bruto)
	{

		if (bruto > 1903.98)
		{
			return 142.80;
		}
		else if (bruto > 2826.66)
		{
			return 354.80;
		}
		else if (bruto > 3751.06)
		{
			return 636.13;
		}
		else if (bruto > 4664.68)
		{
			return 869.36;
		}
		return 0;
	}

	public double calcularFGTS(double bruto)
	{
		return bruto / (8 / 100);
	}

	public double calcularLiquido(double bruto)
	{
		double liquido = calcularBruto(Valor,Quantidade) - calcularFGTS(bruto) - calcularIR(bruto);
		return liquido;
	}
}
