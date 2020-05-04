using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Justice.Questionary.Catalogs
{
    class DatabaseTable
    {
        public List<TableColumn> columnCollection;

        public DatabaseTable()
        {
            columnCollection = new List<TableColumn>();
        }

    }
}
