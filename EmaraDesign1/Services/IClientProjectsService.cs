using EmaraDesign1.Models;

namespace EmaraDesign1.Services
{
    public interface IClientProjectsService
    {
        public List<Project> GetAll();
        public Project GetByName(string name);
        public List<Project> GetAllByClientId(int id);
    }
}
