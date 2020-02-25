
using System;
using Castle.Core.Internal;
using Castle.MicroKernel.Facilities;
using Castle.MicroKernel.Registration;
using Pe.Stracon.Politicas.Infraestructura.Core.Context;
using System.Configuration;

namespace Pe.Stracon.Politicas.Aplicacion.Core.Factory
{
    /// <summary>
    /// Facilitador de la implementaci�n del objeto de persistencia
    /// </summary>
    /// <remarks>
    /// Creaci�n:   GMD 22122014 <br />
    /// Modificaci�n:            <br />
    /// </remarks>
    public class PersistenceFacility : AbstractFacility
    {
        /// <summary>
        /// M�todo de Inicio
        /// </summary>
        protected override void Init()
        {
            string valueLifestylePerThread = ConfigurationManager.AppSettings["LifestylePerThread"];
            bool isLifestylePerThread = !string.IsNullOrEmpty(valueLifestylePerThread) && bool.Parse(valueLifestylePerThread);

            if (isLifestylePerThread)
            {
                Kernel.Register(Component.For<IDbContextProvider>()
                                 .ImplementedBy<PoliticaDbContextProvider>()
                                 .LifestylePerThread());
            }
            else
            {
                Kernel.Register(Component.For<IDbContextProvider>()
                                 .ImplementedBy<PoliticaDbContextProvider>()
                                 .LifestylePerWebRequest());
            }
        }
    }
}