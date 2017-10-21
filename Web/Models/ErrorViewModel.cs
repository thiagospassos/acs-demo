using System;
using System.Collections.Generic;

namespace Web.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

    public class ApiXResponse
    {
        public string Code { get; set; }
        public IEnumerable<string> Values { get; set; }
    }
}