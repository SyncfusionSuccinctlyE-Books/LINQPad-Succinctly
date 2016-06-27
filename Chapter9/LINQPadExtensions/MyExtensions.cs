using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using LINQPad.datetimevalues;
using LINQPad.objectshandling;
using LINQPad.stringsmanager;

namespace LINQPad
{
    public static class MyExtensions
    {
        public static string ToXmlSchemaDateTime(this DateTime currentDateTime)
        {
            return new DateTimeManager().ToXmlSchemaDateTime(currentDateTime);
        }

        public static DateTime BackNDays(this DateTime inputDateTime, int daysNumber)
        {
            return (new DateTimeManager().BackNDays(inputDateTime, daysNumber));
        }

        public static DateTime ForwardNDays(this DateTime inputDateTime, int daysNumber)
        {
            return (new DateTimeManager().ForwardNDays(inputDateTime, daysNumber));
        }

        public static string Proper(this string inputString)
        {
            return (Strings.Proper(inputString));
        }

        public static Dictionary<string, object> Properties(this object mySelf)
        {
            return ObjectsManager.Properties(mySelf);
        }

        public static void MyDump(this object content, string title = null, string style = null,bool toDataGrid = false)
        {
            if (string.IsNullOrEmpty(title)) title = string.Empty;
            if (string.IsNullOrEmpty(style)) style = string.Empty;

            var myContainer = new DumpContainer {Content = content, Style = style};
            myContainer.Dump(title,toDataGrid);

        }

        public static void StackWpfControls(this List<System.Windows.UIElement> elements, string title = null)
        {
            elements.ForEach(element => StackWpfControl(element,title));
        }

        public static void StackWpfControl(this System.Windows.UIElement element, string title = null)
        {
            if (string.IsNullOrEmpty(title)) title = "&Custom";
            PanelManager.StackWpfElement(element, title);
        }

        public static void DisplayInGrid<T>(this IQueryable<T> queryData,string title = null, EventHandler evPanelClosed = null)
        {
            if (string.IsNullOrEmpty(title)) title = "&Custom";
            DisplayInGrid(EnumToDataTable(queryData.AsEnumerable()),title,evPanelClosed);
        }

        public static void DisplayInGrid(this DataTable dataTable,string title = null,EventHandler evPanelClosed = null)
        {
            if (string.IsNullOrEmpty(title)) title = "&Custom";

            var dgrid = new DataGridView { DataSource = dataTable };
            var outputPanel = PanelManager.DisplayControl(dgrid, title);
            outputPanel.PanelClosed += evPanelClosed;
        }


        public static DataTable LinqToDataTable<T>(this IQueryable<T> queryData)
        {
            return (EnumToDataTable(queryData.AsEnumerable()));
        }

        #region Private Methods

        private static DataTable EnumToDataTable<T>(IEnumerable<T> queryData)
        {
            var result = new DataTable();

            if (queryData == null) return result;

            PropertyInfo[] queryDataProps = null;

            foreach (var queryRecord in queryData)
            {
                if (queryDataProps == null)
                {
                    queryDataProps = queryRecord.ReadProperties();

                    foreach (var property in queryDataProps)
                    {
                        var columnType = property.PropertyType;

                        if (columnType.IsGenericType && (columnType.GetGenericTypeDefinition() == typeof(Nullable<>)))
                        {
                            columnType = columnType.GetGenericArguments()[0];
                        }
                        result.Columns.Add(new DataColumn(property.Name, columnType));
                    }
                }

                var resultRow = result.NewRow();

                queryDataProps.ToList().ForEach(property => resultRow[property.Name] = property.GetValue(queryRecord, null) ?? DBNull.Value);

                result.Rows.Add(resultRow);
            }

            return (result);
        }

        #endregion

    }
}
