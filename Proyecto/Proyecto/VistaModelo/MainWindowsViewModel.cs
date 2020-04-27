using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Proyecto.VistaModelo
{
    class MainWindowsViewModel : ViewModelBase
    {
        #region Atributos
        private ICommand incrementar;
        #endregion 

        public MainWindowsViewModel()
        {
            incrementar = new CommandBase(param => this.DoIncrementar());
        }

        #region Propiedades
        public ICommand Incrementar
        {
            get
            {
                return incrementar;
            }//Fin de get.
            set
            {
                incrementar = value;
            }//Fin de set.
        }
        #endregion
        
        #region metodos
        private void DoIncrementar()
        {
            Console.WriteLine("Buenaws");
        }
        #endregion 
    }
}
