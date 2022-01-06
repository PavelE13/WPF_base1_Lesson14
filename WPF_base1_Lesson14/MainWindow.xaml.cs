using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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


namespace WPF_base1_Lesson14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
        products = new ObservableCollection<Product>();
            products.Add(new Product()
        {
            NameofGood = " Арбуз ",
                PriceGood = 55,
                CodeofGood = 1,
                CategoryofGood = CategoryofGoods.Food
            });
            products.Add(new Product()
        {
            NameofGood = " Помидоры ",
                PriceGood = 35,
                CodeofGood = 1,
                CategoryofGood = CategoryofGoods.Food
            });
            products.Add(new Product()
        {
            NameofGood = " Холодильник LG x5SN200 ",
                PriceGood = 12500,
                CodeofGood = 2,
                CategoryofGood = CategoryofGoods.Appliance
            }) ;
            ListBox.ItemsSource = products;
        }
}
}