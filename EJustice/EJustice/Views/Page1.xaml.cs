using EJustice.Model;
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
    public partial class Page1 : ContentPage
    {
        string selectedCaseType;
        string selectedCaseCategory;
        public Page1()
        {
            InitializeComponent();
        }

        public void btnSelect_Case(object sender, EventArgs e)
        {
            String[] violent_crime =  { "robbery","rape","kidnaping"};
            String[] nonviolent_crime = { "hacking","extortion"};
            String[][] crime_category= new String[2][] {violent_crime,nonviolent_crime };
            CaseClass category = (CaseClass)caseOption.SelectedItem;
            selectedCaseCategory = category.CaseTypeName;
            int caseId = category.CaseTypeId;
            int i = 0;
            foreach (String case1 in crime_category[caseId]){
                RadioButton rb = new RadioButton() { Content = case1, IsChecked = i++ == 0 };
                rb.CheckedChanged += radioSelected;
                radioButtons.Children.Add(rb);
            }
        }


        /*
        * RadioButton CheckChange Event Handler
        */
        void radioSelected(object sender, CheckedChangedEventArgs e)
        {
            selectedCaseType = (sender as RadioButton).Content.ToString();
            Console.WriteLine(selectedCaseType+ " " + selectedCaseCategory);
        }

        /*
        * RadioButton CheckChange Event Handler
        */
        void onSubmit(object sender, EventArgs e)
        {
            /**TODO
             Action after submitting*/
        }
    }
}