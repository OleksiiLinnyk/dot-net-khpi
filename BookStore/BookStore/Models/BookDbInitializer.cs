using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace BookStore.Models
{
    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {

        protected override void Seed(BookContext context)
        {
            context.Books.Add(new Book { Name = " Назва 1" , Author = " Автор1" , Price = 250 });
            context.Books.Add(new Book { Name = "Назва 2", Author = "Автор2", Price = 200});
            context.Books.Add(new Book { Name = "Назва 3", Author = "Автор3", Price = 150});

            base.Seed(context);
        }
    }
}