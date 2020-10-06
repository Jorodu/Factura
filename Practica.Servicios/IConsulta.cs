using System.ServiceModel;
using Practica.Dto;

namespace Practica.Servicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IConsulta" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IConsulta
    {
        [OperationContract]
        FacturaDto ObtenerIdFactura();
    }
}
