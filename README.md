# Data Storage API

Implemented a small HTTP service to store objects organized by repository.
Clients of this service are able to GET, PUT, and DELETE objects.

## API

### Upload an Object

```
PUT /data/{repository}
{binary object data}
```

#### Response

```
Status: 201 Created
{
  "oid": "2845f5a412dbdfacf95193f296dd0f5b2a16920da5a7ffa4c5832f223b03de96",
  "size": 1234
}
```

### Download an Object

```
GET /data/{repository}/{objectID}
```

#### Response

```
Status: 200 OK
{binary object data}
```

Objects that are not on the server will return a `404 Not Found`.

### Delete an Object

```
DELETE /data/{repository}/{objectID}
```

#### Response

```
Status: 200 OK
```

## Creating The Database

- Run `Update-Database` in Package-Manager-Console
  - Ensure the selected project with Package-Manager-Console is `data\DataStorage.EF`.
  - You may also need to change the connection string within `DataStorageContext.cs`.