package com.example.weatherapp;

import retrofit2.Call;
import retrofit2.http.GET;
import retrofit2.http.Query;

public interface WeatherApiService {
    @GET("weather")
    Call<WeatherApiResponse> getWeatherData(
            @Query("q") String cityName,
            @Query("appid") String apiKey
    );
}