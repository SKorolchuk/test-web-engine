using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;

namespace TestWebEngine.Data.Contexts
{
    public class EfDataObjectContext : DbContext, IDbContext
    {
        #region Private
        #endregion

        #region Public

        protected DbConnection Connection
        {
            get
            {
                var connection = Database.Connection;

                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                return connection;
            }
        }

        protected ObjectContext ContextAdapter
        {
            get
            {
                return (this as IObjectContextAdapter).ObjectContext;
            }
        }

        #endregion

        #region Ctor

        public EfDataObjectContext(string connectionString = "defaultConnection")
            : base(connectionString)
        {
        }

        #endregion

        #region Override

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var modelConfigurationTypes =
                Assembly.GetExecutingAssembly()
                    .GetTypes()
                    .Where(
                        type =>
                            !string.IsNullOrEmpty(type.Namespace) && type.BaseType != null &&
                            type.BaseType.IsGenericType &&
                            type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));

            foreach (dynamic configuration in modelConfigurationTypes.Select(Activator.CreateInstance))
            {
                modelBuilder.Configurations.Add(configuration);
            }

            base.OnModelCreating(modelBuilder);
        }

        #endregion

        #region Implementation of IDbContext

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }

        public IList<TResultSetType> ExecuteStoredProcedureListResultSetType<TResultSetType>(string commandText, params object[] parameters) where TResultSetType : class, new()
        {
            return ExecuteStoredProcedureBase(commandText, 
                    cmd =>
                    {
                        var reader = cmd.ExecuteReader();
                        var result = ContextAdapter.Translate<TResultSetType>(reader).ToList();
                        reader.Close();
                        return result;
                    },
                    parameters);
        }

        public IList<T> ExecuteStoredProcedure<T>(string commandText, params object[] parameters)
        {
            return ExecuteStoredProcedureBase(commandText,
                    cmd =>
                    {
                        var reader = cmd.ExecuteReader();
                        var result = ContextAdapter.Translate<T>(reader).ToList();
                        reader.Close();
                        return result;
                    },
                    parameters);
        }

        public int ExecuteStoredProcedure(string commandName, params object[] parameters)
        {
            return ExecuteStoredProcedureBase(commandName, cmd => cmd.ExecuteNonQuery(), parameters);
        }

        public IEnumerable<TElement> SqlQuery<TElement>(string sql, params object[] parameters)
        {
            return Database.SqlQuery<TElement>(sql, parameters);
        }

        public int ExecuteSqlCommand(string sql, int? timeout = null, params object[] parameters)
        {
            int? previousTimeout = null;
            if (timeout.HasValue)
            {
                previousTimeout = ContextAdapter.CommandTimeout;
                ContextAdapter.CommandTimeout = timeout;
            }

            var result = Database.ExecuteSqlCommand(sql, parameters);

            if (timeout.HasValue)
            {
                ContextAdapter.CommandTimeout = previousTimeout;
            }

            return result;
        }

        private T ExecuteStoredProcedureBase<T>(string command, Func<DbCommand, T> callbackResult, params object[] parameters)
        {
            using (var cmd = Connection.CreateCommand())
            {
                cmd.CommandText = command;
                cmd.CommandType = CommandType.StoredProcedure;
                
                if (parameters != null)
                    foreach (var p in parameters)
                        cmd.Parameters.Add(p);

                return callbackResult(cmd);
            }
        }

        #endregion
    }
}
