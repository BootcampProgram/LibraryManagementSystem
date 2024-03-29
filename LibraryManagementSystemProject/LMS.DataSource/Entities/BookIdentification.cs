﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LMS.DataSource.Entities
{

    //-----------------------------------------------------------------
    //$Developer                :  Iresha
    //$Created on               :  09/12/2019
    //$Mobile No                :  0778377630
    //$Email                    :  ireshasilva96@gmail.com
    //$Description (If Any)     : 
    //-----------------------------------------------------------------

    public class BookIdentification
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookID { get; set; }

        public string Status { get; set; }

        [ForeignKey("DetailID")]
        public BookDetail ParentDeatilID { get; set; }
        public int DetailID { get; set; }


    }
}
