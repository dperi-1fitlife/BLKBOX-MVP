using System.Collections.Generic;

namespace BLKBOX_MVP.Data
{
    public class Workout
    {
        public int WorkoutID { get; set; }
        public string WorkoutName { get; set; }
        public string WorkoutDescription { get; set; }
        public WorkoutType WorkoutType { get; set; }
        public int Sets { get; set; }
        public List<SetDetail> SetDetails { get; set; }
    }
}
