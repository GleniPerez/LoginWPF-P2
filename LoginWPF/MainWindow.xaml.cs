using LoginWPF.negocio;
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

namespace LoginWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LOginSErvice login =new LOginSErvice();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTexBox.Password;
            
            if (login.checkContraBaseDatos(username,password))
            {
                // salidaLabel.Content = "Usuario logeado";
                //MessageBox.Show("EXito!!", "Usuario logeado");
                
                VentanaPrincipal ventanaPrincipal = new VentanaPrincipal();
                ventanaPrincipal.Show();
                this.Close();
            }
            else
            {
                //salidaLabel.Content = "Usuario incorrecto";
                MessageBox.Show("ERROR!!", "Usuario incorrecto");
            }
        }
    }
}
