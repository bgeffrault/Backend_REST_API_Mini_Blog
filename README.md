# Backend_REST_API_Mini_Blog
It's a backend REST API made with ASP .NET Core in C#. It interacts with a local MySQL database.

## What does-it do ?
The API let you create, modify, dalete, get one or all the posts in your database.

* GET /Posts
Return a List of Posts with a json format
Exemple :
  {
  "title": "Titre de Test1",
  "content": "Content test",
  "loveIts": "0",
  "created_at": "08/02/2020",
  "photo": "url1",
  "photoCropped": "urlCropped1",
  "id": "1"
},
  {
  "title": "Titre de Test2",
  "content": "Content test",
  "loveIts": "0",
  "created_at": "08/02/2020",
  "photo": "urlPhoto",
  "photoCropped": "urlPhotoCropped",
  "id": "2"
},

* GET /Posts/id
Return a Post with json format, if the post doesn't exist in the database, the fields returned are all "null"
Exemple :
{
  "title": "Titre de Test1",
  "content": "Content test",
  "loveIts": "0",
  "created_at": "08/02/2020",
  "photo": "url1",
  "photoCropped": "urlCropped1",
  "id": "1"
}

* POST /Posts
Send a Post with a json format to create or modify a Post. 
Return a String "Success".
Exemple :
{
  "title":"Troisième test",
  "content":"Je vais tester, la virgule",
  "loveIts":"0",
  "created_at":"08/02/2020",
  "photo":"url1",
  "photoCropped":"urlCropped1",
}

* DELETE /Posts/id
Delete a post. 
Return a String "Success".
Exemple :
DELETE /Posts/5

## Posts model

title: string; 
content: string;  
loveIts: number;
created_at: string;
photo: string;
photoCropped: string;

## Connect with a Database
To implement this solution, I used a local MySQL database.
To use your own database, you can set the parameters inside the ConnexionIDs class :
        public static string User = "user";
        public static string Password = "password";
        public static string Port = "3306";
        public static string Server = "localhost";
        public static string Database = "mini_blog_mydb";
        
 ## Author
 Baptiste GEFFRAULT
