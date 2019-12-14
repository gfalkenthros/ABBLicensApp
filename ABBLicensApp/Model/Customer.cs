﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ABBLicensApp.Annotations;

namespace ABBLicensApp.Model
{
    public class Customer : INotifyPropertyChanged
    {
        private string _companyName;
        private string _address;
        private string _email;
        private int _id;
        private ObservableCollection<string> _notes;
        private List<Product> _products;
        private string _phoneNumber;
        private string _contactName;

        public Customer(string companyName, string address, string email, string phoneNumber, string contactName)
        {
            _companyName = companyName;
            _address = address;
            _email = email;
            _notes = new ObservableCollection<string>();
            _phoneNumber = phoneNumber;
            _contactName = contactName;
            _products = new List<Product>();
        }

        public string CompanyName
        {
            get => _companyName;
            set => _companyName = value;
        }

        public string Address
        {
            get => _address;
            set => _address = value;
        }

        public string Email
        {
            get => _email;
            set => _email = value;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public ObservableCollection<string> Notes
        {
            get => _notes;
            set
            {
                if (Equals(value, _notes)) return;
                _notes = value;
                OnPropertyChanged();
            }
        }

        public List<Product> Products
        {
            get => _products;
            set => _products = value;
        }

        public string PhoneNumber
        {
            get => _phoneNumber;
            set => _phoneNumber = value;
        }

        public string ContactName
        {
            get => _contactName;
            set => _contactName = value;
        }


        public void AddProduct()
        {
            throw new System.NotImplementedException();
        }

        public void RemoveProduct()
        {
            throw new System.NotImplementedException();
        }

        public void AddComments()
        {
            throw new System.NotImplementedException();
        }

        public void DeleteComments()
        {
            throw new System.NotImplementedException();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}