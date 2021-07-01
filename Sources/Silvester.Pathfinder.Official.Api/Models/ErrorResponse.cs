namespace Silvester.Pathfinder.Official.Api.Models
{
    public record ErrorResponse
    {
        public string Message { get; }
        public object? Details { get; }

        public ErrorResponse(string message, object? details = null)
        {
            Message = message;
            Details = details;
        }
    }
}
