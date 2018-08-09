using System.Collections.Generic;

namespace BLKBOX_MVP.Data
{
    public static class WorkoutData
    {
        public static List<Workout> Workouts = new List<Workout>
            {
                new Workout
                {
                    WorkoutID = 1,
                    WorkoutName = "EMOM",
                    WorkoutDescription = "Every Minute on the Minute",
                    WorkoutType = WorkoutType.Custom,
                    Sets = 30
                },
                new Workout
                {
                    WorkoutID = 2,
                    WorkoutName = "TABATA",
                    WorkoutDescription = "An 8 round timing sequence. 20 Seconds of work, 10 Seconds of rest.",
                    WorkoutType = WorkoutType.Custom,
                    Sets = 8
                },
                new Workout
                {
                    WorkoutID = 3,
                    WorkoutName = "40 : 20",
                    WorkoutDescription = "40 Seconds of Work, 20 Seconds of rest. Max time 30 minutes.",
                    WorkoutType = WorkoutType.Custom,
                    Sets = 30
                },
                new Workout
                {
                    WorkoutID = 4,
                    WorkoutName = "30 : 30",
                    WorkoutDescription = "A repeating timer of 30 Seconds of Work, 30 Seconds of Rest.",
                    WorkoutType = WorkoutType.Custom,
                    Sets = 30
                },
                new Workout
                {
                    WorkoutID = 5,
                    WorkoutName = "HIIT 7",
                    WorkoutDescription = "A 7 minute bodyweight workout. 12 rounds, 30 seconds of work, 10 seconds of rest. Specific exercises per round.",
                    WorkoutType = WorkoutType.Defined,
                    Sets = 12,
                    SetDetails = new List<SetDetail>
                    {
                        new SetDetail
                        {
                            ExerciseName = "Jumping Jacks",
                            ExerciseDurationInSecs = 30,
                            RestDurationInSecs = 10
                        },
                        new SetDetail
                        {
                            ExerciseName = "Squat Hold",
                            ExerciseDurationInSecs = 30,
                            RestDurationInSecs = 10
                        },
                        new SetDetail
                        {
                            ExerciseName = "Push-ups",
                            ExerciseDurationInSecs = 30,
                            RestDurationInSecs = 10
                        },
                        new SetDetail
                        {
                            ExerciseName = "Crunches",
                            ExerciseDurationInSecs = 30,
                            RestDurationInSecs = 10
                        },
                        new SetDetail
                        {
                            ExerciseName = "Step-ups",
                            ExerciseDurationInSecs = 30,
                            RestDurationInSecs = 10
                        },
                        new SetDetail
                        {
                            ExerciseName = "Squats",
                            ExerciseDurationInSecs = 30,
                            RestDurationInSecs = 10
                        },
                        new SetDetail
                        {
                            ExerciseName = "Push-ups",
                            ExerciseDurationInSecs = 30,
                            RestDurationInSecs = 10
                        },
                        new SetDetail
                        {
                            ExerciseName = "Plank",
                            ExerciseDurationInSecs = 30,
                            RestDurationInSecs = 10
                        },
                        new SetDetail
                        {
                            ExerciseName = "Burpees",
                            ExerciseDurationInSecs = 30,
                            RestDurationInSecs = 10
                        },
                        new SetDetail
                        {
                            ExerciseName = "Lunges",
                            ExerciseDurationInSecs = 30,
                            RestDurationInSecs = 10
                        },
                        new SetDetail
                        {
                            ExerciseName = "Side Plank(L)",
                            ExerciseDurationInSecs = 30,
                            RestDurationInSecs = 10
                        },
                        new SetDetail
                        {
                            ExerciseName = "Side Plank(R)",
                            ExerciseDurationInSecs = 30,
                            RestDurationInSecs = 0
                        }
                    }
                },
            };        
    }
}
