using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Pe.Stracon.Politicas.Aplicacion.Core.Installers
{
    /// <summary>
    /// Instalador de Logger
    /// </summary>
    /// <remarks>
    /// Creaci�n:   GMD 22122014 <br />
    /// Modificaci�n:            <br />
    /// </remarks>
	public class LoggerInstaller : IWindsorInstaller
	{
        /// <summary>
        /// Instalaci�n
        /// </summary>
        /// <param name="container">Contenedor</param>
        /// <param name="store">Store</param>
		public void Install(IWindsorContainer container, IConfigurationStore store)
		{
		}
	}
}