# OpenAPI Fake BRP
![travis build](https://travis-ci.org/sjefvanleeuwen/openapi-brp-fake.svg?branch=master)

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

## Metrics

API Metrics can be readched at:
* [METRICS](http://localhost:5080/metrics) - Metrics JSON data

For example:
```JSON
{
  "timestamp": "2018-09-09T10:35:28.3977549Z",
  "contexts": [
    {
      "context": "Application.HttpRequests",
      "apdexScores": [
        {
          "name": "Apdex|server:serverX,app:Org.OpenAPITools,env:development",
          "frustrating": 0,
          "sampleSize": 0,
          "satisfied": 0,
          "score": 1.0,
          "tolerating": 0,
          "tags": {
            "server": "serverX",
            "app": "Org.OpenAPITools",
            "env": "development"
          }
        }
      ],
      "counters": [
        {
          "name": "Active|server:serverX,app:Org.OpenAPITools,env:development",
          "unit": "Active Requests",
          "count": 0,
          "items": [],
          "tags": {
            "server": "serverX",
            "app": "Org.OpenAPITools",
            "env": "development"
          }
        },
        {
          "name": "Errors|http_status_code:304,server:serverX,app:Org.OpenAPITools,env:development",
          "unit": "err",
          "count": 1,
          "items": [],
          "tags": {
            "http_status_code": "304",
            "server": "serverX",
            "app": "Org.OpenAPITools",
            "env": "development"
          }
        }
      ],
      "gauges": [
        {
          "name": "One Minute Error Percentage Rate Per Endpoint|route:GET,server:serverX,app:Org.OpenAPITools,env:development",
          "unit": "req",
          "value": "NaN",
          "tags": {
            "route": "GET",
            "server": "serverX",
            "app": "Org.OpenAPITools",
            "env": "development"
          }
        },
        {
          "name": "One Minute Error Percentage Rate|server:serverX,app:Org.OpenAPITools,env:development",
          "unit": "req",
          "value": 19.629179811906724,
          "tags": {
            "server": "serverX",
            "app": "Org.OpenAPITools",
            "env": "development"
          }
        }
      ],
      "histograms": [],
      "meters": [
        {
          "name": "Error Rate Per Endpoint And Status Code|route:GET,http_status_code:304,server:serverX,app:Org.OpenAPITools,env:development",
          "unit": "req",
          "count": 1,
          "fifteenMinuteRate": 11.606593205784071,
          "fiveMinuteRate": 10.858049016431513,
          "items": [],
          "meanRate": 1.6737163945245745,
          "oneMinuteRate": 7.2783679165516029,
          "rateUnit": "min",
          "tags": {
            "route": "GET",
            "http_status_code": "304",
            "server": "serverX",
            "app": "Org.OpenAPITools",
            "env": "development"
          }
        },
        {
          "name": "Error Rate Per Endpoint|route:GET,server:serverX,app:Org.OpenAPITools,env:development",
          "unit": "req",
          "count": 1,
          "fifteenMinuteRate": 11.606593205784071,
          "fiveMinuteRate": 10.858049016431513,
          "items": [],
          "meanRate": 1.6734288381814635,
          "oneMinuteRate": 7.2783679165516029,
          "rateUnit": "min",
          "tags": {
            "route": "GET",
            "server": "serverX",
            "app": "Org.OpenAPITools",
            "env": "development"
          }
        },
        {
          "name": "Error Rate|server:serverX,app:Org.OpenAPITools,env:development",
          "unit": "req",
          "count": 1,
          "fifteenMinuteRate": 11.606593205784071,
          "fiveMinuteRate": 10.858049016431513,
          "items": [],
          "meanRate": 1.6729329874181504,
          "oneMinuteRate": 7.2783679165516029,
          "rateUnit": "min",
          "tags": {
            "server": "serverX",
            "app": "Org.OpenAPITools",
            "env": "development"
          }
        }
      ],
      "timers": [
        {
          "name": "Transactions Per Endpoint|route:GET,server:serverX,app:Org.OpenAPITools,env:development",
          "unit": "req",
          "activeSessions": 0,
          "count": 0,
          "durationUnit": "ms",
          "histogram": {
            "lastValue": 0.0,
            "max": 0.0,
            "mean": 0.0,
            "median": 0.0,
            "min": 0.0,
            "percentile75": 0.0,
            "percentile95": 0.0,
            "percentile98": 0.0,
            "percentile99": 0.0,
            "percentile999": 0.0,
            "sampleSize": 0,
            "stdDev": 0.0,
            "sum": 0.0
          },
          "rate": {
            "fifteenMinuteRate": 0.0,
            "fiveMinuteRate": 0.0,
            "meanRate": 0.0,
            "oneMinuteRate": 0.0
          },
          "rateUnit": "min",
          "tags": {
            "route": "GET",
            "server": "serverX",
            "app": "Org.OpenAPITools",
            "env": "development"
          }
        },
        {
          "name": "Transactions|server:serverX,app:Org.OpenAPITools,env:development",
          "unit": "req",
          "activeSessions": 0,
          "count": 6,
          "durationUnit": "ms",
          "histogram": {
            "lastValue": 767.123301,
            "max": 767.123301,
            "mean": 303.10469144514923,
            "median": 394.628816,
            "min": 17.988464999999998,
            "percentile75": 479.0546,
            "percentile95": 767.123301,
            "percentile98": 767.123301,
            "percentile99": 767.123301,
            "percentile999": 767.123301,
            "sampleSize": 6,
            "stdDev": 289.79297897924232,
            "sum": 1730.0413919999999
          },
          "rate": {
            "fifteenMinuteRate": 58.097986773339386,
            "fiveMinuteRate": 54.475795926985121,
            "meanRate": 9.676341058506905,
            "oneMinuteRate": 37.079327747238167
          },
          "rateUnit": "min",
          "tags": {
            "server": "serverX",
            "app": "Org.OpenAPITools",
            "env": "development"
          }
        }
      ]
    },
    {
      "context": "OpenAPI BRP Fake",
      "apdexScores": [],
      "counters": [],
      "gauges": [],
      "histograms": [],
      "meters": [],
      "timers": [
        {
          "name": "RaadpleegIngeschrevenPersoonNAW|server:serverX,app:Org.OpenAPITools,env:development",
          "unit": "items",
          "activeSessions": 0,
          "count": 1,
          "durationUnit": "ms",
          "histogram": {
            "lastValue": 377.98471,
            "max": 377.98471,
            "mean": 377.98471,
            "median": 377.98471,
            "min": 377.98471,
            "percentile75": 377.98471,
            "percentile95": 377.98471,
            "percentile98": 377.98471,
            "percentile99": 377.98471,
            "percentile999": 377.98471,
            "sampleSize": 1,
            "stdDev": 0.0,
            "sum": 377.98471
          },
          "rate": {
            "fifteenMinuteRate": 0.00019560457449692014,
            "fiveMinuteRate": 0.00018710139700632352,
            "meanRate": 4.0376090571666718E-05,
            "oneMinuteRate": 0.0001433062621147579
          },
          "rateUnit": "ms",
          "tags": {
            "server": "serverX",
            "app": "Org.OpenAPITools",
            "env": "development"
          }
        }
      ]
    }
  ]
}
```


## Built With

* [VSCODE](https://code.visualstudio.com/) - The IDE used
* [DOCKER](https://www.docker.com/) - Build, Ship, and Run Any App, Anywhere

## Contributing

Pull requests are accepted

## Authors

* **Sjef van Leeuwen** - *Initial work* - [github](https://github.com/sjefvanleeuwen)

## License

This project is licensed under the GPL-V3 License - see the [LICENSE.md](LICENSE.md) file for details