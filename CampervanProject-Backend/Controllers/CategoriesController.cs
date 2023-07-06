using CampervanProject_Backend.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CampervanProject_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        public List<Category> _categories;
        public CategoriesController()
        {
            _categories = new List<Category>
            {
                new Category {Id=1,Name= "Çekme Karavan" },
                new Category {Id=2,Name= "Moto Karavan" },
                new Category {Id=3,Name= "Minivan Karavan" },
                new Category {Id=4,Name= "Pick-up Karavan" },
                new Category {Id=5,Name= "Küçük Gözyaşı Karavan" },
                new Category {Id=6,Name= "Panelvan Karavan" }
            };
        }
        [HttpGet]
        public ActionResult<List<Category>> GetAllCategories()
        {
            return _categories;
        }


    }
}