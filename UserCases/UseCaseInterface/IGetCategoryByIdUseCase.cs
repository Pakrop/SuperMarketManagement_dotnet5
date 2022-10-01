using CoreBusiness;

namespace UserCases.UseCaseInterface
{
    public interface IGetCategoryByIdUseCase
    {
        Category Execute(int categoryId);
    }
}