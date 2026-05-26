using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
namespace WpfIntro;
public partial class MainWindow : Window
{
public MainWindow()
{
    InitializeComponent();
    }
    private void BtnGenerar_Click(object sender, RoutedEventArgs e)
    {
            string nombre = txtNombre.Text;
            
            ComboBoxItem item =
            (ComboBoxItem)cmbRaza.SelectedItem;
            string clase = item.Content.ToString();
            
            StringBuilder habilidades = 
            new StringBuilder();
            if (chkFisico.IsChecked == true)
                habilidades.AppendLine("- Fisico");
            if (chkMagia.IsChecked == true)
                habilidades.AppendLine("- Magia");

        switch (clase)
        {
            case "Night":
                imgPersonaje.Source =
                new BitmapImage(
                new Uri("Images/SMT3_Black_Frost_Artwork.png",
                UriKind.Relative));
            break;

            case "Megami":
                imgPersonaje.Source =
                new BitmapImage(
                new Uri("Images/SMTN_Maria_Artwork.png",
                UriKind.Relative));
            break;

            case "Tyrant":
                imgPersonaje.Source =
                new BitmapImage(
                new Uri("Images/SMT2_Beelzebub_Artwork.png",
                UriKind.Relative));
            break;
        }

        txtResultado.Text =
        $"Nombre: {nombre}\n" +
        $"Clase: {clase}\n" +
        $"Habilidades:\n{habilidades}";
    }
}
