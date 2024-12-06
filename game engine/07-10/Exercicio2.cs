using System;

class Exercicios2
{
     static void Main (string [] args) {
        int nota1 = 10;
        double nota2 = 5.9;
        double nota3 = 9.9;
        int nota4 = 3;

        //Aqui eu criei/declarei minha variavel
        double soma;
        //Aqui, eu troquei o valor dela
        soma = nota1 + nota2 + nota3;
        Console.WriteLine(soma);
    

        double media;
        media = soma / nota4;
        Console.WriteLine(media);


        int par1 = 2;
        int par2 = 44;
        int par3 = 32;
        int par4 = 100;
        int par5 = 286;

        int impar1 = 599;
        int impar2 = 53;
        int impar3 = 687;
        int impar4 = 333;
        int impar5 = 11;


        Console.WriteLine(par1%2);
        Console.WriteLine(par2%2);
        Console.WriteLine(par3%2);
        Console.WriteLine(par4%2);
        Console.WriteLine(par5%2);


        Console.WriteLine(impar1%2);
        Console.WriteLine(impar2%2);
        Console.WriteLine(impar3%2);
        Console.WriteLine(impar4%2);
        Console.WriteLine(impar5%2);


     }
}