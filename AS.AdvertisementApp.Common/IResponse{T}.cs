using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS.AdvertisementApp.Common
{
    public interface IResponse<T> : IResponse
    {
        T Data { get; set; }
        List<CustomValidationError> ValidataionErrors { get; set; }
    }
}
