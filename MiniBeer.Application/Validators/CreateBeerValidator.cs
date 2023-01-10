using MiniBeer.Application.Contracts.Input;
using FluentValidation;

namespace MiniBeer.Application.Validators
{
	public class CreateBeerValidator: AbstractValidator<CreateBeerInput>
	{
		public CreateBeerValidator()
		{
			RuleFor(beer => beer.Name).NotEmpty();
			RuleFor(beer => beer.Price).NotNull().GreaterThan(0);
		}
	}
}

