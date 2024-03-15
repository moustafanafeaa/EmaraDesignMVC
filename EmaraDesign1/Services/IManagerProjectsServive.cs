using EmaraDesign1.Models;

namespace EmaraDesign1.Services
{
    public interface IManagerProjectsService : IClientProjectsService

    { 
        public void Create(Project project);
        public void Delete(Project project);
        public void Update(Project project);
    }
}
