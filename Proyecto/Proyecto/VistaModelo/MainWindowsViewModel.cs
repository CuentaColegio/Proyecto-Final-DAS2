using Proyecto.Servicios;
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
        private ICommand cargarCarpeta;
        private ICommand consultas;
        #endregion 

        public MainWindowsViewModel()
        {
            incrementar = new CommandBase(param => this.DoIncrementar());
            cargarCarpeta = new CommandBase(param => this.cargarCarpetaFunc());
            consultas = new CommandBase(param => this.cargarCarpetaFunc());

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
        public ICommand Consultas
        {
            get
            {
                return consultas;
            }//Fin de get.
            set
            {
                consultas = value;
            }//Fin de set.
        }
        public ICommand CargarCarpeta
        {
            get
            {
                return cargarCarpeta;
            }//Fin de get.
            set
            {
                cargarCarpeta = value;
            }//Fin de set.
        }
        #endregion

        // System.Windows.Data Error: 40 : BindingExpression path error: 'cargarCarpetaFunc' property not found on 'object' ''MainWindowsViewModel' (HashCode=64844482)'. BindingExpression:Path=cargarCarpetaFunc; 
        // DataItem='MainWindowsViewModel' (HashCode=64844482); target element is 'MenuItem' (Name=''); target property is 'Command' (type 'ICommand')
        #region metodos
        private void DoIncrementar()
        {
            Console.WriteLine("Buenaws");
        }
        private void ConsultasFunc()
        {
            
        }
        private void cargarCarpetaFunc()
        {
            string Path = VentanaFileDialogService.VentanaFileDialogLaunch();
            Console.WriteLine(Path);
        }
        #endregion 
    }
}
