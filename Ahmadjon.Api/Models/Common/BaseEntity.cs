using Ahmadjon.Api.Enums;
using System;

namespace Ahmadjon.Api.Models.Common
{
    public class BaseEntity
    {
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime EditedDate { get; set; }
        public long UpdatedBy { get; set; }
        public ItemState State { get; set; } = ItemState.Created;

        public void Update(long userId)
        {
            EditedDate = DateTime.Now;
            UpdatedBy = userId;
            State = ItemState.Updated;
        }
        public void Deleted(long userId)
        {
            EditedDate = DateTime.Now;
            UpdatedBy = userId;
            State = ItemState.Deleted;
        }
    }
}
