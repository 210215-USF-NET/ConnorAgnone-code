using System.Collections.Generic;
using Model = ToHModels;
using Entity = ToHDL.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ToHModels;
namespace ToHDL
{
    public class HeroRepoDB : IHeroRepository
    {
        private Entity.StoreDBContext _context;
        private IMapper _mapper;
        public HeroRepoDB(Entity.StoreDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Model.Hero AddHero(Model.Hero newHero)
        {
            _context.Heroes.Add(_mapper.ParseHero(newHero));
            _context.SaveChanges();
            return newHero;
        }

        public List<Model.Hero> GetHeroes()
        {
            return _context.Heroes.Include("Superpowers").Select(x => _mapper.ParseHero(x)).ToList();
        }
                public Hero GetHeroByName(string name)
        {
            return _context.Heroes.Include("Superpowers").Select(x => _mapper.ParseHero(x)).ToList().FirstOrDefault(x => x.HeroName == name);
        }
    }
}