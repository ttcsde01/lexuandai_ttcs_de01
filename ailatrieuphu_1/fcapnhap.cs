using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace ailatrieuphu_1
{
    public partial class fcapnhap : Form
    {
        public fcapnhap()
        {
            InitializeComponent();
        }

        private void fcapnhap_Load(object sender, EventArgs e)
        {

        }
        private void capnhat()
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range range;
            xlApp = new Excel.Application();
            string url = Application.StartupPath + "\\cau-hoi-1.xlsx";
            xlWorkBook = xlApp.Workbooks.Open(url, 0, false, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            int sheet = Int32.Parse(tbSheet.Text);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(sheet);
            range = xlWorkSheet.UsedRange;
            string index = tbcn.Text;
            Excel.Range cauhoi = (Excel.Range)xlWorkSheet.Cells[index, 1];
            cauhoi.Value2 = tbch.Text;
            Excel.Range a = (Excel.Range)xlWorkSheet.Cells[index, 2];
            a.Value2 = tba.Text;
            Excel.Range b = (Excel.Range)xlWorkSheet.Cells[index, 3];
            b.Value2 = tbb.Text;
            Excel.Range c = (Excel.Range)xlWorkSheet.Cells[index, 4];
            c.Value2 = tbc.Text;
            Excel.Range d = (Excel.Range)xlWorkSheet.Cells[index, 5];
            d.Value2 = tbd.Text;
            Excel.Range da = (Excel.Range)xlWorkSheet.Cells[index, 6];
            da.Value2 = tbda.Text;
            xlWorkBook.SaveAs(url, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Excel.XlSaveAsAccessMode.xlNoChange,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            xlWorkBook.Close(true, null, null);

            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range range;
            int rw = 0; 
            int cl = 0;
            xlApp = new Excel.Application();
            string url = Application.StartupPath + "\\cau-hoi-1.xlsx";
            xlWorkBook = xlApp.Workbooks.Open(url, 0, false, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            int sheet = Int32.Parse(tbSheet.Text);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(sheet);
            range = xlWorkSheet.UsedRange;
            rw = range.Rows.Count;     
            cl = range.Columns.Count;
            // string index = tbcn.Text;
           int index = rw+1;
            Excel.Range cauhoi = (Excel.Range)xlWorkSheet.Cells[index, 1];
            cauhoi.Value2 = tbch.Text;
            Excel.Range a = (Excel.Range)xlWorkSheet.Cells[index, 2];
            a.Value2 = tba.Text;
            Excel.Range b = (Excel.Range)xlWorkSheet.Cells[index, 3];
            b.Value2 = tbb.Text;
            Excel.Range c = (Excel.Range)xlWorkSheet.Cells[index, 4];
            c.Value2 = tbc.Text;
            Excel.Range d = (Excel.Range)xlWorkSheet.Cells[index, 5];
            d.Value2 = tbd.Text;
            Excel.Range da = (Excel.Range)xlWorkSheet.Cells[index, 6];
            da.Value2 = tbda.Text;
            xlWorkBook.SaveAs(url, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Excel.XlSaveAsAccessMode.xlNoChange,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            xlWorkBook.Close(true, null, null);

            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);

            MessageBox.Show("Thêm thành công!!");
        }
      
        private void laycauhoi()
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range range;


            int rw = 0; //số hàng tối đa có trong sheet
            int cl = 0; //số cột tối đa có trong sheet

            xlApp = new Excel.Application();
            string url = Application.StartupPath + "\\cau-hoi-1.xlsx";
            xlWorkBook = xlApp.Workbooks.Open(url, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
           int sheet = Int32.Parse( tbSheet.Text);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(sheet);//Truyền số vào đây để đọc sheet (cấp độ của câu 
            range = xlWorkSheet.UsedRange;
            rw = range.Rows.Count;      //Đếm số hàng
            cl = range.Columns.Count;   //Đếm số cột 
            string index= tbcn.Text;

            tbch.Text = (string)(range.Cells[index, 1] as Excel.Range).Value2;
            tba.Text = (string)(range.Cells[index, 2] as Excel.Range).Value2;
            tbb.Text = (string)(range.Cells[index, 3] as Excel.Range).Value2;
            tbc.Text = (string)(range.Cells[index, 4] as Excel.Range).Value2;
            tbd.Text = (string)(range.Cells[index, 5] as Excel.Range).Value2;
            tbda.Text = (string)(range.Cells[index, 6] as Excel.Range).Value2;

            xlWorkBook.Close(true, null, null);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);


        }
        private void loadCh(int ch)
        {
          
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            laycauhoi();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            capnhat();
            MessageBox.Show("Sữa thành công!!");
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range range;


            int rw = 0; //số hàng tối đa có trong sheet
            int cl = 0; //số cột tối đa có trong sheet
            xlApp = new Excel.Application();
            string url = Application.StartupPath + "\\cau-hoi-1.xlsx";
            xlWorkBook = xlApp.Workbooks.Open(url, 0, false, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            int sheet = Int32.Parse(tbSheet.Text);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(sheet);//Truyền số vào đây để đọc sheet (cấp độ của câu 
            range = xlWorkSheet.UsedRange;
            rw = range.Rows.Count;      //Đếm số hàng
            cl = range.Columns.Count;   //Đếm số cột 
            string index = tbcn.Text;

            tbch.Text = (string)(range.Cells[index, 1] as Excel.Range).Value2;
            tba.Text = (string)(range.Cells[index, 2] as Excel.Range).Value2;
            tbb.Text = (string)(range.Cells[index, 3] as Excel.Range).Value2;
            tbc.Text = (string)(range.Cells[index, 4] as Excel.Range).Value2;
            tbd.Text = (string)(range.Cells[index, 5] as Excel.Range).Value2;
            tbda.Text = (string)(range.Cells[index, 6] as Excel.Range).Value2;
            xlWorkSheet.Rows[index].Delete();
            xlWorkBook.SaveAs(url, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
               Excel.XlSaveAsAccessMode.xlNoChange,
               Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            xlWorkBook.Close(true);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);

            MessageBox.Show("Xoá thành công!!");
        }
    }

}
