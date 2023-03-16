FROM postgis/postgis:12-2.5-alpine
ENV POSTGRES_USER db
ENV POSTGRES_DEB db
ENV POSTGRES_PASSWORD db
ENV ALLOW_IP_RANGE=0.0.0.0/0
EXPOSE 5432
#this is very empty right now but it will at least spin up a container
