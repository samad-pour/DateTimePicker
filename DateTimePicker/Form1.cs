namespace DateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            datPicker1.MinDate = new DateTime(2016, 12, 15);
            datPicker1.MaxDate = new DateTime(2017, 2, 15);
            datPicker1.Value = new DateTime(2017, 1, 15);
            datPicker2.CustomFormat = "dd.MM.yy";
            datPicker2.Format = DateTimePickerFormat.Custom;
            datPicker3.ShowUpDown = true;
            datPicker3.Format = DateTimePickerFormat.Short;
            datPicker4.ShowUpDown = true;
            datPicker4.Format = DateTimePickerFormat.Time;
        }

        private void DatPicker_ValueChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.DateTimePicker datPicker = sender as System.Windows.Forms.DateTimePicker;
            lblDate.Text = datPicker.Value + "";
            DateTime plusTag;
            plusTag = datPicker.Value;
            plusTag = plusTag.AddDays(1);
            lblPlusTime.Text = plusTag + "";
        }
    }
}