using CoreBusiness;
using System.Collections.Generic;

namespace UserCases.UseCaseInterface
{
    public interface IViewCategoryUserCases
    {
        IEnumerable<Category> Excute();
    }
}