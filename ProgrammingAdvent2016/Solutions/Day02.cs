﻿using System;
using System.IO;
using System.Windows.Forms;

namespace ProgrammingAdvent2016
{
    public static class Day02
    {
        public static void SetSolutionText(TextBox partOneTextBox, TextBox partTwoTextBox)
        {
            string[] input;
            try
            {
                input = File.ReadAllLines(@"InputFiles\InputDay01Part1.txt");
            }
            catch
            {
                partOneTextBox.Text = "ERROR: Unable to read input file.";
                return;
            }

            partOneTextBox.Text = "Day 2 Solution Not Yet Implemented";
            partTwoTextBox.Text = "Day 2 Solution Not Yet Implemented";
        }
    }
}
