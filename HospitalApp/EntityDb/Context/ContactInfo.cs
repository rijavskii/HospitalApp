using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityDb.Context
{
    public class ContactInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public virtual Users User { get; set; }

        public int FkContactType { get; set; }
        
        public virtual ContactType Type { get; set; }

        public string Contact { get; set; }

        public bool IsDefault { get; set; }

    }
}
