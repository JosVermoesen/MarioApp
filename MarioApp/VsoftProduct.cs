using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarioApp
{
    class VsoftProduct
    {
        public int Id { get; set; }
        [Column("v102")]
        [StringLength(13)]
        public string V102 { get; set; }
        [Column("v105")]
        [StringLength(40)]
        public string V105 { get; set; }
        [Column("v221")]
        [StringLength(40)]
        public string V221 { get; set; }
        [Column("v106")]
        [StringLength(1)]
        public string V106 { get; set; }
        [Column("v107")]
        [StringLength(10)]
        public string V107 { get; set; }
        [Column("v108")]
        [StringLength(1)]
        public string V108 { get; set; }
        [Column("v110")]
        [StringLength(3)]
        public string V110 { get; set; }
        [Column("v111")]
        [StringLength(1)]
        public string V111 { get; set; }
        [Column("v168")]
        [StringLength(1)]
        public string V168 { get; set; }
        [Column("v169")]
        [StringLength(3)]
        public string V169 { get; set; }
        [Column("v112")]
        [StringLength(15)]
        public string V112 { get; set; }
        [Column("v113")]
        [StringLength(15)]
        public string V113 { get; set; }
        [Column("v115")]
        [StringLength(10)]
        public string V115 { get; set; }
        [Column("v116")]
        [StringLength(7)]
        public string V116 { get; set; }
        [Column("v117")]
        [StringLength(7)]
        public string V117 { get; set; }
        [Column("v118")]
        [StringLength(7)]
        public string V118 { get; set; }
        [Column("v114")]
        [StringLength(10)]
        public string V114 { get; set; }
        [Column("v119")]
        [StringLength(10)]
        public string V119 { get; set; }
        [Column("v120")]
        [StringLength(10)]
        public string V120 { get; set; }
        [Column("v121")]
        [StringLength(15)]
        public string V121 { get; set; }
        [Column("v122")]
        [StringLength(15)]
        public string V122 { get; set; }
        [Column("v123")]
        [StringLength(15)]
        public string V123 { get; set; }
        [Column("v109")]
        [StringLength(10)]
        public string V109 { get; set; }
        [Column("v103")]
        [StringLength(8)]
        public string V103 { get; set; }
        [Column("v104")]
        [StringLength(20)]
        public string V104 { get; set; }
        [Column("v124")]
        [StringLength(12)]
        public string V124 { get; set; }
        [Column("v125")]
        [StringLength(1)]
        public string V125 { get; set; }
        [Column("v001")]
        [StringLength(30)]
        public string V001 { get; set; }
        [Column("v002")]
        [StringLength(255)]
        public string V002 { get; set; }
        [Column("v249")]
        [StringLength(50)]
        public string V249 { get; set; }
        [Column("e112")]
        [StringLength(50)]
        public string E112 { get; set; }
        [Column("e113")]
        [StringLength(50)]
        public string E113 { get; set; }
        [Column("e121")]
        [StringLength(50)]
        public string E121 { get; set; }
        [Column("e122")]
        [StringLength(50)]
        public string E122 { get; set; }
        [Column("e123")]
        [StringLength(50)]
        public string E123 { get; set; }
        [Column("dece112", TypeName = "money")]
        public decimal? Dece112 { get; set; }
        [Column("dece113", TypeName = "money")]
        public decimal? Dece113 { get; set; }
        [Column("dece121", TypeName = "money")]
        public decimal? Dece121 { get; set; }
        [Column("dece122", TypeName = "money")]
        public decimal? Dece122 { get; set; }
        [Column("dece123", TypeName = "money")]
        public decimal? Dece123 { get; set; }
        [Column("v261")]
        [StringLength(50)]
        public string V261 { get; set; }
        public int? RvID { get; set; }
    }
}
