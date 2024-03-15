using EmaraDesign1.Models;
using Microsoft.EntityFrameworkCore;

namespace EmaraDesign1.Services
{
    public class ManagerProjectsService : IManagerProjectsService
    {
        private readonly ApplicationDbContext _context;

        public ManagerProjectsService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Create(Project project)
        {
            _context.Projects.Add(project);
            _context.SaveChanges();
        }

        public void Delete(Project project)
        {
            _context.Projects.Remove(project);
            _context.SaveChanges();
        }

        public List<Project> GetAll()
        {
            var proj = _context.Projects.Include(p => p.Client).ToList();
            return proj;

        }

        public List<Project> GetAllByClientId(int id)
        {
            var projects = _context.Projects.Include(p => p.Client).Where(p => p.ClientId == id).ToList();
            return projects;

        }

        public Project GetByName(string name)
        {
            return _context.Projects.Include(p => p.Client).FirstOrDefault(p => p.Name == name);
        }
        public void Update(Project project)
        {
            _context.Projects.Update(project);
            _context.SaveChanges();
        }
    }
}
