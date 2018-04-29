using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class BaseBo : ObservableObject
    {
        public Error error { get; set; }
    }
    public class Error
    {
        public string message { get; set; }
        public int status_code { get; set; }
    }

}
