using Entra21.ExerciciosWhile;

Console.WriteLine(@"      MENU           
1 - Exercício 01");

Console.Write("Informe o exercício desejado: ");
int menuDesejado = Convert.ToInt32(Console.ReadLine());

if (menuDesejado == 1)
{
    Exercicios01 exercicios01 = new Exercicios01();
    exercicios01.Executar();
}
