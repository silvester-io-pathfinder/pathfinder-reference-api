FROM postgres:13.2-alpine

ENV POSTGRES_DB database_pathfinder_reference
ENV POSTGRES_USER user_pathfinder_reference
ENV POSTGRES_PORT 5432
ENV POSTGRES_PASSWORD passwordPlaceholder

COPY seed.sql docker-entrypoint-initdb.d/seed.sql
CMD ["postgres"]