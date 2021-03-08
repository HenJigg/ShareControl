using Prism.Mvvm;
using ShareControl.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ShareControl.ViewModels
{
    public class MenuViewModel : BindableBase
    {
        private ObservableCollection<FUNC_ATTRIBUTE_BITS> _gridModelList;

        public ObservableCollection<FUNC_ATTRIBUTE_BITS> GridModelList
        {
            get { return _gridModelList; }
            set { _gridModelList = value; RaisePropertyChanged(); }
        }

        public MenuViewModel()
        {
            GridModelList = new ObservableCollection<FUNC_ATTRIBUTE_BITS>();
            for (int i = 0; i < 10; i++)
            {
                GridModelList.Add(new FUNC_ATTRIBUTE_BITS()
                {
                    Code = "F0-00",
                    Name = "最大频率",
                    DefaultValue = 200.00,
                    Uplimit = 400.00,
                    Lowlimit = 50.00,
                    Address = 2,
                    VarName = "0x4112",
                    AttrValue = "maxFrq",
                    Desc = "presetFrq",
                });
            }
        }
    }
}
