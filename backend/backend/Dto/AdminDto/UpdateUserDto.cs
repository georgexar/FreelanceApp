﻿using backend.Enum;

namespace backend.Dto.AdminDto
{
    public class UpdateUserDto
    {
        public string PreviousUsername { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? ImageUrl { get; set; }
        public string? Biography { get; set; }
        public Role? Role { get; set; }
    }
}