using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Instancia um novo objeto de determinada classe onde serão armazenados dados nas propriedades da classe
              e a possibilidade de utilizar seus métodos.
              Sintaxe:
              Classe nomeObjeto = new Classe();
              Classe nomeObjeto = new Classe(parametros);
             */
            Carro Uno = new Carro("an6fkd4nf895a", "Vermelho", "Escuro", "Fiat", 1, 2018);
            Carro Gol = new Carro("kf6dcfk56895a", "Cinza", "Claro", "Volkswagen", 1, 2017);
            Console.WriteLine("A cor do Uno é: " + Uno.Cor);
            Console.WriteLine("A cor do Gol é: " + Gol.Cor);
            Uno.AlteraCor("Preto");
            Console.WriteLine("A nova cor do Uno é: " + Uno.Cor);
            Console.WriteLine("O chassi do Uno é:  " + Uno.PegaChassi());
        }
    }
}
