﻿using System;
using Pe.Stracon.SGC.Infraestructura.QueryModel.Base;

namespace Pe.Stracon.SGC.Infraestructura.QueryModel.Contractual
{
    /// <summary>
    /// Representa el objeto Logic de Contrato Documento Adjunto
    /// </summary>
    /// <remarks>
    /// Creación :  GMD 20150515 <br />
    /// Modificación :           <br />
    /// </remarks>
    public class ContratoDocumentoAdjuntoLogic : Logic
    {
        /// <summary>
        /// Codigo de Contrato Documento Adjunto
        /// </summary>
        public Guid CodigoContratoDocumentoAdjunto { get; set; }
        /// <summary>
        /// Codigo de Contrato
        /// </summary>
        public Guid CodigoContrato { get; set; }
        /// <summary>
        /// Codigo de Archivo
        /// </summary>
        public int CodigoArchivo { get; set; }
        /// <summary>
        /// Nombre de Archivo
        /// </summary>
        public string NombreArchivo { get; set; }        
        /// <summary>
        /// Ruta de Archivo en el SharePoint
        /// </summary>
        public string RutaArchivoSharePoint { get; set; }
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
    }
}
