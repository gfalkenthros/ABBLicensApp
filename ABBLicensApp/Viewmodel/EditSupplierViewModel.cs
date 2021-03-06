﻿using System.ComponentModel;
using System.Runtime.CompilerServices;
using ABBLicensApp.Annotations;
using ABBLicensApp.Common;
using ABBLicensApp.Model;

namespace ABBLicensApp.Viewmodel
{
    public class EditSupplierViewModel : ViewModel
    {
        private string _name;

        public EditSupplierViewModel()
        {
            Shared = StaticClassSingleton.Instance;
            EditBtn = new RelayCommand(EditMethod);
            _name = Shared.SelectedLicensSupplier.Name;
            GoBackBtn = new GoBackCommand();
        }

        //Metoder
        private void EditMethod()
        {
            foreach (var a in Shared.LicensSupplier)
            {
                if (a.Name == Shared.SelectedLicensSupplier.Name)
                {
                    a.Name = Name;
                }
            }

            Navigation.GoBack();
        }

        //Properties
        public string Name
        {
            get => _name;
            set
            {
                SetProperty<string>(ref _name, value);
            }
        }

        public StaticClassSingleton Shared { get; set; }
        public RelayCommand GoBackBtn { get; set; }
        public RelayCommand EditBtn { get; set; }
    }
}
