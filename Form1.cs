using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winFormCrypto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            checkBox_english.Checked = true;
            checkBox_right.Checked = true;
        }

        private void checkBox_left_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_left.Checked)
                checkBox_right.Checked = false;
        }

        private void checkBox_right_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_right.Checked)
                checkBox_left.Checked = false;
        }

        private void checkBox_russian_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_russian.Checked)
                checkBox_english.Checked = false;
        }

        private void checkBox_english_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_english.Checked)
                checkBox_russian.Checked = false;
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            char[] eng = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] rus = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ".ToCharArray();
            //
            int step = int.Parse(txt_box_step.Text);
            int way = 0;
            if (checkBox_right.Checked)
                way = 1;
            else
                way = -1;
            string param = txt_box_param.Text;
            int typeLang = 0;
            if (checkBox_russian.Checked)
                typeLang = 1;
            else
                typeLang = 2;
            //
            switch (typeLang)
            {
                case 1:
                    param = Ceasar(param, step, way, rus);
                    break;
                case 2:
                    param = Ceasar(param, step, way, eng);
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            label3.Text = $"Result: {param}";
        }
        static string Ceasar(string param, int step, int way, char[] alphabet)
        {
            param = param.ToUpper();
            char[] charsParam = param.ToCharArray();
            char[] resParam = param.ToCharArray();
            int[] postions = new int[param.Length];
            for (int i = 0; i < charsParam.Length; i++)
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (charsParam[i] == ' ')
                        postions[i] = -1;       // пробелы
                    if (alphabet[j] == charsParam[i])
                    {
                        postions[i] = j;
                        break;
                    }
                }
            switch (way)
            {
                case 1:
                    for (int i = 0; i < postions.Length; i++)
                    {
                        if (postions[i] == -1)
                        {
                            resParam[i] = ' ';
                            continue;
                        }
                        int upperStep;
                        if (postions[i] + step > alphabet.Length)
                        {
                            upperStep = (postions[i] + step) % alphabet.Length;
                            resParam[i] = alphabet[upperStep];
                        }
                        else
                            resParam[i] = alphabet[postions[i] + step];
                        Console.WriteLine(resParam[i]);
                    }
                    break;
                case -1:
                    for (int i = 0; i < postions.Length; i++)
                    {
                        if (postions[i] == -1)
                        {
                            resParam[i] = ' ';
                            continue;
                        }
                        int lowerstep;
                        if (postions[i] - step < 0)
                        {
                            lowerstep = -((postions[i] - step) % alphabet.Length);
                            resParam[i] = alphabet[alphabet.Length - 1 - lowerstep];
                        }
                        else
                            resParam[i] = alphabet[postions[i] - step];
                    }
                    break;
                default:
                    break;
            }
            return new string(resParam);
        }
    }
}
