using System;
using System.Collections.Generic;

namespace Noordover.ResourceManagement.Domain
{
    
    public class PersonType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<PersonPersonType> PersonPersonTypes { get; set; }
    }
}