﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace bit285_lucky_number_viewmodel.Models
{
    public class LuckyNumberDbContext : DbContext
    {
        public LuckyNumberDbContext() : base("LuckyNum") { } //changed the name to LuckyNum to avoid exception 

        public DbSet<Player> Players { get; set; }


    }
}