using Models;
using Service;

namespace Controller
{
    public class GenericController
    {
        private GenericService _GenericService;

        public GenericController()
        {
            _GenericService = new GenericService();
        }
        public bool Insert(Generic generic)
        {
            return _GenericService.Insert(generic);
        }

    }
}
