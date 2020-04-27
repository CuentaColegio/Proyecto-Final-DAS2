using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Modelo.Raspado
{
    class Scrapy
    {
        private string _path;
        private HtmlDocument _doc;
        private string _resultado;

        #region Constructores
        public Scrapy(string path, HtmlDocument doc)
        {
            this._doc = doc;
            this._path = path;
        }
        #endregion

        #region propiedades
        public string Resultado
        {
            get { return _resultado; }
        }
        #endregion

        #region Metodos.
        public Boolean PuedoSeleccionarNodosXPath(string ExpresionXPath)
        {

            HtmlNodeCollection htmlNodes = _doc.DocumentNode.SelectNodes(ExpresionXPath);
            if (htmlNodes != null)
            {
                return true;
            }
            else { return false; }
        }

        public string SeleccionarNodosXPath(string ExpresionXPath)
        {
            HtmlNodeCollection htmlNodes = _doc.DocumentNode.SelectNodes(ExpresionXPath);
            _resultado = htmlNodes.ToString();

            return _resultado;
        }
        #endregion
    }
}
