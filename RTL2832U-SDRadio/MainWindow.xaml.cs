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

        private void Viewport3D()
        {
        }



        private void GetBackColor()
        {

        }
        private void GetGridColor()
        {

        }
        private void GetLineColor()
        {

        }
        private void GetTextColor()
        {

        }
        private void GetZColor(object z, object numColors)
        {

        }
        //numColors = 2: Blue > Cyan numColors = 3: Blue > Cyan > Green numColors = 4: Blue > Cyan > Green > Yellow numColors = 5: Blue > Cyan > Green > Yellow > Red numColors = 6: Blue > Cyan > Green > Yellow > Red > Purple numColors = 7: Blue > Cyan > Green > Yellow > Red > Purple > Black

        private void GetFont()
        {

        }
        private void View3D()
        {
            ExtIORTLSDR2832.Adc a; ExtIORTLSDR2832.Adc b;

        }
        private void CopyToBitmap(int width, int height, bool clientEdge, object result)
        {

        }
        private void CopyToClipboard()
        {
            return;
        }
        private void GetShowBackAxis()
        {

        }
        private void GetShowDivX()
        {

        }
        private void GetShowDivY()
        {

        }
        private void GetShowDivZ()
        {

        }
        private void GetShowFrontAxis()
        {

        }
        private void IsEvent(object e, int notification)
        {

        }
        private void SaveEmf(object fileName)
        {

        }
        private void Setup()
        {

        }
        private void GetAngle()
        {

        }
        private void GetElevation()
        {

        }
        private void GetMaxX()
        {

        }
        private void GetMaxY()
        {

        }
        private void GetMaxZ()
        {

        }
        private void GetMinX()
        {

        }
        private void GetMinY()
        {

        }
        private void GetMinZ()
        {

        }
        private void GetZoom()
        {

        }
        private void TransformToGridX(double x)
        {

        }
        private void TransformToGridY(double y)
        {

        }
        private void TransformToGridZ(double z)
        {

        }
        private void TransformX(double gridValueX)
        {

        }
        private void TransformY(double gridValueY)
        {

        }
        private void TransformZ(double gridValueZ)
        {

        }
        private void GetDivisionCountX()
        {

        }
        private void GetDivisionCountY()
        {

        }
        private void GetDivisionCountZ()
        {

        }
        private void GetElementCount(object pdi, int element_width_millicm, int element_height_millicm)
        {

        }
        private void GetLineWidth()
        {

        }
        private static void ConvertFromSphericalToCartesian(object input, object output, object count)
        {

        }
        private void OnPaint3D(object gdi)
        {

        }
        private void SetBackColor(object color)
        {
            BackColor = 7;
        }
        private void SetFont(object font)
        {

        }
        private void SetLineColor(object color)
        {
            LineColor = 2;
        }
        private void SetTextColor(object color)
        {
            TextColor = 4;
        }
        private void GetCenter(object centerX, object centerY)
        {

        }
        private void GetControlSize(object width, object height)
        {

        }
        private void GetLogfont(object logfont)
        {

        }
        private void OnPaintControl1(object gdi)
        {

        }
        private void OnPaintControl2(object gdi)
        {

        }
        private void OnPrintElement(object gdi, object pdi, object pei)
        {

        }
        private void OnPrintPartBegin(object gdi, object pdi, int element_width_millicm, int element_height_millicm)
        {

        }
        private void OnPrintPartEnd(object gdi, object pdi)
        {

        }
        private void Print()
        {

        }
        private void ResetView(bool resetZoom)
        {
            resetZoom = true;
        }
        private void SetAngle(double angleDegrees)
        {
            angleDegrees = 5.0;
        }
        private void SetCaptionX(object caption, bool isFontSymbol)
        {
            caption = 3.0;
            isFontSymbol = true;
        }
        private void SetCaptionY(object caption, bool isFontSymbol)
        {
            caption = 1.7;
            isFontSymbol = true;
        }
        private void SetCaptionZ(object caption, bool isFontSymbol)
        {
            caption = 2.4;
            isFontSymbol = true;
        }
        private void SetCenter(double centerX, double centerY)
        {

        }
        //This function will not work, if it is called from Window_Open

        private void SetControlSize(int width, int height)
        {
            width = 524;
            height = 190;
        }
        private void SetDivisionCountX(int count)
        {

        }
        private void SetDivisionCountY(int count)
        {

        }
        private void SetDivisionCountZ(int count)
        {

        }
        private void SetElevation(double angleDegrees)
        {

        }
        private void SetFont2(object hfont)
        {

        }
        private void SetGridColor(object color)
        {
            GridColor = 3;
        }
        private void SetLine(object line, float x1, float y1, float z1, float x2, float y2, float z2, object color)
        {

        }
        private void SetLineWidth(int lineWidth)
        {
            lineWidth = 2;
        }
        private void SetMaxX(double maximum)
        {

        }
        private void SetMaxY(double maximum)
        {

        }
        private void SetMaxZ(double maximum)
        {

        }
        private void SetMinX(double minimum)
        {

        }
        private void SetMinY(double minimum)
        {

        }
        private void SetMinZ(double minimum)
        {

        }
        private void SetShowBackAxis(bool show)
        {
            show = true;
        }
        private void SetShowDivX(bool show)
        {
            show = true;
        }
        private void SetShowDivY(bool show)
        {
            show = true;
        }
        private void SetShowDivZ(bool show)
        {
            show = true;
        }
        private void SetShowFrontAxis(bool show)
        {
            show = true;
        }
        private void SetZoom(double zoom)
        {

        }
        private void Setup(double minX, double maxX, double minY, double maxY, double minZ, double maxZ)
        {

        }
        private void TransformX(object input, object output, object count)
        {

        }
        private void TransformY(object input, object output, object count)
        {

        }
        private void TransformZ(object input, object output, object count)
        {

        }
        private void TransformInputX(object input, object output, object index)
        {

        }
        private void TransformInputY(object input, int type, object output, object index)
        {

        }
        private void TransformInputZ(object input, int type, object output, object index)
        {

        }
        private void TransformInputToGrid(object input, object output, object count)
        {

        }
        //It modifies: input

        private object BackColor = 7;
        private object LineColor = 2;
        private object GridColor = 3;
        private object TextColor = 4;
        private object Font = 1;
        private object Zoom = 50;
        private object Angle = 5.0;
        private object ShowBackAxis = true;
        private object ShowFrontAxis = true;
        private object ShowDivX = true;
        private object ShowDivY = true;
        private object ShowDivZ = true;
        private object Elevation = 4.5;
        private object MinX = 0.2;
        private object MaxX = 3.0;
        private object MinY = 0.2;
        private object MaxY = 4.0;
        private object MinZ = 0.1;
        private object MaxZ = 0.2;
        private object DivisionCountX = 2;
        private object DivisionCountY = 4;
        private object DivisionCountZ = 0.5;
    

    }
}