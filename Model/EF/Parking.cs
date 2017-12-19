namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Parking")]
    public partial class Parking
    {
        public int ParkingID { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        public bool? IsOverNight { get; set; }

        [StringLength(500)]
        public string Website { get; set; }

        [StringLength(500)]
        public string OpenTime { get; set; }

        [StringLength(500)]
        public string Price { get; set; }

        public float? Lat { get; set; }

        public float? Lng { get; set; }
    }
}
