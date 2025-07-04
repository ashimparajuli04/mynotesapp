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
    public class IndexModel : PageModel
    {
        private readonly notes.Data.NotesContext _context;

        public IndexModel(notes.Data.NotesContext context)
        {
            _context = context;
        }

        public IList<Note> Note { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Note = await _context.Note.ToListAsync();
        }
    }
}
