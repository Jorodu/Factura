using Practica.Dto;
using System;

namespace Practica.Servicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Consulta" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Consulta.svc o Consulta.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Consulta : IConsulta
    {
        public FacturaDto ObtenerIdFactura()
        {
            return new FacturaDto { Fecha = DateTime.Now }; 
        }
    }
}
