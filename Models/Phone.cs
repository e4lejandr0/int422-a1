using System;
using System.ComponentModel.DataAnnotations;

namespace INT422A1.Models
{
    public class Phone
    {
        public Guid Id{ get; set; }
        public string PhoneName{ get; set; }
        public string Manufacturer{ get; set; }
        [DisplayFormat(DataFormatString = "{:d}")]
        public DateTime DateReleased{ get; set; }
        [DataType(DataType.Currency)]
        public float MSRP{ get; set; }
        public double ScreenSize{ get; set; }
    }
}
