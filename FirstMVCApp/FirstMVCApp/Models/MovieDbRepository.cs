using Microsoft.Data.SqlClient;
using System.Data;



namespace FirstMVCApp.Models
{
    public class MovieDbRepository
    {
        public static List<Entities> GetMovieList()
        {
            List<Entities> list = new List<Entities>();
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != System.Data.ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand selectmoviecmd = cn.CreateCommand();
                String selectAllmovies = "Select * from Movie";
                selectmoviecmd.CommandText = selectAllmovies;
                SqlDataReader moviedr = selectmoviecmd.ExecuteReader();
                while (moviedr.Read())
                {
                    Entities entities = new Entities
                    {
                        Id = moviedr.GetInt32(0),
                        Title = moviedr.GetString(1),
                        Language = moviedr.GetString(2),
                        Hero = moviedr.GetString(3),
                        Director = moviedr.GetString(4),
                        MusicDirector = moviedr.GetString(5),
                        ReleaseDate = moviedr.GetDateTime(6),
                        Cost = moviedr.GetInt32(7),
                        Collection = moviedr.GetInt32(8),
                        Review = moviedr.GetString(9)
                    };
                    list.Add(entities);
                }
            }
            return list;
        }
        public static Entities GetMovieById(int id)
        {
            Entities entityFound = null;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != System.Data.ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand selectmoviecmd = cn.CreateCommand();
                String selectAllEntities = "Select * from Movie where Id=@id";
                selectmoviecmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                selectmoviecmd.CommandText = selectAllEntities;
                SqlDataReader moviedr = selectmoviecmd.ExecuteReader();
                while (moviedr.Read())
                {
                    entityFound = new Entities
                    {
                        Id = moviedr.GetInt32(0),
                        Title = moviedr.GetString(1),
                        Language = moviedr.GetString(2),
                        Hero = moviedr.GetString(3),
                        Director = moviedr.GetString(4),
                        MusicDirector = moviedr.GetString(5),
                        ReleaseDate = moviedr.GetDateTime(6),
                        Cost = moviedr.GetInt32(7),
                        Collection = moviedr.GetInt32(8),
                        Review = moviedr.GetString(9)
                    };
                }
            }
            return entityFound;
        }
        public static int AddNewMovie(Entities newMovie)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand insertMoviecmd = cn.CreateCommand();
                String insertNewMovieQuery = "insert into Movie values( @id,@Title,@Language,@Hero,@Director,@MusicDirector,@ReleaseDate,@Cost,@Collection,@Review)";
                insertMoviecmd.Parameters.Add("@id", SqlDbType.Int).Value = newMovie.Id;
                insertMoviecmd.Parameters.Add("@Title", SqlDbType.NVarChar).Value = newMovie.Title;
                insertMoviecmd.Parameters.Add("@Language", SqlDbType.NVarChar).Value = newMovie.Language;
                insertMoviecmd.Parameters.Add("@Hero", SqlDbType.NVarChar).Value = newMovie.Hero;
                insertMoviecmd.Parameters.Add("@Director", SqlDbType.NVarChar).Value = newMovie.Director;
                insertMoviecmd.Parameters.Add("@MusicDirector", SqlDbType.NVarChar).Value = newMovie.MusicDirector;
                insertMoviecmd.Parameters.Add("@ReleaseDate", SqlDbType.DateTime).Value = newMovie.ReleaseDate;
                insertMoviecmd.Parameters.Add("@Cost", SqlDbType.Int).Value = newMovie.Cost;
                insertMoviecmd.Parameters.Add("@Collection", SqlDbType.Int).Value = newMovie.Collection;
                insertMoviecmd.Parameters.Add("@Review", SqlDbType.NVarChar).Value = newMovie.Review;
                insertMoviecmd.CommandText = insertNewMovieQuery;
                query_result = insertMoviecmd.ExecuteNonQuery();
            }
            return query_result;
        }
        public static int UpdateMovie(Entities modifiedMovie)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand updateMoviecmd = cn.CreateCommand();
                String updateMovieQuery = "Update Movie set Title=@Title, Language=@Language, Hero=@Hero, Director=@Director, MusicDirector=@MusicDirector, ReleaseDate=@ReleaseDate, Cost=@Cost, Collection=@Collection, Review=@Review where Id=@id";
                updateMoviecmd.Parameters.Add("@id", SqlDbType.Int).Value = modifiedMovie.Id;
                updateMoviecmd.Parameters.Add("@Title", SqlDbType.NVarChar).Value = modifiedMovie.Title;
                updateMoviecmd.Parameters.Add("@Language", SqlDbType.NVarChar).Value = modifiedMovie.Language;
                updateMoviecmd.Parameters.Add("@Hero", SqlDbType.NVarChar).Value = modifiedMovie.Hero;
                updateMoviecmd.Parameters.Add("@Director", SqlDbType.NVarChar).Value = modifiedMovie.Director;
                updateMoviecmd.Parameters.Add("@MusicDirector", SqlDbType.NVarChar).Value = modifiedMovie.MusicDirector;
                updateMoviecmd.Parameters.Add("@ReleaseDate", SqlDbType.DateTime).Value = modifiedMovie.ReleaseDate;
                updateMoviecmd.Parameters.Add("@Cost", SqlDbType.Int).Value = modifiedMovie.Cost;
                updateMoviecmd.Parameters.Add("@Collection", SqlDbType.Int).Value = modifiedMovie.Collection;
                updateMoviecmd.Parameters.Add("@Review", SqlDbType.NVarChar).Value = modifiedMovie.Review;
                updateMoviecmd.CommandText = updateMovieQuery;
                query_result = updateMoviecmd.ExecuteNonQuery();
            }
            return query_result;



        }
        public static int DeleteMovie(int id)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand deleteMoviecmd = cn.CreateCommand();
                String deleteMovieQuery = "Delete from Movie where Id=@id";
                deleteMoviecmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                deleteMoviecmd.CommandText = deleteMovieQuery;
                query_result = deleteMoviecmd.ExecuteNonQuery();
            }
            return query_result;



        }
    }
}