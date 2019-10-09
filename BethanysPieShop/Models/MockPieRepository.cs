using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class MockPieRepository: IPieRepository
    {
        private readonly ICategoryRepository _ = new MockCategoryRepository();

        public IEnumerable<Pie> AllPies =>
            new List<Pie>
            {
                new Pie {PieId = 1, Name="Strawberry Pie", Price=15.95M, ShortDescription="lorem ipsum", LongDescription="lorem ipsum"},
                new Pie {PieId = 1, Name="Cheesecake", Price=19.95M, ShortDescription="lorem ipsum", LongDescription="lorem ipsum"},
                new Pie {PieId = 1, Name="Rhubarb Pie", Price=15.95M, ShortDescription="lorem ipsum", LongDescription="lorem ipsum"},
                new Pie {PieId = 1, Name="Pumpkin Pie", Price=12.95M, ShortDescription="lorem ipsum", LongDescription="lorem ipsum"}
            };

        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie GetPieById(int PieId) 
        {
            return AllPies.FirstOrDefault(p => p.PieId == PieId);
        }
    }
}
