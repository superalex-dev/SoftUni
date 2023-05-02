package com.example.weatherapp;

public class Weather {
    private String cityName;
    private MainWeatherData mainData;
    private WindData windData;

    public String getCityName() {
        return cityName;
    }

    public MainWeatherData getMainData() {
        return mainData;
    }

    public WindData getWindData() {
        return windData;
    }
}