﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BT.AdminRepository.IRepository;
using BT.Repositories;
using BT_Data.BT_EDMX;
using BT_Model;

namespace BT.AdminRepository
{
    public class CityRepo : ICityRepo
    {
        GUnitWork gWork=null;
        public CityRepo()
        {
            gWork = new BestTravelingEntities();
        }
        public void AddCity(CityModel model)
        {
            bt_City city = new bt_City();
            city.CityId = model.CityId;
            city.Name = model.Name;
            city.Code = model.Code;
            city.DistrictId = model.DistrictId;
            gWork.Repository<bt_City>().Add(city);
            gWork.SaveChanges();
        }

        public IQueryable<CityModel> GetCitis()
        {
            var cities =(from cts in gWork.Repository<bt_City>().AsQuerable()
                        select new CityModel {
                            CityId = cts.CityId,
                            Name = cts.Name,
                            DistrictId = cts.DistrictId,
                            Code = cts.Code,
            });
            return cities;
        }

        public CityModel GetCityById(Guid CityId)
        {
            var cities = (from x in gWork.Repository<bt_City>().AsQuerable()
                          select new CityModel
                          {
                              CityId = x.CityId,
                              Name = x.Name,
                              Code = x.Code,
                              DistrictId = x.DistrictId,
                          }).FirstOrDefault(x => x.CityId == CityId);
            return cities;
        }

        public void RemoveCity(CityModel model)
        {
            throw new NotImplementedException();
        }

        public void UpdateCity(CityModel model)
        {
            throw new NotImplementedException();
        }
    }
}
