// Controllers/MenuController.cs
using HotPot.Models;
using HotPot.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotPot.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IMenuService _menuService;

        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Menu>> GetMenuById(int id)
        {
            var menu = await _menuService.GetMenuByIdAsync(id);
            if (menu == null)
                return NotFound();
            return Ok(menu);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Menu>>> GetAllMenus()
        {
            var menus = await _menuService.GetAllMenusAsync();
            return Ok(menus);
        }

        [HttpPost]
        public async Task<ActionResult<Menu>> CreateMenu(Menu menu)
        {
            var createdMenu = await _menuService.CreateMenuAsync(menu);
            return CreatedAtAction(nameof(GetMenuById), new { id = createdMenu.Id }, createdMenu);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMenu(int id, Menu menu)
        {
            if (id != menu.Id)
                return BadRequest();

            var updatedMenu = await _menuService.UpdateMenuAsync(menu);
            if (updatedMenu == null)
                return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMenu(int id)
        {
            var result = await _menuService.DeleteMenuAsync(id);
            if (!result)
                return NotFound();

            return NoContent();
        }
    }
}

