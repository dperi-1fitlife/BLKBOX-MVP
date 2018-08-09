using BLKBOX_MVP.Data;
using System;
using System.Collections.Generic;

namespace BLKBOX_MVP.Models
{
    public class WorkoutsViewModel
    {
        public List<Workout> Workouts { get; set; }

        public WorkoutsViewModel()
        {
            Workouts = WorkoutData.Workouts;
        }
    }
}