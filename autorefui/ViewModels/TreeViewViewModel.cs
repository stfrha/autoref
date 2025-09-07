using MicroMvvm;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace autorefui
{
   [Serializable]
   public class TreeViewViewModel : MicroMvvm.ViewModelBase
   {
      private ObservableCollection<TreeViewViewModel> _children;
      private TreeViewViewModel _treeParent;
      protected bool _isSelected;
      protected bool _isExpanded;
      private bool _isEnabled;
      private void _localObject;
      private MainViewModel _mainVm;

      public TreeViewViewModel(
        TreeViewViewModel treeParent,
        MainViewModel mainVm,
        bool enabled = true)
      {
         _treeParent = treeParent;
         _mainVm = mainVm;
         _isSelected = false;
         _isExpanded = false;
         _isEnabled = enabled;
      }


      public TreeViewViewModel TreeParent
      {
         get { return _treeParent; }
         set
         {
            _treeParent = value;
            OnPropertyChanged("");
         }
      }

      public bool IsSelected
      {
         get { return _isSelected; }
         set
         {
            if (value != _isSelected)
            {
               _isSelected = value;
               OnPropertyChanged("IsSelected");
            }
         }
      }

      public bool IsExpanded
      {
         get { return _isExpanded; }
         set
         {
            if (_isExpanded != value)
            {
               if (value && _treeParent != null)
               {
                  _treeParent.IsExpanded = true;
               }

               _isExpanded = value;
               OnPropertyChanged("IsExpanded");
            }
         }
      }

      public bool IsEnabled
      {
         get { return _isEnabled; }
         set
         {
            if (value != _isEnabled)
            {
               _isEnabled = value;
               OnPropertyChanged("IsEnabled");
            }
         }
      }

      public MainViewModel MainVm
      {
         get { return _mainVm; }
         set { _mainVm = value; }
      }
   }
}


