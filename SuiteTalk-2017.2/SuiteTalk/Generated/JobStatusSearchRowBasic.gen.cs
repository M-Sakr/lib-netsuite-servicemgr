//~ Generated by SearchStubs/SearchRowBasic

using System;
using System.Collections.Generic;

namespace SuiteTalk
{
    partial class JobStatusSearchRowBasic
    {
        private static readonly Lazy<ColumnFactory> columnFactoryLoader = new Lazy<ColumnFactory>(() => new ColumnFactory());

        public override void SetColumns(string[] columnNames)
        {
            var factory = columnFactoryLoader.Value;
            for (int i = 0; i < columnNames.Length; i++)
            {
                factory.BuildColumn(this, columnNames[i]);
            }
        }

        class ColumnFactory:  ColumnFactory<JobStatusSearchRowBasic>
        {
            protected override Dictionary<string, Action<JobStatusSearchRowBasic>> InitializeColumnBuilders()
            {
                return new Dictionary<string, Action<JobStatusSearchRowBasic>> {
                    { "description", r => r.@description = new [] { new SearchColumnStringField { customLabel = "description" } } },
                    { "externalId", r => r.@externalId = new [] { new SearchColumnSelectField { customLabel = "externalId" } } },
                    { "internalId", r => r.@internalId = new [] { new SearchColumnSelectField { customLabel = "internalId" } } },
                    { "isInactive", r => r.@isInactive = new [] { new SearchColumnBooleanField { customLabel = "isInactive" } } },
                    { "name", r => r.@name = new [] { new SearchColumnStringField { customLabel = "name" } } },
                };
            }
        }
    }
}