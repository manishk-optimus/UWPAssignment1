﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWPAssignment.Models;

namespace UWPAssignment.Data
{
    public class MenuData
    {
        private List<MenuModel> _menu = new List<MenuModel>();

        private string[] _image =
            {
            "ms-appx:///Assets/menu1.jpg",
            "ms-appx:///Assets/menu2.jpg",
            "ms-appx:///Assets/menu3.jpg",
            "ms-appx:///Assets/menu4.jpg",
            "ms-appx:///Assets/menu5.jpg"
             };

        public List<MenuModel> GetMenu()
        {
            _menu.Add(new MenuModel
            {
                Name = "Samosa",
                Description = "The speciality of north india generally enjoyed with Tea",
                ImageSource = new Uri(_image[0], UriKind.Absolute),
                Price = 100
            });

            _menu.Add(new MenuModel
            {
                Name = "Idli",
                Description = "The speciality of south india generally enjoyed with sambhar",
                ImageSource = new Uri(_image[1], UriKind.Absolute),
                Price = 125
            });

            _menu.Add(new MenuModel
            {
                Name = "Butter Chicken",
                Description = "A delicious Lunch special",
                ImageSource = new Uri(_image[2], UriKind.Absolute),
                Price = 350
            });

            _menu.Add(new MenuModel
            {
                Name = "Chhole Bhature",
                Description = "The speciality of north india",
                ImageSource = new Uri(_image[3], UriKind.Absolute),
                Price = 150
            });

            _menu.Add(new MenuModel
            {
                Name = "pizza",
                Description = "Perfect for foodies",
                ImageSource = new Uri(_image[4], UriKind.Absolute),
                Price = 240
            });

            return _menu;
        }
    }
}
