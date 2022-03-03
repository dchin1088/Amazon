using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon.Models
{
    public interface ICheckingOutRepository
    {
        IQueryable<CheckingOut> CheckingOuts { get; }

        void SaveCheckout(CheckingOut checkingOut);
    }
}
