using System.Collections.Generic;

namespace AAServer.Domain.Base.ValidationHttp
{
    public class ValidationResultHttpServer : ValidationHttpBase
    {
        public EnumStatusValidation Status { get; set; }
        public string ErrorMessage { get; set; }   
        public string SuccessMessage { get; set; }
    }
}
