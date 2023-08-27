using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace kotranacs
{
    public record Contact(
        [property: JsonPropertyName("first")]
        string FirstName,
        [property: JsonPropertyName("last")]
        string LastName,
        string Email)
    {
        public string FullName => $"{FirstName} {LastName}";
    }

}
