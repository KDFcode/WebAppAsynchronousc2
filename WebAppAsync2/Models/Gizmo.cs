using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppAsync2.Models
{
    public class Gizmo
    {

        public int Id { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime IntroducedDate { get; set; }
        public int Quantity { get; set; }
    }
}