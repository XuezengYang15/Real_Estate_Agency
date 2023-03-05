using System.Collections;
using System.Collections.Generic;

namespace Real_Estate_Agency
{
    public partial class F : Form
    {
        public string address;
        float sqFtTotal;
        string sqFtTotalString;
        float price;
        string priceString;
        byte quality;
        string qualityString;
        float averageSqFtTotal;
        int arrayListSize;
        float nextHouseAverage;
        float firstHouseAverage;
        string houseListBox;

        ArrayList houseList = new ArrayList();
        List<float> averagePrice = new List<float>();   
        
        public class house
        {
            public string houseAddress;
            public float houseSqFtTotal;
            public float housePrice;
            public byte houseQuality;

            public house(string argAddress, float argSqFtTotal, float argPrice, byte argQuality)
            {
                houseAddress = argAddress;
                houseSqFtTotal = argSqFtTotal;
                housePrice = argPrice;
                houseQuality = argQuality;
                
            }

            public house()
            {

            }

         

        }
        public F()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //If address or Square footage is blank, warning message will show
            if(string.IsNullOrEmpty(stringAddress.Text) || string.IsNullOrEmpty(floatSqFtTotal.Text))
            {
                warningLabel.Text = "Address and/or Square footage cannot be blank.";
            }
            else
            {
                //If price is not entered
                if (string.IsNullOrEmpty(floatPrice.Text))
                {


                    price = float.Parse(floatSqFtTotal.Text) *
                            byte.Parse(byteQuality.Text) *
                            averageSqFtTotal;
                    price = (float)(price * 0.01);
                }
                else
                {
                    price = float.Parse(floatPrice.Text);

                }

                if (string.IsNullOrEmpty(byteQuality.Text))
                {
                    quality = 0;
                }
                else
                {
                    quality = byte.Parse(byteQuality.Text);
                }

             

                address = stringAddress.Text;
                sqFtTotal = float.Parse(floatSqFtTotal.Text);
                


                house nextHouse = new house(address, sqFtTotal, price, quality);

                houseList.Add(nextHouse);

                arrayListSize = houseList.Count;

                nextHouseAverage = (nextHouse.housePrice) / (nextHouse.houseSqFtTotal);

                averagePrice.Add(nextHouseAverage);

                for (int i = 0; i < arrayListSize; i++)
                {
                    averageSqFtTotal = averageSqFtTotal + averagePrice[i];
                }

                averageSqFtTotal = averageSqFtTotal / arrayListSize;

                averageTextBox.Text = averageSqFtTotal.ToString();

                houseListBox = "Address: " + nextHouse.houseAddress + ", Square Footage Total: " + nextHouse.houseSqFtTotal
                                + ", Price: " + nextHouse.housePrice + ", Quality: " + nextHouse.houseQuality;

                listBox.Items.Add(houseListBox);

                //Resets the text boxes after each submission
                stringAddress.Text = "";
                floatSqFtTotal.Text = "";
                floatPrice.Text = "";
                byteQuality.Text = "";

                warningLabel.Text = "";
            }

            



        }

        private void stringAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void floatSqFtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void floatPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void byteQuality_TextChanged(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //Clicking on start button will insert first data set.
            house firstHouse = new house("1234 fake st", 900, 150000, 100);

            houseList.Add(firstHouse);

            firstHouseAverage = (firstHouse.housePrice)/(firstHouse.houseSqFtTotal);

            averageSqFtTotal = firstHouseAverage;

            averagePrice.Add(firstHouseAverage);

            averageTextBox.Text = averageSqFtTotal.ToString();

            startButton.Visible = false;

            submitButton.Visible = true;
             
            houseListBox = "Address: " + firstHouse.houseAddress + ", Square Footage Total: " + firstHouse.houseSqFtTotal
                            + ", Price: " + firstHouse.housePrice + ", Quality: " + firstHouse.houseQuality;

            listBox.Items.Add(houseListBox);

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void F_Load(object sender, EventArgs e)
        {

        }
    }
}