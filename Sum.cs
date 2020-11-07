using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Text;

namespace ds.test.impl
{
    internal class Sum : IPlugin
    {
        internal Sum()
        {
            Image = Properties.Resources.Sum;
        }
        public string PluginName { get; } = "Сложение чисел";
        public string Version { get; } = "1.0";
        public Image Image { get; }
        public string Description { get; } = "Плагин выполняет операции сложения.";
        public int Run(int input1, int input2) => input1 + input2;
    }
}
