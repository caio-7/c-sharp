

Console.WriteLine("Bem-Vindo a calculadora!");
Console.WriteLine("Escolha a operação a ser realizada:\n");

//Após a primeira utilização, mantém programa em loop para outras operações
while(true){

Console.WriteLine("1-Soma\n2-Subtração\n3-Multiplicação\n4-Divisão\n0-Sair\n");


//Leitura da opção escolhida
int opcao = Convert.ToInt32(Console.ReadLine());

decimal n1,n2;
//string n3;

switch(opcao)
{
    case 0:
        break;
    
    case 1:
        Console.WriteLine("Digite o primeiro valor:");
        n1 = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor:");
        n2 = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("\nResultado:");
        Console.WriteLine($"{n1} + {n2} = {n1+n2}\n");
        
        break;

    case 2:
        Console.WriteLine("Digite o primeiro valor:");
        n1 = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor:");
        n2 = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine($"\n{n1} - {n2} = {n1-n2}\n");
        break;

    case 3:
        Console.WriteLine("Digite o primeiro valor:");
        n1 = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor:");
        n2 = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine($"\n{n1} * {n2} = {n1*n2}\n");
        break;

    case 4:
        Console.WriteLine("Digite o primeiro valor:");
        n1 = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor:");
        n2 = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine($"\n{n1} / {n2} = {n1/n2}\n");
        break;
    
    default:
        Console.WriteLine("\nOpção inválida\n");
        break;
}

}