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

    //CRIE UMA CLASSE CHAMADA INIMIGO, PENSE EM QUAIS ATRIBUTOS DEVE TER E OQUE ELE DEVE FAZER(OU SEJA, SEUS MÉTODOS). Depois que criar esta classe, crie um objeto com ela, dentro da classe jogo e chame os métodos.//

}