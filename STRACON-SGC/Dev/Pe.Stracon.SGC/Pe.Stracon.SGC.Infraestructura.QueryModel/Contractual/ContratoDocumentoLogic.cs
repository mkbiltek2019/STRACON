﻿using System;
using Pe.Stracon.SGC.Infraestructura.QueryModel.Base;

namespace Pe.Stracon.SGC.Infraestructura.QueryModel.Contractual
{
    /// <summary>
    /// Representa el objeto Logic de Contrato Documento
    /// </summary>
    /// <remarks>
    /// Creación :  GMD 20150515 <br />
    /// Modificación :           <br />
    /// </remarks>
    public class ContratoDocumentoLogic : Logic
    {
        /// <summary>
        /// Codigo de Contrato Documento
        /// </summary>
        public Guid CodigoContratoDocumento { get; set; }
        /// <summary>
        /// Codigo de Contrato
        /// </summary>
        public Guid CodigoContrato { get; set; }
        /// <summary>
        /// Número de Contrato
        /// </summary>
        public string NumeroContrato { get; set; }
        /// <summary>
        /// Codigo de Archivo
        /// </summary>
        public int CodigoArchivo { get; set; }
        /// <summary>
        /// Ruta de Archivo en el SharePoint
        /// </summary>
        public string RutaArchivoSharePoint { get; set; }
        /// <summary>
        /// Contenido
        /// </summary>
        public string Contenido { get; set; }
        /// <summary>
        /// Indicador Actual
        /// </summary>
        public bool IndicadorActual { get; set; }
        /// <summary>
        /// Version
        /// </summary>
        public byte Version { get; set; }
        /// <summary>
        /// Usuario de Creación
        /// </summary>
        public string UsuarioCreacion { get; set; }
        /// <summary>
        /// Fecha de Creación
        /// </summary>
        public DateTime FechaCreacion { get; set; }
        /// <summary>
        /// Terminal de Creación
        /// </summary>
        public string TerminalCreacion { get; set; }
        /// <summary>
        /// Codigo de Contrato Estadio
        /// </summary>
        public Guid? CodigoContratoEstadio { get; set; }
    }
}