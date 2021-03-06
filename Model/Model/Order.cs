﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    [Table("Orders")]
   public class Order
    {
       [Key]
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        [MaxLength(250)]
        public string CustomerName { set; get; }
        [Required]
        [MaxLength(250)]
        public string CustomerAddress { set; get; }
        [Required]
        [MaxLength(250)]
        public string CustomerEmail { set; get; }
        [Required]
        [MaxLength(50)]
        public string CustomerMobile { set; get; }
        public DateTime CreateDate { set; get; }
        public string CreateBy { set; get; }

        public string PaymentMethod { set; get; }
        public string PaymentStatus { set; get; }
        public bool Status { set; get; }

        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }

    }
}
