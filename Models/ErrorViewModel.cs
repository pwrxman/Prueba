using System;

namespace WebApplication1.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        //este es un cometario de prueba para git

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}