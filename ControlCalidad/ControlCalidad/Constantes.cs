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
      EXPEDIENTES = 1,
      REGISTRO_QC_ENTRADA = 2,
      REPORT_EVALUACION_PIEZAS_GARANTIA = 3,
      REPORT_EVALUACION_MUESTRAS = 4,
      REPORT_EVALUACION_MUESTRAS_GARANTIA_STOCK = 5,
      REGISTRO_GARANTIA_TRAMITE_OT = 6,
    }

    public static String EXPEDIENTES = "Expedientes";
    public static String REGISTRO_QC_ENTRADA = "Registro Q.C. entrada";
    public static String REPORT_EVALUACION_PIEZAS_GARANTIA = "Report evaluación piezas en garantía";
    public static String REPORTE_EVALUACION_MUESTRAS = "Report evaluación de muestras";
    public static String REPORT_EVALUACION_MUESTRAS_GARANTIA_STOCK = "Report evaluación de muestras garantias / stock";
    public static String REGISTRO_GARANTIA_TRAMITE_OT = "Registro garantias en trámite O.T.";
    
  }
}
