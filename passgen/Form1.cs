using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passgen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }

    class PassGenState
    {
        private bool digits;
        private bool upperCaseLetters;
        private bool lowerCaseLetters;
        private bool specialCharacters;
        private bool memorizable;
        private bool multiple;

        public PassGenState()
        {
            digits = false;
            upperCaseLetters = false;
            lowerCaseLetters = false;
            specialCharacters = false;
            memorizable = false;
            multiple = false;
        }

        public PassGenState useDigits()
        {
            digits = true;

            return this;
        }

        public PassGenState useUpperCaseLetters()
        {
            upperCaseLetters = true;

            return this;
        }

        public PassGenState useLowerCaseLetters()
        {
            lowerCaseLetters = true;

            return this;
        }

        public PassGenState useSpecialCharacters()
        {
            specialCharacters = true;

            return this;
        }

        public PassGenState setMemorizableMode()
        {
            memorizable = true;

            return this;
        }

        public PassGenState generateMultiple()
        {
            multiple = true;

            return this;
        }

        public PassGenState useNotDigits()
        {
            digits = false;

            return this;
        }

        public PassGenState useNotUpperCaseLetters()
        {
            upperCaseLetters = false;

            return this;
        }

        public PassGenState useNotLowerCaseLetters()
        {
            lowerCaseLetters = false;

            return this;
        }

        public PassGenState useNotSpecialCharacters()
        {
            specialCharacters = false;

            return this;
        }

        public PassGenState unsetMemorizableMode()
        {
            memorizable = false;

            return this;
        }

        public PassGenState generateNotMultiple()
        {
            multiple = false;

            return this;
        }

        public bool digitsUsed()
        {
            return digits;
        }

        public bool lowerCaseLettersUsed()
        {
            return lowerCaseLetters;
        }

        public bool upperCaseLettersUsed()
        {
            return upperCaseLetters;
        }

        public bool specialCharactersUsed()
        {
            return specialCharacters;
        }

        public bool memorizableModSet()
        {
            return memorizable;
        }

        public bool isMultiple()
        {
            return multiple;
        }

    }
}
