using System;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace ExcelApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Excel.Application application = null;
            Excel.Workbooks workbooks = null;
            Excel.Workbook workbook = null;
            Excel.Sheets worksheets = null;
            Excel.Worksheet worksheet = null;
            //переменная для хранения диапазона ячеек
            //в нашем случае - это будет одна ячейка
            Excel.Range cell = null;
            try
            {
                application = new Excel.Application
                {
                    Visible = true
                };
                workbooks = application.Workbooks;
                workbook = workbooks.Add();
                worksheets = workbook.Worksheets; //получаем доступ к коллекции рабочих листов
                worksheet = worksheets.Item[1];//получаем доступ к первому листу
                cell = worksheet.Cells[1, 1];//получаем доступ к ячейке
                cell.Value = "Hello Excel";//пишем строку в ячейку A1
                application.Quit();
            }
            finally
            {
                //освобождаем память, занятую объектами
                Marshal.ReleaseComObject(cell);
                Marshal.ReleaseComObject(worksheet);
                Marshal.ReleaseComObject(worksheets);
                Marshal.ReleaseComObject(workbook);
                Marshal.ReleaseComObject(workbooks);
                Marshal.ReleaseComObject(application);

            }
        }
    }
}
