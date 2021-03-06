﻿using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ABBLicensApp.Annotations;
using ABBLicensApp.Common;
using ABBLicensApp.Model;

namespace ABBLicensApp.Viewmodel
{
    public class CustomersViewModel : ViewModel
    {
        public CustomersViewModel()
        {
            GoBack = new GoBackCommand();
            NewCustomerBtn = new GoToPageCommand("AddCustomer");
            Shared = StaticClassSingleton.Instance;
            SelectedCustomer = null;
        }

        //Metoder

        //Properties

        public Customer SelectedCustomer
        {
            get => Shared.SelectedCustomer;
            set
            {
                Shared.SelectedCustomer = value;
                if (SelectedCustomer != null)
                {
                    Navigation.GoToPage("Customer");
                }
            }
        }

        public string SearchCustomerText
        {
            get { return Shared.SearchCustomerText; }
            set
            {
                Shared.SearchCustomerText = value;
                OnPropertyChanged(nameof(FilteredCustomers));
            }
        }

        public ObservableCollection<Customer> FilteredCustomers
        {
            get => Shared.FilteredCustomers;
            set
            {
                Shared.FilteredCustomers = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Customer> Customers
        {
            get => Shared.Customers;
            set => Shared.Customers = value;
        }

        public RelayCommand NewCustomerBtn { get; set; }
        public RelayCommand GoBack { get; set; }
        public StaticClassSingleton Shared { get; }
    }
}
