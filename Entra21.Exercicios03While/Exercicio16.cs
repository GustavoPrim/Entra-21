using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.Exercicios03While
{
    internal class Exercicio16
    {
        public void Executar()
        {
            Console.Write("Informe o texto: ");
            string texto = Console.ReadLine().Trim().ToLower();
            int indice = 0, quantidadeCaracteres = texto.Length, quantidadeLetraA = 0, quantidadeLetraB = 0, quantidadeLetraC = 0, quantidadeLetraD = 0, quantidadeLetraE = 0, quantidadeLetraF = 0, quantidadeLetraG = 0, quantidadeLetraH = 0,
                quantidadeLetraI = 0, quantidadeLetraJ = 0, quantidadeLetraK = 0, quantidadeLetraL = 0, quantidadeLetraM = 0, quantidadeLetraN = 0, quantidadeLetraO = 0, quantidadeLetraP = 0,
                quantidadeLetraQ = 0, quantidadeLetraR = 0, quantidadeLetraS = 0, quantidadeLetraT = 0, quantidadeLetraU = 0, quantidadeLetraV = 0, quantidadeLetraW = 0, quantidadeLetraX = 0,
                quantidadeLetraY = 0, quantidadeLetraZ = 0, quantidadeCaracteresOutros = 0;
            while (indice < quantidadeCaracteres)
            {
                string caracteresUtilizadas = texto.Substring(indice, 1);
                if (caracteresUtilizadas == "a")
                {
                    quantidadeLetraA = quantidadeLetraA + 1;
                }
                else if (caracteresUtilizadas == "b")
                {
                    quantidadeLetraB = quantidadeLetraB + 1;
                }
                else if (caracteresUtilizadas == "c")
                {
                    quantidadeLetraC = quantidadeLetraC + 1;
                }
                else if (caracteresUtilizadas == "d")
                {
                    quantidadeLetraD = quantidadeLetraD + 1;
                }
                else if (caracteresUtilizadas == "e")
                {
                    quantidadeLetraE = quantidadeLetraE + 1;
                }
                else if (caracteresUtilizadas == "f")
                {
                    quantidadeLetraF = quantidadeLetraF + 1;
                }
                else if (caracteresUtilizadas == "g")
                {
                    quantidadeLetraG = quantidadeLetraG + 1;
                }
                else if (caracteresUtilizadas == "h")
                {
                    quantidadeLetraH = quantidadeLetraH + 1;
                }
                else if (caracteresUtilizadas == "i")
                {
                    quantidadeLetraI = quantidadeLetraI + 1;
                }
                else if (caracteresUtilizadas == "j")
                {
                    quantidadeLetraJ = quantidadeLetraJ + 1;
                }
                else if (caracteresUtilizadas == "k")
                {
                    quantidadeLetraK = quantidadeLetraK + 1;
                }
                else if (caracteresUtilizadas == "l")
                {
                    quantidadeLetraL = quantidadeLetraL + 1;
                }
                else if (caracteresUtilizadas == "m")
                {
                    quantidadeLetraM = quantidadeLetraM + 1;
                }
                else if (caracteresUtilizadas == "n")
                {
                    quantidadeLetraN = quantidadeLetraN + 1;
                }
                else if (caracteresUtilizadas == "o")
                {
                    quantidadeLetraO = quantidadeLetraO + 1;
                }
                else if (caracteresUtilizadas == "p")
                {
                    quantidadeLetraP = quantidadeLetraP + 1;
                }
                else if (caracteresUtilizadas == "q")
                {
                    quantidadeLetraQ = quantidadeLetraQ + 1;
                }
                else if (caracteresUtilizadas == "r")
                {
                    quantidadeLetraR = quantidadeLetraR + 1;
                }
                else if (caracteresUtilizadas == "s")
                {
                    quantidadeLetraS = quantidadeLetraS + 1;
                }
                else if (caracteresUtilizadas == "t")
                {
                    quantidadeLetraT = quantidadeLetraT + 1;
                }
                else if (caracteresUtilizadas == "u")
                {
                    quantidadeLetraU = quantidadeLetraU + 1;
                }
                else if (caracteresUtilizadas == "v")
                {
                    quantidadeLetraV = quantidadeLetraV + 1;
                }
                else if (caracteresUtilizadas == "w")
                {
                    quantidadeLetraW = quantidadeLetraW + 1;
                }
                else if (caracteresUtilizadas == "x")
                {
                    quantidadeLetraX = quantidadeLetraX + 1;
                }
                else if (caracteresUtilizadas == "y")
                {
                    quantidadeLetraY = quantidadeLetraY + 1;
                }
                else if (caracteresUtilizadas == "z")
                {
                    quantidadeLetraZ = quantidadeLetraZ + 1;
                }
                else
                {
                    quantidadeCaracteresOutros = quantidadeCaracteresOutros + 1;
                }
                indice = indice + 1;
            }
            Console.WriteLine("A: " + quantidadeLetraA +
                            "\nB: " + quantidadeLetraB +
                            "\nC: " + quantidadeLetraC +
                            "\nD: " + quantidadeLetraD +
                            "\nE: " + quantidadeLetraE +
                            "\nF: " + quantidadeLetraF +
                            "\nG: " + quantidadeLetraG +
                            "\nH: " + quantidadeLetraH +
                            "\nI: " + quantidadeLetraI +
                            "\nJ: " + quantidadeLetraJ +
                            "\nK: " + quantidadeLetraK +
                            "\nL: " + quantidadeLetraL +
                            "\nM: " + quantidadeLetraM +
                            "\nN: " + quantidadeLetraN +
                            "\nO: " + quantidadeLetraO +
                            "\nP: " + quantidadeLetraP +
                            "\nQ: " + quantidadeLetraQ +
                            "\nR: " + quantidadeLetraR +
                            "\nS: " + quantidadeLetraS +
                            "\nT: " + quantidadeLetraT +
                            "\nU: " + quantidadeLetraU +
                            "\nV: " + quantidadeLetraV +
                            "\nW: " + quantidadeLetraW +
                            "\nX: " + quantidadeLetraX +
                            "\nY: " + quantidadeLetraY +
                            "\nZ: " + quantidadeLetraZ);

        }
    }
}
