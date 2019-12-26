

using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace _1111webapi.Models
{
    public class Client
    {
         [BindingBehavior(BindingBehavior.Never)]
        public int Id { get; set; }
         [BindingBehavior(BindingBehavior.Optional)]
        public string Name { get; set; }
         [BindingBehavior(BindingBehavior.Optional)]
        public int Amount { get; set; }
         [BindingBehavior(BindingBehavior.Never)]
        public List<Transaction> Transactions { get; set; }

    }
}