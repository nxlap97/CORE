using CORE.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CORE.Service.IF
{
    public interface ISettingService
    {
        List<Setting> GetAll();

        void Add(Setting obj);

        void Update(Setting obj);

        void Delete(string id);

        Setting GetById(string id);

        void Save();
    }
}
