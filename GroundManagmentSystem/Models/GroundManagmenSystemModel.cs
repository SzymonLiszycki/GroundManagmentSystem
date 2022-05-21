using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GroundManagmentSystem.Models
{
    
    
        public class ISA_Model
        {
            [Key]
            [DisplayName("ID")]
            public int ISA_id { get; set; }
            [DisplayName("ISA")]
            public long ISA_number { get; set; }                   
            [DisplayName("Data")]
            public DateTime ISA_date_time { get; set; }
            [DisplayName("Linia")]
            public string ?ISA_line { get; set; }
            [DisplayName("Ilość")]
            public int ISA_units { get; set; }
            [DisplayName("FBA-Ilość")]
            public int ISA_fba { get; set; }                                
            [DisplayName("FBA-ST")]
            public int ISA_semitrailer { get; set; }
            [DisplayName("FBA-SC")]
            public int ISA_fba_sea_container { get; set; }
            [DisplayName("FBA-S")]
            public int ISA_fba_standard { get; set; }                      
            [DisplayName("LP")]
            public int ISA_lp { get; set; }
            [DisplayName("LP ilość")]
            public int ISA_lp_value { get; set; }
            [DisplayName("Parcel")]
            public int ISA_parcel { get; set; }
            [DisplayName("Parcel ilość")]
            public int ISA_parcel_value { get; set; }
            [DisplayName("Mono.")]
            public int ISA_mono { get; set; }
            [DisplayName("Monp-ILOŚĆ")]
            public int ISA_mono_value { get; set; }
            [DisplayName("Pax.")]
            public int ISA_pax { get; set; }
            [DisplayName("PAX-ILOŚĆ")]
            public int ISA_pax_value { get; set; }
            [DisplayName("Ra.")]
            public int ISA_ra { get; set; }
            [DisplayName("Ra-ILOŚĆ")]
            public int ISA_ra_value { get; set; }
            [DisplayName("Rb.")]
            public int ISA_rb { get; set; }
            [DisplayName("Rb-ILOŚĆ")]
            public int ISA_rb_value { get; set; }
            [DisplayName("Rh.")]
            public int ISA_rh { get; set; }
            [DisplayName("Rh-ILOŚĆ")]
            public int ISA_rh_value { get; set; }
            [DisplayName("Rap.")]
            public int ISA_rap { get; set; }
            [DisplayName("Rap-ILOŚĆ")]
            public int ISA_rap_value { get; set; }
            [DisplayName("Rbp.")]
            public int ISA_rbp { get; set; }
            [DisplayName("rbp-ILOŚĆ")]
            public int ISA_rbp_value { get; set; }
            [DisplayName("Rhp.")]
            public int ISA_rhp { get; set; }
            [DisplayName("LP-ILOŚĆ")]
            public int ISA_rhp_value { get; set; }
            [DisplayName("Ac.")]
            public int ISA_ac { get; set; }
            [DisplayName("ac-ILOŚĆ")]
            public int ISA_ac_value { get; set; }
            [DisplayName("Bc.")]
            public int ISA_bc { get; set; }
            [DisplayName("bc-ILOŚĆ")]
            public int ISA_bc_value { get; set; }
            [DisplayName("Hc.")]
            public int ISA_hc { get; set; }
            [DisplayName("hc-ILOŚĆ")]
            public int ISA_hc_value { get; set; }
            [DisplayName("DS")]
            public bool ISA_to_chceck { get; set; }
            [DisplayName("Komentarz")]
            public string? ISA_comment { get; set; }
            public DateTime ISA_last_update { get; set; } = DateTime.Now;
            
        }
        
    

}

