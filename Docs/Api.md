# Portfolio API

![RestApi](https://img.shields.io/badge/Rest-Api-red) ![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-7.0-purple)

- [Portfolio API](#portfolio-api)
  - [Auth](#auth)
    - [Register](#register)
      - [Register Request](#register-request)
      - [Register Response](#register-response)
    - [Login](#login)
      - [Login Request](#login-request)
      - [Login Response](#login-response)

## Auth
<hr>
<br/>

### Register

```js
POST /auth/register
```

#### Register Request

```json
{
    "FirstName": "Chad",
    "LastName": "Powell",
    "Email": "test@test.com",
    "Password": "password"
}
```

#### Register Response

```js
200 OK
```

```json
{
    "id": "68d4eac9-709f-4466-9e7f-44d67ae41b44", 
    "FirstName": "Chad",
    "LastName": "Powell",
    "Email": "test@test.com",
    "Token": "BIx5h9FikocADkfH4LGODxovq3Kz7129HrbwoO0ui0jx1Hb1irf1rL6tLqwP4wfp7rRumEXp6r1i6TcfrZ8vbFXz6OXt6hu8d3JAllKjcEaG5hLj7QA9tMDGz7f55Cz6IO7t2CsCqxlWVddh1oqRWPhUhvZwvycj87bwShkGGX4w17QwdIAzk7T0T4lRPF0W8rK5HyyKeIwyOYytA06Jz3BKXdmm05bCM8ocXpWY8cyhWV6HsAGjZfuMVB01MUws"
}
```

### Login

```js
POST /auth/login
```

#### Login Request

```json
{
    "email": "test@test.com",
    "password": "password"
}
```

#### Login Response

```js
200 OK
```

```json
{
    "id": "68d4eac9-709f-4466-9e7f-44d67ae41b44", 
    "firstName": "Chad",
    "lastName": "Powell",
    "email": "test@test.com",
}
```