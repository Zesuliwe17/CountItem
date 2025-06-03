# CountItem

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
