﻿using Pe.Stracon.SGC.Infraestructura.CommandModel.Base;
using System;

namespace Pe.Stracon.SGC.Infraestructura.CommandModel.Contractual
{
    /// <summary>
    /// Clase que representa la entidad Contrato
    /// </summary>
    /// <remarks>
    /// Creación:   GMD 20150525 <br />
    /// Modificación:            <br />
    /// </remarks>
    public class ContratoEntity : Entity
    {
        /// <summary>
        /// Código de Contrato
        /// </summary>
        public Guid CodigoContrato { get; set; }
        /// <summary>
        /// Código de Unidad Operativa
        /// </summary>
        public Guid CodigoUnidadOperativa { get; set; }
        /// <summary>
        /// Código de Proveedor
        /// </summary>
        public Guid CodigoProveedor { get; set; }
        /// <summary>
        /// Número de Contrato
        /// </summary>
        public string NumeroContrato { get; set; }
        /// <summary>
        /// Descripción
        /// </summary>
        public string Descripcion { get; set; }
        /// <summary>
        /// Código de Tipo de Servicio
        /// </summary>
        public string CodigoTipoServicio { get; set; }
        /// <summary>
        /// Código de Tipo de Requerimiento
        /// </summary>
        public string CodigoTipoRequerimiento { get; set; }
        /// <summary>
        /// Código de Tipo de Documento
        /// </summary>
        public string CodigoTipoDocumento { get; set; }
        /// <summary>
        /// Indicador de Versión Oficial
        /// </summary>
        public bool IndicadorVersionOficial { get; set; }
        /// <summary>
        /// Fecha de Inicio de Vigencia
        /// </summary>
        public DateTime FechaInicioVigencia { get; set; }
        /// <summary>
        /// Fecha de Fin de Vigencia
        /// </summary>
        public DateTime FechaFinVigencia { get; set; }
        /// <summary>
        /// Código de Moneda
        /// </summary>
        public string CodigoMoneda { get; set; }
        /// <summary>
        /// Monto de Contrato
        /// </summary>
        public decimal MontoContrato { get; set; }
        /// <summary>
        /// Monto Acumulado
        /// </summary>
        public decimal MontoAcumulado { get; set; }
        /// <summary>
        /// Código de Estado
        /// </summary>
        public string CodigoEstado { get; set; }
        /// <summary>
        /// Código de Plantilla
        /// </summary>
        public Guid? CodigoPlantilla { get; set; }
        /// <summary>
        /// Código de Contrato Principal
        /// </summary>
        public Guid? CodigoContratoPrincipal { get; set; }
        /// <summary>
        /// Código de Estado de Edición
        /// </summary>
        public string CodigoEstadoEdicion { get; set; }
        /// <summary>
        /// Comentario de Modificación
        /// </summary>
        public string ComentarioModificacion { get; set; }
        /// <summary>
        /// Respuesta de Modificación
        /// </summary>
        public string RespuestaModificacion { get; set; }
        /// <summary>
        /// Código de Flujo de Aprobación
        /// </summary>
        public Guid? CodigoFlujoAprobacion { get; set; }
        /// <summary>
        /// Código de Estadio Actual
        /// </summary>
        public Guid? CodigoEstadioActual { get; set; }
        /// <summary>
        /// Número de correlativo de adenda
        /// </summary>
        public int? NumeroAdenda { get; set; }
        /// <summary>
        /// Número de adenda concantenado
        /// </summary>
        public string NumeroAdendaConcatenado { get; set; }
        /// <summary>
        /// Si el contrato es flexible
        /// </summary>
        public bool? EsFlexible { get; set; }
        /// <summary>
        /// Si el contrato es corporativo
        /// </summary>
        public bool? EsCorporativo { get; set; }
        /// <summary>
        /// Código de Contrato Original (se registra cuando se realiza la copia del contrato)
        /// </summary>
        public Guid? CodigoContratoOriginal { get; set; }
      
    }
}
