using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace victor.Models;

public class Folha
{
	public Folha(double quantidade, double valor)
	{
		Quantidade = quantidade;
		Valor = valor;
		CalcularBruto();
		calcularFGTS();
		calcularIr();
		CalcularInss();
		calcularLiquido();
	}

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
	public double Liquido { get; set; }
	public double Bruto { get; set; }
	public double Ir { get; set; }
	public double Fgts { get; set; }
	public double Inss { get; set; }

	[ForeignKey("Funcionario")]
	public int FuncionarioId { get; set; }
	public Funcionario Funcionario { get; private set; }


	private void CalcularBruto() =>
		Bruto = Valor * Quantidade;

	private void calcularIr()
	{
		if (Bruto <= 1903.98)
			Ir = 0;
		else if (Bruto <= 2826.65)
			Ir = Bruto * .075 - 142.8;
		else if (Bruto <= 3751.05)
			Ir = Bruto * .15 - 354.8;
		else if (Bruto <= 4664.68)
			Ir = Bruto * .225 - 636.13;
		else
			Ir = Bruto * .275 - 869.36;
	}

	private void calcularFGTS()
	{
		Fgts = Bruto * (100 / 8);
	}

	private void CalcularInss()
	{
		if (Bruto <= 1693.72)
			Inss = Bruto * .08;
		else if (Bruto <= 2822.9)
			Inss = Bruto * .09;
		else if (Bruto <= 5645.8)
			Inss = Bruto * .11;
		else
			Inss = 621.03;
	}

	private void calcularLiquido()
	{
		Liquido = Bruto - Ir - Fgts - Inss;
	}
}
