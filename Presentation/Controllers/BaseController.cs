using Microsoft.AspNetCore.Mvc;

using System.Net;

using Domain.Common;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Presentation.Controllers
{
    [Route("api")]
    [ApiController]
    public abstract class BaseController : ControllerBase
    {
        /// <summary>
        ///     Este método serve para que evitemos repetir muito o código, entao fazemos a chamada dele e ele decidira qual
        ///     retorno deve voltar
        /// </summary>
        /// <param name="statusCode"></param>
        /// <param name="basicResult"></param>
        /// <param name="responseMessage"></param>
        /// <param name="statusCodeError">Opcional HttpStatusCode.NotFound</param>
        /// <returns>ActionResult</returns>
        protected ActionResult ResponseBase(
            HttpStatusCode statusCode,
            BasicResult basicResult,
            string responseMessage,
            HttpStatusCode statusCodeError = HttpStatusCode.NotFound)
        {
            if (basicResult.IsFailure)
                return StatusCode(basicResult.Error.StatusCode, new BaseResponse<Error>(basicResult.Error));

            return StatusCode((int)statusCode, responseMessage);
        }

        /// <summary>
        ///     Este método serve para que evitemos repetir muito o código, entao fazemos a chamada dele e ele decidira qual
        ///     retorno deve voltar
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="statusCode"></param>
        /// <param name="basicResult"></param>
        /// <param name="statusCodeError">Opcional HttpStatusCode.NotFound</param>
        /// <returns>ActionResult</returns>
        protected ActionResult ResponseBase<T>(
            HttpStatusCode statusCode,
            BasicResult<T> basicResult,
            HttpStatusCode statusCodeError = HttpStatusCode.NotFound)
        {
            if (basicResult.IsFailure)
            {
                return StatusCode(basicResult.Error.StatusCode, basicResult.Error);
            }

            return StatusCode((int)statusCode, new BaseResponse<T>(basicResult.Value));
        }
    }
}
