# Count Items API
A .NET Web API that provides functionality to count occurrences of items in a list.  
The API uses a generic counting class to support counting any item type that can be used as a dictionary key, with a RESTful POST endpoint to count string items.

## Features

- Generic item counting functionality via `ItemCounter<T>` class  
- Single `/count` POST endpoint for counting occurrences in a list of strings  
- RESTful API design  
- Swagger documentation enabled in development environment  
- Basic handling for null or empty input lists

## Getting Started

### Prerequisites

- .NET 8 SDK installed  
- A tool to test the API (Postman, curl, or similar)

### Running the API locally

1. Clone the repository:  
   ```bash
   git clone https://github.com/Zesuliwe17/CountItemAPI.git
   cd CountItemAPI
   
2. Build the project:

bash: 
dotnet build

3. Run the API:

bash: 
dotnet run

4. Access Swagger UI (if in development mode) at:

bash

https://localhost:5001/swagger


Using the API 

POST /count

Send a JSON array of string items, and receive a JSON object with counts.

Example request body:

json
Copy
Edit
["apple", "banana", "apple", "orange", "banana", "apple"]
Example response:

json
Copy
Edit
{
  "apple": 3,
  "banana": 2,
  "orange": 1
}
Project Structure
ItemCounter.cs: Generic class for counting occurrences of items.

Program.cs: API setup with endpoints and Swagger configuration.

Controllers/CountController.cs (if applicable): API controller logic.

Technologies Used
ASP.NET Core 8

C#

Swagger for API documentation

Created by Zesuliwe17

Feel free to open issues or pull requests on GitHub for improvements or feedback.
