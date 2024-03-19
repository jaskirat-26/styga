using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backendServer.Models
{
    public class OptionsGrid
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long OptionGridID { get; set; }

        public string? OptionGridName { get; set; }

        public string? OptionGridDescription { get; set; }

        [Column(TypeName = "jsonb")]
        public string? ProductList { get; set; }

        public DateTime CreatedAt { get; set; }

    }
}
