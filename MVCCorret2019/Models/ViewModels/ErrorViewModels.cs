using System;

namespace MVCCorret2019.Models.ViewModels
{
    public class ErrorViewModels
    {
        public string RequestId { get; set; }
        public string Message { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}