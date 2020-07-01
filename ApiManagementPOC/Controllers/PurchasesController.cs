using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiManagementPOC.Controllers
{
    [Route("api")]
    [ApiController]
    public class PurchasesController : ControllerBase
    {
        [HttpGet("/{userId}/[controller]/{purchaseId}")]
        public IActionResult GetPurchase(int userId, int purchaseId)
        {
            return Ok($"User {userId} and Purcase {purchaseId}");
        }

        [HttpPut("/{userId}/[controller]/{itemId}")]
        public IActionResult Buy(int userId, int itemId)
        {
            return Ok($"User {userId} bought {itemId}");
        }
    }
}