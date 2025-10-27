using System.Xml.Serialization;
using Biblio.Common.Models.Requests;

namespace Biblio.Common.Service.Interfaces
{
    public interface IBookService
    {
        public long Create(CreateBookRequest request);
    }
}