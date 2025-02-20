﻿using MusicStoreEntity.UserAndRole;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreEntity
{
  public class Reply
    {
        public Guid ID { get; set; }

        [Display(Name = "标题")]
        //[Required]
        public virtual string Title { get; set; }

        [Display(Name = "内容")]
        [Required]
        public virtual string Content { get; set; }

        [Required]
        public virtual Person Person { get; set; }

        [Required]
        public virtual Albun Album { get; set; }

        //[Required]
        public virtual Reply ParentReply { get; set; }   //上级回复

        public DateTime CreateDateTime { get; set; }  //回复时间

        //赞
        public int Like { get; set; }
        //黑
        public int Hate { get; set; }
        public Reply()
        {
            ID = Guid.NewGuid();
            CreateDateTime = DateTime.Now;
        }
    }
}
