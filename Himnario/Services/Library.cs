using Himnario.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Windows;

namespace Himnario.Services
{
    public class Library
    {
        private List<HimnoModel> _himnos;
        public string aBuscar;
        public Library()
        {
            _himnos = HimnosData();
        }
       public List<HimnoModel> Himnos
        {
            get
            {
                return AllHimnos.Where(x => x.NoHimno.ToString().Contains(aBuscar)
                || x.Titulo.ToUpper().Contains(aBuscar.ToUpper()) || x.Lyric.ToUpper().Contains(aBuscar.ToUpper())).ToList();
            }
        }
           
        public List<HimnoModel> AllHimnos
        {
            get
            {
                return _himnos;
            }
        }
         List<HimnoModel> HimnosData()
        {
            try
            {
                string filename = @"Himnario.7d";
                String connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filename + ";Extended Properties=\"Excel 12.0 Xml;HDR=YES;\"";
                String Command = @"Select Himno as NoHimno, Título as Titulo, Letra as Lyric
                                from[Hoja1$]";
                OleDbConnection con = new OleDbConnection(connection);
                var h = con.Query<HimnoModel>(Command).ToList();
                return h;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
        //public void CrearLista()
        //{
        //    _himnos = new List<HimnoModel> { new HimnoModel{ NoHimno = 1, Titulo = "Cantad alegres al Señor", Lyric = @"1. Cantad alegres al Señor, 
        //                                                                            mortales todos por doquier; servidle siempre con fervor, obedecedle con placer.
        //                                                                            2.Con gratitud canción alzad al Hacedor que el ser os dio; al Dios excelso venerad,
        //                                                                            que como Padre nos amó. 3.Su pueblo somos: salvará a los que busquen al Señor;
        //                                                                            ninguno de ellos dejará; él los ampara con su amor." },
        //                                    new HimnoModel{NoHimno = 2, Titulo = }
        //    };
        //}
    }
}
