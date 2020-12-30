using CORE.Data.Infrastructor;
using CORE.Domain.Models;
using CORE.Service.IF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CORE.Service.EF
{
    public class PricingService : IPricingService
    {
        private readonly IRepository<Pricing, string> _pricingService;

        public PricingService(IRepository<Pricing, string> pricingRepository)
        {
            _pricingService = pricingRepository;
        }


        public void Add(Pricing obj)
        {
             _pricingService.Add(obj);
        }
     

        public void Delete(string id)
        {
            _pricingService.Remove(id);
        }

        public List<Pricing> GetAll()
        {
            return _pricingService.FindAll().ToList();
        }

        public Pricing GetById(string id)
        {
            return _pricingService.FindById(id);
        }

        public void Save()
        {
            _pricingService.SaveChange();
        }

        public void Update(Pricing obj)
        {
            _pricingService.Update(obj);
        }
    }
}
