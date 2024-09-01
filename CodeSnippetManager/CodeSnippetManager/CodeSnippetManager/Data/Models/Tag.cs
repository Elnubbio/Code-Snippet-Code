﻿namespace CodeSnippetManager.Data.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Colour { get; set; }
        public virtual IEnumerable<Snippet>? Snippets { get; set; }
    }
}
