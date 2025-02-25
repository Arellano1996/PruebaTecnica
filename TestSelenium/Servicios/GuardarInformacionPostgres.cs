using System.Data;
using MediatR;
using PruebaTecnica.Core.Feature.CapacidadDemandadaYRAPEn2024BCAPreliminarv20250127.Command;
using PruebaTecnica.Core.Feature.CapacidadDemandadaYRAPEn2024BCAv20250131.Command;
using PruebaTecnica.Core.Feature.CapacidadDemandadaYRAPEn2024BCSPreliminarv20250127.Command;
using PruebaTecnica.Core.Feature.CapacidadDemandadaYRAPEn2024BCSv20250131.Command;
using PruebaTecnica.Core.Feature.CapacidadDemandadaYRAPEn2024SINPreliminarv20250127.Command;
using PruebaTecnica.Core.Feature.CapacidadDemandadaYRAPEn2024SINv20250131.Command;
using PruebaTecnica.Dominio.Enumeradores;

namespace TestSelenium.Servicios
{
    public class GuardarInformacionPostgres
    {
        private IMediator _mediator;
        public GuardarInformacionPostgres(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task GuardarDatosEnTablaCorrecta(DataTable tabla, string nombreArchivo)
        {
            //Primera tabla CapacidadDemandadaYRAPEn2024SINv20250131
            if (string.Equals(nombreArchivo, ArchivosDescargaEnumeracion.CapacidadDemandadaYRAPEn2024SINv20250131.DisplayName))
            {
                var entidades = ConvertirTablaAEntidades.ConvertirDataTableACapacidadDemandadaYRAPEn2024SINv20250131(tabla);

                try
                {
                    CapacidadDemandadaYRAPEn2024SINv20250131Command command = new();
                    command.CapacidadDemandadaYRAPEn2024SINv20250131s = entidades;

                    await _mediator.Send(command);
                }
                catch (Exception ex)
                {
                    throw;
                }

            }

            //Segunda tabla CapacidadDemandadaYRAPEn2024SINPreliminarv20250127
            if (string.Equals(nombreArchivo, ArchivosDescargaEnumeracion.CapacidadDemandadaYRAPEn2024SINPreliminarv20250127.DisplayName))
            {
                var entidades = ConvertirTablaAEntidades.ConvertirDataTableACapacidadDemandadaYRAPEn2024SINPreliminarv20250127(tabla);

                try
                {
                    CapacidadDemandadaYRAPEn2024SINPreliminarv20250127Command command = new();
                    command.CapacidadDemandadaYRAPEn2024SINPreliminarv20250127s = entidades;

                    await _mediator.Send(command);
                }
                catch (Exception ex)
                {
                    throw;
                }

            }
            //Tercera tabla CapacidadDemandadaYRAPEn2024BCSv20250131
            if (string.Equals(nombreArchivo, ArchivosDescargaEnumeracion.CapacidadDemandadaYRAPEn2024BCSv20250131.DisplayName))
            {
                var entidades = ConvertirTablaAEntidades.ConvertirDataTableACapacidadDemandadaYRAPEn2024BCSv20250131(tabla);

                try
                {
                    CapacidadDemandadaYRAPEn2024BCSv20250131Command command = new();
                    command.CapacidadDemandadaYRAPEn2024BCSv20250131s = entidades;

                    await _mediator.Send(command);
                }
                catch (Exception ex)
                {
                    throw;
                }

            }
            //Cuarta tabla CapacidadDemandadaYRAPEn2024BCSPreliminarv20250127
            if (string.Equals(nombreArchivo, ArchivosDescargaEnumeracion.CapacidadDemandadaYRAPEn2024BCSPreliminarv20250127.DisplayName))
            {
                var entidades = ConvertirTablaAEntidades.ConvertirDataTableACapacidadDemandadaYRAPEn2024BCSPreliminarv20250127(tabla);

                try
                {
                    CapacidadDemandadaYRAPEn2024BCSPreliminarv20250127Command command = new();
                    command.CapacidadDemandadaYRAPEn2024BCSPreliminarv20250127s = entidades;

                    await _mediator.Send(command);
                }
                catch (Exception ex)
                {
                    throw;
                }

            }

            //Quinta tabla CapacidadDemandadaYRAPEn2024BCAv20250131
            if (string.Equals(nombreArchivo, ArchivosDescargaEnumeracion.CapacidadDemandadaYRAPEn2024BCAv20250131.DisplayName))
            {
                var entidades = ConvertirTablaAEntidades.ConvertirDataTableACapacidadDemandadaYRAPEn2024BCAv20250131(tabla);

                try
                {
                    CapacidadDemandadaYRAPEn2024BCAv20250131Command command = new();
                    command.CapacidadDemandadaYRAPEn2024BCAv20250131s = entidades;

                    await _mediator.Send(command);
                }
                catch (Exception ex)
                {
                    throw;
                }

            }
            //Sexta tabla CapacidadDemandadaYRAPEn2024BCAPreliminarv20250127
            if (string.Equals(nombreArchivo, ArchivosDescargaEnumeracion.CapacidadDemandadaYRAPEn2024BCAPreliminarv20250127.DisplayName))
            {
                var entidades = ConvertirTablaAEntidades.ConvertirDataTableACapacidadDemandadaYRAPEn2024BCAPreliminarv20250127(tabla);

                try
                {
                    CapacidadDemandadaYRAPEn2024BCAPreliminarv20250127Command command = new();
                    command.CapacidadDemandadaYRAPEn2024BCAPreliminarv20250127s = entidades;

                    await _mediator.Send(command);
                }
                catch (Exception ex)
                {
                    throw;
                }

            }

        }
    }
}
