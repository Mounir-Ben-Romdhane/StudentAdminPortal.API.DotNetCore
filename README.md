# StudentAdminPortal.API.NetCore
- User Management: Administrators have the ability to create, update, and delete user accounts with different roles.
- This role-based access control ensures secure and controlled access to the application.
- Student Management: Authorized users can manage student records, including adding new students, updating their information, and deleting student profiles.
- This feature provides a comprehensive solution for organizing and maintaining student data.
- Authentication and Authorization: The backend implements JWT-based authentication to securely manage user login and access. Users receive a JWT token upon successful authentication, which is then used for subsequent API requests to validate their identity and permissions.
- Refresh Token Support: To enhance security and user experience, the backend supports refresh tokens. When a JWT token expires, users can request a new one using a refresh token without having to reauthenticate.
- API Endpoints: The backend exposes a set of RESTful API endpoints to handle user and student-related operations. These endpoints follow best practices for request handling, input validation, and response formatting.
- Database Integration: The backend is integrated with a SQL Server (or any other supported database) to store user and student data. It utilizes Entity Framework Core for data access and ORM (Object-Relational Mapping) capabilities, ensuring efficient and reliable data management.

Technology Stack:
Backend: .NET (C#), ASP.NET Web API, Entity Framework Core, JWT authentication, SQL Server(SSMS)
