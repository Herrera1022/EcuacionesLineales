using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcuacionesLneales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Resolver_Click(object sender, EventArgs e)
        {
            string función1 = textFun1.Text;
            string función2 = textFun2.Text;
            string funciónMin1 = función1.ToLower();
            string funciónMin2 = función2.ToLower();
            string funciónSinEspacios1 = funciónMin1.Replace(" ", "");
            string funciónSinEspacios2 = funciónMin2.Replace(" ", "");

            if (OPCIONES.SelectedItem.ToString() == "y=mx+b")
            {


                if (textFun1.Text == "" && textFun2.Text == "")
                {
                    MessageBox.Show("Para poder realizar la operación, ingrese " +
                        "las ecuaciones en los espacios designados.");

                }
                else
                {
                    int indexM = (funciónSinEspacios1.IndexOf("=") + 1);
                    int indexX = (funciónSinEspacios1.IndexOf("x") - 2);
                    int indexM2 = (funciónSinEspacios2.IndexOf("=") + 1);
                    int indexX2 = (funciónSinEspacios2.IndexOf("x") - 2);
                    string m1 = (funciónSinEspacios1.Substring(indexM, indexX));
                    string m2 = (funciónSinEspacios2.Substring(indexM2, indexX2));
                    float pend1 = 0;
                    float pend2 = 0;
                    bool result1 = (float.TryParse(m1, out pend1));
                    bool result2 = (float.TryParse(m2, out pend2));
                    if (result1 == false && result2 == false)
                    {
                        MessageBox.Show("Por favor ingrese un numero que corresponda al valor de la pendiente m");
                    }
                    if (result1 && result2)
                    {
                        if (pend1 * pend2 == -1)
                        {
                            textfin3.Text = ("PERPENDICULAR");
                        }
                        if (pend2 == pend1)
                        {
                            textfin3.Text = ("PARALELA");
                        }
                    }
                }
            }
            else
            {
                if (textFun1.Text == "" && textFun2.Text == "")
                {
                    MessageBox.Show("Para poder realizar la operación, ingrese " +
                        "las ecuaciones en los espacios designados.");

                }
                else
                {
                    int indexM = (funciónSinEspacios1.IndexOf("=") + 1);
                    int indexX = (funciónSinEspacios1.IndexOf("(") - 2);
                    int indexM2 = (funciónSinEspacios2.IndexOf("=") + 1);
                    int indexX2 = (funciónSinEspacios2.IndexOf("(") - 2);
                    string m1 = (funciónSinEspacios1.Substring(indexM, indexX));
                    string m2 = (funciónSinEspacios2.Substring(indexM2, indexX2));
                    float pend1 = 0;
                    float pend2 = 0;
                    bool result1 = (float.TryParse(m1, out pend1));
                    bool result2 = (float.TryParse(m2, out pend2));
                    if (result1 == false && result2 == false)
                    {
                        MessageBox.Show("Por favor ingrese un numero que corresponda al valor de la pendiente m");
                    }
                    if (result1 && result2)
                    {
                        if (pend1 * pend2 == -1)
                        {
                            textfin3.Text = ("PERPENDICULAR");
                        }
                        if (pend2 == pend1)
                        {
                            textfin3.Text = ("PARALELA");
                        }
                    }
                }
            }
        }
    }
}
