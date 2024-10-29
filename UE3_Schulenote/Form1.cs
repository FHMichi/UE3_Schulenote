namespace UE3_Schulenote
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void lblNote_Click(object sender, EventArgs e)
        {

        }

        private void numNote_ValueChanged(object sender, EventArgs e)
        {
            switch (numNote.Value)
            {
                case 1:
                    lblNote.Text = "Sehr Gut";
                    break;
                case 2:
                    lblNote.Text = "Gut";
                    break; 
                case 3:
                    lblNote.Text = "Befridigend"; 
                    break;
                case 4:
                    lblNote.Text = "Genügend";
                    break;
                case 5:
                    lblNote.Text = "Nicht Genügend";
                    break;
                
            }
        }
    }
}
