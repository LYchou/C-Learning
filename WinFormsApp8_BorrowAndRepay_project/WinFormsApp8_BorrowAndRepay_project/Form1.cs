namespace WinFormsApp8_BorrowAndRepay_project
{
    public partial class Form1 : Form
    {
        Person i, friend;

        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void borrowButton_Click(object sender, EventArgs e)
        {
            i.borrow(friend, 1000);
            updateMoney();
        }

        private void repayButton_Click(object sender, EventArgs e)
        {
            i.repay(friend, 1000);
            updateMoney();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // declare obj
            i = new Person(myNameInput.Text, 0);
            friend = new Person(friendNameInput.Text, 200000);

            // de-activate button
            myNameInput.Enabled = false;
            friendNameInput.Enabled = false;
            submitButton.Enabled = false;

            // setup name
            borrowButton.Text = "∏Ú" + friend.Name + "≠… 1000$";
            repayButton.Text = "¡Ÿµπ" + friend.Name + "1000$";
            myNameLabel.Text = i.Name;
            friendNameLable.Text = friend.Name;

            // activate button
            borrowButton.Enabled = true;
            repayButton.Enabled = true;

        }

        private void updateMoney()
        {
            myMoneyLabel.Text = "" + i.Money;
            friendMoneyLabel.Text = "" + friend.Money;
        }
    }
}