// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using Azure;
    using Management;
    using Sql;
    using Rest;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a database recommended index.
    /// </summary>
    [JsonTransformation]
    public partial class RecommendedIndex : Resource
    {
        /// <summary>
        /// Initializes a new instance of the RecommendedIndex class.
        /// </summary>
        public RecommendedIndex() { }

        /// <summary>
        /// Initializes a new instance of the RecommendedIndex class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="name">Resource name</param>
        /// <param name="id">Resource ID</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="action">The proposed index action. You can create a
        /// missing index, drop an unused index, or rebuild an existing index
        /// to improve its performance. Possible values include: 'Create',
        /// 'Drop', 'Rebuild'</param>
        /// <param name="state">The current recommendation state. Possible
        /// values include: 'Active', 'Pending', 'Executing', 'Verifying',
        /// 'Pending Revert', 'Reverting', 'Reverted', 'Ignored', 'Expired',
        /// 'Blocked', 'Success'</param>
        /// <param name="created">The UTC datetime showing when this resource
        /// was created (ISO8601 format).</param>
        /// <param name="lastModified">The UTC datetime of when was this
        /// resource last changed (ISO8601 format).</param>
        /// <param name="indexType">The type of index (CLUSTERED, NONCLUSTERED,
        /// COLUMNSTORE, CLUSTERED COLUMNSTORE). Possible values include:
        /// 'CLUSTERED', 'NONCLUSTERED', 'COLUMNSTORE', 'CLUSTERED
        /// COLUMNSTORE'</param>
        /// <param name="schema">The schema where table to build index over
        /// resides</param>
        /// <param name="table">The table on which to build index.</param>
        /// <param name="columns">Columns over which to build index</param>
        /// <param name="includedColumns">The list of column names to be
        /// included in the index</param>
        /// <param name="indexScript">The full build index script</param>
        /// <param name="estimatedImpact">The estimated impact of doing
        /// recommended index action.</param>
        /// <param name="reportedImpact">The values reported after index action
        /// is complete.</param>
        public RecommendedIndex(string location, string name = default(string), string id = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), RecommendedIndexActions? action = default(RecommendedIndexActions?), RecommendedIndexStates? state = default(RecommendedIndexStates?), System.DateTime? created = default(System.DateTime?), System.DateTime? lastModified = default(System.DateTime?), RecommendedIndexTypes? indexType = default(RecommendedIndexTypes?), string schema = default(string), string table = default(string), IList<string> columns = default(IList<string>), IList<string> includedColumns = default(IList<string>), string indexScript = default(string), IList<OperationImpact> estimatedImpact = default(IList<OperationImpact>), IList<OperationImpact> reportedImpact = default(IList<OperationImpact>))
            : base(location, name, id, type, tags)
        {
            Action = action;
            State = state;
            Created = created;
            LastModified = lastModified;
            IndexType = indexType;
            Schema = schema;
            Table = table;
            Columns = columns;
            IncludedColumns = includedColumns;
            IndexScript = indexScript;
            EstimatedImpact = estimatedImpact;
            ReportedImpact = reportedImpact;
        }

        /// <summary>
        /// Gets the proposed index action. You can create a missing index,
        /// drop an unused index, or rebuild an existing index to improve its
        /// performance. Possible values include: 'Create', 'Drop', 'Rebuild'
        /// </summary>
        [JsonProperty(PropertyName = "properties.action")]
        public RecommendedIndexActions? Action { get; protected set; }

        /// <summary>
        /// Gets the current recommendation state. Possible values include:
        /// 'Active', 'Pending', 'Executing', 'Verifying', 'Pending Revert',
        /// 'Reverting', 'Reverted', 'Ignored', 'Expired', 'Blocked', 'Success'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public RecommendedIndexStates? State { get; protected set; }

        /// <summary>
        /// Gets the UTC datetime showing when this resource was created
        /// (ISO8601 format).
        /// </summary>
        [JsonProperty(PropertyName = "properties.created")]
        public System.DateTime? Created { get; protected set; }

        /// <summary>
        /// Gets the UTC datetime of when was this resource last changed
        /// (ISO8601 format).
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModified")]
        public System.DateTime? LastModified { get; protected set; }

        /// <summary>
        /// Gets the type of index (CLUSTERED, NONCLUSTERED, COLUMNSTORE,
        /// CLUSTERED COLUMNSTORE). Possible values include: 'CLUSTERED',
        /// 'NONCLUSTERED', 'COLUMNSTORE', 'CLUSTERED COLUMNSTORE'
        /// </summary>
        [JsonProperty(PropertyName = "properties.indexType")]
        public RecommendedIndexTypes? IndexType { get; protected set; }

        /// <summary>
        /// Gets the schema where table to build index over resides
        /// </summary>
        [JsonProperty(PropertyName = "properties.schema")]
        public string Schema { get; protected set; }

        /// <summary>
        /// Gets the table on which to build index.
        /// </summary>
        [JsonProperty(PropertyName = "properties.table")]
        public string Table { get; protected set; }

        /// <summary>
        /// Gets columns over which to build index
        /// </summary>
        [JsonProperty(PropertyName = "properties.columns")]
        public IList<string> Columns { get; protected set; }

        /// <summary>
        /// Gets the list of column names to be included in the index
        /// </summary>
        [JsonProperty(PropertyName = "properties.includedColumns")]
        public IList<string> IncludedColumns { get; protected set; }

        /// <summary>
        /// Gets the full build index script
        /// </summary>
        [JsonProperty(PropertyName = "properties.indexScript")]
        public string IndexScript { get; protected set; }

        /// <summary>
        /// Gets the estimated impact of doing recommended index action.
        /// </summary>
        [JsonProperty(PropertyName = "properties.estimatedImpact")]
        public IList<OperationImpact> EstimatedImpact { get; protected set; }

        /// <summary>
        /// Gets the values reported after index action is complete.
        /// </summary>
        [JsonProperty(PropertyName = "properties.reportedImpact")]
        public IList<OperationImpact> ReportedImpact { get; protected set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}

