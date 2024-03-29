﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TH2_CoreRazerContoso.Models;

namespace TH2_CoreRazerContoso.Pages.Students
{
    public class DetailsModel : PageModel
    {
        private readonly TH2_CoreRazerContoso.Models.UniversityContext _context;

        public DetailsModel(TH2_CoreRazerContoso.Models.UniversityContext context)
        {
            _context = context;
        }

        public Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Student = await _context.Student.FirstOrDefaultAsync(m => m.ID == id);

            if (Student == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
