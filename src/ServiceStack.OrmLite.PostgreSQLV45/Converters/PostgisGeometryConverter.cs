using Npgsql;
using NpgsqlTypes;
using System;
using System.Data;

namespace ServiceStack.OrmLite.PostgreSQL.Converters
{
    public class PostgisGeometryConverter : OrmLiteConverter
    {
        public override string ColumnDefinition
        {
            get { return "geometry"; }
        }

        public override DbType DbType
        {
            get { return DbType.Object; }
        }

        public override void InitDbParam(IDbDataParameter p, Type fieldType)
        {
            ((NpgsqlParameter)p).NpgsqlDbType = NpgsqlDbType.Geometry;
        }
    }
}