//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LattesExtractor.Entities.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProducaoBibliografica
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProducaoBibliografica()
        {
            this.BaseDeConsulta = new HashSet<BaseDeConsulta>();
            this.Professor = new HashSet<Professor>();
            this.AreaConhecimento = new HashSet<AreaConhecimento>();
            this.PalavraChave = new HashSet<PalavraChave>();
        }
    
        public int ProducaoBibliograficaId { get; set; }
        public string NaturezaProducaoBibliografica { get; set; }
        public string TipoProducaoBibliografica { get; set; }
        public string TituloProducaoBibliografica { get; set; }
        public decimal AnoProducaoBibliografica { get; set; }
        public string PaisProducaoBibliografica { get; set; }
        public Nullable<int> IdiomaId { get; set; }
        public string MeioDivulgacaoProducaoBibliografica { get; set; }
        public string HomePageProducaoBibliografica { get; set; }
        public string DOIProducaoBibliografica { get; set; }
        public string ISBNProducaoBibliografica { get; set; }
        public string InformacoesAdicionaisProducaoBibliografica { get; set; }
        public bool DivulgacaoCeTProducaoBibliografica { get; set; }
        public string InformacoesAdicionaisEmInglesProducaoBibliografica { get; set; }
        public string TituloEmInglesProducaoBibliografica { get; set; }
        public Nullable<int> PeriodicoQualisId { get; set; }
        public Nullable<int> JCRId { get; set; }
        public string NomePeriodicoProducaoBibliografica { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaseDeConsulta> BaseDeConsulta { get; set; }
        public virtual Idioma Idioma { get; set; }
        public virtual JCR JCR { get; set; }
        public virtual PeriodicoQualis PeriodicoQualis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Professor> Professor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AreaConhecimento> AreaConhecimento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PalavraChave> PalavraChave { get; set; }
    }
}
