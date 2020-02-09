using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mini_Blog_Backend.Models;
using MySql.Data.MySqlClient; //For connexion with a database

namespace Mini_Blog_Backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        // GET: api/Posts
        [HttpGet]
        public IEnumerable<Post> Get()
        {
            var list = new List<Post>();

            Post post = new Post();
            MySqlConnection connection = new MySqlConnection(
                "server=" + ConnexionIDs.Server +
                ";port=" + ConnexionIDs.Port +
                ";database=" + ConnexionIDs.Database +
                ";user=" + ConnexionIDs.User +
                ";password=" + ConnexionIDs.Password);
            connection.Open();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM posts_table";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                var post = new Post();
                post.Id = reader.GetString(0);
                post.Title = reader.GetString(1);
                post.Content = reader.GetString(2);
                post.Created_at = reader.GetString(3);
                post.LoveIts = reader.GetString(4);
                post.Photo = reader.GetString(5);
                post.PhotoCropped = reader.GetString(6);

                list.Add(post);
            }
            reader.Close();
            
            return list;
        }

        // GET: api/Posts/id
        [HttpGet("{id}", Name = "Get")]
        public Post Get(int id)
        {
            Post post = new Post();
            MySqlConnection connection = new MySqlConnection(
                "server=" + ConnexionIDs.Server +
                ";port=" + ConnexionIDs.Port +
                ";database=" + ConnexionIDs.Database +
                ";user=" + ConnexionIDs.User +
                ";password=" + ConnexionIDs.Password );
            connection.Open();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM posts_table WHERE id=" +id;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                
                post.Id = reader.GetString(0);
                post.Title = reader.GetString(1);
                post.Content = reader.GetString(2);
                post.Created_at = reader.GetString(3);
                post.LoveIts = reader.GetString(4);
                post.Photo = reader.GetString(5);
                post.PhotoCropped = reader.GetString(6);
            }
            reader.Close();
            return post;
        }

        // POST: api/Posts
        [HttpPost]
        public String Post([FromBody] Post post)
        {

            MySqlConnection connection = new MySqlConnection(
                "server=" + ConnexionIDs.Server +
                ";port=" + ConnexionIDs.Port +
                ";database=" + ConnexionIDs.Database +
                ";user=" + ConnexionIDs.User +
                ";password=" + ConnexionIDs.Password);
            connection.Open();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "INSERT INTO posts_table (title, content, created_at, loveIts, photo, photoCropped) " +
                "VALUES('"+ post.ConvertForSQL(post.Title)+"', '"+
                post.ConvertForSQL(post.Content) +"', '"+ 
                post.Created_at +"', '"+ 
                post.LoveIts +"', '"+ 
                post.Photo + "', '" + 
                post.PhotoCropped + "')";

            MySqlDataReader reader = command.ExecuteReader();
            return "Success";

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            MySqlConnection connection = new MySqlConnection(
                "server=" + ConnexionIDs.Server +
                ";port=" + ConnexionIDs.Port +
                ";database=" + ConnexionIDs.Database +
                ";user=" + ConnexionIDs.User +
                ";password=" + ConnexionIDs.Password);
            connection.Open();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "DELETE FROM posts_table WHERE id=" + id;
            MySqlDataReader reader = command.ExecuteReader();

            return "Success";
        }
    }
}
