using Microsoft.AspNetCore.Mvc;
using MiniBeer.Application.Contracts.Input;
using MiniBeer.Application.Contracts.Output;
using MiniBeer.Application.UseCases;
using MiniBeer.Application.Validators;
using FluentValidation.Results;
using MiniBeer.Application.Extensions;

namespace Beer.Api.Controllers.V1
{
    [ApiController]
    [Route("/v1/beers")]
    public class BeerController : Controller
    {
        private readonly CreateBeerUseCase _createBeerUseCase;
        private readonly CreateBeerValidator _createBeerValidator;

        public BeerController(CreateBeerUseCase createBeerUseCase, CreateBeerValidator createBeerValidator)
        {
            _createBeerUseCase = createBeerUseCase;
            _createBeerValidator = createBeerValidator;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateBeerInput input)
        {
            try
            {
                ValidationResult validation = await _createBeerValidator.ValidateAsync(input);
                List<string> errorList = new List<string>();
                if (!validation.IsValid)
                {
                    List<String> errors = validation.GetNotifications();

                    return StatusCode(StatusCodes.Status400BadRequest, errors);
                }

                CreateBeerOutput output = _createBeerUseCase.CreateBeerAsync(input);

                return Created(output.Id, output);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.StackTrace);
            }
        }
	}
}

