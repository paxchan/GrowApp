using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GrowApp.Models
{
    public class Post
    {
        [Key]
        [Required]
        public int post_id { get; set; }
        public int user_id { get; set; }
        public string photo { get; set; }
        public string caption { get; set; }
        public string posted_at { get; set; }

        [ForeignKey("goal_id")]
        public int goal_id { get; set; }
        public Goal Goal { get; set; }
    }
}
