using System.Data;
using PruebaTecnica.Dominio.Entidades;

namespace TestSelenium.Servicios
{
    public class ConvertirTablaAEntidades
    {
        //CapacidadDemandadaYRAPEn2024SINv20250131
        public static CapacidadDemandadaYRAPEn2024SINv20250131[] ConvertirDataTableACapacidadDemandadaYRAPEn2024SINv20250131(DataTable tabla)
        {
            var lista = new List<CapacidadDemandadaYRAPEn2024SINv20250131>();

            foreach (DataRow row in tabla.Rows)
            {
                var item = new CapacidadDemandadaYRAPEn2024SINv20250131
                {
                    ZonaDePotencia = row[0].ToString() ?? string.Empty,
                    Participante = row[1].ToString() ?? string.Empty,
                    SubCuentaDelParticipante = row[2].ToString() ?? string.Empty,
                    CapacidadDemandadaMW = double.TryParse(row[3].ToString(), out double capacidad) ? capacidad : 0,
                    RequisitoAnualDePotenciaMWAnio = double.TryParse(row[4].ToString(), out double requisito) ? requisito : 0,
                    ValorDelRequisitoAnualDePotenciaEficienteMWAnio = double.TryParse(row[5].ToString(), out double valor) ? valor : 0
                };

                lista.Add(item);
            }

            return lista.ToArray();
        }

        //CapacidadDemandadaYRAPEn2024SINPreliminarv20250127
        public static CapacidadDemandadaYRAPEn2024SINPreliminarv20250127[] ConvertirDataTableACapacidadDemandadaYRAPEn2024SINPreliminarv20250127(DataTable tabla)
        {
            var lista = new List<CapacidadDemandadaYRAPEn2024SINPreliminarv20250127>();

            foreach (DataRow row in tabla.Rows)
            {
                var item = new CapacidadDemandadaYRAPEn2024SINPreliminarv20250127
                {
                    ZonaDePotencia = row[0].ToString() ?? string.Empty,
                    Participante = row[1].ToString() ?? string.Empty,
                    SubCuentaDelParticipante = row[2].ToString() ?? string.Empty,
                    CapacidadDemandadaMW = double.TryParse(row[3].ToString(), out double capacidad) ? capacidad : 0,
                    RequisitoAnualDePotenciaMWAnio = double.TryParse(row[4].ToString(), out double requisito) ? requisito : 0,
                    ValorDelRequisitoAnualDePotenciaEficienteMWAnio = double.TryParse(row[5].ToString(), out double valor) ? valor : 0
                };

                lista.Add(item);
            }

            return lista.ToArray();
        }

        //CapacidadDemandadaYRAPEn2024BCSv20250131
        public static CapacidadDemandadaYRAPEn2024BCSv20250131[] ConvertirDataTableACapacidadDemandadaYRAPEn2024BCSv20250131(DataTable tabla)
        {
            var lista = new List<CapacidadDemandadaYRAPEn2024BCSv20250131>();

            foreach (DataRow row in tabla.Rows)
            {
                var item = new CapacidadDemandadaYRAPEn2024BCSv20250131
                {
                    ZonaDePotencia = row[0].ToString() ?? string.Empty,
                    Participante = row[1].ToString() ?? string.Empty,
                    SubCuentaDelParticipante = row[2].ToString() ?? string.Empty,
                    CapacidadDemandadaMW = double.TryParse(row[3].ToString(), out double capacidad) ? capacidad : 0,
                    RequisitoAnualDePotenciaMWAnio = double.TryParse(row[4].ToString(), out double requisito) ? requisito : 0,
                    ValorDelRequisitoAnualDePotenciaEficienteMWAnio = double.TryParse(row[5].ToString(), out double valor) ? valor : 0
                };

                lista.Add(item);
            }

            return lista.ToArray();
        }
        //CapacidadDemandadaYRAPEn2024BCSPreliminarv20250127
        public static CapacidadDemandadaYRAPEn2024BCSPreliminarv20250127[] ConvertirDataTableACapacidadDemandadaYRAPEn2024BCSPreliminarv20250127(DataTable tabla)
        {
            var lista = new List<CapacidadDemandadaYRAPEn2024BCSPreliminarv20250127>();

            foreach (DataRow row in tabla.Rows)
            {
                var item = new CapacidadDemandadaYRAPEn2024BCSPreliminarv20250127
                {
                    ZonaDePotencia = row[0].ToString() ?? string.Empty,
                    Participante = row[1].ToString() ?? string.Empty,
                    SubCuentaDelParticipante = row[2].ToString() ?? string.Empty,
                    CapacidadDemandadaMW = double.TryParse(row[3].ToString(), out double capacidad) ? capacidad : 0,
                    RequisitoAnualDePotenciaMWAnio = double.TryParse(row[4].ToString(), out double requisito) ? requisito : 0,
                    ValorDelRequisitoAnualDePotenciaEficienteMWAnio = double.TryParse(row[5].ToString(), out double valor) ? valor : 0
                };

                lista.Add(item);
            }

            return lista.ToArray();
        }
        //CapacidadDemandadaYRAPEn2024BCAv20250131
        public static CapacidadDemandadaYRAPEn2024BCAv20250131[] ConvertirDataTableACapacidadDemandadaYRAPEn2024BCAv20250131(DataTable tabla)
        {
            var lista = new List<CapacidadDemandadaYRAPEn2024BCAv20250131>();

            foreach (DataRow row in tabla.Rows)
            {
                var item = new CapacidadDemandadaYRAPEn2024BCAv20250131
                {
                    ZonaDePotencia = row[0].ToString() ?? string.Empty,
                    Participante = row[1].ToString() ?? string.Empty,
                    SubCuentaDelParticipante = row[2].ToString() ?? string.Empty,
                    CapacidadDemandadaMW = double.TryParse(row[3].ToString(), out double capacidad) ? capacidad : 0,
                    RequisitoAnualDePotenciaMWAnio = double.TryParse(row[4].ToString(), out double requisito) ? requisito : 0,
                    ValorDelRequisitoAnualDePotenciaEficienteMWAnio = double.TryParse(row[5].ToString(), out double valor) ? valor : 0
                };

                lista.Add(item);
            }

            return lista.ToArray();
        }
        //CapacidadDemandadaYRAPEn2024BCAPreliminarv20250127
        public static CapacidadDemandadaYRAPEn2024BCAPreliminarv20250127[] ConvertirDataTableACapacidadDemandadaYRAPEn2024BCAPreliminarv20250127(DataTable tabla)
        {
            var lista = new List<CapacidadDemandadaYRAPEn2024BCAPreliminarv20250127>();

            foreach (DataRow row in tabla.Rows)
            {
                var item = new CapacidadDemandadaYRAPEn2024BCAPreliminarv20250127
                {
                    ZonaDePotencia = row[0].ToString() ?? string.Empty,
                    Participante = row[1].ToString() ?? string.Empty,
                    SubCuentaDelParticipante = row[2].ToString() ?? string.Empty,
                    CapacidadDemandadaMW = double.TryParse(row[3].ToString(), out double capacidad) ? capacidad : 0,
                    RequisitoAnualDePotenciaMWAnio = double.TryParse(row[4].ToString(), out double requisito) ? requisito : 0,
                    ValorDelRequisitoAnualDePotenciaEficienteMWAnio = double.TryParse(row[5].ToString(), out double valor) ? valor : 0
                };

                lista.Add(item);
            }

            return lista.ToArray();
        }

    }
}
