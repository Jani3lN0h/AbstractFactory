using AbstractFactory.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Services
{
    public class MacCheckBox : ICheckBox
    {
        public string CreateCheckBox()
        {
            return "Mac CheckBox";
        }
    }
}