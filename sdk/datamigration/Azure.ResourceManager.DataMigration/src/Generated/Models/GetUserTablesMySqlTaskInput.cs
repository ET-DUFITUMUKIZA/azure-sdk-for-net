// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Input for the task that collects user tables for the given list of databases. </summary>
    public partial class GetUserTablesMySqlTaskInput
    {
        /// <summary> Initializes a new instance of GetUserTablesMySqlTaskInput. </summary>
        /// <param name="connectionInfo"> Connection information for SQL Server. </param>
        /// <param name="selectedDatabases"> List of database names to collect tables for. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionInfo"/> or <paramref name="selectedDatabases"/> is null. </exception>
        public GetUserTablesMySqlTaskInput(MySqlConnectionInfo connectionInfo, IEnumerable<string> selectedDatabases)
        {
            if (connectionInfo == null)
            {
                throw new ArgumentNullException(nameof(connectionInfo));
            }
            if (selectedDatabases == null)
            {
                throw new ArgumentNullException(nameof(selectedDatabases));
            }

            ConnectionInfo = connectionInfo;
            SelectedDatabases = selectedDatabases.ToList();
        }

        /// <summary> Initializes a new instance of GetUserTablesMySqlTaskInput. </summary>
        /// <param name="connectionInfo"> Connection information for SQL Server. </param>
        /// <param name="selectedDatabases"> List of database names to collect tables for. </param>
        internal GetUserTablesMySqlTaskInput(MySqlConnectionInfo connectionInfo, IList<string> selectedDatabases)
        {
            ConnectionInfo = connectionInfo;
            SelectedDatabases = selectedDatabases;
        }

        /// <summary> Connection information for SQL Server. </summary>
        public MySqlConnectionInfo ConnectionInfo { get; set; }
        /// <summary> List of database names to collect tables for. </summary>
        public IList<string> SelectedDatabases { get; }
    }
}
