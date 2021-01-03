using System.Collections.Generic;

namespace FineAdmin.Model
{
    public class Tree
    {
        public int id { get; set; }
        public string title { get; set; }
        public string href { get; set; }
        public string fontFamily { get; set; }
        public string icon { get; set; }
        public IEnumerable<Tree> children { get; set; }
    }
}
