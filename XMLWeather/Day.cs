using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLWeather
{
    public class Day
    {
        public string date, currentTemp, feelsLikeTemp, condition, location, country, tempHigh, tempLow, 
            windSpeed, windDirection, visibility, sunrise, sunset, symbol, precipProb, precipType, precipAmount, humidity, lastUpdated;
        public Day()
        {
            date = currentTemp = feelsLikeTemp = condition = location = country = tempHigh = tempLow
                = windSpeed = windDirection = visibility = sunrise = sunset = symbol = precipProb 
                = precipType = precipAmount = humidity = lastUpdated = "";
        }
    }
}
