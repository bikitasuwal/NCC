using Microsoft.AspNetCore.Mvc;

namespace Bikita_4_interest.Models
{
    public class InterestModel
    {
        public decimal Principal { get; set; }
        public decimal Rate { get; set; }
        public decimal Time { get; set; }
        public decimal Result { get; set; }

    }

}
