using EbookManage.Data;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Text.RegularExpressions;
using Microsoft.Office.Interop.Excel;


public class XuLyDuLieu
{

    public static string LoaiBoDauTiengViet(string noiDung)
    {
        Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
        string temp = noiDung.Normalize(NormalizationForm.FormD).Trim().ToLower();

        return regex.Replace(temp, String.Empty)
                    .Replace('\u0111', 'd')
                    .Replace('\u0110', 'D')
                    .Replace(",", "-")
                    .Replace(".", "-")
                    .Replace("!", "")
                    .Replace("(", "")
                    .Replace(")", "")
                    .Replace(";", "-")
                    .Replace("/", "-")
                    .Replace("%", "ptram")
                    .Replace("&", "va")
                    .Replace("?", "")
                    .Replace('"', '-')
                    .Replace(' ', '-');
    }

    public static string WriteToExcel(string _path, List<ebook> BookContents)
    {
        #region ref
        Application _XL;
        _Workbook _WB;
        _Worksheet _Sheet;
        Range _Rng;
        object misvalue = System.Reflection.Missing.Value;
        try
        {
            //Start Excel and get Application object.
            _XL = new Microsoft.Office.Interop.Excel.Application();
            _XL.Visible = true;

            //Get a new workbook.
            _WB = (Microsoft.Office.Interop.Excel._Workbook)(_XL.Workbooks.Add(""));
            _Sheet = (Microsoft.Office.Interop.Excel._Worksheet)_WB.ActiveSheet;
            #region Test Content

            ////Add table headers going cell by cell.
            //_Sheet.Cells[1, 1] = "First Name";
            //_Sheet.Cells[1, 2] = "Last Name";
            //_Sheet.Cells[1, 3] = "Full Name";
            //_Sheet.Cells[1, 4] = "Salary";
            ////Format A1:D1 as bold, vertical alignment = center.
            //_Sheet.get_Range("A1", "D1").Font.Bold = true;
            //_Sheet.get_Range("A1", "D1").VerticalAlignment =
            //    Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            //// Create an array to multiple values at once.
            //string[,] saNames = new string[5, 2];
            //saNames[0, 0] = "John";
            //saNames[0, 1] = "Smith";
            //saNames[1, 0] = "Tom";
            //saNames[4, 1] = "Johnson";
            ////Fill A2:B6 with an array of values (First and Last Names).
            //_Sheet.get_Range("A2", "B6").Value2 = saNames;

            ////Fill C2:C6 with a relative formula (=A2 & " " & B2).
            //_Rng = _Sheet.get_Range("C2", "C6");
            //_Rng.Formula = "=A2 & \" \" & B2";

            ////Fill D2:D6 with a formula(=RAND()*100000) and apply format.
            //_Rng = _Sheet.get_Range("D2", "D6");
            //_Rng.Formula = "=RAND()*100000";
            //_Rng.NumberFormat = "$0.00";

            ////AutoFit columns A:D.
            //_Rng = _Sheet.get_Range("A1", "D1");
            //_Rng.EntireColumn.AutoFit();
            #endregion

            //Ebook info
            _Sheet.Cells[10, 1] = "ID";
            _Sheet.Cells[10, 2] = "Category";
            _Sheet.Cells[10, 3] = "Book name";
            _Sheet.Cells[10, 4] = "Link";
            _Sheet.Cells[10, 5] = "File size";
            _Sheet.Cells[10, 6] = "File Format";
            _Sheet.Cells[10, 7] = "Year";
            for (int i = 0; i < BookContents.Count; i++)
            {
                _Sheet.Cells[11+i, 1] = BookContents[i].id;
                _Sheet.Cells[11+i, 2] = BookContents[i].chude;
                _Sheet.Cells[11+i, 3] = BookContents[i].name;
                _Sheet.Cells[11+i, 4] = BookContents[i].link;
                _Sheet.Cells[11+i, 5] = BookContents[i].filesize;
                _Sheet.Cells[11+i, 6] = BookContents[i].dinhdang;
                _Sheet.Cells[11+i, 7] = BookContents[i].namXB;                
            }
            _XL.Visible = false;
            _XL.UserControl = false;
            _WB.SaveAs(_path + "\\test.xlsx", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing,
                false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            _WB.Close();
            _XL.Quit();
            #endregion
            return "Write file sucessful";
        }
        catch (Exception ex)
        {
            return "Write file to Excel failse because " + ex.Message;
        }
    }


}

