using CORE.Data.Infrastructor;
using CORE.Domain.Models;
using CORE.Service.IF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CORE.Service.EF
{
    public class MDocumentService : IMDocumentService
    {
        private readonly IRepository<MDocument, string> _documentRepository;

        public MDocumentService(IRepository<MDocument, string> documentRepository)
        {
            _documentRepository = documentRepository;
        }

        public void Add(MDocument obj)
        {
            _documentRepository.Add(obj);
        }

        public void Delete(string id)
        {
            _documentRepository.Remove(id);
        }

        public List<MDocument> GetAll()
        {
            return _documentRepository.FindAll().ToList();
        }

        public MDocument GetById(string id)
        {
            return _documentRepository.FindById(id);
        }

        public void Save()
        {
            _documentRepository.SaveChange();
        }

        public void Update(MDocument obj)
        {
            _documentRepository.Update(obj);
        }
    }
}
