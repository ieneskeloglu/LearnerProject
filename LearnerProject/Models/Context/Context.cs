﻿using LearnerProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LearnerProject.Models.Context
{
    public class Context:DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseRegister> CourseRegisters { get; set; }
        public DbSet<FAQ> FAQs { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }


    }
}