using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace victor.Models
{
	public class Funcionario
	{
		public Funcionario()
		{
		}

		public Funcionario(string nome, string cpf)
		{
			Id = Guid.NewGuid().ToString();
			Nome = nome;
			Cpf = cpf;
		}

		[Key]
		public string Id { get; set; }
		public string Nome { get; set; }
		public string Cpf { get; set; }
		public Folha Folha { get; set; }
	}
}