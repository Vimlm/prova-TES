using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace victor.Models;

public class Funcionario
{
	public Funcionario()
	{
	}

	public Funcionario(string nome, string cpf, int id, Folha folha)
	{
		Nome = nome;
		Cpf = cpf;
		Id = id;
		Folha = folha;
	}

	[Key]
	public int Id { get; set; }
	public string Nome { get; set; }
	public string Cpf { get; set; }


	[ForeignKey("Folha")]
	public int FolhaId { get; set; }
	public Folha Folha { get; private set; }
}
