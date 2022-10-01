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
    public class AddCategoryUserCase : IAddCategoryUserCase
    {
        private readonly ICategoryRepository _categoryRepository;

        public AddCategoryUserCase(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void Excute(Category category)
        {
            _categoryRepository.AddCategory(category);
        }
    }
}
