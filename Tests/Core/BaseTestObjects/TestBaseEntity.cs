using EXCSLA.Shared.Core;
using System;

namespace EXCSLA.Shared.Tests.Core.UnitTests.BaseTestObjects
{
    public class TestIntBaseEntity : BaseEntity<int>
    {
        public string FirstName {get; private set;}
        public string LastName {get; private set;}

        public TestIntBaseEntity(int id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName  = lastName;
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }

    public class TestGuidBaseEntity : BaseEntity<Guid>
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public TestGuidBaseEntity(Guid id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}