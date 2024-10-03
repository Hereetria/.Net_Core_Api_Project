using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.RoomDto
{
    public class RoomAddDto
    {
        [Required(ErrorMessage = "Lütfen oda numarası girin")]
        public string RoomNumber { get; set; }

        public string RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Lütfen fiyat bilgisi girin")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Lütfen oda başlığı bilgisi girin")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Lütfen yatak sayısı girin")]
        public string BedCount { get; set; }

        [Required(ErrorMessage = "Lütfen yatak sayısı girin")]
        public string BathCount { get; set; }

        public string Wifi { get; set; }

        public string Description { get; set; }
    }
}
