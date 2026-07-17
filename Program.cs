namespace aula04;
public class program {
    public static void Main()
        {
        Console.WriteLine("-----------CADASTRO DE USUARIO--------------");

        //solicitar o nome do usuario

        Console.WriteLine("Digite o Seu Nome: ");
        String name = Console.ReadLine();
        
        //solicitar a idade do usuario
        Console.WriteLine("Digite Sua Idade:");
        int age = Convert.ToInt32(Console.ReadLine());

        //solicitar a altura do Usuario

        Console.WriteLine("Digite sua altura: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        //solicitar peso da pessoa

        Console.WriteLine("Digite Seu Peso: ");
        int peso = Convert.ToInt32(Console.ReadLine());

        //faculdade
        Console.WriteLine("Qual Faculdade Esta Fazendo?: ");
        String faculdade = Console.ReadLine();

        //curso

        Console.WriteLine("Qual Curso Esta Fazendo?: ");
        String curso = Console.ReadLine();

        //Trabalho
        Console.Write("Está trabalhando? (Sim/Não): ");
        string resposta = Console.ReadLine();

        bool trabalho = resposta.ToLower() == "sim";


        Console.WriteLine("------------------ INFORMAÇÕES DE USUARIO -----------------------");

        Console.WriteLine("Nome do Usuario: " + name);
        Console.WriteLine("Idade: " + age);
        Console.WriteLine("Altura: " + altura);
        Console.WriteLine("Peso: " + peso);
        Console.WriteLine("Faculdade Atual: " + faculdade);
        Console.WriteLine("Trabalhando?: " + trabalho);
        Console.WriteLine("Aluno " + name + " Protocolo 357321 " + "Registrado Com Sucesso! " );
        
        


    }
}