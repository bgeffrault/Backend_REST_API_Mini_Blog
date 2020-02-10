# Backend_REST_API_Mini_Blog
It's a backend REST API made with ASP .NET Core in C#. It interacts with a local MySQL database.
It's design to be a backend solution for the "premier-blog" project.

## What does-it do ?
The API let you create, modify, dalete, get one or all the posts in your database.

* GET /Posts <br />
Return a List of Posts with a json format. <br />
Exemple : <br />
  { <br />
  "title": "Titre de Test1", <br />
  "content": "Content test", <br />
  "loveIts": "0", <br />
  "created_at": "08/02/2020", <br />
  "photo": "url1", <br />
  "photoCropped": "urlCropped1", <br />
  "id": "1" <br />
}, <br />
  { <br />
  "title": "Titre de Test2", <br />
  "content": "Content test", <br />
  "loveIts": "0", <br />
  "created_at": "08/02/2020", <br />
  "photo": "urlPhoto", <br />
  "photoCropped": "urlPhotoCropped", <br />
  "id": "2" <br />
},

* GET /Posts/id <br />
Return a Post with json format, if the post doesn't exist in the database, the fields returned are all "null". <br />
Exemple : <br />
{ <br />
  "title": "Titre de Test1", <br />
  "content": "Content test", <br />
  "loveIts": "0", <br />
  "created_at": "08/02/2020", <br />
  "photo": "url1", <br />
  "photoCropped": "urlCropped1", <br />
  "id": "1" <br />
}

* POST /Posts <br />
Send a Post with a json format to create or modify a Post. <br />
Return a String "Success". <br />
Exemple : <br />
{<br />
  "title":"Troisième test", <br />
  "content":"Je vais tester, la virgule", <br />
  "loveIts":"0", <br />
  "created_at":"08/02/2020", <br />
  "photo":"url1", <br />
  "photoCropped":"urlCropped1", <br />
}

* DELETE /Posts/id <br />
Delete a post. <br />
Return a String "Success".<br />
Exemple :<br />
DELETE /Posts/5 <br />

## Posts model

title: string;  // Post's title <br />
content: string;  // Post's content <br />
loveIts: number; //Number of likes <br />
created_at: string; // Date of create in string <br />
photo: string; //URL where to fetch a picture for the post <br />
photoCropped: string; //URL where to fetch a picture for carroussel <br />

## Connect with a Database
To implement this solution, it uses a local MySQL database. <br />
To use your own database, you can set the parameters inside the ConnexionIDs class : <br />
        public static string User = "user"; <br />
        public static string Password = "password"; <br />
        public static string Port = "3306"; <br />
        public static string Server = "localhost"; <br />
        public static string Database = "mini_blog_mydb"; <br />
        
 ## Author
 Baptiste GEFFRAULT
