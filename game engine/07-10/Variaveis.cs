using System;

class Variaveis
{

     static void Main (string [] args) {
        //Aqui criei uma variavel de numero inteiro, com  o valor 15 
            int numero = 15;
        Console.WriteLine (numero + 20);
        Console.WriteLine (numero + 30);
        Console.WriteLine (numero + 70);
        Console.WriteLine (numero + 100);

        //Comentario de uma linha só se usa duas barra
        /*
        Comentario de mais de uma linha se usa barra e Asterisco
        */

        /* EXERCICIO 1: Variaveis 
        - Crie um novo arquivo
        - Chame ele de Exercicio 1 
        - Coloque dentro ele o código base.
        -Crie 4 variaveis int. 
        */


        int idade = 17;                                   //Numero inteiro
        double altura  = 1.68;                          //Numero com ponto flutuante
        char inicial = 'G';                              //Um unico caractere
        string nome = "Giovana Mücke Vijalva";           //texto
        bool aprovado = true;                            // Verdadeiro ou falso

        Console.WriteLine($"Meu nome é {nome}. Tenho {idade} anos. Minha altura é {altura}. Meu nome começa com a letra {inicial}. Estou aprovado na Escola? {aprovado}");

     }
}