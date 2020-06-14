﻿using _456Lab.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;


public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public DbSet<Course> Courses { get; set; }
    public DbSet<Category> Categories { get; set; }
    public ApplicationDbContext()
        : base("DefaultConnection", throwIfV1Schema: false)
    {

    }
    public static ApplicationDbContext Create()
    {
        return new ApplicationDbContext();
    }
}