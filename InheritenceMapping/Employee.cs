using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceMapping
{
    internal class Employee
    {
        public int Id { get; set; }

        // ✅ خليتها Nullable (مرن أكتر مع البيانات)
        public int? Age { get; set; }

        public string Name { get; set; }

        // ✅ خليتها Nullable برضه عشان ممكن يبقى في موظف ملوش Address
        public string? Address { get; set; }
    }
}
