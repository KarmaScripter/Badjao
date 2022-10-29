// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    public static class TriggerBuilder
    {
        /// <summary>
        /// Gets the foreign key triggers.
        /// </summary>
        /// <param name="dt">The dt.</param>
        /// <returns></returns>
        public static IList<TriggerSchema> GetForeignKeyTriggers( TableSchema dt )
        {
            IList<TriggerSchema> _result = new List<TriggerSchema>( );

            foreach( var fks in dt.ForeignKeys )
            {
                _result.Add( GenerateInsertTrigger( fks ) );
                _result.Add( GenerateUpdateTrigger( fks ) );
                _result.Add( GenerateDeleteTrigger( fks ) );
            }

            return _result;
        }

        /// <summary>
        /// Generates the insert trigger.
        /// </summary>
        /// <param name="foreignKey">The FKS.</param>
        /// <returns></returns>
        public static TriggerSchema GenerateInsertTrigger( ForeignKeySchema foreignKey )
        {
            var _schema = new TriggerSchema( );

            _schema.Name = MakeTriggerName( foreignKey, "fki" );
            _schema.Type = TriggerType.Before;
            _schema.Event = TriggerEvent.Insert;
            _schema.Table = foreignKey.TableName;

            var _columnName = string.Empty;

            if( foreignKey.IsNullable )
            {
                _columnName = " NEW." + foreignKey.ColumnName + " IS NOT NULL AND";
            }

            _schema.Body = "SELECT RAISE(ROLLBACK, 'insert on table " + foreignKey.TableName
                + " violates foreign key constraint " + _schema.Name + "')" + " WHERE" + _columnName
                + " (SELECT " + foreignKey.ForeignColumnName + " FROM "
                + foreignKey.ForeignTableName + " WHERE " + foreignKey.ForeignColumnName + " = NEW."
                + foreignKey.ColumnName + ") IS NULL; ";

            return _schema;
        }

        /// <summary>
        /// Generates the update trigger.
        /// </summary>
        /// <param name="foreignKey">The FKS.</param>
        /// <returns></returns>
        public static TriggerSchema GenerateUpdateTrigger( ForeignKeySchema foreignKey )
        {
            var _schema = new TriggerSchema( );

            _schema.Name = MakeTriggerName( foreignKey, "fku" );
            _schema.Type = TriggerType.Before;
            _schema.Event = TriggerEvent.Update;
            _schema.Table = foreignKey.TableName;

            var _schemaName = _schema.Name;
            var _empty = string.Empty;

            if( foreignKey.IsNullable )
            {
                _empty = " NEW." + foreignKey.ColumnName + " IS NOT NULL AND";
            }

            _schema.Body = "SELECT RAISE(ROLLBACK, 'update on table " + foreignKey.TableName
                + " violates foreign key constraint " + _schemaName + "')" + " WHERE" + _empty
                + " (SELECT " + foreignKey.ForeignColumnName + " FROM "
                + foreignKey.ForeignTableName + " WHERE " + foreignKey.ForeignColumnName + " = NEW."
                + foreignKey.ColumnName + ") IS NULL; ";

            return _schema;
        }

        /// <summary>
        /// Generates the delete trigger.
        /// </summary>
        /// <param name="foreignKey">The FKS.</param>
        /// <returns></returns>
        public static TriggerSchema GenerateDeleteTrigger( ForeignKeySchema foreignKey )
        {
            var _schema = new TriggerSchema( );

            _schema.Name = MakeTriggerName( foreignKey, "fkd" );
            _schema.Type = TriggerType.Before;
            _schema.Event = TriggerEvent.Delete;
            _schema.Table = foreignKey.ForeignTableName;

            var _schemaName = _schema.Name;

            _schema.Body = !foreignKey.CascadeOnDelete
                ? "SELECT RAISE(ROLLBACK, 'delete on table " + foreignKey.ForeignTableName
                + " violates foreign key constraint " + _schemaName + "')" + " WHERE (SELECT "
                + foreignKey.ColumnName + " FROM " + foreignKey.TableName + " WHERE "
                + foreignKey.ColumnName + " = OLD." + foreignKey.ForeignColumnName
                + ") IS NOT NULL; "
                : "DELETE FROM [" + foreignKey.TableName + "] WHERE " + foreignKey.ColumnName
                + " = OLD." + foreignKey.ForeignColumnName + "; ";

            return _schema;
        }

        /// <summary>
        /// Makes the name of the trigger.
        /// </summary>
        /// <param name="foreignKey">The FKS.</param>
        /// <param name="prefix">The prefix.</param>
        /// <returns></returns>
        private static string MakeTriggerName( ForeignKeySchema foreignKey, string prefix )
        {
            return prefix + "" + foreignKey.TableName + "" + foreignKey.ColumnName + ""
                + foreignKey.ForeignTableName + "" + foreignKey.ForeignColumnName;
        }
    }
}