using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Pe.Stracon.Politicas.Aplicacion.Core.Installers
{
    /// <summary>
    /// Instalador de repositorios
    /// </summary>
    /// <remarks>
    /// Creaci�n:   GMD 22122014 <br />
    /// Modificaci�n:            <br />
    /// </remarks>
    public class RepositoriesInstaller : IWindsorInstaller
    {
        /// <summary>
        /// Instalaci�n
        /// </summary>
        /// <param name="container">Contenedor</param>
        /// <param name="store">Store</param>
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            var assemblyName = System.Configuration.ConfigurationManager.AppSettings["RepositoryAssembly"];
            if (assemblyName != null && assemblyName != "")
            {
                container.Register(Classes.FromAssemblyNamed(assemblyName)
                    .Pick()
                    .LifestyleTransient().WithService.DefaultInterfaces());
            }
        }
    }
}