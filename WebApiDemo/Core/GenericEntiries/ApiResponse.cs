using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDemo.Core.GenericEntiries
{
    public class ApiResponse
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public bool Is_Display_Message { get; set; }
        public object Data { get; set; }
        public Error Error { get; set; }
    }
}
