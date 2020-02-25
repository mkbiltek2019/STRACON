using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Pe.Stracon.Politicas.Aplicacion.Core.Installers
{
    /// <summary>
    /// Servicio de Instalador de aplicaciones
    /// </summary>
    /// <remarks>
    /// Creaci�n:   GMD 22122014 <br />
    /// Modificaci�n:            <br />
    /// </remarks>
    public class ApplicationServiceInstaller : IWindsorInstaller
    {
        /// <summary>
        /// M�todo para instalar
        /// </summary>
        /// <param name="container">Contenedor</param>
        /// <param name="store">Store</param>
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            var assemblyName = System.Configuration.ConfigurationManager.AppSettings["ApplicationServiceAssembly"];
            if (assemblyName != null && assemblyName != "")
            {
                container.Register(Classes.FromAssemblyNamed(assemblyName)
                                    .Pick()
                                    .LifestyleTransient().WithService.DefaultInterfaces());
            }
        }
    }
}