using Microsoft.VisualBasic;
using System.ComponentModel.Design;

namespace Atividade;

public class Program
{

    public static void Main ()
    {

        string nome = "Gustavo";

        Console.WriteLine("Nome:" + nome);

        int idade = 23;

        Console.WriteLine("Idade: " + idade);

        double altura = 1.68;

        Console.WriteLine("Altura: " + altura);

        int peso = 90;

        Console.WriteLine("Peso: " + peso + "KG");

        string faculdade = "Uninove";

        Console.WriteLine("Faculdade: " + faculdade);

        string curso = "Ciencia de dados";

        Console.WriteLine ("curso: "+ curso);



        bool EstaTrabalhando = true; 
    
       
        Console.WriteLine ("Esta trabalhando?: " + EstaTrabalhando);


        double numberdouble = 9.5;

        Console.WriteLine("nota geral da faculdade: " + numberdouble);

        char charecter = 'G';

        Console.WriteLine("Primeira letra do Nome: " + charecter);

        const String DataDeNascimento = "05/03/2003";

        Console.WriteLine ("Data de nascimento: " + DataDeNascimento);

        dynamic Protocolo = "358123 ";

        Console.WriteLine ("'protocolo'- " + Protocolo + nome +  " registrado com sucesso! " );













    }

}