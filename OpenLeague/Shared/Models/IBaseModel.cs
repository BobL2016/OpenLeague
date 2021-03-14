using System;

namespace OpenLeague.Shared.Models
{
    public interface IBaseModel
    {
        DateTimeOffset Created { get; set; }
        DateTimeOffset? Deleted { get; set; }
        int Id { get; set; }
        DateTimeOffset? Updated { get; set; }
    }
}