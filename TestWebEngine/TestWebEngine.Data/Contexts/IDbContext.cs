using System.Collections.Generic;
using System.Data.Entity;

namespace TestWebEngine.Data.Contexts
{
    public interface IDbContext
    {
        IDbSet<TEntity> Set<TEntity>() where TEntity : class;

        int SaveChanges();

        IList<TResultSetType> ExecuteStoredProcedureListResultSetType<TResultSetType>(string commandText, params object[] parameters)
            where TResultSetType : class , new();

        IList<T> ExecuteStoredProcedure<T>(string commandText, params object[] parameters);

        int ExecuteStoredProcedure(string commandName, params object[] parameters);

        IEnumerable<TElement> SqlQuery<TElement>(string sql, params object[] parameters);

        int ExecuteSqlCommand(string sql, int? timeout = null, params object[] parameters);
    }
}
