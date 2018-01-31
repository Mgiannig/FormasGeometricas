﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodingChallenge.Models.FormaGeometrica
{
    public class FormaEdit
    {
        public SelectList TipoFormaList { get; set; }
        public Guid FormaId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Indique el tipo de forma")]
        public int TipoFormaId { get; set; }
        public decimal Altura { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese por lo menos un lado")]
        public decimal Lado { get; set; }
        public decimal LadoB { get; set; }
        public decimal LadoC { get; set; }
        public decimal LadoD { get; set; }

        public decimal Area { get; set; }
        public decimal Perimetro { get; set; }
        public string Nombre { get; set; }

    }
}