using System;
using System.Collections.Generic;

namespace LMS.Models;

public partial class Member
{
    public int MemberId { get; set; }

    public string Name { get; set; } = null!;

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public DateOnly? MembershipDate { get; set; }

    public virtual ICollection<BorrowReturnTransaction> BorrowReturnTransactions { get; set; } = new List<BorrowReturnTransaction>();
}
