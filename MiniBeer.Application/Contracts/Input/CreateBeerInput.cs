using Newtonsoft.Json;

namespace MiniBeer.Application.Contracts.Input
{
	public class CreateBeerInput
	{
		[JsonProperty("name")]
		public string Name { get; set; } = string.Empty;

        [JsonProperty("price")]
        public float Price { get; set; }
	}
}

