﻿using System;
using System.Collections.Generic;

public class Reptil : Animal
{
    public Reptil(string nome, int idade) : base(nome, idade) { }

    public override string EmitirSom()
    {
        return "";
    }
}