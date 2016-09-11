using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace review_box.Models
{
    public class ReviewModel
    {
        private string topic;
        private string suggestion;

        [Key]
        public int RecordNum { get; set; }

        public string Topic
        {
            get { return this.topic; }
            set { this.topic = value; }
        }
        public string Suggestion
        {
            get { return this.suggestion; }
            set { this.suggestion = value; }

        }
           //[ForeignKey("Category")]
           //public int CategoryID { get; set; }
           //public virtual Category Category { get; set; }



    }
}
