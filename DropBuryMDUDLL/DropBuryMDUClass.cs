/* Title:           Drop Bury MDU Class
 * Date:            7-31-17
 * Author:          Terry Holmes */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace DropBuryMDUDLL
{
    public class DropBuryMDUClass
    {
        //setting up the class
        EventLogClass TheEventLogClass = new EventLogClass();

        //setting up the data
        DropBuryCompletedDataSet aDropBuryCompletedDataSet;
        DropBuryCompletedDataSetTableAdapters.dropburycompletedTableAdapter aDropBuryCompletedTableAdapter;

        DropBuryTasksDataSet aDropBuryTasksDataSet;
        DropBuryTasksDataSetTableAdapters.dropburytasksTableAdapter aDropBuryTasksTableAdapter;

        MDUCompletedDataSet aMDUCompletedDataSet;
        MDUCompletedDataSetTableAdapters.mducompletedTableAdapter aMDUCompletedTableAdapter;

        MDUTasksDataSet aMDUTasksDataSet;
        MDUTasksDataSetTableAdapters.mdutasksTableAdapter aMDUTasksTableAdapter;

        InsertDropBuryCompletedEntryTableAdapters.QueriesTableAdapter aInsertDropBuryCompletedTableAdapter;

        FindDropBuryCompleteByDateRangeDataSet aFindDropBuryCompleteByDateRangeDataSet;
        FindDropBuryCompleteByDateRangeDataSetTableAdapters.FindDropBuryCompletedByDateRangeTableAdapter aFindDropBuryCompleteByDateRangeTableAdapter;

        FindDropBuryCompletedByWorkOrderNumberDataSet aFindDropBuryCompletedByWorkOrderNumberDataSet;
        FindDropBuryCompletedByWorkOrderNumberDataSetTableAdapters.FindDropBuryCompletedByWorkOrderNumberTableAdapter aFindDropBuryCompletedByWorkOrderNumberTableAdapter;

        FindDropBuryCompletedByTechnicianIDDataSet aFindDropBuryCompletedByTechnicianIDDataSet;
        FindDropBuryCompletedByTechnicianIDDataSetTableAdapters.FindDropBuryCompletedByTechnicianIDTableAdapter aFindDropBuryCompletedByTechnicianIDTableAdapter;

        InsertMDUCompletedEntryTableAdapters.QueriesTableAdapter aInsertMDUCompletedTableAdapter;

        FindMDUCompletedByWorkOrderNumberDataSet aFindMDUCompletedByWorkOrderNumberDataSet;
        FindMDUCompletedByWorkOrderNumberDataSetTableAdapters.FindMDUCompletedByWorkOrderNumberTableAdapter aFindMDUCompletedByWorkOrderNumberTableAdapter;

        FindMDUCompletedByDateRangeDataSet aFindMDUCompletedByDateRangeDataSet;
        FindMDUCompletedByDateRangeDataSetTableAdapters.FindMDUCompleteByDateRangeTableAdapter aFindMDUCompletedByDateRangeTableAdapter;

        FindMDUCompletedByTechnicianIDDataSet aFindMDUCompletedByTechnicianIDDataSet;
        FindMDUCompletedByTechnicianIDDataSetTableAdapters.FindMDUCompleteByTechnicianIDTableAdapter aFindMDUCompletedByTechnicianIDTableAdapter;

        InsertMDUTaskEntryTableAdapters.QueriesTableAdapter aInsertMDUTaskTableAdapter;

        UpdateMDUTaskPricedEntryTableAdapters.QueriesTableAdapter aUpdateMDUPriceTableAdapter;

        FindMDUTaskByTaskCodeDataSet aFindMDUTaskByTaskCodeDataSet;
        FindMDUTaskByTaskCodeDataSetTableAdapters.FindMDUTasksByTaskCodeTableAdapter aFindMDUTaskByTaskCodeTableAdapter;

        FindMDUTaskByTaskIDDataSet aFindMDUTaskByTaskIDDataSet;
        FindMDUTaskByTaskIDDataSetTableAdapters.FindMDUTaskByTaskIDTableAdapter aFindMDUTaskByTaskIDTableAdapter;

        FindMDUTasksSortedDataSet aFindMDUTasksSortedDataSet;
        FindMDUTasksSortedDataSetTableAdapters.FindMDUTasksSortedTableAdapter aFindMDUTasksSortedTableAdapter;

        InsertDropBuryTaskEntryTableAdapters.QueriesTableAdapter aInsertDropBuryTaskTableAdapter;

        FindDropBuryTaskByDescriptionDataSet aFindDropBuryTaskByDescriptionDataSet;
        FindDropBuryTaskByDescriptionDataSetTableAdapters.FindDropBuryTaskByDescriptionTableAdapter aFindDropBuryTaskByDescriptionTableAdapter;

        FindDropBuryTaskByTaskIDDataSet aFindDropBuryTaskByTaskIDDataSet;
        FindDropBuryTaskByTaskIDDataSetTableAdapters.FindDropBuryTaskByTaskIDTableAdapter aFindDropBuryTaskByTaskIDTableAdapter;

        FindDropBuryTasksSortedDataSet aFindDropBuryTasksSortedDataSet;
        FindDropBuryTasksSortedDataSetTableAdapters.FindDropBuryTasksSortedTableAdapter aFindDropBuryTasksSortedTableAdapter;

        FindMDUTaskByDescriptionDataSet aFindMDUTaskByDescriptionDataSet;
        FindMDUTaskByDescriptionDataSetTableAdapters.FindMDUTaskByDescriptionTableAdapter aFindMDUTaskByDescriptionTableAdapter;

        UpdateMDUTaskDescriptionEntryTableAdapters.QueriesTableAdapter aUpdateMDUTaskDescriptionTableAdapter;

        FindAllOpenMDUDropOrdersDataSet aFindAllOpenMDUDropOrdersDataSet;
        FindAllOpenMDUDropOrdersDataSetTableAdapters.FindAllOpenMDUDropOrdersTableAdapter aFindAllOpenMDUDropOrdersTableAdapter;

        public FindAllOpenMDUDropOrdersDataSet FindAllOpenMDUDropOrders(DateTime datStartDate, DateTime datEndDate, string strWorkType)
        {
            try
            {
                aFindAllOpenMDUDropOrdersDataSet = new FindAllOpenMDUDropOrdersDataSet();
                aFindAllOpenMDUDropOrdersTableAdapter = new FindAllOpenMDUDropOrdersDataSetTableAdapters.FindAllOpenMDUDropOrdersTableAdapter();
                aFindAllOpenMDUDropOrdersTableAdapter.Fill(aFindAllOpenMDUDropOrdersDataSet.FindAllOpenMDUDropOrders, datStartDate, datEndDate, strWorkType);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Drop Bury MDU Class // Find All Open MDU Drop Orders " + Ex.Message);
            }

            return aFindAllOpenMDUDropOrdersDataSet;
        }
        public bool UpdateMDUTaskDescription(int intTaskID, string strTaskDescription)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateMDUTaskDescriptionTableAdapter = new UpdateMDUTaskDescriptionEntryTableAdapters.QueriesTableAdapter();
                aUpdateMDUTaskDescriptionTableAdapter.UpdateMDUTaskDescription(intTaskID, strTaskDescription);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Drop Bury MDU Class // Update MDU Task Description " + Ex.Message);
            }

            return blnFatalError;
        }
        public FindMDUTaskByDescriptionDataSet FindMDUTaskByDescription(string strDescription)
        {
            try
            {
                aFindMDUTaskByDescriptionDataSet = new FindMDUTaskByDescriptionDataSet();
                aFindMDUTaskByDescriptionTableAdapter = new FindMDUTaskByDescriptionDataSetTableAdapters.FindMDUTaskByDescriptionTableAdapter();
                aFindMDUTaskByDescriptionTableAdapter.Fill(aFindMDUTaskByDescriptionDataSet.FindMDUTaskByDescription, strDescription);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Drop Bury MDU Class // Find MDU Task By Description " + Ex.Message);
            }

            return aFindMDUTaskByDescriptionDataSet;
        }
        public FindDropBuryTasksSortedDataSet FindDropBuryTasksSorted()
        {
            try
            {
                aFindDropBuryTasksSortedDataSet = new FindDropBuryTasksSortedDataSet();
                aFindDropBuryTasksSortedTableAdapter = new FindDropBuryTasksSortedDataSetTableAdapters.FindDropBuryTasksSortedTableAdapter();
                aFindDropBuryTasksSortedTableAdapter.Fill(aFindDropBuryTasksSortedDataSet.FindDropBuryTasksSorted);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Drop Bury MDU Class // Find Drop Bury Tasks Sorted " + Ex.Message);
            }

            return aFindDropBuryTasksSortedDataSet;
        }
        public FindDropBuryTaskByTaskIDDataSet FindDropBuryTaskByTaskID(int intTaskID)
        {
            try
            {
                aFindDropBuryTaskByTaskIDDataSet = new FindDropBuryTaskByTaskIDDataSet();
                aFindDropBuryTaskByTaskIDTableAdapter = new FindDropBuryTaskByTaskIDDataSetTableAdapters.FindDropBuryTaskByTaskIDTableAdapter();
                aFindDropBuryTaskByTaskIDTableAdapter.Fill(aFindDropBuryTaskByTaskIDDataSet.FindDropBuryTaskByTaskID, intTaskID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Drop Bury MDU Class // Find Drop Bury Task By Task ID " + Ex.Message);
            }

            return aFindDropBuryTaskByTaskIDDataSet;
        }
        public FindDropBuryTaskByDescriptionDataSet FindDropBuryTaskByDescription(string strTaskDescription)
        {
            try
            {
                aFindDropBuryTaskByDescriptionDataSet = new FindDropBuryTaskByDescriptionDataSet();
                aFindDropBuryTaskByDescriptionTableAdapter = new FindDropBuryTaskByDescriptionDataSetTableAdapters.FindDropBuryTaskByDescriptionTableAdapter();
                aFindDropBuryTaskByDescriptionTableAdapter.Fill(aFindDropBuryTaskByDescriptionDataSet.FindDropBuryTaskByDescription, strTaskDescription);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Drop Bury MDU Class // Find Drop Bury Task By Description " + Ex.Message);
            }

            return aFindDropBuryTaskByDescriptionDataSet;
        }
        public bool InsertDropBuryTask(string strTaskDescription)
        {
            bool blnFatalError = false;

            try
            {
                aInsertDropBuryTaskTableAdapter = new InsertDropBuryTaskEntryTableAdapters.QueriesTableAdapter();
                aInsertDropBuryTaskTableAdapter.InsertDropBuryTask(strTaskDescription);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Drop Bury MDU Class // Insert Drop Bury Task " + Ex.Message);
            }

            return blnFatalError;
        }
        public FindMDUTasksSortedDataSet FindMDUTasksSorted()
        {
            try
            {
                aFindMDUTasksSortedDataSet = new FindMDUTasksSortedDataSet();
                aFindMDUTasksSortedTableAdapter = new FindMDUTasksSortedDataSetTableAdapters.FindMDUTasksSortedTableAdapter();
                aFindMDUTasksSortedTableAdapter.Fill(aFindMDUTasksSortedDataSet.FindMDUTasksSorted);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Drop Bury MDU Class // Find MDU Tasks Sorted " + Ex.Message);
            }

            return aFindMDUTasksSortedDataSet;
        }
        public FindMDUTaskByTaskIDDataSet FindMDUTaskByTaskID(int intTaskID)
        {
            try
            {
                aFindMDUTaskByTaskIDDataSet = new FindMDUTaskByTaskIDDataSet();
                aFindMDUTaskByTaskIDTableAdapter = new FindMDUTaskByTaskIDDataSetTableAdapters.FindMDUTaskByTaskIDTableAdapter();
                aFindMDUTaskByTaskIDTableAdapter.Fill(aFindMDUTaskByTaskIDDataSet.FindMDUTaskByTaskID, intTaskID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Drop Bury MDU Class // Find MDU Task By Task ID " + Ex.Message);
            }

            return aFindMDUTaskByTaskIDDataSet;
        }
        public FindMDUTaskByTaskCodeDataSet FindMDUTaskByTaskCode(string strTaskCode)
        {
            try
            {
                aFindMDUTaskByTaskCodeDataSet = new FindMDUTaskByTaskCodeDataSet();
                aFindMDUTaskByTaskCodeTableAdapter = new FindMDUTaskByTaskCodeDataSetTableAdapters.FindMDUTasksByTaskCodeTableAdapter();
                aFindMDUTaskByTaskCodeTableAdapter.Fill(aFindMDUTaskByTaskCodeDataSet.FindMDUTasksByTaskCode, strTaskCode);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Drop Bury MDU Class // Find MDU Task By Task Code " + Ex.Message);
            }

            return aFindMDUTaskByTaskCodeDataSet;
        }
        public bool UpdateMDUTaskPrice(int intTaskID, float fltTaskPrice)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateMDUPriceTableAdapter = new UpdateMDUTaskPricedEntryTableAdapters.QueriesTableAdapter();
                aUpdateMDUPriceTableAdapter.UpdateMDUTaskPrice(intTaskID, fltTaskPrice);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Drop Bury MDU Class // Update MDU Task Price " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertMDUTask(string strTaskCode, string strTaskDecription, float fltTaskPrice)
        {
            bool blnFatalError = false;

            try
            {
                aInsertMDUTaskTableAdapter = new InsertMDUTaskEntryTableAdapters.QueriesTableAdapter();
                aInsertMDUTaskTableAdapter.InsertMDUTask(strTaskCode, strTaskDecription, fltTaskPrice);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Drop Bury MDU Class // Insert MDU Task " + Ex.Message);
            }

            return blnFatalError;
        }
        public FindMDUCompletedByTechnicianIDDataSet FindMDUCompletedByTechnicianID(int intTechnicianID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindMDUCompletedByTechnicianIDDataSet = new FindMDUCompletedByTechnicianIDDataSet();
                aFindMDUCompletedByTechnicianIDTableAdapter = new FindMDUCompletedByTechnicianIDDataSetTableAdapters.FindMDUCompleteByTechnicianIDTableAdapter();
                aFindMDUCompletedByTechnicianIDTableAdapter.Fill(aFindMDUCompletedByTechnicianIDDataSet.FindMDUCompleteByTechnicianID, intTechnicianID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Drop Bury MDU Class // Find MDU Completec By Technician ID " + Ex.Message);
            }

            return aFindMDUCompletedByTechnicianIDDataSet;
        }
        public FindMDUCompletedByDateRangeDataSet FindMDUCompletedByDateRange(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindMDUCompletedByDateRangeDataSet = new FindMDUCompletedByDateRangeDataSet();
                aFindMDUCompletedByDateRangeTableAdapter = new FindMDUCompletedByDateRangeDataSetTableAdapters.FindMDUCompleteByDateRangeTableAdapter();
                aFindMDUCompletedByDateRangeTableAdapter.Fill(aFindMDUCompletedByDateRangeDataSet.FindMDUCompleteByDateRange, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Drop Bury MDU Class // Find MDU Complete By Date Range " + Ex.Message);
            }

            return aFindMDUCompletedByDateRangeDataSet;
        }
        public FindMDUCompletedByWorkOrderNumberDataSet FindMDUCompletedByWorkOrderNumber(string strWorkOrderNumber)
        {
            try
            {
                aFindMDUCompletedByWorkOrderNumberDataSet = new FindMDUCompletedByWorkOrderNumberDataSet();
                aFindMDUCompletedByWorkOrderNumberTableAdapter = new FindMDUCompletedByWorkOrderNumberDataSetTableAdapters.FindMDUCompletedByWorkOrderNumberTableAdapter();
                aFindMDUCompletedByWorkOrderNumberTableAdapter.Fill(aFindMDUCompletedByWorkOrderNumberDataSet.FindMDUCompletedByWorkOrderNumber, strWorkOrderNumber);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Drop Bury MDU Class // Find MDU Complted By Work Order Number " + Ex.Message);
            }

            return aFindMDUCompletedByWorkOrderNumberDataSet;
        }
        public bool InsertMDUCompleted(int intWorkOrderID, int intTaskID, int intTechnicianID, int intQuantity, string strWorkNotes)
        {
            bool blnFatalError = false;

            try
            {
                aInsertMDUCompletedTableAdapter = new InsertMDUCompletedEntryTableAdapters.QueriesTableAdapter();
                aInsertMDUCompletedTableAdapter.InsertMDUCompleted(intWorkOrderID, intTaskID, intTechnicianID, intQuantity, DateTime.Now, strWorkNotes);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Drop Bury MDU Class // Insert MDU Completed " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public FindDropBuryCompletedByTechnicianIDDataSet FindDropBuryCompletedByTechnicianID(int intTechnicianID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindDropBuryCompletedByTechnicianIDDataSet = new FindDropBuryCompletedByTechnicianIDDataSet();
                aFindDropBuryCompletedByTechnicianIDTableAdapter = new FindDropBuryCompletedByTechnicianIDDataSetTableAdapters.FindDropBuryCompletedByTechnicianIDTableAdapter();
                aFindDropBuryCompletedByTechnicianIDTableAdapter.Fill(aFindDropBuryCompletedByTechnicianIDDataSet.FindDropBuryCompletedByTechnicianID, intTechnicianID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Drop Bury MDU Class // Find Drop Bury Completed By Technician ID " + Ex.Message);
            }

            return aFindDropBuryCompletedByTechnicianIDDataSet;
        }
        public FindDropBuryCompletedByWorkOrderNumberDataSet FindDropBuryCompletedByWorkOrderNumber(string strWorkOrderNumber)
        {
            try
            {
                aFindDropBuryCompletedByWorkOrderNumberDataSet = new FindDropBuryCompletedByWorkOrderNumberDataSet();
                aFindDropBuryCompletedByWorkOrderNumberTableAdapter = new FindDropBuryCompletedByWorkOrderNumberDataSetTableAdapters.FindDropBuryCompletedByWorkOrderNumberTableAdapter();
                aFindDropBuryCompletedByWorkOrderNumberTableAdapter.Fill(aFindDropBuryCompletedByWorkOrderNumberDataSet.FindDropBuryCompletedByWorkOrderNumber, strWorkOrderNumber);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Drop Bury MDU Class // Find Drop Bury Completed By Work Order Number " + Ex.Message);
            }

            return aFindDropBuryCompletedByWorkOrderNumberDataSet;
        }
        public FindDropBuryCompleteByDateRangeDataSet FindDropBuryCompletedByDateRange(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindDropBuryCompleteByDateRangeDataSet = new FindDropBuryCompleteByDateRangeDataSet();
                aFindDropBuryCompleteByDateRangeTableAdapter = new FindDropBuryCompleteByDateRangeDataSetTableAdapters.FindDropBuryCompletedByDateRangeTableAdapter();
                aFindDropBuryCompleteByDateRangeTableAdapter.Fill(aFindDropBuryCompleteByDateRangeDataSet.FindDropBuryCompletedByDateRange, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Drop Bury MDU Class // Find Drop Bury Completed By Date Range " + Ex.Message);
            }

            return aFindDropBuryCompleteByDateRangeDataSet;
        }
        public bool InsertDropBuryCompleted(int intWorkOrderID, string strWorkNotes, int intTaskID, int intWorkQuantity, int intTechnicianID)
        {
            bool blnFatalError = false;

            try
            {
                aInsertDropBuryCompletedTableAdapter = new InsertDropBuryCompletedEntryTableAdapters.QueriesTableAdapter();
                aInsertDropBuryCompletedTableAdapter.InsertDropBuryCompleted(intWorkQuantity, DateTime.Now, strWorkNotes, intTaskID, intWorkQuantity, intTechnicianID);
            }
            catch (Exception ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Drop Bury MDU Class // Insert Drop Bury Completed " + ex.Message);
            }

            return blnFatalError;
        }
        public MDUTasksDataSet GetMDUTasksInfo()
        {
            try
            {
                aMDUTasksDataSet = new MDUTasksDataSet();
                aMDUTasksTableAdapter = new MDUTasksDataSetTableAdapters.mdutasksTableAdapter();
                aMDUTasksTableAdapter.Fill(aMDUTasksDataSet.mdutasks);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Drop Bury MDU Class // get MDU Tasks Info " + Ex.Message);
            }

            return aMDUTasksDataSet;
        }
        public void UpdateMDUTasksDB(MDUTasksDataSet aMDUTasksDataSet)
        {
            try
            {
                aMDUTasksTableAdapter = new MDUTasksDataSetTableAdapters.mdutasksTableAdapter();
                aMDUTasksTableAdapter.Update(aMDUTasksDataSet.mdutasks);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Drop Bury MDU Class // Update MDU Tasks DB " + Ex.Message);
            }
        }
        public MDUCompletedDataSet GetMDUCompletedInfo()
        {
            try
            {
                aMDUCompletedDataSet = new MDUCompletedDataSet();
                aMDUCompletedTableAdapter = new MDUCompletedDataSetTableAdapters.mducompletedTableAdapter();
                aMDUCompletedTableAdapter.Fill(aMDUCompletedDataSet.mducompleted);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Drop Bury MDU Class // Get MDU Completed Info " + Ex.Message);
            }

            return aMDUCompletedDataSet;
        }
        public void UpdateMDUCompletedDB(MDUCompletedDataSet aMDUCompletedDataSet)
        {
            try
            {
                aMDUCompletedTableAdapter = new MDUCompletedDataSetTableAdapters.mducompletedTableAdapter();
                aMDUCompletedTableAdapter.Update(aMDUCompletedDataSet.mducompleted);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Drop Bury MDU Class // Update MDU Completed DB " + Ex.Message);
            }
        }
        public DropBuryTasksDataSet GetDropBuryTasksInfo()
        {
            try
            {
                aDropBuryTasksDataSet = new DropBuryTasksDataSet();
                aDropBuryTasksTableAdapter = new DropBuryTasksDataSetTableAdapters.dropburytasksTableAdapter();
                aDropBuryTasksTableAdapter.Fill(aDropBuryTasksDataSet.dropburytasks);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Drop Bury MDU Class // get Drop bury Tasks Info " + Ex.Message);
            }

            return aDropBuryTasksDataSet;
        }
        public void UpdateDropBuryTasksDB(DropBuryTasksDataSet aDropBuryTasksDataSet)
        {

            try
            {
                aDropBuryTasksTableAdapter = new DropBuryTasksDataSetTableAdapters.dropburytasksTableAdapter();
                aDropBuryTasksTableAdapter.Update(aDropBuryTasksDataSet.dropburytasks);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Drop Bury MDU Class // Update Drop bury Tasks DB " + Ex.Message);
            }
        }
        public DropBuryCompletedDataSet GetDropBuryCompletedInfo()
        {
            try
            {
                aDropBuryCompletedDataSet = new DropBuryCompletedDataSet();
                aDropBuryCompletedTableAdapter = new DropBuryCompletedDataSetTableAdapters.dropburycompletedTableAdapter();
                aDropBuryCompletedTableAdapter.Fill(aDropBuryCompletedDataSet.dropburycompleted);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Drop Bury MDU Class // Get Drop Bury Completed Info " + Ex.Message);
            }

            return aDropBuryCompletedDataSet;
        }
        public void UpdateDropBuryCompletedDB(DropBuryCompletedDataSet aDropBuryCompletedDataSet)
        {
            try
            {
                aDropBuryCompletedTableAdapter = new DropBuryCompletedDataSetTableAdapters.dropburycompletedTableAdapter();
                aDropBuryCompletedTableAdapter.Update(aDropBuryCompletedDataSet.dropburycompleted);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Drop Bury MDU Class // Update Drop Bury Completed DB " + Ex.Message);
            }
        }
    }
}
