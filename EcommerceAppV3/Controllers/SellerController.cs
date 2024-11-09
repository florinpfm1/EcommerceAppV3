using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAppV3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellerController : ControllerBase
    {
        private readonly ISender _sender;

        public SellerController(ISender sender)
        {
            _sender = sender;
        }







    }
}
