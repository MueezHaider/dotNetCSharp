using CarRental.Components;
using CarRental.Components.SuperInterfaces;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CarRental.Screens
{
    public partial class Vehicles : Form, IResetFrormsState
    {
        private string vehType = "truck";

        private void Load_Veh(int typ)
        {
            if (typ == 0)
            {
                Truck truck = new Truck();
                displayVehGridView.DataSource = truck.Display();
            } else
            {
                Car car = new Car();
                displayVehGridView.DataSource = car.Display();
            }
            
        }

        public void Reset_All_Fields()
        {
            numbPlateTxt.Text = "";
            brandTxt.Text = "";
            modelTxt.Text = "";
            brandTxt.Text = "";
            priceTxt.Text = ""; 
            specialInputText.Text = "";
        }

        public Vehicles()
        {
            InitializeComponent();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            if (Utilz.questionBox("Are you sure?", "Logout"))
            {
                SignIn signIn = new SignIn();
                signIn.Show();
                this.Hide();
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void exitIconBtn_Click(object sender, EventArgs e)
        {
            if (Utilz.questionBox())
                Application.Exit();
        }

        private void minimizeIconBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (
                    numbPlateTxt.Text != "" &&
                    brandTxt.Text != "" &&
                    modelTxt.Text != "" &&
                    brandTxt.Text != "" &&
                    priceTxt.Text != "" &&
                    int.Parse(priceTxt.Text) > 0 &&
                    specialInputText.Text != "" &&
                    int.Parse(specialInputText.Text) > 0 
                )
            {
                if (trueIfCar.Checked)
                {
                    Car newCar = new Car(
                        numbPlateTxt.Text,
                        brandTxt.Text,
                        modelTxt.Text,
                        priceTxt.Text,
                        int.Parse(specialInputText.Text)
                    );
                    newCar.Dump();
                    Utilz.msgBox("Record Added", "Car");
                }
                else
                {
                    Truck newTruck = new Truck(
                            numbPlateTxt.Text,
                            brandTxt.Text,
                            modelTxt.Text,
                            priceTxt.Text,
                            int.Parse(specialInputText.Text)
                        );
                    newTruck.Dump();

                    Utilz.msgBox("Record Added", "Truck");
                }
            } else
            {
                warningText.Text = "Fill all fields";
            }
            
        }

        private void trueIfCar_Click(object sender, EventArgs e)
        {
            if (trueIfCar.Checked)
            {
                specialInputText.PlaceholderText = "No of Passengers";
            } else
            {
                specialInputText.PlaceholderText = "Load Capacity";
            }
        }

        private void Vehicles_Load(object sender, EventArgs e)
        {
            truckTabUnderline.BackColor = Color.DarkGray;
            carTabUnderline.BackColor = Color.White;
            vehType = "truck";

            updateBtn.Enabled = false;

            /*Loading car data*/
            Load_Veh(0);
            
        }

        private void carTabBtn_Click(object sender, EventArgs e)
        {
            truckTabUnderline.BackColor = Color.White;
            carTabUnderline.BackColor = Color.DarkGray;

            specialVehTxt.Text = "No Of Passsengers";
            vehType = "car";

            /*Loading car data*/
            Load_Veh(1);
        }

        private void truckTabBtn_Click(object sender, EventArgs e)
        {
            truckTabUnderline.BackColor = Color.DarkGray;
            carTabUnderline.BackColor = Color.White;

            specialVehTxt.Text = "Load Capacity";
            vehType = "truck";

            /*Loading Truck data*/
            Load_Veh(0);
        }

        private void adminProfileBtn_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            this.Hide();
        }

        private void displayVehGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            updateBtn.Enabled = true;
            AddBtn.Enabled = false;

            numbPlateTxt.Text = displayVehGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            brandTxt.Text = displayVehGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            modelTxt.Text = displayVehGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            priceTxt.Text = displayVehGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            specialInputText.Text = displayVehGridView.Rows[e.RowIndex].Cells[4].Value.ToString();

            if (vehType == "car")
                trueIfCar.Checked = true;
            else
                trueIfCar.Checked = false;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (trueIfCar.Checked)
            {
                Car newCar = new Car(
                        numbPlateTxt.Text,
                        brandTxt.Text,
                        modelTxt.Text,
                        priceTxt.Text,
                        int.Parse(specialInputText.Text)
                    );
                newCar.Update();
                Load_Veh(1);
                Utilz.msgBox("Record Updated", "Car");
            } else
            {
                Truck newTruck = new Truck(
                            numbPlateTxt.Text,
                            brandTxt.Text,
                            modelTxt.Text,
                            priceTxt.Text,
                            int.Parse(specialInputText.Text)
                        );
                newTruck.Update();
                Load_Veh(0);
                Utilz.msgBox("Record Updated", "Truck");
            }
            
        }

        private void reloadIconBtn_Click(object sender, EventArgs e)
        {
            updateBtn.Enabled = false;
            AddBtn.Enabled = true;

            Reset_All_Fields();
        }

        private void reloadText_Click(object sender, EventArgs e)
        {
            updateBtn.Enabled = false;
            AddBtn.Enabled = true;

            Reset_All_Fields();
        }
    }
}


