using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataObjects;

namespace ScannerApp.Backend.Apis
{
    public class Login : ApiBase
    {
        public async Task<LoginBo> LoginTask(string pin)
        {
            var dictionary = new Dictionary<string, string> {{"pin", pin}};
            var result = await HttpClinetHelper.HttpPostRequest<LoginBo>(LoginApi, dictionary);
            return result;
        }
    }
}
