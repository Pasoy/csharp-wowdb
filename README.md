# Wow (Web)  

* Working with Data
* Custom Forms
* Validation (Client & Server)
* RESTful
* CRUD
* APIs for both players, characters and picks
  * With DTOs (Data Transer Objects)
  * More
* Datatables
* User Roles
  * Admin can create players / characters while guests can not
* Authentication
  * **Admin** Email: `admin@wow.com` - Password: `admin&PW420HELP`
  * **Guest** Email: `guest@wow.com` - Password: `guest&PW420HELP` or create your own
* Tried to minify security holes
  * Anti-forgery
  * Secure API requests
  
### Migrations  
Built with the help of migrations  
To build the basic DB:  

```
Enable-Migrations
Update-Database
```  

If this does not work, try the script I generated: [Link to Script](https://hastebin.com/gumobenoxo.md)
Should be able to deploy to autogenix server.
