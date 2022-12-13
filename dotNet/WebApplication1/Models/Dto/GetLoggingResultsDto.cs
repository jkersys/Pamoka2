namespace ApiMokymai.Models.Dto
{
    public class GetLoggingResultsDto
    {
        public GetLoggingResultsDto(string message)
        {
            Message = message;
        }

        public string Message { get; set; }
    }
}
