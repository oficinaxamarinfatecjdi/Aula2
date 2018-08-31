using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    //A classe Carro está herdando as propriedades da classe Automovel (que no caso é o Chassi), atravéz da herança.
    class Carro : Automovel
    {
        //Construtor: Método que possuí o mesmo nome da Classe que irá "construir" o nosso objeto, 
        //nele inicialisamos as propriedades atrávez dos valores passados
        public Carro(string chassi, string cor, string corVidro, string marca, int tipo, int ano)
        {
            Chassi = chassi;
            Cor = cor;
            CorVidro = corVidro;
            Marca = marca;
            Tipo = tipo;
            Ano = ano;
        }
        //Propriedades: variáveis pertencentes à classe;
        //Sintaxe: acesso tipo Nome {get; set;}
        public string Cor { get; set; }
        public string CorVidro { get; set; }
        public string Marca { get; set; }
        public int Tipo { get; set; }
        public int Ano { get; set; }
        /*Método sem retorno (void) que irá apenas executar uma determinada ação,
          nesse caso de alterar a propriedade Cor através do valor passado como parametro (variável do método).
          Sintaxe: 
          acesso tipo NomeMetodo (tipoArgumento nomeArgumento)
          {
            ...
          }*/
        public void AlteraCor(string cor)
        {
            Cor = cor;
        }
        /*Método com retorno (string) que irá executar uma determinada ação e retornar um valor desejado,
          nesse caso a propriedade Chassi.
          Sintaxe: 
          acesso tipo NomeMetodo (tipoArgumento nomeArgumento)
          {
             ...
             return valor;
          }*/
        public string PegaChassi()
        {
            return Chassi;
        }
    }
}
