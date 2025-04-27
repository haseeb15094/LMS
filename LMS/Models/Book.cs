using System;
using System.Collections.Generic;

namespace LMS.Models;

public partial class Book
{
    public int BookId { get; set; }

    public string Title { get; set; } = null!;

    public int? AuthorId { get; set; }

    public int? CategoryId { get; set; }

    public string? Isbn { get; set; }

    public string? Publisher { get; set; }

    public int? Year { get; set; }

    public int? CopiesAvailable { get; set; }

    public virtual Author? Author { get; set; }

    public virtual ICollection<BorrowReturnTransaction> BorrowReturnTransactions { get; set; } = new List<BorrowReturnTransaction>();

    public virtual Category? Category { get; set; }
}
