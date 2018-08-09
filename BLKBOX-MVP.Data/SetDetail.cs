using System.Collections.Generic;

namespace BLKBOX_MVP.Data
{
    public class SetDetail
    {
        public WorkoutSection WorkoutSection { get; set; }
        public int SectionOrderID { get; set; }
        public string ExerciseName { get; set; }
        public int ExerciseDurationInSecs { get; set; }
        public int RestDurationInSecs { get; set; }
    }
}
