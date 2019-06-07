namespace ArabComputersTask.API.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Reservations = new HashSet<Reservation>();
            Reservations1 = new HashSet<Reservation>();
        }

        public int UserID { get; set; }

        public int UserSSN { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [StringLength(1)]
        public string UserGender { get; set; }

        [Required]
        public string UserPhoneNumber { get; set; }

        [Required]
        [StringLength(450)]
        public string UserMailAddress { get; set; }

        [Required]
        public string UserPassword { get; set; }

        public int RoleID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservation> Reservations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservation> Reservations1 { get; set; }

        public virtual Role Role { get; set; }
    }
}
