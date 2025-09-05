using System;
using System.ComponentModel.DataAnnotations;

namespace Acme.BookStore.Authors;

[Serializable]
public class CreateAuthorDto
{
    [Required]
    [StringLength(AuthorConsts.MaxNameLength)]
    public string Name { get; set; }

    [Required]
    public DateTime BirthDate { get; set; } = new DateTime(1970, 1, 1);

    public string ShortBio { get; set; }
}
