using System;

public class Cobra : Reptil
{
    public Cobra (string nome, int idade, double comprimento) : base(nome, idade) { }

    public override string EmitirSom()
    {
        return "sssssss";
    }
}