﻿using System;
using System.Collections.Generic;
using System.Text;
using ScannerApp.Backend.HttpClinetHelper;

namespace ScannerApp.Backend.Apis
{
   public class ApiBase
    {
        public static HttpClientHelper HttpClinetHelper = new HttpClientHelper();

        public const string BaseUrl = @"http://lcc.velitsol.com/";

        public const string LoginApi = "api/auth/tix/login";

    }
}
