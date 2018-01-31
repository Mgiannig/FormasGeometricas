using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodingChallenge.Controllers
{
    public class FiguraGeometricaController : Controller
    {
        [HttpGet]
        public ActionResult Form()
        {
            Models.FormaGeometrica.Form model = new Models.FormaGeometrica.Form();
            try
            {                                
                Models.FormaGeometrica.FormaEdit figuraModel = new Models.FormaGeometrica.FormaEdit();
                figuraModel.FormaId = Guid.NewGuid();
                FillSelectList(figuraModel);
                model.ListaFigura.Add(figuraModel);

                return View(model);
            }

            catch (Exception ex)
            {
          //   Common.LogAndShowError(ex, "Error al cargar, por favor intente nuevamente");

            }
            return View(model);
        }

        [ValidateInput(false)]
        public ActionResult AddFigura()
        {
            try
            {
                Models.FormaGeometrica.FormaEdit model = new Models.FormaGeometrica.FormaEdit();
                model.FormaId = Guid.NewGuid();
                FillSelectList(model);

                return PartialView("_figuraEdit", model);
            }
            catch (Exception ex)
            {
             // Business.ErrorLog.LogError(Common.UsuarioLogueado, ex);
                return null;
            }
        }

        private void FillSelectList(Models.FormaGeometrica.FormaEdit model)
        {
            model.TipoFormaList = new SelectList(new[]
               {
                    new SelectListItem {Text = "Cuadrado", Value = "1"},
                    new SelectListItem {Text = "TrianguloEquilatero", Value = "2"},
                    new SelectListItem {Text = "Circulo", Value = "3"},
                    new SelectListItem {Text = "Trapecio", Value = "4"},                    

                }, "Value", "Text");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Reporte(Models.FormaGeometrica.Form model)
        {
            try
            {
                
                    List<Models.FormaGeometrica.FormaEdit> formaCollectionLst = new List<Models.FormaGeometrica.FormaEdit>();
                    model.GetForma(formaCollectionLst);

                    return View(model);
                

            }
            catch (Exception ex)
            {
             //   Common.LogAndShowError(ex, "Error al guardar Workflow, por favor intente nuevamente");
            }

            return View(model);
        }
    }
}