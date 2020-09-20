CREATE TABLE Movies(
   no serial PRIMARY KEY,
   name VARCHAR (50) UNIQUE NOT NULL,
   releasedate INT NOT NULL,
   mainactor VARCHAR (50) NOT NULL
);
