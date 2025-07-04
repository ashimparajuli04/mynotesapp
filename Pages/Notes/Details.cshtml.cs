using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using notes.Data;
using notes.Models;

namespace notes.Pages.Notes
{
    public class DetailsModel : PageModel
    {
        private readonly notes.Data.NotesContext _context;

        public DetailsModel(notes.Data.NotesContext context)
        {
            _context = context;
        }

        public Note Note { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var note = await _context.Note.FirstOrDefaultAsync(m => m.Id == id);

            if (note is not null)
            {
                Note = note;

                return Page();
            }

            return NotFound();
        }
    }
}
