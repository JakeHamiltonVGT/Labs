namespace Lab_34_Gym_Website_MVC_Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class User
    {
        public int UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        public bool? InductionCompleted { get; set; }

        public DateTime? DateJoined { get; set; }
    }
}
