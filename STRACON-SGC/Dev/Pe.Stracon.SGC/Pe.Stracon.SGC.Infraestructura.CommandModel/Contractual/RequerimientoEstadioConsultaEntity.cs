﻿using System;
using Pe.Stracon.SGC.Infraestructura.CommandModel.Base;

namespace Pe.Stracon.SGC.Infraestructura.CommandModel.Contractual
{
    /// <summary>
    /// Clase que representa la entidad  Estadio Consulta
    /// </summary>
    /// <remarks>
    /// Creación :  GMD 20150511 <br />
    /// Modificación :           <br />
    /// </remarks>  
    public class RequerimientoEstadioConsultaEntity : Entity
    {
        /// <summary>
        /// Codigo Requerimiento Estadio de Consulta
        /// </summary>
        public Guid CodigoRequerimientoEstadioConsulta { get; set; }
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
    }
}
