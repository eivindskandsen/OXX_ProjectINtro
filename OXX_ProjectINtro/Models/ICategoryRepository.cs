using System.Collections.Generic;

namespace OXX_ProjectINtro.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
