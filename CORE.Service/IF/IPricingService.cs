using CORE.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CORE.Service.IF
{
    public interface IPricingService
    {
        List<Pricing> GetAll();

        void Add(Pricing obj);

        void Update(Pricing obj);

        void Delete(string id);

        Pricing GetById(string id);

        void Save();

    }
}
