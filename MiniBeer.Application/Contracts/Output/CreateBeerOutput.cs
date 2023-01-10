namespace MiniBeer.Application.Contracts.Output
{
	public class CreateBeerOutput
	{
        public string Id { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public float Price { get; set; }
    }
}

