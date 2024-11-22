
using System;

using System.Windows.Forms;

namespace LAB3B
{
    public partial class Form1 : Form
    {
        private bool hairdresserAdded = false; // Track if hairdresser has been added to Charged Items
        public Form1()
        {
            InitializeComponent();
            cmbHairdresser.SelectedIndex = 0; // Set the default selection to the first item
            cmbHairdresser.DropDownStyle = ComboBoxStyle.DropDownList; // Disable editing in ComboBox
            serviceBtn.Enabled = false;       // Disable Add Service button initially
            totalBtn.Enabled = false; // Disable Calculate Total button initially
        }

        /// <summary>
        /// This method return an int which is price for selected hairdresses 
        /// </summary>
        /// <returns>Integer - which is price</returns>
        private int GetHairdresserPrice()
        {
            switch (cmbHairdresser.SelectedIndex) //Selected index is the index the  list box
            {
                case 0: return 30; // Jane
                case 1: return 45; // Pat
                case 2: return 40; // Ron
                case 3: return 50; // Sue
                case 4: return 55; // Laurie
                default: return 0;
            }
        }

        /// <summary>
        /// This method returns an integer (price of a service) for a selected service
        /// </summary>
        /// <param name="selectedIndex">sleected index for  a service</param>
        /// <returns>Integer - (Price of a service)</returns>
        private int GetServicePrice(int selectedIndex)
        {
            switch (selectedIndex)
            {
                case 0: return 30;  // Cut
                case 1: return 20;  // Wash, blow-dry, and style
                case 2: return 40;  // Colour
                case 3: return 50;  // Highlights
                case 4: return 200; // Extension
                case 5: return 60;  // Up-do
                default: return 0;
            }
        }

        /// <summary>
        /// This method checkes to see if hairdresser and service are selected, if a hairdresser has been selected then the program disable the drop down
        /// and gets the hair dresser price and add service button is enabled,  when a service is selected it gets its price and calculateTotal button is enabled, the services, hairdressser infor are added to chargeBox -listBox while the price is 
        /// added to priceBox.
        /// </summary>
        private void AddService()
        {
            if (serviceBox.SelectedIndex >= 0)
            {
                int selectedServicePrice = GetServicePrice(serviceBox.SelectedIndex);

                // Add Hairdresser to Charged Items only on first Add Service click
                if (!hairdresserAdded)
                {
                    int hairdresserPrice = GetHairdresserPrice();
                    chargedItm.Items.Add(cmbHairdresser.SelectedItem.ToString()); // Add Hairdresser name
                    priceBox.Items.Add(hairdresserPrice.ToString("C")); // Add Hairdresser price

                    hairdresserAdded = true;       // Prevent further additions of hairdresser
                    cmbHairdresser.Enabled = false; // Disable ComboBox after first use
                }

                // Add selected service and its price
                chargedItm.Items.Add(serviceBox.SelectedItem.ToString());
                priceBox.Items.Add(selectedServicePrice.ToString("C"));

                totalBtn.Enabled = true; // Enable Calculate Total button after adding a service
            }
        }

        /// <summary>
        /// This method calulates the total amount, of the services and hairdressers charge which was selected
        /// By converting each item in price box to an integer, and displaying it back to the total price label as a string
        /// </summary>
        private void CalculateTotalPrice()
        {
            int total = 0;
            foreach (var item in priceBox.Items)
            {
                total += int.Parse(item.ToString(), System.Globalization.NumberStyles.Currency); //converts the string to an int and adds a currrency sign
            }
            totalPrice.Text = total.ToString("C");
        }


        /// <summary>
        /// This method resets the form to its initial state
        /// </summary>
        private void ResetForm()
        {
            cmbHairdresser.SelectedIndex = 0;
            cmbHairdresser.Enabled = true;

            chargedItm.Items.Clear();
            priceBox.Items.Clear();

            totalPrice.Text = string.Empty;

            serviceBtn.Enabled = false;
            totalBtn.Enabled = false;

            hairdresserAdded = false; // Reset the hairdresser added flag
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbHairdresser_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Enable Add Service button only if a service is selected
            serviceBtn.Enabled = serviceBox.SelectedIndex >= 0;
        }

        private void serviceBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            serviceBtn.Enabled = true; // Enable Add Service button when a service is selected
        }

        private void chargeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void serviceBtn_Click(object sender, EventArgs e)
        {
            AddService();
        }

        private void totalBtn_Click(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
