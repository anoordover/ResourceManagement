using System.Collections.Generic;

namespace Noordover.ResourceManagement.Domain
{
    public class Person
    {
        public int Id { get; set; }
        public string GivenName { get; set; }
        public string MiddleName { get; set; }
        public string SurName { get; set; }
        public IList<PersonPersonType> PersonPersonTypes { get; set; }
        public string PhoneNumber { get; set; }
        #region Foreign Keys
        public int ScheduleId { get; set; }
        #endregion
    }
}
