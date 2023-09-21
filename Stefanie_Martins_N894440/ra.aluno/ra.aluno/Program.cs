using System;

class Aluno
{
    public virtual string GetNome()
    {
        return "";
    }
}

class AlunaStefanie : Aluno
{
    public override string GetNome()
    {
        return "Stefanie Martins F.";
    }

    public string GetRA()
    {
        return "n89444";
    }
}
class Program
{
    static void Main(string[] args)
    {
        Aluno stefanie = new AlunaStefanie();
        Console.WriteLine("RA: " + ((AlunaStefanie)stefanie).GetRA());
        Console.WriteLine("Nome: " + stefanie.GetNome());
    }
}
