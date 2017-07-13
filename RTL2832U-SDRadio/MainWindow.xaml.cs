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
using ExtIORTLSDR2832;

namespace RTL2832U_SDRadio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DrawingCollection Digit = new DrawingCollection();
            InitializeComponent();
        }

        private void CreateMainWindow(object dwExStyle, object dwStyle, int x, int y, int width, int height, object text, int cmdShow, object iconID, object menuID, object bkgnd, object hInstance)
        {
            width = 600;
            height = 400;
            object RTL2832USDRadio = null;
            text = RTL2832USDRadio;
            iconID = "client.ico";
        }
        private void CreateMainWindow(object text, int cmdShow, object iconID, object menuID, Brush background, object hInstance)
        {

        }
        private void CreateMainWindow(object text, int cmdShow, object iconID, object menuID, object bkgnd, object hInstance)
        {

        }
        private void GetDialogItem(object hDlg, int id)
        {

        }
        private void GetHWND()
        {

        }
        private void GetCommandFileName(object in_cmdLine, object out_filename)
        {

        }
        private void RegisterClassEx(object hCursor, object hbrBackground)
        {

        }
        private void RegisterClassEx(object nClassStyle, bool bModelessDialog, object hInst, object nIconId, object nSmallIconId, object nMenu, object hCursor, object hBackground)
        {

        }
        private void RegisterGlobalClassEx(object hCursor, object hbrBackground)
        {

        }
        private void GetClientHeight()
        {

        }
        private void GetClientWidth()
        {

        }
        private void MessageBox1(object text1, object caption1, object type1)
        {

        }
        private void MessageBox2(object text2, object caption2, object type2)
        {

        }
        private void MessageLoop(object aceleratorsID, /*IModelessDlg*/ object modelessDlg)
        {

        }
        private void MessageLoop(object aceleratorsID, /*Win::IModelessDlg&*/ object modelessDlg1, /*Win::IModelessDlg&*/ object modelessDlg2)
        {

        }
        private void MessageLoop(object aceleratorsID, /*Win::IModelessDlg&*/object modelessDlg1, /*Win::IModelessDlg&*/object modelessDlg2, /*Win::IModelessDlg&*/object modelessDlg3)
        {

        }
        private void MessageLoop(object aceleratorsID, /*Win::IModelessDlg&*/object modelessDlg1, /*Win::IModelessDlg&*/object modelessDlg2, /*Win::IModelessDlg&*/object modelessDlg3, /*Win::IModelessDlg&*/object modelessDlg4)
        {

        }
        private static void UserControlRegisterClass()
        {

        }
        private void Create(object dwExStyle, object text, object dwStyle, int pixelsX, int pixelsY, int pixelsWidth, int pixelsHeight, object hParent, int id)
        {

        }
        private void CreateX(object dwExStyle, object text, object dwStyle, double cmX, double cmY, double cmWidth, double cmHeight, object hParent, int id)
        {

        }
        private void MessageLoop(object aceleratorsID)
        {

        }
        private void GetWindowInformation(object createStruct)
        {

        }
        private void Digit(object Event, int Notifications, object color, int n1, int n2, int n3, object text, int n4, int n5, int n6, object text2, int n7, int n8, int n9)
        {
            n1 = 0;
            for (n1 = 0; n1 < 9; n1++) ;
            n2 = 0;
            for (n2 = 0; n2 < 9; n2++) ;
            n3 = 0;
            for (n3 = 0; n3 < 9; n3++) ;
            text = ",";
            n4 = 0;
            for (n4 = 0; n4 < 9; n4++) ;
            n5 = 0;
            for (n5 = 0; n5 < 9; n5++) ;
            n6 = 0;
            for (n6 = 0; n6 < 9; n6++) ;
            text2 = ",";
            n7 = 0;
            for (n7 = 0; n7 < 9; n7++) ;
            n8 = 0;
            for (n8 = 0; n8 < 9; n8++) ;
            n9 = 0;
            for (n9 = 0; n9 < 9; n9++) ;
        }
        private void SetValue(int n1, int n2, int n3, object text, int n4, int n5, int n6, object text2, int n7, int n8, int n9)
        {
            n1 = 0;
            for (n1 = 0; n1 < 9; n1++) ;
            n2 = 0;
            for (n2 = 0; n2 < 9; n2++) ;
            n3 = 0;
            for (n3 = 0; n3 < 9; n3++) ;
            text = ",";
            n4 = 0;
            for (n4 = 0; n4 < 9; n4++) ;
            n5 = 0;
            for (n5 = 0; n5 < 9; n5++) ;
            n6 = 0;
            for (n6 = 0; n6 < 9; n6++) ;
            text2 = ",";
            n7 = 0;
            for (n7 = 0; n7 < 9; n7++) ;
            n8 = 0;
            for (n8 = 0; n8 < 9; n8++) ;
            n9 = 0;
            for (n9 = 0; n9 < 9; n9++) ;
        }
        
        

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Vector slider = new Vector(0.0, 100.0);
            object BiquadFilter = (50.0);
        }

        private void a_Checked(object sender, RoutedEventArgs e)
        {
            
                ExtIORTLSDR2832.BiquadFilter CreateLowPass;
            
        }

        private void b_Checked(object sender, RoutedEventArgs e)
        {
            ExtIORTLSDR2832.BiquadFilter CreateHighPass;
        }
        
        private void onbutton_Click(object sender, RoutedEventArgs e)
        {
            this.onbutton.IsEnabled = false;
            this.offbutton.IsEnabled = true;
            object AdcInput = null;
            AdcInput = 1;
        }


        private void offbutton_Click(object sender, RoutedEventArgs e)
        {
            this.onbutton.IsEnabled = true;
            this.offbutton.IsEnabled = true;
            object AdcInput = null;
            AdcInput = 0;
        }
        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Vector slider1 = new Vector(0, 50);
        }

        private void slider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Vector slider2 = new Vector(0, 50);
        }

        private void sldTime_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Vector sldTime = new Vector(0, 100);
            Vector position = new Vector(50, 100);
        }

        private void Display(object sender,EventArgs e)
        {
            SignalView on = new SignalView();
        }

        private void LayoutUpdatedOn(object sender, EventArgs e)
        {
            return;
        }
    }
}