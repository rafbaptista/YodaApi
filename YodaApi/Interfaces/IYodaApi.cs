using Refit;
using YodaApi.Requests;
using YodaApi.Responses;

namespace YodaApi.Interfaces
{
    public interface IYodaApi
    {
        [Get("/yoda.json?text={request.Text}")]
        Task<ResponseWrapper<YodaTranslateResponse>> Translate(YodaTranslateRequest request);
    }
}
