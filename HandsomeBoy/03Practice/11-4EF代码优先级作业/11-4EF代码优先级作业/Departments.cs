//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace _11_4EF代码优先级作业
{
    using System;
    using System.Collections.Generic;
    
    public partial class Departments
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Departments()
        {
            this.Courses = new HashSet<Courses>();
        }
    
        public System.Guid ID { get; set; }
        public string Name { get; set; }
        public string Dscn { get; set; }
        public string SortCode { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Courses> Courses { get; set; }
        public virtual Departments Departments1 { get; set; }
        public virtual Departments Departments2 { get; set; }
    }
}
