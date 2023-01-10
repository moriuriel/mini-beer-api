namespace MiniBeer.Application.Extensions
{
	public static class ValidationExtensions
	{
		public static List<string> GetNotifications(this FluentValidation.Results.ValidationResult validationResult)
		{
			if (validationResult is null)
			{
				return new List<string>();
			}

			return validationResult.Errors.Select(s =>
			{
				return s.ErrorMessage;
			}).ToList();
		}
	}
}

