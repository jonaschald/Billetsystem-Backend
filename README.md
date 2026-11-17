# Husk at lave din MariaDb docker
Kør denne linje i din terminal
```
docker run --detach -p 3306:3306 --name billet_db --env MARIADB_ROOT_PASSWORD=root mariadb:latest
```
Derefter tilknyt dig til din database i Rider og kør denne linje i konsolen
```
create database billet_db
```
