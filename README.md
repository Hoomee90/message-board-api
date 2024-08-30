# Message Board API

#### By **Samantha Callie**

#### See below for documentation

## Technologies Used

* C#
* SQL
* ASP.NET Core
* EF Core
* Swagger

## Description

This api allows users to create and manage messages and boards in a database. They can get, post, put and delete as much as they want through interfacing with the api.

## Setup/Installation Requirements

1. Press the green <> Code button and select Download ZIP
2. Unzip file
3. Open your terminal (e.g., Terminal or GitBash) and navigate to this project's production directory called "MessageBoard".
4. Within that directory, create a file called `appsettings.json`
5. In `appsettings.json`, paste the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL.
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=message_board;uid=YOUR_USERNAME;pwd=YOUR_PASSWORD;"
  }
}
```
6. To create the database, execute `dotnet ef database update` in the command line (still in the production directory)
7. Now run the command `dotnet run` to compile and execute the application. Then on navigate to https://localhost:612/swagger/index.html.
8. Alternatively, after running it you can use something like Postman to interface with the API

## Known Bugs

* Formatting issues for the parameter of message GET requests do not yet return accurate HTTP response status codes 

# Documentation
I tried my best!
## Endpoints:
GET http://localhost:5000/api/Messages/

GET http://localhost:5000/api/Messages/{id}

POST http://localhost:5000/api/Messages/

PUT http://localhost:5000/api/Messages/{id}

DELETE http://localhost:5000/api/Messages/{id}

---
GET http://localhost:5000/api/Boards/

GET http://localhost:5000/api/Boards/{id}

POST http://localhost:5000/api/Boards/

PUT http://localhost:5000/api/Boards/{id}

DELETE http://localhost:5000/api/Boards/{id}

## Parameters for Message GET:
| Parameter| Type | Required | Description 
| -------- | ---- | -------- | ----------
| BoardId  | Number | Not required | Returns messages from only that board
| page | Number  | Not required | Returns a page of five messages
| startDate    | DateTime | Not required | Returns messages sent only before that date
| endDate    | DateTime | Not required | Returns messages sent only before that date

## Parameters For Message PUT and DELETE:
| Parameter| Type | Required | Description 
| -------- | ---- | -------- | ----------
| username  | String | Required | Request will only go through if the inputted username matches the username value of the message |

## Additional Requirements for POST Request

When making a POST request to http://localhost:5000/api/Messages/, you need to include a body. Here's an example body in JSON:

```json
{
  "username": "Matilda",
  "content": "Woolly Mammoth",
  "postedOn": "2018-08-18T07:22:16",
  "boardId": 1
}
```
## Additional Requirements for PUT Request
When making a PUT request to http://localhost:5000/api/Messages/{id}, you need to include a body that includes the Message's MessageId property. Here's an example body in JSON:

```json
{
    "messageId": 2,
    "username": "Hoomee90",
    "content": "Videogames rock",
    "postedOn": "2024-08-28T22:31:18.174",
    "boardId": 7
  },
```

And here's the PUT request we would send the previous body to:

http://localhost:5000/api/Messages/2

Notice that the value of MessageId needs to match the id number in the URL. In this example, they are both 1.

Both of these additional requirements are the same for the board endpoints

## License

MIT License

Copyright (c) 2024 Samantha Callie

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.