using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
}
