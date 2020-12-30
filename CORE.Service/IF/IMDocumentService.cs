using CORE.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CORE.Service.IF
{
    public interface IMDocumentService
    {
        List<MDocument> GetAll();

        void Add(MDocument obj);

        void Update(MDocument obj);

        void Delete(string id);

        MDocument GetById(string id);

        void Save();

    }
}
