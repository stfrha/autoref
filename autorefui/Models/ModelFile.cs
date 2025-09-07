using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autorefui
{

   internal class RelatedFile
   {
      #region Declarations

      private bool _referenced;
      private string _relativePath;


      #endregion

      #region Constructor

      public ReFile(bool referenced, string relativePath)
      {
         _referenced = referenced;
         _relativePath = relativePath;
      }

      #endregion

      #region Properties

      public bool Referenced 
      { 
         get { return _referenced; } 
         set { _referenced = value; }
      }   
      public string RelativePath 
      { 
         get { return _relativePath; } 
         set { _relativePath = value; }
      }

      #endregion
   }



   internal class ModelFile
   {
      #region Declarations

      private string _path;
      private ObservableCollection<ModelFile> _childrenFiles;
      private ObservableCollection<ModelFile> _referencedFiles;

      #endregion
   }
}
