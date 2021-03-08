using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShareControl.Models
{
    public class FUNC_ATTRIBUTE_BITS : BindableBase
    {
        #region private

        private string code;
        private string name;
        private double defaultValue;
        private double uplimit;
        private double lowlimit;
        private int address;
        private string attrValue;
        private string varName;
        private string desc;

        #endregion

        /// <summary>
        /// 菜单编号
        /// </summary>
        [Display(Name = "菜单编号")]
        public string Code
        {
            get { return code; }
            set { code = value; RaisePropertyChanged(); }
        }

        /// <summary>
        /// 名称
        /// </summary>
        [Display(Name = "名称")]
        public string Name
        {
            get { return name; }
            set { name = value; RaisePropertyChanged(); }
        }

        /// <summary>
        /// 初始值
        /// </summary>
        [Display(Name = "初始值")]
        public double DefaultValue
        {
            get { return defaultValue; }
            set { defaultValue = value; RaisePropertyChanged(); }
        }

        /// <summary>
        /// 上限
        /// </summary>
        [Display(Name = "上限")]
        public double Uplimit
        {
            get { return uplimit; }
            set { uplimit = value; RaisePropertyChanged(); }
        }

        /// <summary>
        /// 下限
        /// </summary>
        [Display(Name = "下限")]
        public double Lowlimit
        {
            get { return lowlimit; }
            set { lowlimit = value; RaisePropertyChanged(); }
        }

        /// <summary>
        /// 地址
        /// </summary>
        [Display(Name = "地址")]
        public int Address
        {
            get { return address; }
            set { address = value; RaisePropertyChanged(); }
        }

        /// <summary>
        /// 属性值
        /// </summary>
        [Display(Name = "属性值")]
        public string AttrValue
        {
            get { return attrValue; }
            set { attrValue = value; RaisePropertyChanged(); }
        }

        /// <summary>
        /// 变量名称
        /// </summary>
        [Display(Name = "变量名称")]
        public string VarName
        {
            get { return varName; }
            set { varName = value; RaisePropertyChanged(); }
        }

        /// <summary>
        /// 描述
        /// </summary>
        [Display(Name = "描述")]
        public string Desc
        {
            get { return desc; }
            set { desc = value; RaisePropertyChanged(); }
        }
    }
}
