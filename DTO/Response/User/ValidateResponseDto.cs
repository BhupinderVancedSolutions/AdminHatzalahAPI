namespace DTO.Response.User
{
    public class ValidateResponseDto<T> where T : class
    {
        public T Data { get; set; }
        public string Message { get; set; }
        public bool IsValid { get; set; }
    }
}
