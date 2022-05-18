using Entra21.ExerciciosForComTryCatch;

Console.WriteLine(@"          MENU            
01 - Exercício 01
02 - Exercicio 02");

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

