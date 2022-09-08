using System;
using System.Collections.Generic;
using System.Text;

namespace Browser_HomeWork
{
    public class SearchEngin
    {
        public string searchURL { get; set; }
        //public string search_google { get; set; } = "https://google.com";
        //public string search_rambler { get; set; } = "https://mile.ru";
        public string homeURL { get; set; }
        public override string ToString()
        {
            return $"{homeURL} {searchURL}";
        }
    }
}
