using CarRental.Components;
using CarRental.Components.SuperInterfaces;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CarRental.Screens
{
    public partial class Rentals : Form, IResetFrormsState
    {
        private string selectedVeh;
        private bool isOnRentTab = true;
        private string return_date;

        public Rentals()
        {
            InitializeComponent();
        }

        public void Reset_All_Fields()
        {
            customerIdTxt.Text = "";
            customerNameTxt.Text = "";
            paymentIdTxt.Text = "";
            cardNumberTxt.Text = "";
            paymentAmountTxt.Text = "";

            Load_IDs();
        }

        private bool Val_All_Fields()
        {
            if (
                customerIdTxt.Text != "" &&
                paymentIdTxt.Text != "" &&
                int.Parse(customerIdTxt.Text) > 0 &&
                int.Parse(paymentIdTxt.Text) > 0 &&
                Utilz.Validate_Card(cardNumberTxt.Text) &&
                paymentAmountTxt.Text != "" &&
                checkCustomerIDFound() &&
                Utilz.Validate_Name(customerNameTxt.Text)
            ) return true;

            return false;
        }

        private bool checkCustomerIDFound()
        {
            string[] r = Customer.CheckCustomer(customerIdTxt.Text);

            if (r[0] == "1")
            {
                return true;
                warnCustomerID.Text = "";
            }
            else
            {
                warnCustomerID.Text = "Customer Not Found";
                return false;
            }
                
        }

        private void Load_IDs()
        {
            idTxt.Text = Rental.NewRentalId();
            paymentIdTxt.Text = Payment.NewPaymentId();
            idTxt.Enabled = false;
            paymentIdTxt.Enabled = false;
        }

        private void Load_Rent()
        {
            Rental rental = new Rental();
            displayRentalGridView.DataSource = rental.Display();
            
            customerNameValText.Text = "";
            cardWarnText.Text = "";
        }

        private void loadIntoCoboBox(string query)
        {
            SqlDataReader _reader = DBConnection.SqlReader(query);
            selectVehComboBox.Items.Clear();

            while (_reader.Read())
            {
                string numbPlate = _reader["numberPlate"].ToString();
                string brand = _reader["vehicleBrand"].ToString();
                string model = _reader["vehicleModel"].ToString();

                string r = numbPlate + ",   " + brand + ",   " + model;
                selectVehComboBox.Items.Add(r);
            }
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

       

        private void Rental_Load(object sender, EventArgs e)
        {
            Load_Rent();
            Load_IDs();
            warnCustomerID.Text = "";
            updateBtn.Enabled = false;
           

            /*loading data into combo box*/
            loadIntoCoboBox("EXEC Get_BrandModelTruck;");
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (Val_All_Fields())
            {
                Vehicle vehicle;

                Customer customer = new Customer();
                customer.Name = customerNameTxt.Text;
                customer.Id = int.Parse(customerIdTxt.Text);

                Payment payment = new Payment(
                        int.Parse(paymentIdTxt.Text),
                        cardNumberTxt.Text,
                        double.Parse(paymentAmountTxt.Text)
                    );

                Rental rental = new Rental(
                        int.Parse(idTxt.Text),
                        Utilz.makeDate(rentalDatePick.Text),
                        Utilz.makeDate(returnDatePick.Text)
                    );

                MessageBox.Show(return_date);
                MessageBox.Show(rental.ReturnDate);

                if (trueIfCar.Checked)
                {
                    vehicle = new Car();
                    vehicle.NumberPlate = selectedVeh;
                    rental.Vehicle_ = vehicle;
                }
                else
                {
                    vehicle = new Truck();
                    vehicle.NumberPlate = selectedVeh;
                    rental.Vehicle_ = vehicle;
                }

                customer.Pay = payment;
                rental.Customer_ = customer;
                rental.Vehicle_ = vehicle;


                rental.Dump();

                Load_Rent();

                MessageBox.Show("Data inserted");

                Reset_All_Fields();

                if (trueIfCar.Checked) loadIntoCoboBox("EXEC Get_BrandModelCar;");
                else loadIntoCoboBox("EXEC Get_BrandModelTruck;");

            } 
            else
            {
                MessageBox.Show("Fill All Fields");
            }


        }

        private void trueIfCar_Click(object sender, EventArgs e)
        {
            if (!isOnRentTab)
            {
                if (trueIfCar.Checked)
                {
                    availableBtnTab.Text = "Available Car";
                    loadIntoCoboBox("EXEC Get_BrandModelCar;");
                    displayRentalGridView.DataSource = Car.AvailCars();
                }
                else
                {
                    availableBtnTab.Text = "Available Truck";
                    loadIntoCoboBox("EXEC Get_BrandModelTruck;");
                    displayRentalGridView.DataSource = Truck.AvailTrucks();
                }
            }
            
        }

        private void selectVehComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedVeh = selectVehComboBox.SelectedItem.ToString().Split(',')[0].Trim();
        }

        private void adminProfileBtn_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            this.Hide();
        }

        private void displayRentalGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (isOnRentTab)
            {
                AddBtn.Enabled = false;
                updateBtn.Enabled = true;
               
                customerIdTxt.Text = displayRentalGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                idTxt.Text = displayRentalGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                paymentIdTxt.Text = displayRentalGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                customerNameTxt.Text = displayRentalGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                rentalDatePick.Text = displayRentalGridView.Rows[e.RowIndex].Cells[4].Value.ToString().Split(' ')[0];
                returnDatePick.Text = displayRentalGridView.Rows[e.RowIndex].Cells[5].Value.ToString().Split(' ')[0];
            } else
            {
                selectVehComboBox.Items.Clear();
                selectVehComboBox.Items.Add(
                        displayRentalGridView.Rows[e.RowIndex].Cells[0].Value.ToString()
                        + ",   " + displayRentalGridView.Rows[e.RowIndex].Cells[1].Value.ToString()
                        + ",   " + displayRentalGridView.Rows[e.RowIndex].Cells[2].Value.ToString()
                    );
                selectVehComboBox.SelectedIndex = 0;
            }
        }

        private void cardNumberTxt_TextChanged(object sender, EventArgs e)
        {
            if (Utilz.Validate_Card(cardNumberTxt.Text)) cardWarnText.Text = "";
            else cardWarnText.Text = "Invalid Card Number"; 
        }

    

        private void reloadText_Click(object sender, EventArgs e)
        {
            AddBtn.Enabled = true;
            updateBtn.Enabled = false;
            Reset_All_Fields();
            if (isOnRentTab)
            {
                Load_Rent();
            }
            else
            {
                if (trueIfCar.Checked)
                {
                    loadIntoCoboBox("EXEC Get_BrandModelCar;");
                    displayRentalGridView.DataSource = Car.AvailCars();
                }
                else
                {
                    loadIntoCoboBox("EXEC Get_BrandModelTruck;");
                    displayRentalGridView.DataSource = Truck.AvailTrucks();
                }
            }
            
        }

        private void availableBtnTab_Click(object sender, EventArgs e)
        {
            LabelcustomerID.Text = "Number Plate";
            LabelRentalID.Text = "";
            LabelPayID.Text = "";
            LabelNameTxt.Text = "Brand";
            LabelRentalDate.Text = "";
            LabelReturnDate.Text = "";
            LabelPayAmount.Text = "Model";
            LabelPayStatus.Text = "";


            rentTab.BackColor = Color.White;
            availVehicleTab.BackColor = Color.DarkGray;
            displayRentalGridView.DataSource = Truck.AvailTrucks();
            isOnRentTab = false;
        }

        private void onRentBtnTab_Click(object sender, EventArgs e)
        {
            rentTab.BackColor = Color.DarkGray;
            availVehicleTab.BackColor = Color.White;

            LabelcustomerID.Text = "Customer ID";
            LabelRentalID.Text = "Rental ID";
            LabelPayID.Text = "Payment ID";
            LabelNameTxt.Text = "Name";
            LabelRentalDate.Text = "Rent Date";
            LabelReturnDate.Text = "Return Date";
            LabelPayAmount.Text = "Pay Amount";
            LabelPayStatus.Text = "Pay Status";

            isOnRentTab = true;
            Load_Rent();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (
                customerIdTxt.Text != "" &&
                paymentIdTxt.Text != "" &&
                Utilz.Validate_Name(customerNameTxt.Text)
            )
            {
                Vehicle vehicle;

                Customer customer = new Customer();
                customer.Name = customerNameTxt.Text;
                customer.Id = int.Parse(customerIdTxt.Text);

                Payment payment = new Payment(
                        int.Parse(paymentIdTxt.Text),
                        cardNumberTxt.Text,
                        double.Parse(paymentAmountTxt.Text)
                    );

                Rental rental = new Rental(
                        int.Parse(idTxt.Text),
                        Utilz.makeDate(rentalDatePick.Text),
                        Utilz.makeDate(return_date)
                    );

                MessageBox.Show(return_date);
                MessageBox.Show(rental.ReturnDate);

                if (trueIfCar.Checked)
                {
                    vehicle = new Car();
                    vehicle.NumberPlate = selectedVeh;
                    rental.Vehicle_ = vehicle;
                }
                else
                {
                    vehicle = new Truck();
                    vehicle.NumberPlate = selectedVeh;
                    rental.Vehicle_ = vehicle;
                }

                customer.Pay = payment;
                rental.Customer_ = customer;
                rental.Vehicle_ = vehicle;

                /*payment.Update();*/
                rental.Update();

                Load_Rent();

                MessageBox.Show("Data Updated");

                Reset_All_Fields();

                if (trueIfCar.Checked) loadIntoCoboBox("EXEC Get_BrandModelCar;");
                else loadIntoCoboBox("EXEC Get_BrandModelTruck;");
            }
            else
            {
                MessageBox.Show("Fill All Fields");
            }
        }


        private void customerNameTxt_TextChanged(object sender, EventArgs e)
        {
            if (Utilz.Validate_Name(customerNameTxt.Text)) customerNameValText.Text = "";
            else customerNameValText.Text = "Invalid Name";
        }

        private void customerIdTxt_Leave(object sender, EventArgs e)
        {
            string[] r = Customer.CheckCustomer(customerIdTxt.Text);
            
            if (r[0] == "1")
                warnCustomerID.Text = "";
            else
                warnCustomerID.Text = "Customer Not Found";

            customerNameTxt.Enabled = false;
            customerNameTxt.Text = r[1];

        }
    }
}
