//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RRHH911ECU.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_EstructuraProgramatica
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_EstructuraProgramatica()
        {
            this.Tbl_Personas = new HashSet<Tbl_Personas>();
        }
    
        public int EstrucProgra_id { get; set; }
        public string EstrucProgra_nom { get; set; }
        public string EstrucProgra_estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Personas> Tbl_Personas { get; set; }
    }
}
