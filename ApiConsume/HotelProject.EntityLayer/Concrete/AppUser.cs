using Microsoft.AspNetCore.Identity;

namespace HotelProject.EntityLayer.Concrete
{
    public class AppUser:IdentityUser<int>
    {//v39
      
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string ImagesUrl { get; set; }
        public string WorkDepartment { get; set; }

        public int WorkLocationId { get; set; }
        public WorkLocation WorkLocation { get; set; }
    }
}
