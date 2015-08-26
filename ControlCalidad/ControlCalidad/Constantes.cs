using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlCalidad
{
  public static class Constantes
  {
    public enum Modulo
    {
      EXPEDICIONES = 1,
      REGISTRO_QC_ENTRADA = 2,
      REGISTRO_QC_ENTRADA_CALIDAD = 3,
      REPORT_EVALUACION_MUESTRAS = 4,
      REPORT_EVALUACION_MUESTRAS_GARANTIA_STOCK = 5,
      REGISTRO_GARANTIA_TRAMITE_OT = 6,
    }
  }
}
