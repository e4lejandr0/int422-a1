using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace INT422A1.Models
{
    public class Phone
    {
        public Guid Id{ get; set; }
        [DisplayName("Phone Name")]
        public string PhoneName{ get; set; }
        public string Manufacturer{ get; set; }
        [DisplayName("Release Date")]
        [DisplayFormat(DataFormatString = "{0: dd ddd, MMMM yyyy}")]
        public DateTime DateReleased{ get; set; }
        [DataType(DataType.Currency)]
        public float MSRP{ get; set; }
        [DisplayFormat(DataFormatString = "{0:0.00}\"")]
        [DisplayName("Screen Size")]
        public double ScreenSize{ get; set; }
    }
}
