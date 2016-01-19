using CadnunsDev.Financas.Dominio.Models;
using CadnunsDev.Financas.Wpf.ORM;
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

namespace CadnunsDev.Financas.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Context _context;
        public MainWindow()
        {
            InitializeComponent();
            try
            {
                _context = new Context();
                _context.Anotacoes.Add(new Anotacao
                {
                    Texto = "Inciiando aplicacao " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss")
                });
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                
                throw;
            }
        }
    }
}
