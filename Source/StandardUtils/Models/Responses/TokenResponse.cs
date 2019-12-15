using System;
using System.Collections.Generic;
using System.Text;

namespace StandardUtils.Models.Responses
{
    [Serializable]
    public class TokenResponse
    {
        public bool isOk { get; set; }
        public Guid token { get; set; }
    }
}
