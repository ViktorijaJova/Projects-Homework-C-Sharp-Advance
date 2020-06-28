﻿using System;
using System.Collections.Generic;
using System.Text;
using TimeTrackingApp.Services.Helpers;
using TrackingTimeApp.Domain.Entities;
using TrackingTimeApp.Domain.Enums;
using TrackingTimeApp.Domain.Interfaces;

namespace TimeTrackingApp.Services.Services
{
    public class MenuService : IMenuService
    {
       
        public int LogInMenu()
        {
            Console.WriteLine("Welcome to the LogIn Menu");
            Console.WriteLine("Press 1 to LogIn");
            Console.WriteLine("Press 2 to Exit");
            int readline = int.Parse(Console.ReadLine());
         
            if(readline == 2)
            {
                Environment.Exit(0);
            }
            return readline;
        }

        public int MainMenu()
        {
            Console.WriteLine("Welcome back");
            Console.WriteLine("Choose what to do:");
            Console.WriteLine("1.Start Tracking 2. Manage your Account 3.Your Statistics 4.Log Out");
            int readline = int.Parse(Console.ReadLine());
            return readline;
          
        }

        public int ShowWatchingTypes()
        {
            Console.WriteLine("1.Movies 2.TvShows 3.StandUp");
            int readline = int.Parse(Console.ReadLine());
            return readline;
        }

        public int ShowReadingTypes()
        {
            Console.WriteLine("1.Fiction 2.Drama 3.Romance");
            int readline = int.Parse(Console.ReadLine());
            return readline;
        }

        public int ShowPuzzlesTypes()
        {
            Console.WriteLine("1.Jigsaw 2.EscapeRoom 3.Crossword 4.RubiksCube");
            int readline = int.Parse(Console.ReadLine());
            return readline;
        }

        public int ActivityMenu()
        {
            Console.WriteLine("Choose which activity");
            Console.WriteLine("1.Reading 2.Puzzles 3.Watching 4.OtherHobby");
            int readline = int.Parse(Console.ReadLine());
            return readline;
        }
        public void Welcome(User user)
        {
            Console.WriteLine("Welcome to the Time Tracking App");
            Console.WriteLine("Choose 1.To Login  2.To Register 3.Exit");

        }
    }
}
