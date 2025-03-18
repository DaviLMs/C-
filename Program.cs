using System;
using System.Collections.Generic;  // Necessário para usar List<T>

class Primitivos
{
    static void Main(string[] args)
    {
        // Declaração e atribuição de variáveis primitivas
        int valor = 10;
        Console.WriteLine("Valor: " + valor);

        float valor2 = 10.5f;  // Lembre-se de adicionar o 'f' para float
        Console.WriteLine("Valor2: " + valor2);

        string valor3 = "olá";
        Console.WriteLine("Valor3: " + valor3);

        bool valor4 = true;
        Console.WriteLine("Valor4: " + valor4);

        // Chamada de método Teste()
        Teste();

        // Estrutura condicional com OR (||)
        if (valor4 == true || valor3 == "olá")
        {
            Console.WriteLine("Verdadeiro");
        }
        else
        {
            Console.WriteLine("Falso");
        }

        // Array simples
        int[] arrayzinha = new int[] { 1, 2, 3 };

        // List<T> (Lista de inteiros)
        List<int> lista = new List<int>() { 1, 2, 3 };
        lista.Add(4);  // Adicionando um novo valor à lista
        lista.Remove(2);  // Removendo o valor 2 da lista
        Console.WriteLine(lista);

        // Exibindo os valores do array
        for (int i = 0; i < arrayzinha.Length; i++)
        {
            Console.WriteLine(arrayzinha[i]);
        }

        // Chamada do método show()
        show();

        // Método para calcular a soma de dois números
        int resultado = CalcularSoma(10, 20);
        Console.WriteLine("Resultado da soma: " + resultado);

        // Chamada ao método 'apresentacao()' para exibir uma mensagem personalizada
        string frase = apresentacao("João", 20, "programador");
        Console.WriteLine(frase);
    }

    // Método simples que exibe a palavra "Teste"
    static void Teste()
    {
        Console.WriteLine("Teste");
    }

    // Método para calcular a soma de dois números inteiros
    static int CalcularSoma(int numero1, int numero2)
    {
        int resultado = numero1 + numero2;
        return resultado;
    }

    // Método para apresentar uma frase com nome, idade e profissão
    static string apresentacao(string none, int idade, string profissao)
    {
        string frase = "Olá, meu nome é " + none + ", tenho " + idade + " anos e sou " + profissao;
        return frase;
    }

    // Método show() que exibe "show"
    static void show()
    {
        Console.WriteLine("show");
    }

}
