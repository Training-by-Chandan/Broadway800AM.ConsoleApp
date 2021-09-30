using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECom.ViewModels
{
    public class RequestViewModel
    {
    }

    public class ResponeViewModel
    {
        public bool Status { get; set; } = false;
        public string Message { get; set; }
    }
}