using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace CodingChallenge.Models.FormaGeometrica
{
    public class Form
    {
        public List<Models.FormaGeometrica.FormaEdit> ListaFigura { get; set; } = new List<FormaEdit>();
        
        public void GetForma(List<Models.FormaGeometrica.FormaEdit> formaCollectionLst)
        {
            foreach (Models.FormaGeometrica.FormaEdit forma in ListaFigura)
            {

                forma.Perimetro = Business.Classes.FormaGeometrica.CalcularPerimetro(forma.TipoFormaId, forma.Lado, forma.Altura ,forma.LadoB, forma.LadoC, forma.LadoD);
                forma.Area = Business.Classes.FormaGeometrica.CalcularArea(forma.TipoFormaId, forma.Lado, forma.Altura, forma.LadoB);
                switch (forma.TipoFormaId)
                {
                    case 1:
                        forma.Nombre = "Cuadrado";
                        break;

                    case 2:
                        forma.Nombre = "Triangulo equilatero";

                        break;
                    case 3:
                        forma.Nombre = "Circulo";

                        break;
                    case 4:
                        forma.Nombre = "Trapecio";
                        break;

                }
                
            }
        }

    }

}