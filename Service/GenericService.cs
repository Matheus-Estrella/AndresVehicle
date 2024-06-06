using Models;
using Repository;

namespace Service
{
    public class GenericService
    {
        private GenericRepository _GenericRepository;

        public GenericService()
        {
            _GenericRepository = new GenericRepository();
        }
        public bool Insert(Generic generic)
        {
            return _GenericRepository.Insert(generic);
        }

    }
}
