﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdoNetModelFirst
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LibraryContainer : DbContext
    {
        public LibraryContainer()
            : base("name=Model1Container2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Users> UsersSet { get; set; }
        public virtual DbSet<Books> BooksSet { get; set; }
        public virtual DbSet<Authors> AuthorsSet { get; set; }
        public virtual DbSet<LogBooks> LogBooksSet { get; set; }
    }
}
