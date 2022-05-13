using Entra21.Exercicios03While;

Console.WriteLine(@"      MENU           
01 - Exercício 01
02 - Exercicio 02
03 - Exercicio 03
04 - Exercicio 04
05 - Exercicio 05
06 - Exercicio 06
07 - Exercicio 07
08 - Exercicio 08
09 - Exercicio 09
10 - Exercicio 10
11 - Exercicio 11");

Console.Write("Informe o exercício desejado: ");
int menuDesejado = Convert.ToInt32(Console.ReadLine());

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
else if (menuDesejado == 6)
{
    Exercicio06 exercicio06 = new Exercicio06();
    exercicio06.Executar();
}
else if (menuDesejado == 7)
{
    Exercicio07 exercicio07 = new Exercicio07();
    exercicio07.Executar();
}
else if (menuDesejado == 8)
{
    Exercicio08 exercicio08 = new Exercicio08();
    exercicio08.Executar();
}
else if (menuDesejado == 9)
{
    Exercicio09 exercicio09 = new Exercicio09();
    exercicio09.Executar();
}
else if (menuDesejado == 10)
{
    Exercicio10 exercicio10 = new Exercicio10();
    exercicio10.Executar();
}
else if (menuDesejado == 11)
{
    Exercicio11 exercicio11 = new Exercicio11();
    exercicio11.Executar();
}

