using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Pe.Stracon.Politicas.Aplicacion.Core.Factory;

namespace Pe.Stracon.Politicas.Aplicacion.Core.Installers
{
    /// <summary>
    /// Instalador persistencia
    /// </summary>
    /// <remarks>
    /// Creaci�n:   GMD 22122014 <br />
    /// Modificaci�n:            <br />
    /// </remarks>
    public class PersistenceInstaller : IWindsorInstaller
    {
        /// <summary>
        /// Instalaci�n
        /// </summary>
        /// <param name="container">Contenedor</param>
        /// <param name="store">Store</param>
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.AddFacility<PersistenceFacility>();
        }
    }
}