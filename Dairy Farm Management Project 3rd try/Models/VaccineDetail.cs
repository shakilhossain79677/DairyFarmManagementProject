//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dairy_Farm_Management_Project_3rd_try.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class VaccineDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VaccineDetail()
        {
            this.Vaccinations = new HashSet<Vaccination>();
        }


        [Display(Name = "Vaccine No.")]
        public int VaccineNo { get; set; }

        [Display(Name = "Disease Name")]
        public string NameOfDisease { get; set; }

        [Display(Name = "Schedule Time")]
        public int MinimumAge { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vaccination> Vaccinations { get; set; }
    }
}
