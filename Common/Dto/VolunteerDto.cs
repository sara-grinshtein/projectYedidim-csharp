﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Common.Dto
{
    public class VolunteerDto
    {
        public int volunteer_id { get; set; }
        public string password { get; set; }
        public string volunteer_first_name { get; set; } //שם פרטי
        public string? volunteer_last_name { get; set; } //משפחה 
        public string? location { get; set; } // לבדוק את העניין לגבי המיקום האם מיקום או אזור התנדבות או שתיהם//
        public TimeSpan? start_time { get; set; }
        public TimeSpan? end_time { get; set; }
        public string? tel { get; set; }//טל
        public string email { get; set; }
        public bool IsDeleted { get; set; }

    }
}
