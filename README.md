
# BackendExamHub Submission

## Project Structure
```
BackendExamHub/
├── Controllers/
│   └── Myoffice_ACPDController.cs
├── SQL/
│   ├── TSQL_Myoffice_ACPD.sql
│   ├── TSQL_Myoffice_ExcuteionLog.sql
│   ├── usp_AddLog.sql
│   ├── NewSID.sql
├── README.md
├── BackendExamHub.sln
├── appsettings.json
```

## Setup Instructions
1. Clone the repository:
   ```bash
   git clone <repository_url>
   ```

2. Open `BackendExamHub.sln` in Visual Studio.

3. Configure the connection string in `appsettings.json`:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=<YourServer>;Database=BackendExamHub;User Id=<YourUser>;Password=<YourPassword>;"
   }
   ```

4. Execute the SQL scripts in the `SQL` folder in the following order:
   - `TSQL_Myoffice_ACPD.sql`
   - `TSQL_Myoffice_ExcuteionLog.sql`
   - `usp_AddLog.sql`
   - `NewSID.sql`

5. Run the application and use Swagger to test the API endpoints.

## API Endpoints
- **Base URL:** `https://localhost:<port>/api/Myoffice_ACPD`
- **Endpoints:**
  - `GET /api/Myoffice_ACPD` - Retrieve all records.
  - `POST /api/Myoffice_ACPD` - Insert a new record (JSON body required).
  - `PUT /api/Myoffice_ACPD` - Update an existing record (JSON body required).
  - `DELETE /api/Myoffice_ACPD/{id}` - Delete a record by ID.
