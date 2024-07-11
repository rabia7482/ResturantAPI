# ResturantAPI
RABIATU SHAFIU IDRIS
BU/22C/IT/7482
## Description

FoodAPI is an ASP.NET Core Web API that manages dishes and menus.It allows users to create,read,update,and delete records for dishes and menus.The purpose of this API is to provide a simple interface for managing Food-related data.

## how to Run
open in visual studio 2022 and run

Examples:GEt all dishes
      GET /api/dishes
Response:
[
    {
        "id": 0,
        "name": "Spaghetti",
        "price": 2000,
        "isVegetarian": true
    },
    GET /api/dishes/1
Response:
{
    "id": 1,
    "name": "Spaghetti"
    "price": 2000,
    "isVegetarian": true
}
 POST /api/dishes
Request Body:
{
    "name": "Caesar Salad",
    "price": 10000,
    "isVegetarian": true
}
Response:
{
    "id": 3,
    "name": "Caesar Salad",
    "price": 10000,
    "isVegetarian": true
}
 PUT /api/dishes/3
Request Body:
{
    "id": 3,
    "name": "Updated Caesar Salad",
    "price": 11000,
    "isVegetarian": true
}
DELETE /api/dishes/3
GET /api/menus
Response:
[
    {
        "id": 1,
        "


  
