using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        private int[] numerosGanadores;
        private List<int> numerosJugados;

        public Form1()
        {
            InitializeComponent();
            numerosGanadores = new int[7];
            
        }


        public int VerificarNumerosGanadores(int[] numerosGanadores,List<int> numerosJugados)
        {
            int numeroAciertos = 0;
            for (int i = 0; i < 7; i++)
            {
                foreach (int numeroJugado in numerosJugados)
                {
                    if (numerosGanadores[i] == numeroJugado) {
                        numeroAciertos++;
                        
                    }

                }
            }

            return numeroAciertos;
        }

        public int[] generarNumerosAleatorios()
        {
            bool bandera;
            bool hayRepetidos;
            bool hayCero;
            int[] numeros = new int[7];
            List<int> valores = new List<int>();
            Random rd = new Random(DateTime.Now.TimeOfDay.Milliseconds);

            for (int i = 0; i < 7; i++)
            {
                bandera = true;
                hayRepetidos = false;
                while (bandera)
                {
                    hayCero = true;
                    
                    while (hayCero)
                    {
                        numeros[i] = rd.Next(59);
                        if (numeros[i]!=0)
                        {
                            hayCero = false;
                        }
                    }
                    foreach (int valor in valores)
                    {
                        if (numeros[i] == valor)
                        {
                            hayRepetidos = true;
                        }
                    }

                    if (hayRepetidos)
                    {
                        hayRepetidos = false;
                    }
                    else
                    {
                        bandera = false;
                        valores.Add(numeros[i]);
                    }
                }

            }



            return numeros;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numerosGanadores = generarNumerosAleatorios();
            txtNumGanadores.Text = "";

            txtNumGanadores.Text = " "+numerosGanadores[0];
            for (int i = 1; i < 6; i++)
            {
                txtNumGanadores.Text=txtNumGanadores.Text+" - "+ numerosGanadores[i] ;
            }

            txtNumAdicoanal.Text = " "+numerosGanadores[6];

            numerosJugados = new List<int>();

            if (numericUpDown7.Value==6)
            {
                numerosJugados.Add(Convert.ToInt32(numericUpDown1.Value));
                numerosJugados.Add(Convert.ToInt32(numericUpDown2.Value));
                numerosJugados.Add(Convert.ToInt32(numericUpDown3.Value));
                numerosJugados.Add(Convert.ToInt32(numericUpDown4.Value));
                numerosJugados.Add(Convert.ToInt32(numericUpDown5.Value));
                numerosJugados.Add(Convert.ToInt32(numericUpDown6.Value));
            }
            else
            {
                if (numericUpDown7.Value == 7)
                {
                    numerosJugados.Add(Convert.ToInt32(numericUpDown1.Value));
                    numerosJugados.Add(Convert.ToInt32(numericUpDown2.Value));
                    numerosJugados.Add(Convert.ToInt32(numericUpDown3.Value));
                    numerosJugados.Add(Convert.ToInt32(numericUpDown4.Value));
                    numerosJugados.Add(Convert.ToInt32(numericUpDown5.Value));
                    numerosJugados.Add(Convert.ToInt32(numericUpDown6.Value));
                    numerosJugados.Add(Convert.ToInt32(numericUpDown8.Value));

                }
                else
                {
                    if (numericUpDown7.Value == 8)
                    {
                        numerosJugados.Add(Convert.ToInt32(numericUpDown1.Value));
                        numerosJugados.Add(Convert.ToInt32(numericUpDown2.Value));
                        numerosJugados.Add(Convert.ToInt32(numericUpDown3.Value));
                        numerosJugados.Add(Convert.ToInt32(numericUpDown4.Value));
                        numerosJugados.Add(Convert.ToInt32(numericUpDown5.Value));
                        numerosJugados.Add(Convert.ToInt32(numericUpDown6.Value));
                        numerosJugados.Add(Convert.ToInt32(numericUpDown8.Value));
                        numerosJugados.Add(Convert.ToInt32(numericUpDown9.Value));

                    }
                    else
                    {
                        if (numericUpDown7.Value == 9)
                        {
                            numerosJugados.Add(Convert.ToInt32(numericUpDown1.Value));
                            numerosJugados.Add(Convert.ToInt32(numericUpDown2.Value));
                            numerosJugados.Add(Convert.ToInt32(numericUpDown3.Value));
                            numerosJugados.Add(Convert.ToInt32(numericUpDown4.Value));
                            numerosJugados.Add(Convert.ToInt32(numericUpDown5.Value));
                            numerosJugados.Add(Convert.ToInt32(numericUpDown6.Value));
                            numerosJugados.Add(Convert.ToInt32(numericUpDown8.Value));
                            numerosJugados.Add(Convert.ToInt32(numericUpDown9.Value));
                            numerosJugados.Add(Convert.ToInt32(numericUpDown10.Value));

                        }
                        else
                        {
                            if (numericUpDown7.Value == 10)
                            {
                                numerosJugados.Add(Convert.ToInt32(numericUpDown1.Value));
                                numerosJugados.Add(Convert.ToInt32(numericUpDown2.Value));
                                numerosJugados.Add(Convert.ToInt32(numericUpDown3.Value));
                                numerosJugados.Add(Convert.ToInt32(numericUpDown4.Value));
                                numerosJugados.Add(Convert.ToInt32(numericUpDown5.Value));
                                numerosJugados.Add(Convert.ToInt32(numericUpDown6.Value));
                                numerosJugados.Add(Convert.ToInt32(numericUpDown8.Value));
                                numerosJugados.Add(Convert.ToInt32(numericUpDown9.Value));
                                numerosJugados.Add(Convert.ToInt32(numericUpDown10.Value));
                                numerosJugados.Add(Convert.ToInt32(numericUpDown11.Value));

                            }
                        }
                    }
                }
            }


            txtNumAciertos.Text = "" + VerificarNumerosGanadores(numerosGanadores,numerosJugados);




        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown7.Value==6)
            {
                numericUpDown8.Visible = false;
                numericUpDown9.Visible = false;
                numericUpDown10.Visible = false;
                numericUpDown11.Visible = false;
            }
            else
            {
                if (numericUpDown7.Value == 7)
                {
                    numericUpDown8.Visible = true;
                    numericUpDown9.Visible = false;
                    numericUpDown10.Visible = false;
                    numericUpDown11.Visible = false;
                }
                else
                {
                    if (numericUpDown7.Value == 8)
                    {
                        numericUpDown8.Visible = true;
                        numericUpDown9.Visible = true;
                        numericUpDown10.Visible = false;
                        numericUpDown11.Visible = false;
                    }
                    else
                    {
                        if (numericUpDown7.Value == 9)
                        {
                            numericUpDown8.Visible = true;
                            numericUpDown9.Visible = true;
                            numericUpDown10.Visible = true;
                            numericUpDown11.Visible = false;
                        }
                        else
                        {
                            if (numericUpDown7.Value == 10)
                            {
                                numericUpDown8.Visible = true;
                                numericUpDown9.Visible = true;
                                numericUpDown10.Visible = true;
                                numericUpDown11.Visible = true;
                            }
                        }
                    }
                }
            }
        }
    }
}
