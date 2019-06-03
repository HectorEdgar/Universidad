using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen
{
    public partial class Form1 : Form
    {
        private MySqlConnection conn;

        private MySqlDataAdapter daFeedback;
        private MySqlDataAdapter daScheduling;
        private MySqlDataAdapter daRegistration;
        private MySqlDataAdapter daTicketbooking;



        private DataSet dsFeedback;
        private DataSet dsScheduling;
        private DataSet dsRegistration;
        private DataSet dsTicketbooking;

        private DataTable dtFeedback;
        private DataRow drFeedback;
        private DataTable dtScheduling;
        private DataRow drScheduling;
        private DataTable dtRegistration;
        private DataRow drRegistration;
        private DataTable dtTicketbooking;
        private DataRow drTicketbooking;

        private String userName;


        private const String tabla1 = "feedback";
        private const String tabla2 = "scheduling";
        private const String tabla3 = "registration";
        private const String tabla4 = "ticketbooking";

        private String cadenaconexion;



        public Form1()
        {
            InitializeComponent();
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
           



            conectar();
        }

        private void llenarDatos()
        {
            dsFeedback = new DataSet();
            dsRegistration = new DataSet();
            dsScheduling = new DataSet();
            dsTicketbooking = new DataSet();

            daFeedback = new MySqlDataAdapter("select * from feedback", conn);
            daRegistration = new MySqlDataAdapter("select * from registration", conn);
            daScheduling = new MySqlDataAdapter("select * from scheduling", conn);
            daTicketbooking = new MySqlDataAdapter("select * from ticketbooking", conn);

            MySqlCommandBuilder cmdBldr1 = new MySqlCommandBuilder(daFeedback);
            MySqlCommandBuilder cmdBldr2 = new MySqlCommandBuilder(daRegistration);
            MySqlCommandBuilder cmdBldr3 = new MySqlCommandBuilder(daScheduling);
            MySqlCommandBuilder cmdBldr4 = new MySqlCommandBuilder(daTicketbooking);

            daFeedback.Fill(dsFeedback, tabla1);
            daRegistration.Fill(dsRegistration, tabla3);
            daScheduling.Fill(dsScheduling, tabla2);
            daTicketbooking.Fill(dsTicketbooking, tabla4);

            dtFeedback = dsFeedback.Tables[tabla1];
            dtRegistration = dsRegistration.Tables[tabla3];
            dtScheduling = dsScheduling.Tables[tabla2];
            dtTicketbooking = dsTicketbooking.Tables[tabla4];


        }

        private void conectar()
        {
            cadenaconexion = "Server=172.16.14.70; Database=hectoredgar; Uid=root2; Pwd=admin; Port=3306;";
            conn = new MySqlConnection(cadenaconexion);
            try
            {
                //Si se abre la conexión mostrará el mensaje y se inicializarán los objetos
                conn.Open();
                MessageBox.Show("Se ha conectado correctamente");
                llenarDatos();
                //conn.Close();

            }
            catch (Exception e)
            {

                MessageBox.Show("Error " + e.StackTrace);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtLoginUser.ResetText();
            txtLoginPassword.ResetText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userName = txtLoginUser.Text;
            //MessageBox.Show(cbLoggin.Text);
            if (cbLoggin.Text.Equals("user"))
            {
                foreach (DataRow item in dtRegistration.Rows)
                {
                    if (item["username"].Equals(txtLoginUser.Text))
                    {
                        drRegistration = item;
                        break;

                    }
                }

                if (drRegistration != null)
                {
                    if (drRegistration["password"].Equals(txtLoginPassword.Text))
                    {

                        panel1.Visible = false;
                        panel9.Visible = true;
                        txtLoginUser.ResetText();
                        txtLoginPassword.ResetText();
                    }
                    else
                    {
                        MessageBox.Show("contraseña incorrecta");
                    }
                }
                else
                {
                    MessageBox.Show("usuario incorrecto");
                }
            }
            else
            {
                if (cbLoggin.Text.Equals("admin"))
                {

                    if (txtLoginUser.Text.Equals("root") && txtLoginPassword.Text.Equals("admin"))
                    {
                        panel1.Visible = false;
                        panel3.Visible = true;
                        txtLoginUser.ResetText();
                        txtLoginPassword.ResetText();
                    }
                    else
                    {
                        MessageBox.Show("usuario o contraseña incorrectos "+ txtLoginUser.Text+" "+txtLoginPassword.Text);
                    }
                }
                else
                {
                    MessageBox.Show("seleccione el tipo de usuario");
                }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;

            panel5.Visible = true;
            dataGridView2.DataSource = dsScheduling;
            dataGridView2.DataMember = tabla2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String gender;
            if (rbMale.Checked)
            {
                gender = "Male";

            }
            else
            {
                gender = "Female";
            }
            if (!txtLocation.Text.Equals("") && !txtloginName.Text.Equals("") &&
                !txtName.Text.Equals("") && !txtPassword1.Text.Equals("") && !txtPhno.Text.Equals(""))
            {

                if (txtPassword1.Text.Equals(txtPassword2.Text))
                {
                    if (cbAccept.Checked)
                    {
                        drRegistration = dtRegistration.NewRow();
                        drRegistration["password"] = txtPassword1.Text;
                        drRegistration["firstname"] = txtName.Text;
                        drRegistration["username"] = txtloginName.Text;
                        drRegistration["gender"] = gender;
                        drRegistration["location"] = txtLocation.Text;
                        drRegistration["phno"] = txtPhno.Text;
                        dtRegistration.Rows.Add(drRegistration);

                        actualizarTablaRegistro();
                        panel2.Visible = false;
                        panel1.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Acepta los terminos y condiciones");
                    }
                }
                else {
                    MessageBox.Show("Las contraseñas no coinciden");
                }




            }
            else

            {
                MessageBox.Show("Rellene todos los campos");
            }







        }

        private void actualizarTablaRegistro()
        {
            try
            {
                daRegistration.Update(dsRegistration, tabla3);
                MessageBox.Show("Registros actualizados");
            }
            catch (Exception e)
            {


                MessageBox.Show(e.StackTrace);
            }


        }
        private void actualizarTablaSchedule()
        {
            try
            {
                daScheduling.Update(dsScheduling, tabla2);
                MessageBox.Show("Registros actualizados");
            }
            catch (Exception e)
            {


                MessageBox.Show(e.StackTrace);
            }
        }
        private void actualizarTablaFeedback()
        {
            try
            {
                daFeedback.Update(dsFeedback, tabla1);
                MessageBox.Show("Registros actualizados");
            }
            catch (Exception e)
            {


                MessageBox.Show(e.StackTrace);
            }
        }
        private void actualizarTablaTicketboocking()
        {
            try
            {
                daTicketbooking.Update(dsTicketbooking, tabla4);
                MessageBox.Show("Registros actualizados");
            }
            catch (Exception e)
            {


                MessageBox.Show(e.StackTrace);
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            txtLocation.ResetText();
            txtloginName.ResetText();
            txtName.ResetText();
            txtPassword1.ResetText();
            txtPassword2.ResetText();
            txtPhno.ResetText();

            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = true;
            dataGridView1.DataSource = dsTicketbooking;
            dataGridView1.DataMember = tabla4;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel7.Visible = true;

            dataGridView4.DataSource = dsRegistration;
            dataGridView4.DataMember = tabla3;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            actualizarTablaRegistro();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            actualizarTablaTicketboocking();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            actualizarTablaSchedule();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            actualizarTablaFeedback();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel6.Visible = true;
            dataGridView3.DataSource = dsFeedback;
            dataGridView3.DataMember = tabla1;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            panel8.Visible = true;
            panel9.Visible = false;

            dataGridView5.DataSource = dsScheduling;
            dataGridView5.DataMember = tabla2;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            panel9.Visible = false;
            panel10.Visible = true;


            
        }

        private void button26_Click(object sender, EventArgs e)
        {
            panel11.Visible = true;
            panel9.Visible = false;
            txtTicketBoockingName.Text = userName;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            drFeedback = dtFeedback.NewRow();

            drFeedback["id"] ="" + new Random().Next();
            drFeedback["name"] = ""+txtFeedbackName.Text;
            drFeedback["subject"] = txtFeedbackSubject.Text;
            drFeedback["email"] = txtFeedbackEmail.Text;
            drFeedback["message"] = txtFeedbackMessage.Text;

            dtFeedback.Rows.Add(drFeedback);

            actualizarTablaFeedback();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            panel9.Visible = true;
            panel10.Visible = false;
            panel11.Visible = false;
            panel8.Visible = false;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            panel9.Visible = true;
            panel10.Visible = false;
            panel11.Visible = false;
            panel8.Visible = false;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            panel9.Visible = true;
            panel10.Visible = false;
            panel11.Visible = false;
            panel8.Visible = false;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel10.Visible = false;
            panel11.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel10.Visible = false;
            panel11.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel10.Visible = false;
            panel11.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel10.Visible = false;
            panel11.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            drTicketbooking = dtTicketbooking.NewRow();

            drTicketbooking["passengername"] =txtTicketBoockingName.Text;
            drTicketbooking["flightname"] =txtTicketBoockingFlightName.Text;

            drTicketbooking["sourcestation"] =txtTicketBoockingSourceStation.Text;

            drTicketbooking["destination"] =txtTicketBoockingDestination.Text;

            drTicketbooking["ticketno"] =txtTicketBoockingTicketNo;

            drTicketbooking["numberofpasenger"] =txtTicketBoockingNumberOfPassangers.Text;


            dtTicketbooking.Rows.Add(drTicketbooking);

            actualizarTablaTicketboocking();

        }
    }
}
