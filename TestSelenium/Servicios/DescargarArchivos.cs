using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSelenium.Servicios
{
    class DescargarArchivos
    {
        public static async Task<string> DescargarArchivoComoBase64(string fileUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                byte[] fileBytes = await client.GetByteArrayAsync(fileUrl);
                return Convert.ToBase64String(fileBytes); // Convertir a Base64
            }
        }
    }
}
