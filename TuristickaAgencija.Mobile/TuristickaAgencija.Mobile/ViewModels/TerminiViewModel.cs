﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TuristickaAgencija.Model;
using TuristickaAgencija.Model.Requests;
using Xamarin.Forms;

namespace TuristickaAgencija.Mobile.ViewModels
{
    public class TerminiViewModel:BaseViewModel
    {
        public TerminiViewModel()
        {
            InitCommand = new Command(async() => await Init());
        }

        bool _aktivno;
        public bool Aktivno
        {
            get { return _aktivno; }
            set { SetProperty(ref _aktivno, value); }
        }
        public ObservableCollection<TerminiPutovanja> TerminiList { get; set; } = new ObservableCollection<TerminiPutovanja>();
        readonly APIService _service = new APIService("TerminiPutovanja");
        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            
            var search = new TerminiSearchRequest { Aktivno = true }; 
            var list = await _service.Get<IEnumerable<TerminiPutovanja>>(search);
            TerminiList.Clear();
            foreach (var novost in list)
            {
                TerminiList.Add(novost);
            }
        }

    }
}
