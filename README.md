# .NET Core WebApi Sample with Swagger

This repo contains a simple TeleHealth Backend for the TeleHealth application.

This repository contains a controller which is dealing with Patients. You can GET/POST/PUT/PATCH and DELETE them.

## Versions

`https://localhost:5001/swagger/index.html`

## GET all Patients

`https://localhost:5001/api/Patient`

![ASPNETCOREWebAPIGET](./.github/get.jpg)

## GET a single patient

`https://localhost:5001/api/Patient/baaedfbf-5f71-4922-656b-08d932e8c309`

## Database Setup

For the database setup, I used a docker MS SQL instance to create and use a DB. The connection string for the config that I used can be found in the appsettings.json file.
