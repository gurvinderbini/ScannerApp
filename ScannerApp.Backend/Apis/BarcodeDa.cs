using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataObjects;

namespace ScannerApp.Backend.Apis
{
    public class BarcodeDa : ApiBase
    {
        public async Task<BarcodeBo> ValidateBarcode(string barcode, string stationId, string employeeId, string token)
        {
            string url = String.Format(BarcodeApi, barcode, stationId, employeeId, token);

            var result = await HttpClinetHelper.HttpGetRequest<BarcodeBo>(url);
            return result;
        }
    }
}
