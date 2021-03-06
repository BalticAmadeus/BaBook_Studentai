﻿namespace BaBookStudentai.Entities
{
    public class EventUser
    {
        public int EventId { get; set; }
        public string UserId { get; set; }
        public AttendanceStatus Status { get; set; }
        public virtual Event Event { get; set; }
        public virtual User User { get; set; }
    }

    public enum AttendanceStatus
    {
        Going = 1, NotGoing = 2, NotAnswered = 3
    }
}