﻿using backend.Enum;

namespace backend.Dto.JobDto
{
    public class JobResponseDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Role Category { get; set; } = 0;
        public DateTime CreatedAt { get; set; }
        public string? Username { get; set; } = string.Empty;
        public decimal Budget { get; set; }
        public DateTime? Deadline { get; set; }
        public string State { get; set; }
        public int? AcceptedQuoteId { get; set; }
        public string? FreelancerUsername { get; set; } = string.Empty;


    }
}
