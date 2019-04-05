using System.Linq.Expressions;
using System.Threading.Tasks;
using GamesFree.Domain;

namespace GamesFree.Repositoy.repositoryClass
{
    public class GameRepository : RepositoryBase<Game>, IGameRepository
    {
        public GameRepository(DataContext context) : base(context)
        {
        }
    }
}