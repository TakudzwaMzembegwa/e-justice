using EJustice.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace EJustice.ViewModel
{
    class CaseViewModel
    {
        public IList<CaseClass> CaseList { get; set; }

        public CaseViewModel()
        {
            try{
                CaseList = new ObservableCollection<CaseClass>();
                CaseList.Add(new CaseClass
                {
                    CaseTypeId = 0, CaseTypeName = "Violent crime"
                });
                CaseList.Add(new CaseClass
                {
                    CaseTypeId = 1,
                    CaseTypeName = "Non Violent crime"
                });
            }
            catch (Exception ex) { }
        }
    }
}
