using System;

namespace atv4
{
    class Program
    {
        static void Main(string[] args)
        {
            int nmatric;
            Double nnota;

            int Matricula;
            Double nnota;

            string nome;
            string nnome = string.Empty;

            nnota = 0;
            nmatric = 0;
        

            int contador = 1;
            while (contador <= 15)
            {
                Console.WriteLine("");
                Console.Write("Informe o nome do aluno: ");
                Nome = (Console.ReadLine());
                Console.WriteLine("");
                Console.Write("Informe a matricula do aluno: ");
                Matricula = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                Console.Write("Informe a nota do aluno: ");
                Nota = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("");

                if (nnota < Nota)
                {
                    nnome= Nome;
                    nmatric = Matricula;
                    nnota = Nota;
                }
                contador++;
            }
            Console.WriteLine($"O nome do aluno com a nota mais alta é {nnome}, a Matricula do aluno é : {nmatric} e a Nota que ele recebeu foi: {nnota}");
        }
    }
}
