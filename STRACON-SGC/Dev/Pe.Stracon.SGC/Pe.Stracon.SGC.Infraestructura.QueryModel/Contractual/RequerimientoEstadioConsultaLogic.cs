﻿using System;
using Pe.Stracon.SGC.Infraestructura.QueryModel.Base;

namespace Pe.Stracon.SGC.Infraestructura.QueryModel.Contractual
{
    /// <summary>
    /// Representa el objeto Logic de Requerimiento Estadio Consulta
    /// </summary>
    /// <remarks>
    /// Creación :  GMD 20150515 <br />
    /// Modificación :           <br />
    /// </remarks>
    public class RequerimientoEstadioConsultaLogic : Logic
    {
        /// <summary>
        /// Codigo de Requerimiento Estadio Consulta
        /// </summary>
        public Guid? CodigoRequerimientoEstadioConsulta { get; set; }
        /// <summary>
        /// Codigo Requerimiento de Estadio
        /// </summary>
        public Guid CodigoRequerimientoEstadio { get; set; }
        /// <summary>
        /// Descripcion
        /// </summary>
        public string Descripcion { get; set; }
        /// <summary>
        /// Fecha de Registro
        /// </summary>
        public DateTime FechaRegistro { get; set; }
        /// <summary>
        /// Codigo de Parrafo
        /// </summary>
        public Guid? CodigoRequerimientoParrafo { get; set; }
        /// <summary>
        /// Destinatario
        /// </summary>
        public Guid Destinatario { get; set; }
        /// <summary>
        /// Respuesta
        /// </summary>
        public string Respuesta { get; set; }
        /// <summary>
        /// Fecha de Respuesta
        /// </summary>
        public DateTime? FechaRespuesta { get; set; }
        /// <summary>
        /// Código de Consultante
        /// </summary>
        public string Consultor { get; set; }

        public Guid? CodigoRequerimiento { get; set; }
    }
}
