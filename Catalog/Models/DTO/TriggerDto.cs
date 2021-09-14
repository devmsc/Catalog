using System;
using Catalog.Models.Questions;

namespace Catalog.Models.DTO
{
    public class TriggerDto
    {
        public TriggerDto(Trigger trigger)
        {
            Id = trigger.Id;
            Status = trigger.TriggerStatus;
            CreatedAt = trigger.CreatedAt;
            UpdatedAt = trigger.UpdatedAt;
            Content = trigger.Content;
        }

        public Guid Id { get; set; }
        public TriggerStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Content { get; set; }
    }
}