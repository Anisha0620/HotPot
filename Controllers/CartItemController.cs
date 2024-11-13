// Controllers/CartItemController.cs
using HotPot.Models;
using HotPot.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotPot.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartItemController : ControllerBase
    {
        private readonly ICartItemService _cartItemService;

        public CartItemController(ICartItemService cartItemService)
        {
            _cartItemService = cartItemService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CartItem>> GetCartItemById(int id)
        {
            var cartItem = await _cartItemService.GetCartItemByIdAsync(id);
            if (cartItem == null)
                return NotFound();
            return Ok(cartItem);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CartItem>>> GetAllCartItems()
        {
            var cartItems = await _cartItemService.GetAllCartItemsAsync();
            return Ok(cartItems);
        }

        [HttpPost]
        public async Task<ActionResult<CartItem>> CreateCartItem(CartItem cartItem)
        {
            var createdCartItem = await _cartItemService.CreateCartItemAsync(cartItem);
            return CreatedAtAction(nameof(GetCartItemById), new { id = createdCartItem.Id }, createdCartItem);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCartItem(int id, CartItem cartItem)
        {
            if (id != cartItem.Id)
                return BadRequest();

            var updatedCartItem = await _cartItemService.UpdateCartItemAsync(cartItem);
            if (updatedCartItem == null)
                return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCartItem(int id)
        {
            var result = await _cartItemService.DeleteCartItemAsync(id);
            if (!result)
                return NotFound();

            return NoContent();
        }
    }
}

