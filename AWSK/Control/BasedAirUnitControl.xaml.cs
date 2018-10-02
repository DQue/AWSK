﻿using AWSK.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static AWSK.Constant;

namespace AWSK.Control {
    /// <summary>
    /// BasedAirUnitControl.xaml の相互作用ロジック
    /// </summary>
    public partial class BasedAirUnitControl : UserControl {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public BasedAirUnitControl() {
            InitializeComponent();
            (DataContext as BasedAirUnitViewModel).WeaponList[0] = (Weapon1.DataContext as SelectWeaponViewModel).Weapon;
            (DataContext as BasedAirUnitViewModel).WeaponList[1] = (Weapon2.DataContext as SelectWeaponViewModel).Weapon;
            (DataContext as BasedAirUnitViewModel).WeaponList[2] = (Weapon3.DataContext as SelectWeaponViewModel).Weapon;
            (DataContext as BasedAirUnitViewModel).WeaponList[3] = (Weapon4.DataContext as SelectWeaponViewModel).Weapon;
        }

        #region 部隊名
        /// <summary>
        /// 部隊名を表す依存プロパティ
        /// </summary>
        public static readonly DependencyProperty BasedAirUnitUnitTextProperty =
            DependencyProperty.Register("BasedAirUnitUnitText", typeof(string), typeof(BasedAirUnitControl),
            new FrameworkPropertyMetadata("", new PropertyChangedCallback(OnBasedAirUnitUnitTextChanged)));

        /// <summary>
        /// 部隊名を参照するためのプロパティ
        /// </summary>
        public string BasedAirUnitUnitText {
            get => (string)GetValue(BasedAirUnitUnitTextProperty);
            set => SetValue(BasedAirUnitUnitTextProperty, value);
        }

        /// <summary>
        /// 部隊名の変更時に呼ばれるコールバック関数
        /// </summary>
        /// <param name="obj">DependencyObject</param>
        /// <param name="e">DependencyPropertyChangedEventArgs</param>
        private static void OnBasedAirUnitUnitTextChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e) {
            // オブジェクトを取得して処理する
            if (obj is BasedAirUnitControl control) {
                (control.DataContext as BasedAirUnitViewModel).BasedAirUnitUnitText.Value = control.BasedAirUnitUnitText;
            }
        }
        #endregion
    }
}
