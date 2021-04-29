using System;
using System.ComponentModel.DataAnnotations;

namespace Api
{
    public class settings
    {
        [Key]
        public Guid id { get; set; }
        public string category { get; set; }
        public string name { get; set; }
        public string value { get; set; }
    }
}