using Business.Abstract;
using Entities;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly ICategoryManager _categoryManager;

        public CategoryController(ICategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }

        [HttpGet("getallCategory")]
        public List<Category> GetCategories()
        {
           return _categoryManager.GetAll();
        }


        [HttpPost("addCategory")]
        public CategoryDTO Add(CategoryDTO category)  
        {
            _categoryManager.Add(category);
            return category;
        }


    }
}
