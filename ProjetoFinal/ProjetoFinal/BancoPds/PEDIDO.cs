//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetoFinal.BancoPds
{
    using System;
    using System.Collections.Generic;
    
    public partial class PEDIDO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PEDIDO()
        {
            this.PRODUTO_PEDIDO = new HashSet<PRODUTO_PEDIDO>();
        }
    
        public long id_pedido { get; set; }
        public Nullable<System.DateTime> data_venda { get; set; }
        public Nullable<double> valor { get; set; }
        public Nullable<long> id_status { get; set; }
        public Nullable<long> id_cliente { get; set; }
        public Nullable<long> id_usuario { get; set; }
        public Nullable<long> id_forma_pagamento { get; set; }
        public Nullable<System.DateTime> data_pagamento { get; set; }
    
        public virtual CLIENTE CLIENTE { get; set; }
        public virtual FORMA_PAGAMENTO FORMA_PAGAMENTO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUTO_PEDIDO> PRODUTO_PEDIDO { get; set; }
        public virtual STATUS STATUS { get; set; }
    }
}
