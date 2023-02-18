namespace Examen.Data.Results
{
    public class ErrorResult
    {
        public bool Success { get; set; }
        public EnumResult Error_Code { get; set; }
        public string Error_Msg { get; set; }

    }

}
