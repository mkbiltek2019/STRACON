﻿using System;
using System.Collections.Generic;
using Pe.Stracon.SGC.Infraestructura.Core.Base;
using Pe.Stracon.SGC.Infraestructura.QueryModel.Contractual;

namespace Pe.Stracon.SGC.Infraestructura.Core.QueryContract.Contractual
{
    /// <summary>
    /// Definición del Repositorio de Plantilla
    /// </summary>
    /// <remarks>
    /// Creación :      GMD 20150518 <br />
    /// Modificación :               <br />
    /// </remarks>
    public interface IPlantillaLogicRepository : IQueryRepository<PlantillaLogic>
    {
        /// <summary>
        /// Permite la búsqueda de plantillas
        /// </summary>
        /// <param name="codigoPlantilla">Código de Plantilla</param>
        /// <param name="descripcion">Descripción</param>
        /// <param name="codigoTipoServicio">Código de Tipo de Servicio</param>
        /// <param name="codigoTipoRequerimiento">Código de Tipo de Requerimiento</param>
        /// <param name="codigoTipoDocumentoContrato">Código de Tipo de Documento de Contrato</param>
        /// <param name="codigoEstadoVigencia">Código de Estado de Vigencia</param>
        /// <param name="indicadorAdhesion">Indicador de Adhesión</param>
        /// <param name="fechaInicioVigencia">Fecha de Inicio de Vigencia</param>
        /// <param name="fechaFinVigencia">Fecha de Fin de Vigencia</param>
        /// <param name="numeroPagina">Total de Páginas</param>
        /// <param name="registroPagina">Total de Registros por Página</param>
        /// <returns>Lista de plantillas</returns>
        List<PlantillaLogic> BuscarPlantilla(Guid? codigoPlantilla, string descripcion, string codigoTipoServicio,
                                                    string codigoTipoDocumentoContrato, string codigoEstadoVigencia, bool? indicadorAdhesion,
                                                    DateTime? fechaInicioVigencia, DateTime? fechaFinVigencia, int numeroPagina, int registroPagina);

        /// <summary>
        /// Realiza la búsqueda de plantillas de acuerdo a los tipos de servicios, requerimientos y documentos de contrato
        /// </summary>
        /// <param name="tipoServicio">Código de Tipo de Servicio</param>
        /// <param name="tipoDocumentoContrato">Código de Tipo de Documento de Contrato</param>
        /// <param name="indicadorAdhesion">Indicador de Adhesión</param>
        /// <returns>Lista de plantillas de acuerdo a los tipos de servicios, requerimientos, documentos de contrato y adhesión</returns>
        List<PlantillaLogic> BuscarPlantillaTipo(string tipoServicio, string tipoDocumentoContrato, bool indicadorAdhesion);

        /// <summary>
        /// Realiza la búsqueda de plantilla párrafo
        /// </summary>
        /// <param name="codigoPlantillaParrafo">Código de Plantilla Párrafo</param>
        /// <param name="codigoPlantilla">Código de Plantilla</param>
        /// <param name="orden">Orden</param>
        /// <param name="titulo">Título</param>
        /// <param name="contenido">Contenido</param>
        /// <param name="numeroPagina">Total de Páginas</param>
        /// <param name="registroPagina">Total de Registros por Página</param>
        /// <returns>Lista de plantillas</returns>
        List<PlantillaParrafoLogic> BuscarPlantillaParrafo(Guid? codigoPlantillaParrafo, Guid? codigoPlantilla, byte? orden, string titulo,
                                                    string contenido, int numeroPagina, int registroPagina);

        /// <summary>
        /// Realiza la búsqueda de párrafos de una plantilla de acuerdo al orden y título
        /// </summary>
        /// <param name="codigoPlantilla">Código de Plantilla</param>
        /// <param name="orden">Orden</param>
        /// <param name="titulo">Título</param>
        /// <returns>Lista de párrafos de una plantilla de acuerdo al orden y título</returns>
        List<PlantillaParrafoLogic> BuscarPlantillaParrafoOrdenTitulo(Guid codigoPlantilla, byte orden, string titulo);

        /// <summary>
        /// Permite la búsqueda de variables de un párrafo de acuerdo al código de plantilla párrafo
        /// </summary>
        /// <param name="codigoPlantillaParrafo">Código de Plantilla Párrafo</param>
        /// <returns>Lista de variables de un párrafo de acuerdo al código de párrafo</returns>
        List<PlantillaParrafoVariableLogic> BuscarPlantillaParrafoVariableCodigoPlantillaParrafo(Guid codigoPlantillaParrafo);

        /// <summary>
        /// Obtener notas al pie por contrato
        /// </summary>
        /// <param name="codigoContrato">Código de contrato</param>
        /// <returns>Lista de notas al pie</returns>
        //List<PlantillaNotaPieLogic> ObtenerNotasPiePorContrato(Guid codigoContrato);

        /// <summary>
        /// Permite la búsqueda de notas al pie por plantilla
        /// </summary> 
        /// <param name="codigoPlantillaNotaPie">Código plantilla nota pie</param>
        /// <param name="codigoPlantilla">Código de Plantilla</param>    
        /// <param name="numeroPagina">Total de Páginas</param>
        /// <param name="registroPagina">Total de Registros por Página</param>
        /// <returns>Lista de plantilla párrafo</returns>
        List<PlantillaNotaPieLogic> BuscarNotasPiePorPlantilla(Guid? codigoPlantillaNotaPie, Guid? codigoPlantilla, int numeroPagina, int registroPagina);
        
    }
}
