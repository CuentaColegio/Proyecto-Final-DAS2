using Proyecto.Controles_de_Usuario;
using Proyecto.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Proyecto.VistaModelo
{
    class MainWindowsViewModel : ViewModelBase
    {
        #region Atributos
        private ICommand incrementar;
        private ICommand cargarCarpeta;
        private ICommand consultas;
        private ICommand prueba;
        #endregion 

        public MainWindowsViewModel()
        {
            incrementar = new CommandBase(param => this.DoIncrementar());
            cargarCarpeta = new CommandBase(param => this.cargarCarpetaFunc());
            consultas = new CommandBase(param => this.cargarCarpetaFunc());
            prueba = new CommandBase(param => this.PruebaFunc());
        }
        #region ViewLogics
        //https://www.tutorialspoint.com/wpf/wpf_dependency_properties.htm
        // https://stackoverflow.com/questions/11570754/binding-viewmodel-to-contentcontrol-as-its-datacontext
        // https://www.codeproject.com/Questions/184774/Tab-control-in-C-code-behind
        // http://csharphelper.com/blog/2014/09/load-a-treeview-control-from-an-xml-file-in-c/

        #endregion

        #region Comandos
        public ICommand Prueba {
            get
            {
                return prueba;
            }
            set
            {
                prueba = value;
            }
        }
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


        private void PruebaFunc()
        {
            TabItem item1 = new TabItem();
            item1.Name = "tabIitemContent";
            item1.Header = "Tab Item with Buttons";

            TabControlApp tabControlApp = new TabControlApp();
            tabControlApp.InsertarTabItem(item1);

        }

        // Lanza función para 
        private void cargarCarpetaFunc()
        {
            string Path = VentanaFileDialogService.VentanaFileDialogLaunch();
            Console.WriteLine(Path);
        }
        #endregion 
    }
}
