using HotelProject.BussinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BussinessLayer.Concrete
{
    public class StaffManager : IStaffService
    {
        private readonly IStaffDal _staffdal;
        public StaffManager(IStaffDal staffDal)
        {
            _staffdal = staffDal;
        }

        public void TDelete(Staff t)
        {
            _staffdal.Delete(t);
        }

        public Staff TGetById(int id)
        {
            return _staffdal.GetById(id);
        }

        public List<Staff> TGetList()
        {
            return _staffdal.GetList();
        }

        public void TInsert(Staff t)
        {
            _staffdal.Insert(t);
        }

        public void TUpdate(Staff t)
        {
            _staffdal.Update(t);
        }
    }
}
