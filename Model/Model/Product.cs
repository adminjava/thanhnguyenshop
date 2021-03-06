﻿using Model.Abstract;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Model.Model
{
    [Table("Products")]
    public class Product : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        public string Name { set; get; }
        [Required]
        public string Alias { set; get; }

        public int CategoryID { set; get; }
        public string Image { set; get; }
        [Column(TypeName ="xml")]
        public string MoreImage { set; get; }
        public string Description { set; get; }

        [Required]
        public decimal Price { set; get; }

        public decimal? PromotionPrice { set; get; }
        public int? Warranty { set; get; }
        public string Content { set; get; }
        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }

        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategory { set; get; } 
        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }
        public virtual IEnumerable<ProductTag> ProductTags { set; get;}
        
    }
}