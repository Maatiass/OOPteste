using System;

public class Leão : Mamifero
{
    public Leão(string nome, int idade, double comprimento, int TamanhoDoGrupo) : base(nome, idade) { }

    public override string EmitirSom()
    {
        return "rawr";
    }
}

