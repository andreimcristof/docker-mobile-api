# docker-mobile-api
api which offers endpoints for Docker container/image management connecting to the Docker engine.

When this works properly you will be able to get a response from your local DOcker Engine by calling the endpoint: 
http://localhost:5000/api/Docker

### how to start
you need dotnet cli to run dotnet restore, this is  a dotnet project.  

##### OS compat
as you can see in Startup config, this connects to unix docker engine. So it works on a mac right now, not windoze. I will soon 
update it to detect OS and connect accordingly. 
