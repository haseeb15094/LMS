using System;
using System.Collections.Generic;

namespace LMS.Models;

public partial class BorrowReturnTransaction
{
    public int TransactionId { get; set; }

    public int? BookId { get; set; }

    public int? MemberId { get; set; }

    public DateOnly IssueDate { get; set; }

    public DateOnly? ReturnDate { get; set; }

    public string? Status { get; set; }

    public virtual Book? Book { get; set; }

    public virtual Member? Member { get; set; }
}
