using DataAccessLayer.Repository;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutRepository _aboutRepository;

        public AboutManager(IAboutRepository aboutRepository)
        {
            _aboutRepository = aboutRepository;
        }

        public About GetById(int id)
        {
            return _aboutRepository.Get(id);
        }

        public void TAdd(About entity)
        {
            _aboutRepository.Create(entity);
        }

        public void TDelete(About entity)
        {
            _aboutRepository.Delete(entity);
        }

        public List<About> TGetList(About entity)
        {
            return _aboutRepository.GetAll();
        }

        public void TUpdate(About entity)
        {
            _aboutRepository.Update(entity);
        }
    }
}
