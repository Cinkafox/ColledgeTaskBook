using Xamarin.Forms;

namespace ColledgeTaskBook
{
   
    public partial class BookPage : ContentPage
    {
        

        public BookPage(string text)
        {
            InitializeComponent();
            tx.Text = text;
        }

        
    }
}
