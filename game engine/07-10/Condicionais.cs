//Condicionais são estruturas que permite um bloco de código só seja executado se obedecer uma determinada condição

using System;

class Condicionais
{
     static void Main (string [] args) {
        //Se eu tenho carteira
        bool temCarteira = true;
        bool  maiorIdade = 29 >= 18;

        if(temCarteira && maiorIdade){

            //Bloco de código que sera executado se a condição for verdadeira
            Console.WriteLine("Você pode dirigir.");
        }    else if  (temCarteira && maiorIdade) {
              Console.WriteLine("Você é maior de idade, mas não tem carteira. Portanto, não pode dirigir.");
        }
            else{
            Console.WriteLine("Você não pode dirigir.");
        }
        
        /*
        Para entrar na faculdade, uma pessoa precisa:


                1-Ter 18 anos ou mais
                2-Ter concluido o ensino medio
                3- Não estar em outra faculdade

        Faça um Console.Writeline que contenha a equação, usando operadores lógicos, que diz se uma pessoa pode ou não entrar na faculdade.
        */


     }
}