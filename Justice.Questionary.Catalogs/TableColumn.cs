using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI;

namespace Justice.Questionary.Catalogs
{
    class TableColumn
    {
        public Telerik.WinControls.UI.GridViewDataColumn  GridColumn;

        public TableColumn(string columnDbName, string columnDescriptiveName, string columnType, int columnSize, bool isReadOnly)
        {
            switch (columnType)
            {
                case "Int32":
                    GridColumn = new GridViewDecimalColumn();
                    GridColumn.DataType = typeof(int);
                    break;
                case "String":
                    GridColumn = new GridViewTextBoxColumn();
                    GridColumn.DataType = typeof(System.String);
                    break;
                default:
                    break;
            }   

            GridColumn.FieldName = columnDbName;
            GridColumn.HeaderText = columnDescriptiveName;
            GridColumn.Name = columnDbName;
            GridColumn.ReadOnly = isReadOnly;
        }

    }
}
