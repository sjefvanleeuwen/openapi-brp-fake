# OpenAPI Fake BRP
![travis build](https://travis-ci.com/sjefvanleeuwenopen/api-brp-fake.svg?branch=master)

Provides an OpenAPI service that serves a fake BRP (Basisregistratie Personen) implementation. The implementation will generate fake addresses, names based on random seed derived from a BSN (Burger Service Nummer / Social Security Number).

The goal of this service is to be able to model government processes around it that use this during an upcoming VNG fieldlab in Zwolle end September 2018.

More information on the model used for BRP can be found at: 
https://github.com/Drechtsteden/API

## Status of this project

This fake BRP has some very basic functionality:

* No Elf-Proof on BSN's
* No valid date / ranges
* Basic person information, no sibblings etc.
* Basic address information
* Currently the system is set statically to one municipality: Haarlem
* No JWT Bearer tokens for auth.
* Still needs to be integrated with NLX

## Building Docker Images

```
docker-compose up --build -d
```

## Pulling / Running from docker cloud


```
docker pull wigo4it/openapi-brp-fak
docker run -p 5080:8080 wigo4it/openapi-brp-fake
```
The API can now be reached at:

* [SWAGGER](http://localhost:5080/swagger) - Swagger API documentation page

Adjust expose of port 5080 to another one as needed for your own environment

## Built With

* [VSCODE](https://code.visualstudio.com/) - The IDE used
* [DOCKER](https://www.docker.com/) - Build, Ship, and Run Any App, Anywhere

## Contributing

Pull requests are accepted

## Authors

* **Sjef van Leeuwen** - *Initial work* - [github](https://github.com/sjefvanleeuwen)

## License

This project is licensed under the GPL-V3 License - see the [LICENSE.md](LICENSE.md) file for details