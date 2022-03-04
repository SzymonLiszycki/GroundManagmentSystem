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
            public string? ISA_date { get; set; }
            [DisplayName("Godzina")]
            public string? ISA_hour { get; set; }
            [DisplayName("Ilość")]
            public int ISA_units { get; set; }
            [DisplayName("FBA-Ilość")]
            public int ISA_fba { get; set; }                                //Naczepy ilość
            [DisplayName("FBA-ST")]
            public int ISA_semitrailer { get; set; }
            [DisplayName("FBA-SC")]
            public int ISA_fba_sea_container { get; set; }
            [DisplayName("FBA-S")]
            public int ISA_fba_standard { get; set; }
            [DisplayName("FBA-PL")]
            public int ISA_fba_palets_value { get; set; }                  //Ilość palet na naczepie
            [DisplayName("LP")]
            public int ISA_lp { get; set; }
            [DisplayName("LP-ILOŚĆ")]
            public int ISA_lp_value { get; set; }
            [DisplayName("Parcel.")]
            public int ISA_parcel { get; set; }
            [DisplayName("Parcel-ILOŚĆ")]
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
            public string? ISA_to_chceck { get; set; }
            [DisplayName("Komentarz.")]
            public string? ISA_comment { get; set; }
            [DisplayName("Data")]
            public  DateTime ISA_date_time { get; set; }
        }
        public class Line_Model
        {
            [Key]
            public int LINE_id { get; set; }
            public ushort LINE_number { get; set; }
            public int LINE_asign_isa { get; set; }
            public int LINE_units { get; set; }
            public short LINE_to_check { get; set; }
            public short LINE_lp { get; set; }
            public short LINE_parcel { get; set; }
            public short LINE_mono { get; set; }
            public short LINE_pax { get; set; }
            public short LINE_ra { get; set; }
            public short LINE_rb { get; set; }
            public short LINE_rh { get; set; }
            public short LINE_rap { get; set; }
            public short LINE_rbp { get; set; }
            public short LINE_rhp { get; set; }
            public short LINE_ac { get; set; }
            public short LINE_bc { get; set; }
            public short LINE_hc { get; set; }
            public short LINE_fba { get; set; }
            public short LINE_sea_container { get; set; }
            public short LINE_standard { get; set; }
            public short LINE_semitrailer { get; set; }
            public string? LINE_comment { get; set; }






        }
    

}

