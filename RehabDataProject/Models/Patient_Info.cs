using System.ComponentModel.DataAnnotations;

namespace RehabDataProject.Models
{
    public class Patient_Info
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public double KneeROM { get; set; }
        public int KneeStrength { get; set; }
        public double LowerbackExtROM { get; set; }
        public double LowerBackFlexionROM { get; set; }
        public int PainFreeWeightLifted { get; set; }
        public DateTime DateUpdated { get; set; } = DateTime.Now;
    }
}
