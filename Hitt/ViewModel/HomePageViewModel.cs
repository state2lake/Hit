using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Hitt.Model.Workouts;

namespace Hitt.ViewModel
{
    public class HomePageViewModel
    {
        readonly IList<QuickWorkouts> source;

        public ObservableCollection<QuickWorkouts> QuickWorkout { get; private set; }

        public HomePageViewModel()
        {
            source = new List<QuickWorkouts>();
            CreatQuickWorkoutCollection();
        }

        void CreatQuickWorkoutCollection()
        {
            source.Add(new QuickWorkouts
            {
                Title ="Tee Drill",
                Description = "Tee",
                Location = "Indoor/Outdoor"
            });
            source.Add(new QuickWorkouts
            {
                Title = "High-Tee Drill",
                Description = "Tee",
                Location = "Indoor/Outdoor"
            });
            source.Add(new QuickWorkouts
            {
                Title = "Soft TOss Drill",
                Description = "Tee"
               
            });

            QuickWorkout = new ObservableCollection<QuickWorkouts>(source);
        }
    }
}
