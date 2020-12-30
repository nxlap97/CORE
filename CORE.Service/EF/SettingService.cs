using CORE.Data.Infrastructor;
using CORE.Domain.Models;
using CORE.Service.IF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CORE.Service.EF
{
    public class SettingService : ISettingService
    {
        private readonly IRepository<Setting, string> _settingService;

        public SettingService(IRepository<Setting, string> settingService)
        {
            _settingService = settingService;
        }

        public void Add(Setting obj)
        {
            _settingService.Add(obj);
        }

        public void Delete(string id)
        {
            _settingService.Remove(id);
        }

        public List<Setting> GetAll()
        {
            return _settingService.FindAll().ToList();
        }

        public Setting GetById(string id)
        {
            return _settingService.FindById(id);
        }

        public void Save()
        {
            _settingService.SaveChange();
        }

        public void Update(Setting obj)
        {
            _settingService.Update(obj);
        }
    }
}
