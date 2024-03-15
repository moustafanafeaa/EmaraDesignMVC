using EmaraDesign1.Models;
using Microsoft.EntityFrameworkCore;

namespace EmaraDesign1.Services
{
    public class ClientProjectsService : IClientProjectsService
    {
        private readonly ApplicationDbContext _context;

        public ClientProjectsService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Project> GetAll()
        {
            var proj =  _context.Projects.Include(p => p.Client).ToList();
            return proj;

        }

        public List<Project> GetAllByClientId(int id)
        {
            var projects= _context.Projects.Include(p=>p.Client).Where(p=>p.ClientId==id).ToList();
            return projects;
                
        }

        public Project GetByName(string name)
        {
            return _context.Projects.Include(p => p.Client).FirstOrDefault(p=>p.Name==name);
        }
    }
}
