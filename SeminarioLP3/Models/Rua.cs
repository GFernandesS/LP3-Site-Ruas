//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SeminarioLP3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rua
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rua()
        {
            this.Loja = new HashSet<Loja>();
        }
    
        public int IdRua { get; set; }
        public int FkBairro { get; set; }
        public int FkTipoComercio { get; set; }
        public string Nome { get; set; }
        public string CEP { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Loja> Loja { get; set; }
        public virtual Bairro Bairro { get; set; }
        public virtual TipoComercio TipoComercio { get; set; }
    }
}
