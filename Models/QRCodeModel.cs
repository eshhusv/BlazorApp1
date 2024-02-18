using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class QRCodeModel
    {
        [Display(Name = "Enter QRCode Text")]
        public string QRCodeText { get; set; }

    }
}
