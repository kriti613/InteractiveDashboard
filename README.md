# Interactive Analytical Dashboard

## Project Overview

This project is an Interactive Analytical Dashboard designed to visualize data dynamically. It is built using HTML, CSS, and the Chart.js framework for the front end, with a SQL database backend connected through ASP.NET MVC. The dashboard allows users to interact with various data visualizations, offering insights and facilitating data-driven decisions.

## Features

- **Data Visualization:** The dashboard provides various interactive charts and graphs using the Chart.js framework.
- **Dynamic Data Interaction:** Users can filter, sort, and manipulate data on the dashboard to view specific metrics.
- **Responsive Design:** The dashboard is fully responsive, ensuring a seamless experience on all devices.
- **Backend Integration:** The data is fetched and managed from a SQL database, ensuring data integrity and consistency.
- **ASP.NET MVC Architecture:** The project follows the Model-View-Controller (MVC) architecture, promoting separation of concerns and making the application scalable and maintainable.

## Technologies Used

- **Frontend:**
  - HTML5
  - CSS3
  - Chart.js (for data visualization)
  
- **Backend:**
  - ASP.NET MVC (for handling server-side logic)
  - SQL (for database management)

## Setup Instructions

### Prerequisites

Before you begin, ensure you have the following installed:

- **.NET Framework**
- **SQL Server**
- **Visual Studio**

### Installation Steps

1. **Clone the Repository**
   ```bash
   git clone https://github.com/kriti613/InteractiveDashboard.git
   cd interactive-analytical-dashboard
   ```

2. **Open the Project in Visual Studio**
   - Navigate to the `.sln` file in the project directory and open it in Visual Studio.

3. **Set Up the Database**
   - Use SQL Server to create a new database.
   - Run the provided SQL scripts in the `Database` folder to set up the tables and populate them with data.

4. **Configure the Connection String**
   - Open the `web.config` file in the root directory.
   - Update the connection string to point to your SQL Server instance.

5. **Build and Run the Application**
   - Press `F5` in Visual Studio to build and run the application.

### Usage

Once the application is running:

- Navigate to the dashboard through the main menu.
- Interact with the various charts and data tables by applying filters and viewing different data sets.
- The dashboard will dynamically update based on user input, providing real-time data visualization.

## Project Structure

- **Controllers:** Handles user input and manages the flow of data between the model and the view.
- **Models:** Represents the data structure and business logic.
- **Views:** The presentation layer, including HTML, CSS, and Chart.js files.
- **Scripts:** Contains JavaScript and Chart.js code for handling client-side logic.
- **Database:** SQL scripts and connection strings to manage data storage.

