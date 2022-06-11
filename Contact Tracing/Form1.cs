namespace Contact_Tracing
{
    public partial class CTForm : Form
    {
        public CTForm()
        {
            InitializeComponent();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\aaa\Documents\Contact Tracing Folder\ContactTracingForm.txt", true);
            file.WriteLine(datelabel.Text + datebox.Text);
            file.WriteLine(lastnamelabel.Text + lastnamebox.Text);
            file.WriteLine(firstnamelabel.Text + firstnamebox.Text);
            file.WriteLine(middlenamelabel.Text + middlenamebox.Text);
            file.WriteLine(agelabel.Text + agebox.Text);
            file.WriteLine(bdaylabel.Text + bdaybox.Text);
            file.WriteLine(sexlabel.Text + sexbox.Text);
            file.WriteLine(addresslabel.Text + addressbox.Text);
            file.WriteLine(nationalitylabel.Text + nationalitybox.Text);
            file.WriteLine(statuslabel.Text + statusbox.Text);
            file.WriteLine(occupationlabel.Text + occupationbox.Text);
            file.WriteLine(phonenumberlabel.Text + numberbox.Text);
            file.WriteLine(emaillabel.Text + emailbox.Text);
            file.WriteLine(residencelabel.Text + residencebox.Text);
            file.WriteLine(distance1label.Text + distance1box.Text);
            file.WriteLine(facemask1label.Text + facemask1box.Text);
            file.WriteLine(publicdatelabel.Text + publicdatebox.Text);
            file.WriteLine(publicaddresslabel.Text + publicaddressbox.Text);
            file.WriteLine(facemask2label.Text + facemask2box.Text);
            file.WriteLine(distance2label.Text + distance2box.Text);
            file.WriteLine("\t");
            file.Close();
        }

        private void clearallbutton_Click(object sender, EventArgs e)
        {
            datebox.Text = "";
            lastnamebox.Text = "";
            firstnamebox.Text = "";
            middlenamebox.Text = "";
            agebox.Text = "";
            bdaybox.Text = "";
            sexbox.Text = "";
            addressbox.Text = "";
            nationalitybox.Text = "";
            statusbox.Text = "";
            occupationbox.Text = "";
            numberbox.Text = "";
            emailbox.Text = "";
            residencebox.Text = "";
            distance1box.Text = "";
            facemask1box.Text = "";
            publicdatebox.Text = "";
            publicaddressbox.Text = "";
            facemask2box.Text = "";
            distance2box.Text = "";
        }
    }
}