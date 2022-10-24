using EntityFrameworkProject.Data;
using EntityFrameworkProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkProject.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class SliderDetailController : Controller
    {
        private readonly AppDbContext _context;

        public SliderDetailController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<SliderDetail> sliderDetails = await _context.SliderDetails.Where(m => !m.IsDeleted).AsNoTracking().OrderByDescending(m => m.Id).ToListAsync();
            return View(sliderDetails);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SliderDetail sliderDetail)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }


                //bool isExist = await _context.SliderDetails.AnyAsync(m => m.t.Trim() == sliderDetail.Name.Trim());

                //if (isExist)
                //{
                //    ModelState.AddModelError("Name", "Category already exist");
                //    return View();
                //}

                //change exist data is delete

                //var data = await _context.Categories.Where(m => m.IsDeleted == true).FirstOrDefaultAsync(m=>m.Name.Trim() == category.Name.Trim());

                //if(data is null)
                //{
                //    await _context.Categories.AddAsync(category);
                //}
                //else
                //{
                //    data.IsDeleted = false;
                //}

                await _context.SliderDetails.AddAsync(sliderDetail);

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {

                ViewBag.Message = ex.Message;
                return View();
            }

        }

        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return BadRequest();

            SliderDetail sliderDetail = await _context.SliderDetails.FindAsync(id);

            if (sliderDetail == null) return NotFound();

            return View(sliderDetail);
        }

        //delete from database

        //[HttpPost]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    Category category = await _context.Categories.FirstOrDefaultAsync(m => m.Id == id);

        //    _context.Categories.Remove(category);

        //    await _context.SaveChangesAsync();

        //    return RedirectToAction(nameof(Index));
        //}


        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            SliderDetail sliderDetail = await _context.SliderDetails.FirstOrDefaultAsync(m => m.Id == id);

            sliderDetail.IsDeleted = true;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            try
            {
                if (id is null) return BadRequest();

                SliderDetail sliderDetail = await _context.SliderDetails.FirstOrDefaultAsync(m => m.Id == id);

                if (sliderDetail is null) return NotFound();

                return View(sliderDetail);

            }
            catch (Exception ex)
            {

                ViewBag.Message = ex.Message;
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, SliderDetail sliderDetail)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(sliderDetail);
                }

                SliderDetail dbSliderDetail = await _context.SliderDetails.AsNoTracking().FirstOrDefaultAsync(m => m.Id == id);

                if (dbSliderDetail is null) return NotFound();

                

                // dbCategory.Name = category.Name;

                _context.SliderDetails.Update(sliderDetail);

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));

            }
            catch (Exception ex)
            {

                ViewBag.Message = ex.Message;
                return View();
            }
        }
    }
}
