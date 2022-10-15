using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_2.Source
{
    internal class UtilityTask4
    {
        internal static string? Replace(string line)
        {
            var tempLine = new StringBuilder();

            // dfgdfgsd <b>Это</b> текст <i>с</i> прапр < апрапр <font color=”red”>HTML/font> кодами

            int iIndx;
            int startIndx = 0;
            int endIndx = -1;

            do
            {
                Console.WriteLine(tempLine.ToString());
                iIndx = line.IndexOf('<', startIndx);
                if(iIndx > -1)
                {
                    endIndx = line.IndexOf('>', iIndx + 1);
                    if(endIndx > -1)
                    {
                        tempLine.Append(line.Substring(startIndx, iIndx - startIndx) + '_');
                        startIndx = endIndx + 1;
                    }
                    else
                    {
                        tempLine.Append(line.Substring(startIndx, line.Length - startIndx));
                        break;
                    }
                }
                else
                {
                    tempLine.Append(line.Substring(startIndx, line.Length - startIndx));
                }
            } while (iIndx != -1);

            return tempLine.ToString();
        }
    }
}
