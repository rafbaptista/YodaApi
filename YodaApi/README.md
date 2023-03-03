## About

Simple API that converts english sentences to the way Master Yoda speaks.

The solution also contains a test project that uses WireMock to perform integration tests with the API responsible for providing the data returned to the user.

The request made to the API is captured locally through a local HTTP server (WireMockServer), where validations and tests are performed.

## Installation and Usage
```bash
cd YodaApi/YodaApi
dotnet run
curl -k -X GET https://localhost:7274/translate/yoda?text=We%20are%20smaller%20in%20number%2C%20but%20larger%20in%20mind
```
You should get a response back like this:

```json
{
	"contents":  { 
		"text": "We are smaller in number, but larger in mind",
		"translated": "Smaller in number we are, but larger in mind"
	}
}
```