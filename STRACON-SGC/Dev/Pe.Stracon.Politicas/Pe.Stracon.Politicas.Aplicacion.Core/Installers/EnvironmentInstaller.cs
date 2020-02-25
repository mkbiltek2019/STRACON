﻿using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Pe.Stracon.Politicas.Aplicacion.Core.Factory;

namespace Pe.Stracon.Politicas.Aplicacion.Core.Installers
{
    /// <summary>
    /// Instalador de Entorno
    /// </summary>
    /// <remarks>
    /// Creación:   GMD 22122014 <br />
    /// Modificación:            <br />
    /// </remarks>
    public class EnvironmentInstaller : IWindsorInstaller
    {
        /// <summary>
        /// Instalación
        /// </summary>
        /// <param name="container">Contenedor</param>
        /// <param name="store">Store</param>
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.AddFacility<EnvironmentFacility>();
        }
    }
}
