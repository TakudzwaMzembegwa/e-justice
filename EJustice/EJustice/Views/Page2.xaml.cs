using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EJustice.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    
    public partial class Page2 : ContentPage
    {
        String caseUpdate;
        public Page2()
        {
            InitializeComponent();
        }
        public void btndone(object sender, EventArgs e)
        {
            caseUpdate = (String)caseEditor.Text;
            Console.WriteLine(caseUpdate);
        }
        public void btnclear(object sender, EventArgs e)
        {
            caseEditor.Text = "";
        }



    }
}