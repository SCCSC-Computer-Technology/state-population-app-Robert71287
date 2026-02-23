using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RZheng_Lab3_Statepopulation
{
    internal class StateData
    {
        public Database1DataSet.TableDataTable GetAllStates()
        {
            var adapter = new Database1DataSetTableAdapters.TableTableAdapter();
            var table = new Database1DataSet.TableDataTable();
            adapter.Fill(table);
            return table;
        }

        public StateInfo GetStateByName(string stateName)
        {
            var adapter = new Database1DataSetTableAdapters.TableTableAdapter();
            var table = new Database1DataSet.TableDataTable();

            adapter.GetSelectedStateByName(table, stateName);

            if (table.Rows.Count == 0)
                return null;

            var row = table.Rows[0];

            return new StateInfo
            {
                StateId = Convert.ToInt32(row["StateId"]),
                StateName = row["StateName"].ToString(),
                Population = row["Population"].ToString(),
                Capitol = row["Capitol"].ToString(),
                LargestCity = row["LargestCity"].ToString(),
                StateFlower = row["StateFlower"].ToString(),
                StateBird = row["StateBird"].ToString(),
                Colors = row["Colors"].ToString(),
                MedianIncome = row["MedianIncome"].ToString(),
                ComputerJobsPercent = row["ComputerJobsPercent"].ToString(),
                FlagDescription = row["FlagDescription"].ToString()
            };
        }
    }
}
