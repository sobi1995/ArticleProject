namespace Versioning_ASP.Net_Core_3_APIs_with_Swashbuckle.Model._ApiResult
{
    public class ApiResult
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public StatusApiResult StatusApiResult { get; set; }
    }
    public class ApiResult<TData>:ApiResult{
public TData Data { get; set; }

public static implicit operator  ApiResult<TData>(TData result){
    return new ApiResult<TData>{
        Data=result,
        IsSuccess=true,
        Message="S",
        StatusApiResult=StatusApiResult.one
    };
}

    }

    public enum StatusApiResult
    {
        one,
        tow
    }
}