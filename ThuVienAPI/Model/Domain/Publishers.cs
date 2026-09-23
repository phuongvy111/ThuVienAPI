using System.ComponentModel.DataAnnotations;
using static System.Reflection.Metadata.BlobBuilder;

namespace LapTrinhWeb2.Models.Domain
{
    public class Publishers
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public List<Books> Books { get; set; }
    }
}
