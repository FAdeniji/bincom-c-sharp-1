using System.ComponentModel.DataAnnotations.Schema;

namespace Ebele
{
    public class Property
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateAdded { get; set; }

        public bool IsAvailable { get; set; }
    }
}
