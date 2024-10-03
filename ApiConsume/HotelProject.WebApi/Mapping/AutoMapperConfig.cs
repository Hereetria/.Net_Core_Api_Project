using AutoMapper;
using HotelProject.DtoLayer.RoomDto;
using HotelProject.DataAccessLayer.Concrete;

namespace HotelProject.WebApi.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<RoomAddDto, Room>();
            CreateMap<Room, RoomAddDto>();

            CreateMap<UpdataRoomDto, Room>().ReverseMap();
        }
    }
}
