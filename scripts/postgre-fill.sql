CREATE EXTENSION IF NOT EXISTS "uuid-ossp";

INSERT INTO public."Product" ("Code", "Title", "Price", "CreatedOnUtc") VALUES
(uuid_generate_v1(), 'Test Product 1', 100, NOW()),
(uuid_generate_v1(), 'Test Product 2', 200, NOW()),
(uuid_generate_v1(), 'Test Product 3', 300, NOW()),
(uuid_generate_v1(), 'Test Product 4', 400, NOW()),
(uuid_generate_v1(), 'Test Product 5', 500, NOW())