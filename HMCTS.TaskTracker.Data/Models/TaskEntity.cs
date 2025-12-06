using HMCTS.TaskTracker.Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace HMCTS.TaskTracker.Data.Models
{
    public class TaskEntity
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Title has exceeded 100 characters")]
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        [Required]
        public Status Status { get; set; }

        [Required]
        public DateTime DueDateTime { get; set; }

    }
}
