using System;

namespace Cookie.DataRepository.Interfaces
{
    public interface IEntity
    {
        DateTime CreatedDate { get; set; }
        string CreatedBy { get; set; }

        DateTime ModifiedDate { get; set; }
        string ModifiedBy { get; set; }
    }
}
