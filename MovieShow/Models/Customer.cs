using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieShow.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool isSubscribedToNewsLetter { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}