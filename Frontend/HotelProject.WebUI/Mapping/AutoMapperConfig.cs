using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.AboutDto;
using HotelProject.WebUI.Dtos.AppUserDto;
using HotelProject.WebUI.Dtos.BookingDto;
using HotelProject.WebUI.Dtos.ContactDto;
using HotelProject.WebUI.Dtos.GuestDto;
using HotelProject.WebUI.Dtos.LoginDto;
using HotelProject.WebUI.Dtos.RegisterDto;
using HotelProject.WebUI.Dtos.ServiceDto;
using HotelProject.WebUI.Dtos.StaffDto;
using HotelProject.WebUI.Dtos.SubscribeDto;
using HotelProject.WebUI.Models.Staff;

namespace HotelProject.WebUI.Mapping
{
    public class AutoMapperConfig:Profile
    { //v35
        public AutoMapperConfig()
        {//v35
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<AddServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            //v41
            CreateMap<AddRegisterDto, AppUser>().ReverseMap();
            //41
            //v42
            CreateMap<LoginUserDto, AppUser>().ReverseMap();

            //v42
            //v47
            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();
            //v47
            //52
            CreateMap<ResultStafDto, Staff>().ReverseMap();
            //52
            //53
            CreateMap<AddSubscribeDto, Subscribe>().ReverseMap();
            //53
            //v59
            CreateMap<AddBookingDto, Booking>().ReverseMap();
            //v59
            //v62
            CreateMap<ApprovedReservationDto, Booking>().ReverseMap();
            //v62
            //v91
            CreateMap<SendMessageDto, Contact>().ReverseMap();
            //v91
            //v99
            CreateMap<AddGuestDto, Guest>().ReverseMap();
            //v99
            //v101
            CreateMap<AddGuestDto, Guest>().ReverseMap();
            //v101

            //142
            CreateMap<ResultAppUserDto, AppUser>().ReverseMap();
            //142
        }
    }
}
