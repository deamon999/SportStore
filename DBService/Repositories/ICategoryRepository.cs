using DBService.Models;

using PagingSortingTools;

using System;
using System.Collections.Generic;
using System.Text;

namespace DBService.Repositories
{
    interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }

        PagedList<Category> GetCategories(QueryOptions options);

        void AddCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(Category category);
    }
}
