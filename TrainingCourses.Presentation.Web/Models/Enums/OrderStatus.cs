using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresentationTier.Models.Enums
{
    public enum OrderStatus
    {
        Draft,
        Reserved,
        Paid,
        CanceledByUser,
        CanceledByCustomer,
    }
}