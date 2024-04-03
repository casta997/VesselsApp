# CRUD on Vessel table

This repository serves as a starting point for a practical development test. 

The project includes an empty Windows Form project and a SQLite database containing only a `Vessel` table. 

The objective of this test is to implement CRUD (Create, Read, Update, Delete) operations for the Vessel table within the Windows Form application.

## Instructions

1. Clone this repository to your local machine.

2. Open the Windows Form project located in the repository.

3. Configure the project to connect to the SQLite database included in the repository. The database file is located in the `Database` folder and is named `msc.db`. You'll need to set up the necessary SQLite connection in your Windows Form application.

### Implement the following functionalities within the Windows Form application:

1. Create: Add functionality to insert new records into the Vessel table.

2. Read: Add functionality to display all vessels from the Vessel table within the WinForm page.

3. Update: Add functionality to modify existing records in the Vessel table.

4. Delete: Add functionality to delete records from the Vessel table.

Test the implemented functionalities to ensure they operate correctly.

--- 

Once completed, commit your changes to the repository.

--- 

## Structure of the `Vessel` Table
The `Vessel` table in the SQLite database has the following structure:

```sql
CREATE TABLE Vessel (
    id INTEGER PRIMARY KEY,
    name TEXT NOT NULL,
    type TEXT,
    flag TEXT,
    owner TEXT,
    is_active BOOLEAN DEFAULT 1
);
```
The table contains the following fields:
```
id: Unique identifier of the vessel.
name: Name of the vessel.
type: Type of the vessel.
flag: Flag of the vessel.
owner: Owner of the vessel.
is_active: Indicates whether the vessel is active or not.
```
