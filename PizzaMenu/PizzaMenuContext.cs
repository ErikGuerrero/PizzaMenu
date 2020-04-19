using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaMenu {
    public class PizzaMenuContext : DbContext {
        public PizzaMenuContext(DbContextOptions<PizzaMenuContext> options)
            : base(options)
        {
        }
    }
}
