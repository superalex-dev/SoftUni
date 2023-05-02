package com.example.weatherapp;

import com.google.gson.annotations.SerializedName;

public class WeatherApiResponse {
    @SerializedName("name")
    private String cityName;

    @SerializedName("main")
    private WeatherData weatherData;

    public String getCityName() {
        return cityName;
    }

    public WeatherData getWeatherData() {
        return weatherData;
    }

    public class WeatherData {
        @SerializedName("temp")
        private double temperature;

        @SerializedName("humidity")
        private double humidity;

        public double getTemperature() {
            return temperature;
        }

        public double getHumidity() {
            return humidity;
        }
    }
}
