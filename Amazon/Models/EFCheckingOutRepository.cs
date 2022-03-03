using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon.Models
{
    public class EFCheckingOutRepository : ICheckingOutRepository
    {
        private BookstoreContext context;
        public EFCheckingOutRepository(BookstoreContext temp)
        {
            context = temp;
        }
        public IQueryable<CheckingOut> CheckingOuts => context.CheckingOut.Include(x => x.Lines).ThenInclude(x => x.Book);

        public void SaveCheckout(CheckingOut checkingOut)
        {
            context.AttachRange(checkingOut.Lines.Select(x => x.Book));

            if (checkingOut.BookId == 0)
            {
                context.CheckingOut.Add(checkingOut);
            }

            context.SaveChanges();
        }
    }
}
