using System.ComponentModel.DataAnnotations;

namespace _1111webapi.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required (ErrorMessage = "Укажите название книги")]

        public string Name { get; set; }

        [Required (ErrorMessage = "Укажите имя автора")]
        public string Author { get; set; }

        [Range (2001, 2100, ErrorMessage = "год должен быть в промежутке от 2001 до 2100")]

        [Required (ErrorMessage = "Укажите имя автора")]
        public int Year { get; set; }

      [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
