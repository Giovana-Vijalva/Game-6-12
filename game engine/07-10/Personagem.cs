using System;

class Personagem
{

   //Atributos - são variaveis que minha classe usa//
    public string nome;
    public int forca;
    public int vida;

   //construtor -  é uma função/método que define como os objetos são criados. Ela é chamada toda vez que criamos um objeto com essa classe//
    public Personagem(string nomepersonagem, int forcainicial, int vidainicial){
        nome = nomepersonagem;
        forca = forcainicial;
        vida = vidainicial;
    }

   //Métodos - são as funções que representam o que o objeto dessa classe pode fazer

    public void Atacar(){
        Console.WriteLine($"{nome} ataca com {foca} pontos de forca.");
        }

    public void Andar(){
        Console.WriteLine($"{nome} esta andando.");
    }



}
class Jogo 
{
    static void main (string[] args){
        //Criar  um personagem
        Personagem personagem1 = new Personagem ("Cristhopper", 15, 100);

        //usando os métodos do personagem
        personagem1.Atacar();
        personagem1.Andar();
    }




using System;

class inimigo
{
  
    public string nome;
    public int defesa;
    public int vida;


    public inimigo(string nomeinimigo, int defesainicialinicial, int vidainicial){
        nome = nomepersonagem;
        defesa = defesainicial;
        vida = vidainicial;
    }


    public void atacar(){
        Console.WriteLine($"{nome} está te atancando {defesa} pontos de defesa.");
        }

    public void atacar(){
        Console.WriteLine($"{nome} esta andando em sua direção.");
    }

}
class Jogo 
{
    static void main (string[] args){
        
        Personagem personagem = new Personagem ("inimigo", 20, 100);
        inimigo.atacar(personagem1);
        inimigo.andar();
    }

    

}
    //CRIE UMA CLASSE CHAMADA INIMIGO, PENSE EM QUAIS ATRIBUTOS DEVE TER E OQUE ELE DEVE FAZER(OU SEJA, SEUS MÉTODOS). Depois que criar esta classe, crie um objeto com ela, dentro da classe jogo e chame os métodos.//

}