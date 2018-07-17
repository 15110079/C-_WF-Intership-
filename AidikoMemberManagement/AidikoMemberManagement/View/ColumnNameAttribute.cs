using System;

namespace AidikoMemberManagement.View
{
    public class ColumnNameAttribute : Attribute
    {
        public ColumnNameAttribute(string Name) { this.Name = Name; }
        public string Name { get; set; }

    }
}