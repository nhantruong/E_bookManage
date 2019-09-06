using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Text.RegularExpressions;


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
       
    }

