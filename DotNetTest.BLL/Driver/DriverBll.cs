using AutoMapper;
using DotNetTest.Common.General;
using DotNetTest.DAL.DesignPattern;
using DotNetTest.DTO;
using DotNetTest.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTest.BLL
{
    public class DriverBll
    {
        private readonly IRepository<Driver> _Driver;
        private readonly IMapper _mapper;

        public DriverBll(IRepository<Driver> Driver, IMapper mapper)
        {
            _Driver = Driver;   
            _mapper = mapper;   
        }


        #region Get

        /// <summary>
        /// To Get all Drivers
        /// </summary>
        /// <returns></returns>
        public IQueryable<Driver> GetAllDrivers()
        {
            return _Driver.GetAllAsNoTracking().Where(x=>!x.IsDeleted && x.IsActive);
        }

        /// <summary>
        /// To Get  Driver
        /// </summary>
        /// <returns></returns>
        public Driver GetDriverById(Guid DriverId)
        {
            return _Driver.GetById(DriverId);
        }


        #endregion


        #region Add 

        /// <summary>
        /// TO Add A new Driver
        /// </summary>
        /// <param name="DriverDTO"></param>
        /// <returns></returns>
        public ResultDTO Add(DriverDTO DriverDTO)
        {
            ResultDTO resultViewModel = new ResultDTO();

            Driver driver = _mapper.Map<Driver>(DriverDTO);
           
            var Add=_Driver.Insert(driver);

            if(Add)
            {
                resultViewModel.Status = true;
                resultViewModel.Message = AppConstants.Messages.AddSuccess;
                resultViewModel.data = driver;
            }
            else
            {
                resultViewModel.Status = false;
                resultViewModel.Message = AppConstants.Messages.AddFailed;
                resultViewModel.data = driver;

            }

            return resultViewModel;
        }
        #endregion


        #region Update 

        /// <summary>
        /// TO Update A  Driver
        /// </summary>
        /// <param name="DriverDTO"></param>
        /// <returns></returns>
        public ResultDTO Update(DriverDTO DriverDTO)
        {
            ResultDTO resultViewModel = new ResultDTO();

            Driver driver = _mapper.Map<Driver>(DriverDTO);

            var Updated = _Driver.Update(driver);

            if (Updated)
            {
                resultViewModel.Status = true;
                resultViewModel.Message = AppConstants.Messages.SavedSuccess;
                resultViewModel.data = driver;
            }
            else
            {
                resultViewModel.Status = false;
                resultViewModel.Message = AppConstants.Messages.SavedFailed;
                resultViewModel.data = driver;

            }

            return resultViewModel;
        }
        #endregion


        #region Delete 

        /// <summary>
        /// TO Delete A  Driver
        /// </summary>
        /// <param name="DriverDTO"></param>
        /// <returns></returns>
        public ResultDTO Delete(Guid id)
        {
            ResultDTO resultViewModel = new ResultDTO();

            var driver = _Driver.GetById(id);
            if(driver != null)
            {
                driver.IsDeleted = true;
                var IsDeleted = _Driver.Update(driver);

                if (IsDeleted)
                {
                    resultViewModel.Status = IsDeleted;
                    resultViewModel.Message = IsDeleted ? AppConstants.Messages.DeletedSuccess : AppConstants.Messages.DeletedFailed;
                }
                return resultViewModel;

            }

            resultViewModel.Status=false;
            resultViewModel.Message = AppConstants.Messages.NotFound;
            return resultViewModel;


        }
        #endregion



    }
}
