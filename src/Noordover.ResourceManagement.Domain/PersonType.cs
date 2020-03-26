using System;

namespace Noordover.ResourceManagement.Domain
{
    [Flags]
    public enum PersonType
    {
        Staff = 1,
        Trainers = 2,
        Volunteers = 4
    }
}