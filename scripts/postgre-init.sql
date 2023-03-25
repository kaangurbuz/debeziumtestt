CREATE TABLE Product
(
    "Id" integer NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
    "Code" uuid NOT NULL,
    "Title" character varying COLLATE pg_catalog."default" NOT NULL,
    "Price" double precision NOT NULL,
    "CreatedOnUtc" date NOT NULL,
    CONSTRAINT Product_pkey PRIMARY KEY ("Id")
)