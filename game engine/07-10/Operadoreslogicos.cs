using System;

class Operadoreslogicos
{
     static void Main (string [] args) {
        bool temCarteira = false;
        int idade = 29;
        bool  maiorIdade = idade >= 18;

        Console.WriteLine($"Para poder dirigir, uma pessoa precisa ter carteira e ter 18 anos ou mais.");
        Console.WriteLine($"Você tem carteira: {temCarteira}.");
        Console.WriteLine($"Você é de maior: {maiorIdade}.");

        Console.WriteLine(temCarteira == true && maiorIdade == true);


        //Operador Lógico OU (OR): retorna false apenas se todos forem false. Apenas um unico true  já é suficiente para que a equação retorne true.

        bool temTrabalho = true;
        bool economiza = true;
        bool investe = true;

        bool nasceuHerdeiro = false;

        Console.WriteLine((temTrabalho && economiza && investe) || nasceuHerdeiro);

        //Operador Lógico Não/Negação (NOT): inverte o estado. Se algo retorna true, ele  transforma em false e vice-versa 

        //!true; // false
        //!false; // true

        bool ligado = true;
        Console.WriteLine( !ligado);


     }
}