using System;
using System.Xml;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] serieDeNumeros = new int[] {1,3,9};

            int i = serieDeNumeros.Length -1;

            while(serieDeNumeros[i] == 9 && i>=0){
                //enquanto i for válido
                serieDeNumeros[i--] = 0;
                }
            if(i<0){

                    //se i<0, ou seja, todos os números forem 9

                    //Assim, colocaremos um 1 no início do vetor -> 999 + 1 = 1000
                    Array.Resize(ref serieDeNumeros, i+ 1); //Redimensionar o vetor, adicionando 1 posição
                    serieDeNumeros[0] = 1; //primeiro número no vetor será 1
            }
            else{
                    //se não for o caso, iremos adicionar 1
                    serieDeNumeros[i]++;
            }
            //Esse será o retorno da nossa função
            Console.Write("[");
            for(int j=0; j<= serieDeNumeros.Length-1; j++){
                if(j == serieDeNumeros.Length-1){
                    Console.Write(serieDeNumeros[j]); //na última parte, não haverá vírgulas
                }
                else{
                    Console.Write(serieDeNumeros[j] + ","); //de resto, haverá!
                }
            }
            Console.Write("]");
        }
    }
}
