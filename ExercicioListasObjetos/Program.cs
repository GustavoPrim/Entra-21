using Entra21.ExercicioListasObjetos.Exercício01;

var menuDesejado = 0;
while(menuDesejado != 3)
{
    Console.WriteLine(@"  MENU          
01 - Exercício 01
02 - Exercício 02
03 - Sair");

    var menuValido = false;
    while(menuValido == false)
    {
        try
        {
            Console.Write("Informe o menu desejado: ");
            menuDesejado = Convert.ToInt32(Console.ReadLine());

            if (menuDesejado < 1 || menuDesejado > 3)
                Console.WriteLine("Opção do menu não existe, informe novamente.");
        }
        catch
        {
            Console.WriteLine("Opção de menu inválida, digite novamente.");
        }
    }
    if (menuDesejado == 1)
    {
        TrianguloController controller = new TrianguloController();
        controller.GerenciarMenu();
    }
    else if (menuDesejado == 2)
    {

    }
        
}
