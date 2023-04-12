using MiniBeer.Application.Contracts.Input;
using MiniBeer.Application.Contracts.Output;
using MiniBeer.Application.Validators;

namespace MiniBeer.Application.UseCases
{
    public interface ICreateBeerUseCase
    {
        CreateBeerOutput CreateBeerAsync(CreateBeerInput input);
    }

    public class CreateBeerUseCase: ICreateBeerUseCase 
    {
        private readonly CreateBeerValidator _createBeerValidator;

        public CreateBeerUseCase(CreateBeerValidator createBeerValidator)
        {
            _createBeerValidator = createBeerValidator;
        }

        public CreateBeerOutput CreateBeerAsync(CreateBeerInput input)
		{
            Guid myuuid = Guid.NewGuid();

            var beer = new CreateBeerOutput()
            {
                Id = myuuid.ToString(),
                Name = input.Name.ToUpper(),
                Price = input.Price,
            };

            return beer;
        }
    }
}

