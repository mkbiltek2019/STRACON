﻿using Pe.Stracon.SGC.Infraestructura.CommandModel.Base;
using Pe.Stracon.SGC.Infraestructura.CommandModel.Contractual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pe.Stracon.SGC.Infraestructura.CommandModel.Mapping.Contractual
{
    /// <summary>
    /// Implementación del mapeo de la entidad Plantilla Nota Pie
    /// </summary>
    /// <remarks>
    /// Creación:   GMD 20170822 <br />
    /// Modificación:            <br />
    /// </remarks>
    public class PlantillaNotaPieMapping : BaseEntityMapping<PlantillaNotaPieEntity>
    {
        public PlantillaNotaPieMapping()
            : base()
        {
            HasKey(x => x.CodigoPlantillaNotaPie).ToTable("PLANTILLA_NOTA_PIE", "CTR");
            Property(u => u.CodigoPlantillaNotaPie).HasColumnName("CODIGO_PLANTILLA_NOTA_PIE");
            Property(u => u.CodigoPlantilla).HasColumnName("CODIGO_PLANTILLA");
            Property(u => u.Orden).HasColumnName("ORDEN");
            Property(u => u.Titulo).HasColumnName("TITULO");
            Property(u => u.Contenido).HasColumnName("CONTENIDO");
            Property(u => u.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");
            Property(u => u.UsuarioCreacion).HasColumnName("USUARIO_CREACION");
            Property(u => u.FechaCreacion).HasColumnName("FECHA_CREACION");
            Property(u => u.TerminalCreacion).HasColumnName("TERMINAL_CREACION");
            Property(u => u.UsuarioModificacion).HasColumnName("USUARIO_MODIFICACION");
            Property(u => u.FechaModificacion).HasColumnName("FECHA_MODIFICACION");
            Property(u => u.TerminalModificacion).HasColumnName("TERMINAL_MODIFICACION");
        }
    }
}
