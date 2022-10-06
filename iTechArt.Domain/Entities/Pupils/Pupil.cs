﻿using iTechArt.Domain.Entities.Commons;
using iTechArt.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace iTechArt.Domain.Entities.Pupils
{
    public class Pupil : Auditable
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public School School { get; set; }
        [Required]
        public byte Grade { get; set; }
        [Required]
        public CourseLanguage CourseLanguage { get; set; }
        [Required]
        public Shift Shift { get; set; }
    }
}
