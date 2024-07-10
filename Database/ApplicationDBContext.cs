﻿using Microsoft.EntityFrameworkCore;

namespace HangFireDemo.Database
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
    }
}
