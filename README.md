# Employment Verification Web Application

This project is a simple employment verification web application consisting of a frontend built with Angular and a backend API built with ASP.NET Core. The application allows users to verify employment details for a given employee by entering the employee's ID, company name, and verification code.

## Features

- Frontend:
  - A form to accept Employee ID, Company Name, and Verification Code.
  - Submits data to the backend for verification.
  - Displays the verification result (either "Verified" or "Not Verified").

- Backend:
  - API endpoint for verifying employee details (`POST /api/verify-employment`).
  - In-memory data store with a few prepopulated employee records.
  - Validates input data and responds with verification status.

## Project Structure

- **Frontend (Angular)**:
  - `src/app/employment-verification-form/`: Contains the component responsible for the employment verification form.
  - Communicates with the backend API for employment verification.

- **Backend (ASP.NET Core)**:
  - `Controllers/EmploymentVerificationController.cs`: Handles API requests for verifying employment details.
  - `Models/Employee.cs`: Represents the employee data model.
  - `Program.cs' Configures and runs the ASP.NET Core API.

## Assumptions

- The API uses an in-memory data store with a few prepopulated employee records. These records include Employee ID, Company Name, and Verification Code.
- The API is accessible locally at `https://localhost:5000`.
- CORS is enabled to allow the Angular frontend to communicate with the ASP.NET Core backend.

## Build abd Run

**Run the Angular application**: 
ng serve 
The Angular application should now be running on http://localhost:4200.

**Run the Backend(ASP.NET Core Web API)** :
dotnet run
The backend API should now be running at https://localhost:5000.


**Running the Application**
Open your browser and navigate to http://localhost:4200.
Enter the employee details (Employee ID, Company Name, and Verification Code) in the form.
Submit the form to check if the employee details are verified. The result will be displayed on the same page.
Example Employee Data

Employee 1:
Employee ID: 1   Company Name: Cisive   Verification Code: ABC123

Employee 2: 
Employee ID: 2   Company Name: Star  Verification Code: DEF456

Employee 3:
Employee ID: 3   Company Name: TCS   Verification Code: GHI789

Employee 4:
Employee ID: 4   Company Name: Google   Verification Code: CBA321






















