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
        PassGenState state;

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBoxDigits_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDigits.Checked)
            {
                state.useDigits();
            }
            else
            {
                state.useNotDigits();
            }
        }

        private void checkBoxUpperCaseLetters_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUpperCaseLetters.Checked)
            {
                state.useUpperCaseLetters();
            }
            else
            {
                state.useNotUpperCaseLetters();
            }
        }

        private void checkBoxLowerCaseLetters_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLowerCaseLetters.Checked)
            {
                state.useLowerCaseLetters();
            }
            else
            {
                state.useNotLowerCaseLetters();
            }
        }

        private void checkBoxSpecialCharacters_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSpecialCharacters.Checked)
            {
                state.useSpecialCharacters();
            }
            else
            {
                state.useNotSpecialCharacters();
            }
        }

        private void checkBoxMemorizeable_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMemorizeable.Checked)
            {
                state.setMemorizableMode();
            }
            else
            {
                state.unsetMemorizableMode();
            }
        }

        private void checkBoxMultiple_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMultiple.Checked)
            {
                state.generateMultiple();
                numericUpDownHowMany.Enabled = true;
            }
            else
            {
                state.generateNotMultiple();
                numericUpDownHowMany.Enabled = false;
            }
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            Password password = new Password(state.getCharactersNumber());

            if (state.digitsUsed())
            {
                password.addDigits();
            }
            if (state.lowerCaseLettersUsed())
            {
                password.addLowerCaseLetters();
            }
            if (state.upperCaseLettersUsed())
            {
                password.addUpperCaseLetters();
            }
            if (state.specialCharactersUsed())
            {
                password.addSpecialCharacters();
            }

            textBoxPasswordList.Clear();

            if (state.isMultiple())
            {
                for (int i = 0; i < state.getPasswordsNumber(); i++)
                {
                    textBoxPasswordList.AppendText(password.generate());
                    if (i != state.getPasswordsNumber() - 1)
                    {
                        textBoxPasswordList.AppendText("\n");
                    }
                }
            }
            else
            {
                textBoxPasswordList.AppendText(password.generate());
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            state = new PassGenState();
            numericUpDownHowMany.Enabled = false;
        }

        private void numericUpDownCharacters_ValueChanged(object sender, EventArgs e)
        {
            state.setCharactersNumber((int)numericUpDownCharacters.Value);
        }

        private void numericUpDownHowMany_ValueChanged(object sender, EventArgs e)
        {
            state.setPasswordsNumber((int)numericUpDownHowMany.Value);
        }
    }

    class Password
    {
        private string charactersSet;
        int length;
        Random rand;

        public Password(int passwordLength)
        {
            rand = new Random();
            length = passwordLength;
            charactersSet = "";        }

        public void addDigits()
        {
            charactersSet += "1234567890";
        }

        public void addLowerCaseLetters()
        {
            charactersSet += "abcdefghijklmnopqrstuvwxyz";
        }

        public void addUpperCaseLetters()
        {
            charactersSet += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        }

        public void addSpecialCharacters()
        {
            charactersSet += "~!@#;%:&*^()[]{}\\|/><,$'.";
        }

        public string generate()
        {
            string password = "";

            if (charactersSet == "")
            {
                MessageBox.Show("Choose any of symbol sets!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                for (int i = 0; i < length; i++)
                {
                    password += charactersSet.ElementAt(rand.Next(charactersSet.Length));
                }
            }

            return password;
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

        int charactersNumber;
        int passwordsNumber;

        public PassGenState()
        {
            digits = false;
            upperCaseLetters = false;
            lowerCaseLetters = false;
            specialCharacters = false;
            memorizable = false;
            multiple = false;

            charactersNumber = 0;
            passwordsNumber = 0;
        }

        public int getCharactersNumber()
        {
            return charactersNumber;
        }

        public PassGenState setCharactersNumber(int number)
        {
            charactersNumber = number;

            return this;
        }

        public int getPasswordsNumber()
        {
            return passwordsNumber;
        }

        public PassGenState setPasswordsNumber(int number)
        {
            passwordsNumber = number;

            return this;
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
