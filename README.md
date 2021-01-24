# Author
Create authors, create books with attached author name, view and filter books by author name and book title.

A two-tier system. Business logic and data logic are both in the second tier.
For the client side Blazor was used to create the pages for creating authors, creating books and viewing books.
ASP.NET framework was used to create a RESTful web service to allow the communication of the presentation tier with the second tier. 
With LINQ a connection to the SQL database was made. 
In the database exists a table for authors and a table for books that has a many to one relationship to authors.
