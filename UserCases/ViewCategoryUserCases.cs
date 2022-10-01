using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserCases.PluginInterfaces;
using UserCases.UseCaseInterface;

namespace UserCases
{
    public class ViewCategoryUserCases : IViewCategoryUserCases
    {
        private readonly ICategoryRepository _categoryRepository;

        public ViewCategoryUserCases(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IEnumerable<Category> Excute()
        {
            return _categoryRepository.GetCategories();
        }
    }
}
