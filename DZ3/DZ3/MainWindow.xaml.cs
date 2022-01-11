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

namespace DZ3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int N = 33;
            string text1 = vvod.Text;
            string text2= "";
            string key1 = slovo.Text;
            char[,] M = new char[N, N];
            List<char> alphavit = new List<char> { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я','а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ь', 'ы', 'ъ', 'э', 'ю', 'я' };
            for(int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    M[i,j] = alphavit[i + j];
                    
                }
            }
            int L2 = text1.Length;
            int Lkey = key1.Length;
            int k;
            int o=0, p=0;
            for(int c=0;c< L2; c++)
            {
                for(int i = 0; i < N; i++)
                {
                    if(text1[c]== alphavit[i])
                    {
                        o = i;
                        break;
                    }
                }
                k = c % Lkey;
                for (int j = 0; j < N; j++)
                {
                    if (key1[k] == alphavit[j])
                    {
                        p = j;
                        break;
                    }
                }
                text2 += M[o, p];
                
            }
        viviod.Text = String.Format("{0}", text2);
        }

        private void deconverter_Click(object sender, RoutedEventArgs e)
        {
            int N = 33;
            string text1 = vvod.Text;
            string text2 = "";
            string key1 = slovo.Text;
            char[,] M = new char[N, N];
            List<char> alphavit = new List<char> { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ь', 'ы', 'ъ', 'э', 'ю', 'я' };
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    M[i, j] = alphavit[i + j];

                }
            }
            int L2 = text1.Length;
            int Lkey = key1.Length;
            int k;
            int o = 0, p = 0;
            for (int c = 0; c < L2; c++)
            {
                k = c % Lkey;
                for (int j = 0; j < N; j++)
                {
                    if (key1[k] == alphavit[j])
                    {
                        p = j;
                        break;
                    }
                }
                for (int i = 0; i < N; i++)
                {
                    if (text1[c] == M[i , p])
                    {
                        o = i;
                        break;
                    }
                    
                }
                text2 += alphavit[o];
            }
            viviod.Text = String.Format("{0}", text2);
        }
    }
}
