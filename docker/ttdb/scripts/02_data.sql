COPY movies(no, name, releasedate, mainactor)
FROM '../data/timetravelmovies.csv'
DELIMITER ','
CSV HEADER;