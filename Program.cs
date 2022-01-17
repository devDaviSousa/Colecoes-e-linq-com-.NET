using System;
using System.Collections.Generic;
using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Operações LINQ


            // ==> Dictionary

            // Dictionary<string, string> estados = new Dictionary<string, string>();

            // -> Adicionando, não pode colocar uma chave igual
            // estados.Add("SP", "São Paulo");
            // estados.Add("CE", "São Paulo");
            // estados.Add("BA", "Bahia");
            // -> Mostrando os Valores
            // foreach (KeyValuePair<string, string> item in estados)
            // {
            //     System.Console.WriteLine($"Chave {item.Key} , Valor {item.Value}");
            // }

            // -> Acessando Valor
            // string valorProcurado = "BA";
            // string valorApagar = "BA";
            //System.Console.WriteLine(estados[valorProcurado]);

            // -> Atualizando um Valor
            //estados[valorProcurado] = "Ba - Teste atualizado";

            // -> Removendo um valor
            // estados.Remove(valorApagar);

            // ==> Usando Pilha

            //Stack<string> pilha = new Stack<string>();

            // -> Adicionando elemento no topo
            //pilha.Push("Flamengo");
            //pilha.Push("Ceará");
            // pilha.Push("PSG");

            // -> Lendo uma Pilha
            //System.Console.WriteLine($"Times: {pilha.Count}");
            // while (pilha.Count > 0)
            // {
            //     //Pega o ultimo elemento mas não remove
            //     System.Console.WriteLine($"Proximo livro pra a leitura: {pilha.Peek()}");
            //     System.Console.WriteLine($"{pilha.Pop()}, time removido");
            // }
            // System.Console.WriteLine("=========");
            // System.Console.WriteLine($"Times: {pilha.Count}");




            // ==> Usando Filas

            // Queue<string> fila = new Queue<string>();

            // -> Adicionando elementos na fila
            // fila.Enqueue("Flamengo");
            // fila.Enqueue("Ceará");
            // fila.Enqueue("PSG");

            // -> Lendo a fila

            //while (fila.Count > 0)
            // {
            //chama o primeiro mas não remove
            //System.Console.WriteLine($"vez de : {fila.Peek()}");
            //chama o que ta no começo e retira
            //System.Console.WriteLine($"{fila.Dequeue()} atendido");
            // }

            //System.Console.WriteLine(fila.Count);

            // ==> Usando Listas<T>

            // OperacoesLista op = new OperacoesLista();

            // List<string> estados = new List<string>() { "CE", "SP", "MG" };
            // string[] estadosArray = new string[2] { "SC", "MT" };

            // ->Add elemento na Lista
            // estados.Add("CE");
            // estados.Add("SP");
            // estados.Add("RJ");

            // ->Colocar um array do msm tipo na coleção
            //estados.AddRange(estadosArray);
            //op.ImprimirLista(estados);
            //System.Console.WriteLine("Removendo");
            // -> Removendo elemento
            //estados.Remove("SP");
            //System.Console.WriteLine("======");

            // -> Inserir item em um indice especifico
            //estados.Insert(1, "RJ");
            //op.ImprimirLista(estados);

            // -> Convertendo o Tipo do Array

            // OperacaoArray op = new OperacaoArray();

            // int[] array = new int[5] { 1, 2, 3, 4, 5 };
            // int[] arrayCopia = new int[10];

            // string[] arrayString = op.ConverterParaArrayString(array);

            // ==> Aumentando o tamanho do Array

            // OperacaoArray op = new OperacaoArray();

            // int[] num = new int[5] { 1, -2, 3, 4, 20 };
            // int[] num2 = new int[10];

            // System.Console.WriteLine($"Capacidade do Array {num.Length}");
            // op.RedmensionarArray(ref num, num.Length * 2);
            // System.Console.WriteLine($"Capacidade do Array com Redimensionamento {num.Length}");


            // ==> Encontrar Indice do elemento

            // OperacaoArray op = new OperacaoArray();

            // int[] num = new int[] { 1, -2, 3, 4, 20 };
            // var valor = 20;

            // int indice = op.obterIndice(num, valor);

            // if (indice > -1)
            // {
            //     System.Console.WriteLine("O indice do elemento {0} é : {1}", valor, indice);
            // }
            // else
            // {
            //     System.Console.WriteLine("valor não existente do array");
            // }

            // ==> Encontrando um elemento no Array

            // OperacaoArray op = new OperacaoArray();

            // int[] num = new int[] { 1, -2, 3, 4,20 };
            // var valor = 20;

            // int todomaiorque = op.ObterValor(num, valor);

            // if (todomaiorque > 0)
            // {
            //     System.Console.WriteLine("valor encontrado");
            // }
            // else
            // {
            //     System.Console.WriteLine("valor nao encontrado");
            // }

            // ==> Verificando se todos elementos do array passam em uma condição

            // OperacaoArray op = new OperacaoArray();

            // int[] num = new int[] { 1, -2, 3, 4 };
            // var valor = 0;
            // bool todomaiorque = op.TodosMaiorQue(num, valor);

            // if (todomaiorque)
            // {
            //     System.Console.WriteLine("Todos os valores são maiores que 0");
            // }
            // else
            // {
            //     System.Console.WriteLine("Nem todo os valores são maiores que 0");
            // }

            // ==>Verificanto se um elemento no array

            // OperacaoArray op = new OperacaoArray();

            // int[] num = new int[] { 1, 2, 3, 4 };
            // bool exist = op.Existe(num, 2);

            // if (exist)
            // {
            //     System.Console.WriteLine("Numero encontrado");
            // }
            // else
            // {
            //     System.Console.WriteLine("numero nao encontrado");
            // }

            // ==> Ordenando Array BubbleSort

            // OperacaoArray op = new OperacaoArray();

            // int[] array = new int[5] { 5, 10, 7, 8, 3 };
            // int[] array = new int[10];

            // System.Console.WriteLine("Array inicial");
            // op.ImprimirArray(array);

            // System.Console.WriteLine("Array Ordenado");
            // op.OrdenarBubbleSort(ref array);
            // op.Ordenar(ref array);
            // op.ImprimirArray(array);

            // ==> Array multidimensional

            // int[,] matriz = new int[4, 2]
            // {
            //     {8,8},
            //     {10,5},
            //     {20,20},
            //     {30,40},
            // };

            // for (int i = 0; i < matriz.GetLength(0); i++)
            // {
            //     for (int j = 0; j < matriz.GetLength(1); j++)
            //     {
            //         System.Console.WriteLine(matriz[i, j]);
            //     }

            // }

            // ==> ARRAY

            // int[] num = new int[3];

            // num[0] = 1;
            // num[1] = 2;
            // num[2] = int.Parse("30");



            // for (int i = 0; i < num.Length; i++)
            // {
            //     System.Console.WriteLine(num[i]);

            // }

            // foreach (var item in num)
            // {
            //     System.Console.WriteLine(item);

            // }


        }
    }
}
