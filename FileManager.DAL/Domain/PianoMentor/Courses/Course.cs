﻿namespace FileManager.DAL.Domain.PianoMentor.Courses
{
    public class Course
    {
        public int CourseId { get; set; }
        public int Position { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
        public virtual List<CourseItem> CourseItems { get; set; }
    }
}