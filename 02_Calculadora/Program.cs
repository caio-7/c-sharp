Console.WriteLine("Bem-Vindo a calculadora!");
Console.WriteLine("Escolha a operação a ser realizada:\n");
Console.WriteLine("1-Soma\n2-Subtração\n3-Multiplicação\n4-Divisão\n0-Sair\n");

//Leitura da opção escolhida
int opcao = Convert.ToInt32(Console.ReadLine());

double n1,n2,n3;

switch(opcao)
{
    case 0:
        break;
    
    case 1:
        Console.WriteLine("Digite o primeiro valor:");
        n1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor:");
        n2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"\n{n1} + {n2} = {n1+n2}");
        //Console.WriteLine(n1 + n2);
        break;


}

