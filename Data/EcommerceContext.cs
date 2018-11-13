using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Vue.Data.Entities;

namespace Vue.Data
{
    public class EcommerceContext : IdentityDbContext<AppUser, 
    AppRole, int>
    {
        public EcommerceContext(DbContextOptions<EcommerceContext> 
        options) : base(options)
        { }
    }
}