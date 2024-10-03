using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.RoomDto
{
    public class UpdataRoomDto
    {
        public int RoomID { get; set; }

        [Required(ErrorMessage = "Lütfen oda numarası girin")]
        public string RoomNumber { get; set; }

        [Required(ErrorMessage = "Lütfen oda görseli girin")]
        public string RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Lütfen fiyat bilgisi girin")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Lütfen oda başlığı bilgisi girin")]
        [StringLength(20,ErrorMessage = "Lütfen en fazla 20 karakter girin")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Lütfen yatak sayısı girin")]
        public string BedCount { get; set; }

        [Required(ErrorMessage = "Lütfen banyo sayısı girin")]
        public string BathCount { get; set; }

        [Required(ErrorMessage = "Lütfen wifi adresi girin")]
        public string Wifi { get; set; }

        [Required(ErrorMessage = "Lütfen açıklama girin")]
        public string Description { get; set; }
    }
}
