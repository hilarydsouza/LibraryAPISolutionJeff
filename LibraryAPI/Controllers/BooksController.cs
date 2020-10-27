using LibraryAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAPI.Controllers
{
    public class BooksController: ControllerBase
    {

        private readonly LibraryDataContext _context;

        public BooksController(LibraryDataContext context)
        {
            _context = context;
        }

        [HttpGet("books")]
        public async Task<ActionResult> GetAllBooks()
        {
            var response = await _context.Books.ToListAsync();
            return Ok(response);
        }
       
    }
}
