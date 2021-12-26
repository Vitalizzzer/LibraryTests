using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryTests
{
    public class Book
    {   
        [Column("Id")]
        [Key]
        public int Id { get; set; }

        [Column("Author")]
        public string Author { get; set; }

        [Column("Title")]
        public string Title { get; set; }

        [Column("GenreName")]    
        [ForeignKey("GenreName")]
        public string GenreName { get; set; }

        [Column("Date")]
        public string Date { get; set; }

        [Column("Info")]
        public string Info { get; set; }

        [Column("Cover")]
        public byte[] Cover { get; set; }

        //public Book() { }
        public Book(string author, string title, string genreName, string date, string info, byte[] cover)
        {
            Author = author;
            Title = title;
            GenreName = genreName;
            Info = info;
            Date = date;
            Cover = cover;
        }

        public Book(int id, string author, string title, string genreName, string date, string info, byte[] cover)
        {
            Id = id;
            Author = author;
            Title = title;
            GenreName = genreName;
            Info = info;
            Date = date;
            Cover = cover;
        }
    }
}
