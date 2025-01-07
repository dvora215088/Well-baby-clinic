using BL;
using DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tipat.Controllers;

namespace Tests
{
    public class TestBabies
    {
        private object exception;

        [Fact]
        public void Test1()
        {
            var id = -1  ;
            
            var controller = new AppointmentController(new AppointmentService(new DataContext()));
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => controller.Get(id));
                  Assert.Equal("AppointmentId cannot be less than zero. (Parameter 'id')", exception.Message);
        }


    }
}
