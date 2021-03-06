﻿using BLKBOX_MVP.Data;
using BLKBOX_MVP.Models;
using Microsoft.AspNetCore.Mvc;

namespace BLKBOX_MVP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult BeginWorkout(int WorkoutID)
        {
            BeginWorkoutViewModel model = new BeginWorkoutViewModel();
            model.Workout = WorkoutData.Workouts.Find(x => x.WorkoutID == WorkoutID);
            return View(model);
        }

        public IActionResult Workouts()
        {
            return View(new WorkoutsViewModel());
        }

        public IActionResult Holding()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}