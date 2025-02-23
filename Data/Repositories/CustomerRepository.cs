using Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories {
    public class CustomerRepository {

        private readonly DataContext _context;
        public CustomerRepository(DataContext context) {
            _context = context;
        }
        // CREATE

        // READ

        // UPDATE

        // DELETE
        public async Task<bool> DeleteAsync(int id) {
            var entity = await _context.Customers.FirstOrDefaultAsync(x => x.Id == id);
            if (entity != null) {
                _context.Customers.Remove(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;

        }
    }
}
