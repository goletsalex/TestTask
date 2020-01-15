using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace TestTaskApp.DataSources
{
    public static class SymbolResults
    {
        /// <summary>
        /// Generate Datasource from OutputValue
        /// </summary>
        /// <param name="outputValue">OutputValue</param>
        /// <returns></returns>
        public static BindingSource GetSymbolResultsSource(string outputValue)
        {
            BindingSource result = null;
            if (!string.IsNullOrEmpty(outputValue))
            {
                try
                {
                    var _resultList = CalculateChars(outputValue);

                    var bindingList = new BindingList<Models.SymbolCount>(_resultList);

                    result = new BindingSource(bindingList, null);
                }
                catch (Exception ex)
                {
                    Helpers.ErrorLog.Log(ex);
                }
            }

            return result;
        }

        public static List<Models.SymbolCount> CalculateChars(string outputValue)
        {
            return outputValue.ToCharArray()
                              .GroupBy(ovc => ovc,
                                       ovc => ovc,
                                       (key, value) => new Models.SymbolCount
                                           {
                                               Symbol = key.ToString(),
                                               Count = value.Count().ToString()
                                           }
                                       )
                             .OrderBy(cc => cc.Symbol)
                             .ToList();
        }
    }
}
