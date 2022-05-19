using Entra21.ExerciciosForComTryCatch;

Console.WriteLine(@"          MENU            
01 - Exercício 01
02 - Exercicio 02
03 - Exercício 03
04 - Exercício 04");

Console.Write("Informe o exercício desejado: ");
int menuDesejado = Convert.ToInt32(Console.ReadLine());
Console.Clear();

if (menuDesejado == 1)
{
    Exercicio01 exercicio01 = new Exercicio01();
    exercicio01.Executar();
}
else if (menuDesejado == 2)
{
    Exercicio02 exercicio02 = new Exercicio02();
    exercicio02.Executar();
}
else if (menuDesejado == 3)
{
    Exercicio03 exercicio03 = new Exercicio03();
    exercicio03.Executar();
}
else if (menuDesejado == 4)
{
    Exercicio04 exercicio04 = new Exercicio04();
    exercicio04.Executar();
}
else if (menuDesejado == 5)
{
    Exercicio05 exercicio05 = new Exercicio05();
    exercicio05.Executar();
}