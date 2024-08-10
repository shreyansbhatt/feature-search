using Dapper;
using feature_search.business.core;
using feature_search.business.core.Entities;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feature_search.repository
{
    public class BrandRepository : IBrandRepository
    {
        private readonly SQLDatabaseConfiguration sqlDBConfig;

        public BrandRepository(IOptions<SQLDatabaseConfiguration> options)
        {
            sqlDBConfig = options.Value;
        }
        public IList<FsBrand> GetAllBrands()
        {
            string sql = "SELECT NAME, DESCRIPTION, IS_DISCOUNTINUED FROM [FeaturesSearch].[dbo].[FS_BRANDS] WHERE IsDeleted = 0";
            using (var connection = new SqlConnection(sqlDBConfig.FeatureSearchDB))
            {
                var result = connection.Query<FsBrand>(sql).ToList();

                return result;
            }
        }

        public FsBrand GetBrandById(short id)
        {
            throw new NotImplementedException();
        }

        public short InsertBrand(BrandInformation brand)
        {
            string sql = "INSERT INTO [FeaturesSearch].[dbo].[FS_BRANDS] Values (@Name, @Description, @Logo, @IsDiscontinued, GETDATE(), NULL, @IsDeleted);";

            using (var connection = new SqlConnection(sqlDBConfig.FeatureSearchDB))
            {
                connection.Open();
                int affectedRows = 0;
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        affectedRows = connection.Execute(sql, new { brand.Name, brand.Description, brand.Logo, brand.IsDiscontinued, IsDeleted = false }, transaction: transaction);

                        transaction.Commit();
                    }
                    catch(Exception ex)
                    {
                        transaction.Rollback();
                    }
                }
                return (short)affectedRows;
            }
        }

        public FsBrand UpdateBrand(short id, BrandInformation brand)
        {
            throw new NotImplementedException();
        }
    }
}
