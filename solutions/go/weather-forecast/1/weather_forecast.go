// Package weather provides weather-related functionalities.
package weather

// CurrentCondition holds the current weather condition.
var CurrentCondition string
// CurrentLocation holds the current location.
var CurrentLocation string

// Forecast returns a formatted string describing the current weather condition for a given city.
func Forecast(city, condition string) string {
	return city + " - current weather condition: " + condition
}
