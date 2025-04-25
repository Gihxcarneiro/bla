using System.Collections.Generic;
using System.Linq;

public class Repositorio
{
    public List<Funcionario> Funcionarios { get; private set; } = new List<Funcionario>();
    public List<Projeto> Projetos { get; private set; } = new List<Projeto>();

    public void AdicionarFuncionario(Funcionario f) => Funcionarios.Add(f);
    public void AdicionarProjeto(Projeto p) => Projetos.Add(p);

 public Funcionario BuscarFuncionario(string nome)
{
    return Funcionarios.FirstOrDefault(f => f.Nome.ToLower() == nome.ToLower());
}

public Projeto BuscarProjeto(string nome)
{
    return Projetos.FirstOrDefault(p => p.Nome.ToLower() == nome.ToLower());
}

}