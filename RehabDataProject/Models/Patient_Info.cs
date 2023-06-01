using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RehabDataProject.Models
{
    public class Patient_Info
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Knee ROM")]
		[Range(0, 155, ErrorMessage = "The Range must be between 0 and 155!")]
		public double KneeROM { get; set; }
		[DisplayName("Knee Strength")]
		public int KneeStrength { get; set; }
		[DisplayName("Lower Back Ext ROM")]
        [Range(0,40,ErrorMessage ="The Range must be between 0 and 40!")]
		public double LowerbackExtROM { get; set; }
		[DisplayName("Lower Back Flexion ROM")]
		[Range(0, 60, ErrorMessage = "The Range must be between 0 and 60!")]
		public double LowerBackFlexionROM { get; set; }
		[DisplayName("Pain Free Weight Lifted")]
		public int PainFreeWeightLifted { get; set; }
        public DateTime DateUpdated { get; set; } = DateTime.Now;
    }
}
