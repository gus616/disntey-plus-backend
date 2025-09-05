using AutoMapper;
using disntney_plus_api.DTOs;
using disntney_plus_api.Models;
using disntney_plus_api.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace disntney_plus_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : Controller
    {
        private readonly ICommonService<Category> _categoriesService;
        private readonly IMapper _mapper;
        public CategoriesController(ICommonService<Category> categoriesService, IMapper mapper)
        {
            _categoriesService = categoriesService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categories = await _categoriesService.GetAllAsync();
            var categoriesDto = _mapper.Map<List<CategoryDto >> (categories);
            return Ok(categoriesDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var category = await _categoriesService.GetByIdAsync(id);
            var categoryDto = _mapper?.Map<CategoryDto> (category);
            return Ok(categoryDto);
        }
    }
}
