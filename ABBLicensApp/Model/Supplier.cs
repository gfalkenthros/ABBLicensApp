﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ABBLicensApp.Annotations;

namespace ABBLicensApp.Model
{
    public class Supplier : INotifyPropertyChanged
    {
        private string _name;
        private ObservableCollection<Product> _licensesAtSupplier = new ObservableCollection<Product>();

        public Supplier(string name)
        {
            Name = name;
        }

        public ObservableCollection<Product> LicensesAtSupplier
        {
            get => _licensesAtSupplier;
            set
            {
                if (Equals(value, _licensesAtSupplier)) return;
                _licensesAtSupplier = value;
                OnPropertyChanged();
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                if (value == _name) return;
                _name = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
