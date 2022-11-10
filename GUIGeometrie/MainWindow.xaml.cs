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
using Geometry;

namespace GUIGeometrie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>´
    public partial class MainWindow : Window
    {
        private List<Geometry.Point> plist = new List<Geometry.Point>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_new_point_Click(object sender, RoutedEventArgs e)
        {
            if (txt_coordx.Text == "" | txt_coordy.Text == "") return;
            long x = int.Parse(txt_coordx.Text);
            long y = int.Parse(txt_coordy.Text);
            Geometry.Point point = new Geometry.Point(x, y);
            tbl_points.Items.Add(point);
            plist.Add(point);
        }

        private void btn_remove_point_Click(object sender, RoutedEventArgs e)
        {
            if (tbl_points.Items.Count == 0)
                return;
            else if (tbl_points.SelectedItems == null)
                return;
            else tbl_points.Items.RemoveAt(tbl_points.SelectedIndex);
        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            if (plist == null) return;
            foreach(Geometry.Point p in plist)
            {
                Console.WriteLine(p);
            }
        }
    }
}
