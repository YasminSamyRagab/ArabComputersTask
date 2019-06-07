namespace ArabComputersTask.API.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Reservation")]
    public partial class Reservation
    {
        public int ReservationID { get; set; }

        public int UserID { get; set; }

        public int RoomID { get; set; }

        [Column(TypeName = "date")]
        public DateTime ReservationTime { get; set; }

        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime EndDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CheckoutTime { get; set; }

        public int CreateReservationBy { get; set; }

        public virtual User User { get; set; }

        public virtual Room Room { get; set; }

        public virtual User User1 { get; set; }
    }
}
