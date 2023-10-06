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
            if (OPCIONES.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione una de las opciones para resolver el sistema de ecuaciones ");
            }
            else
            {

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
                            if (pend1 != pend2&& pend1 * pend2 != -1)
                            {
                                int indexB = (funciónSinEspacios1.IndexOf("x") + 1);
                                int indexB2 = (funciónSinEspacios2.IndexOf("x") + 1);
                                string b = (funciónSinEspacios1.Substring(indexB));
                                string b2 = (funciónSinEspacios1.Substring(indexB));
                                float termInd = 0;
                                float termInd2 = 0;
                                bool independiente1 = (float.TryParse(b, out termInd));
                                bool independiente2 = (float.TryParse(b2, out termInd2));
                                if (independiente1 == false && independiente2 == false)
                                {
                                    MessageBox.Show("Por favor ingrese un valor independiente correcto");
                                }
                                if (independiente1 && independiente2)
                                {
                                    float xIntercepto = (termInd2 - termInd) / (pend1 - pend2);
                                    float yIntercepto = (pend1 * xIntercepto + termInd);
                                    textfin2.Text = ("la intersección es" + (xIntercepto, yIntercepto));
                                }
                            }
                        }
                    }
                }
                if(OPCIONES.SelectedItem.ToString() == "y-y1=m(x-x1)")
                {
                    if (textFun1.Text == "" && textFun2.Text == "")
                    {
                        MessageBox.Show("Para poder realizar la operación, ingrese " +
                            "las ecuaciones en los espacios designados.");

                    }
                    else
                    {
                        int indexM = (funciónSinEspacios1.IndexOf("=") +1);
                        int indexX = (funciónSinEspacios1.IndexOf("(") -4);
                        int indexM2 = (funciónSinEspacios2.IndexOf("=") +1);
                        int indexX2 = (funciónSinEspacios2.IndexOf("(") -4);
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
                            if (pend1 != pend2 && pend1 * pend2 != -1) 
                            {
                                int indexY1=(funciónSinEspacios1.IndexOf("y") + 1);
                                int indexIndY = (funciónSinEspacios1.IndexOf("=") - 1);
                                int indexX1 = (funciónSinEspacios1.IndexOf("x") + 1);
                                int indexIndX = (funciónSinEspacios1.IndexOf(")") - 2);
                                int indexY2 = (funciónSinEspacios2.IndexOf("y") + 1);
                                int indexIndY2 = (funciónSinEspacios2.IndexOf("=") - 2);
                                int indexX3 = (funciónSinEspacios2.IndexOf("x") + 1);
                                int indexIndX2 = (funciónSinEspacios2.IndexOf(")") - 2);
                                string y1 = (funciónSinEspacios1.Substring(indexY1, indexIndY));
                                string x1 = (funciónSinEspacios1.Substring(indexX1, indexIndX));
                                string y2 = (funciónSinEspacios1.Substring(indexY2, indexIndY2));
                                string x2 = (funciónSinEspacios1.Substring(indexX3, indexIndX2));
                                float termY1 = 0;
                                float termX1 = 0;
                                float termY2 = 0;
                                float termX2 = 0;
                                bool term1 = (float.TryParse(y1, out termY1));
                                bool term2 = (float.TryParse(y1, out termX1));
                                bool term3 = (float.TryParse(y1, out termY2));
                                bool term4 = (float.TryParse(y1, out termX2));
                                if(term1==false && term2 == false && term3 == false && term4 == false)
                                {
                                    MessageBox.Show("Por favor ingrese valores optimos para las variables y1 y x1");
                                }
                                if (term1 && term2 && term3 && term4)
                                {
                                    double xIntercept = (termY2 - termY1 + pend1 * termX1 - pend2 * termX2) / (pend2 - pend2);
                                    double yIntercept = pend1 * (xIntercept - termX1) + termY1;
                                    textfin2.Text = ("la intercepción es" + (xIntercept, yIntercept));
                                }
                            }

                        }
                    }
                }
            }
        }
    }
}
