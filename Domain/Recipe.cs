using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Recipe
    {
        public Recipe()
        {
            
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int Servings { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime? DateLastCooked { get; set; }
        public int Rating { get; set; }
    }
}