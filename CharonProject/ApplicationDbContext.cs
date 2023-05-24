namespace Charon
{
    using Charon.Entities;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;


    /// <summary>
    /// DB Name to be set in Conn string
    /// </summary>
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        #region DbSets

        #endregion

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}