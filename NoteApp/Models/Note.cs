using System;
using System.ComponentModel.DataAnnotations;

namespace NoteApp.Models
{
    public class Note
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Başlık alanı gereklidir")]
        [StringLength(100, ErrorMessage = "Başlık 100 karakterden uzun olamaz")]
        public string Title { get; set; }

        [Required(ErrorMessage = "İçerik alanı gereklidir")]
        public string Content { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}