using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LMS.DataSource.Entities
{

    //-----------------------------------------------------------------
    //$Developer : Aysha Firouzs
    //$Created on : 09/12/19
    //$Mobile No : 0767779845
    //$Email : ayshuu1997@gmail.com
    //$Description (if any) :
    //-----------------------------------------------------------------
    public class Payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PaymentId { get; set; }

        public double DuePayment { get; set; }

        [ForeignKey("BorrowingId")]
        public Borrowing ParentBorrowing { get; set; }
        public int BorrowingId { get; set; }
    }
}
