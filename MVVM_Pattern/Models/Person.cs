﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommunityToolkit.Mvvm.ComponentModel;

namespace MVVM_Pattern.Models
{
    public class Person : ObservableObject
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private bool _sex;
        public bool Sex
        {
            get { return _sex; }
            set { SetProperty(ref _sex, value); }   
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set { SetProperty(ref _age, value);}
        }

        private string _address;
        public string Address
        {
            get { return _address; }
            set { SetProperty(ref _address, value); }
        }
    }
}
