package com.example.weatherapp;

import androidx.appcompat.app.AppCompatActivity;

import android.app.DownloadManager;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

import com.android.volley.RequestQueue;
import com.android.volley.Response;

import org.json.JSONException;
import org.json.JSONObject;

public class MainActivity extends AppCompatActivity {

    private TextView textLocation;
    private TextView textTemperature;
    private TextView textHumidity;
    private TextView textWindSpeed;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        textLocation = findViewById(R.id.text_location);
        textTemperature = findViewById(R.id.text_temperature);
        textHumidity = findViewById(R.id.text_humidity);
        textWindSpeed = findViewById(R.id.text_wind_speed);

        Button buttonRefresh = findViewById(R.id.button_refresh);
        buttonRefresh.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                fetchWeatherForecast();
            }
        });

        fetchWeatherForecast();
    }

    private void fetchWeatherForecast() {
        String url = "https://api.open-meteo.com/v1/forecast?latitude=52.52&longitude=13.41&current_weather=true&hourly=temperature_2m,relativehumidity_2m,windspeed_10m";
        JsonObjectRequest request = new JsonObjectRequest(DownloadManager.Request.Method.GET, url, null, new Response.Listener<JSONObject>() {
            @Override
            public void onResponse(JSONObject response) {
                try {
                    WeatherForecast weatherForecast = new WeatherForecast();
                    weatherForecast.setTemperature(response.getJSONArray("temperature_2m").getDouble(0));
                    weatherForecast.setHumidity(response.getJSONArray("relativehumidity_2m").getDouble(0));
                    weatherForecast.setWindSpeed(response.getJSONArray("windspeed_10m").getDouble(0));

                    textLocation.setText("Berlin"); // Set location name here
                    textTemperature.setText("Temperature: " + weatherForecast.getTemperature() + "°C");
                    textHumidity.setText("Humidity: " + weatherForecast.getHumidity() + "%");
                    textWindSpeed.setText("Wind Speed: " + weatherForecast.getWindSpeed() + "m/s");
                } catch (JSONException e) {
                    e.printStackTrace();
                }
            }
        }, new Response.ErrorListener() {
            @Override
            public void onErrorResponse(VolleyError error) {
                Toast.makeText(MainActivity.this, "Error fetching weather forecast", Toast.LENGTH_SHORT).show();
            }
        });

        RequestQueue queue = Volley.newRequestQueue(this);
        queue.add(request);
    }
}
