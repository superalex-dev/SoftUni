package com.example.weatherapp;

import retrofit2.Call;
import retrofit2.http.GET;
import retrofit2.http.Query;

public interface WeatherApi {
    @GET("weather")
    Call<Weather> getWeatherData(@Query("q") String cityName, @Query("appid") String apiKey);
}
