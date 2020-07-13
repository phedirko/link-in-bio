### link-in-bio project setup

#### Prerequisites

* .net core sdk installed (version. 3.1) [SDK](https://dotnet.microsoft.com/download)
* .net core runtime installed (v. 3.1) [Runtime](https://dotnet.microsoft.com/download)


#### Front-end code

Front-end code stored in ./src/LinkInBio/LinkInBio.Host/wwwroot folder
There is `Index.html` added as sample, you can add any files you need in wwwroot folder (.js, .html, .css, .jpg, etc.)

#### Swagger
Tou can explore API by using [Swagger]() UI. The path is `/swagger`

#### How to run code

1. make sure you've installed dependencies
2. from path (link-in-bio) run this commands 
     ```cd /src/LinkInBio/LinkInBio.Host```
     and
     ```dotnet run --urls=http://localhost:5001/```

This will start app on **5001** port

Go to http://localhost:5001/ in browser,
http://localhost:5001/Index.html - stands for first page
http://localhost:5001/swagger - for swagger

Keep in mind that host (the **localhost:5001**) part of uri can be different, so use relative paths while development.

For example:
/Index.html **not** http://localhost:5001/Index.html

