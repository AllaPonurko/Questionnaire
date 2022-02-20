using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire.Entities
{
    [Serializable]
    public class Person
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }

        public string FillName => this.FirstName + " " + SecondName;

        public List<string> Phones { get; set; } = new List<string>();

        public override string ToString()
        {
            return FillName;
        }
    }
}
