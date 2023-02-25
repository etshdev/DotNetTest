using DotNetTest.BLL;
using DotNetTest.DTO;
using DotNetTest.Tables;
using Microsoft.AspNetCore.Mvc;

namespace DotNetTest.API.Controllers
{
    [ApiController]
    [Route("/[controller]/[action]")]
    public class DriverController : ControllerBase
    {
        private readonly DriverBll _driverBll;
        public DriverController(DriverBll driverBll)
        {
            _driverBll = driverBll;
        }
        

        /// <summary>
        /// This Action To return All Driver
        /// </summary>
        /// <returns>List Of Drivers</returns>
        [HttpGet]
        public IEnumerable<Driver> GetAllDriver()
        {
           return   _driverBll.GetAllDrivers().ToList();
        }


        /// <summary>
        /// This Action To return  Driver
        /// </summary>
        /// <returns>one Of Drivers</returns>
        [HttpGet]
        public Driver GetDriverById(Guid id)
        {
            return _driverBll.GetDriverById(id);
        }

        /// <summary>
        /// This Action To Add A new  Driver
        /// </summary>
        /// <returns>Status Of Adding </returns>
        [HttpPost]
        public ResultDTO Add(DriverDTO Driver)
        {
            return _driverBll.Add(Driver);
 
        }


        /// <summary>
        /// This Action To Update A   Driver
        /// </summary>
        /// <returns>Status Of Updating </returns>
        
        [HttpPost]
        public ResultDTO Update(DriverDTO Driver)
        {
            return _driverBll.Update(Driver);

        }

        /// <summary>
        /// This Action To Delete A   Driver
        /// </summary>
        /// <returns>Status Of Deleteing </returns>
         
        [HttpGet]
        public ResultDTO Delete(Guid Id)
        {
            return _driverBll.Delete(Id);

        }
    }
}
