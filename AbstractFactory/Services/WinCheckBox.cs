﻿using AbstractFactory.Services.Interfaces;

namespace AbstractFactory.Services
{
    public class WinCheckBox : ICheckBox
    {
        public string CreateCheckBox()
        {
            return "Win CheckBox";
        }
    }
}
