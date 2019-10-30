using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MT200412272.Models
{
    public class Forum
    {

        public virtual int Id { get; set; }

        public virtual String name { get; set; }

        [StringLength(500, MinimumLength = 5)]
        public virtual String comment { get; set; }

        public virtual DateTime date { get; set; }


        public Forum()
        {

        }

        public Forum(String name, String comment, DateTime date)
        {
            this.name = name;
            this.comment = comment;
            this.date = date;
        }
    }
}
