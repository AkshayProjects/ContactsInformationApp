using System;

namespace contact_app.Models
{
    public class Contact
    {
        public long? id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string phonenumber { get; set; }
    }
}