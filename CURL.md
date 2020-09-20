insure the server is running by doing a curl command

```
curl -kv https://localhost/api/movies
```

fourth line from the bottom will be something like
HTTP/2 200

the -v flag is the verbose way of sending the request
the -k flag or alternatively --unsecure allows the 