using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Models.Staff
{
    public class UpdateStaffViewModel
    {
        public int StaffId { get; set; }
        [Required(ErrorMessage = "Hizmet ikon link ekleyiniz")]
        public string Name { get; set; }
        public string Title { get; set; }
        public string SocialMedia1 { get; set; }
        public string SocialMedia2 { get; set; }
        public string SocialMedia3 { get; set; }
    }
}
