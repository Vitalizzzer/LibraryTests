using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryTests
{
   // [Serializable()]
    public class Genre
    {       
        [Column ("GenreName")]
        [Key]
        public string GenreName { get; set; }
    }
}
