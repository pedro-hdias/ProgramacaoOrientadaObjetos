using System;
using ProgramacaoOrientadaObjetos.Cadastros;

namespace ProgramacaoOrientadaObjetos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Pessoa objetoPessoa = new();
            objetoPessoa.Nome = "Pedro Dias";
            objetoPessoa.Sobrenome = "Sousa";
            Console.WriteLine($"O nome é: {objetoPessoa.Nome} e o sobrenome é: {objetoPessoa.Sobrenome}");
        }
    }
}