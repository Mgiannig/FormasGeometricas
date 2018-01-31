
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Business.Classes
{
    public class FormaGeometrica
    {
        public static decimal CalcularArea(int tipo, decimal lado, decimal altura, decimal ladoB)
        {
            decimal area = 0;
            switch (tipo)
            {
                case TipoForma.Cuadrado:
                    area = lado * lado;
                    break;
                case TipoForma.TrianguloEquilatero:
                    area = ((decimal)Math.Sqrt(3) / 4) * lado * lado;
                    break;
                case TipoForma.Circulo:
                    area = (decimal)Math.PI * (lado / 2) * (lado / 2);
                    break;
                case TipoForma.Trapecio:
                    area = altura * ((lado + ladoB) / 2);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(@"Forma desconocida");

            }
            return area;
        }

        public static decimal CalcularPerimetro(int tipo, decimal lado, decimal altura, decimal ladoB, decimal ladoC, decimal ladoD)
        {
            decimal perimetro = 0;
            switch (tipo)
            {
                case TipoForma.Cuadrado:
                    perimetro = lado * 4;
                    break;
                case TipoForma.TrianguloEquilatero:
                    perimetro = lado * 3;
                    break;
                case TipoForma.Circulo:
                    perimetro = (decimal)Math.PI * lado;
                    break;
                case TipoForma.Trapecio:
                    perimetro = lado + ladoB + ladoC + ladoD;
                    break;

                default:
                    throw new ArgumentOutOfRangeException(@"Forma desconocida");
            }
            return perimetro;
        }
    }
}
