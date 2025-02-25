using System.Data;
using OfficeOpenXml;

namespace TestSelenium.Servicios
{
    class LeerExcel
    {
        public static DataTable LeerExcelDesdeBase64(string base64File)
        {
            byte[] fileBytes = Convert.FromBase64String(base64File); // Convertir Base64 a bytes

            using (MemoryStream stream = new MemoryStream(fileBytes))
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial; // Requerido para EPPlus

                using (var package = new ExcelPackage(stream))
                {
                    var worksheet = package.Workbook.Worksheets[0]; // Primera hoja
                    var dataTable = new DataTable();

                    int colCount = worksheet.Dimension.End.Column;
                    int rowCount = worksheet.Dimension.End.Row;

                    int headerRow = 8;     // Fila donde están los nombres de las columnas
                    int dataStartRow = 9;  // Fila donde empiezan los datos

                    // Obtener nombres de columna desde la fila 8
                    for (int col = 1; col <= colCount; col++)
                    {
                        dataTable.Columns.Add(worksheet.Cells[headerRow, col].Text);
                    }

                    // Obtener los datos desde la fila 9
                    for (int row = dataStartRow; row <= rowCount; row++)
                    {
                        var dataRow = dataTable.NewRow();
                        for (int col = 1; col <= colCount; col++)
                        {
                            dataRow[col - 1] = worksheet.Cells[row, col].Text;
                        }
                        dataTable.Rows.Add(dataRow);
                    }

                    return dataTable;
                }
            }
        }
    }
}
