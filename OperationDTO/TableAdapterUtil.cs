using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OperationDTO
{
    public class TableAdapterUtil
    {
        /// <summary>
        /// Create, Set and Start SqlTransaction for current TableAdapter.
        /// </summary>
        /// <param name="tableAdapter">The TableAdapter object input.</param>
        /// <returns>The SqlTransaction object.</returns>
        public static SqlTransaction GetTransaction(object tableAdapter)
        {
            return GetTransaction(tableAdapter, IsolationLevel.ReadUncommitted);
        }

        /// <summary>
        /// Create, Set and Start SqlTransaction for current TableAdapter with specify isolation level.
        /// </summary>
        /// <param name="tableAdapter">The TableAdapter object input.</param>
        /// <param name="isolationLevel">The isolation lebel input.</param>
        /// <returns>The SqlTransaction object.</returns>
        public static SqlTransaction GetTransaction(object tableAdapter, IsolationLevel isolationLevel)
        {
            Type type = tableAdapter.GetType();

            SqlConnection connection = GetConnection(tableAdapter);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlTransaction transaction = connection.BeginTransaction(isolationLevel);

            SetTransaction(tableAdapter, transaction);

            return transaction;
        }

        /// <summary>
        /// Set SqlTransaction for specify TableAdapter.
        /// </summary>
        /// <param name="tableAdapter">The TableAdapter object input.</param>
        /// <param name="transaction">The SqlTransaction object input.</param>
        public static void SetTransaction(object tableAdapter, SqlTransaction transaction)
        {
            Type type = tableAdapter.GetType();

            // Set the transaction on each command in the adapter'scommand collection
            PropertyInfo commandsProperty = type.GetProperty("CommandCollection", BindingFlags.NonPublic | BindingFlags.Instance);
            SqlCommand[] commands = (SqlCommand[])commandsProperty.GetValue(tableAdapter, null);
            foreach (SqlCommand command in commands)
            {
                command.Transaction = transaction;
            }

            PropertyInfo adapterProperty = type.GetProperty("Adapter", BindingFlags.NonPublic | BindingFlags.Instance);
            SqlDataAdapter adapter = (SqlDataAdapter)adapterProperty.GetValue(tableAdapter, null);

            if (adapter.SelectCommand != null)
            {
                adapter.SelectCommand.Transaction = transaction;
            }

            if (adapter.UpdateCommand != null)
            {
                adapter.UpdateCommand.Transaction = transaction;
            }

            if (adapter.InsertCommand != null)
            {
                adapter.InsertCommand.Transaction = transaction;
            }

            if (adapter.DeleteCommand != null)
            {
                adapter.DeleteCommand.Transaction = transaction;
            }

            SetConnection(tableAdapter, transaction.Connection);
        }

        /// <summary>
        /// Get SqlConnection of TableAdapter object.
        /// </summary>
        /// <param name="tableAdapter">The TableAdapter object input.</param>
        /// <returns>The SqlConnection object.</returns>
        private static SqlConnection GetConnection(object tableAdapter)
        {
            Type type = tableAdapter.GetType();
            PropertyInfo connectionProperty = type.GetProperty("Connection", BindingFlags.NonPublic | BindingFlags.Instance);
            SqlConnection connection = (SqlConnection)connectionProperty.GetValue(tableAdapter, null);
            return connection;
        }

        /// <summary>
        /// Set SqlConnection for TableAdapter object.
        /// </summary>
        /// <param name="tableAdapter">The TableAdapter object input.</param>
        /// <param name="connection">The SqlConnection object input.</param>
        private static void SetConnection(object tableAdapter, SqlConnection connection)
        {
            Type type = tableAdapter.GetType();
            PropertyInfo connectionProperty = type.GetProperty("Connection", BindingFlags.NonPublic | BindingFlags.Instance);
            connectionProperty.SetValue(tableAdapter, connection, null);
        }
    }
}
