package com.example.weatherapp;

import androidx.appcompat.app.AppCompatActivity;

import android.os.AsyncTask;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.TextView;

import org.json.JSONException;
import org.json.JSONObject;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;

public class MainActivity extends AppCompatActivity {

    private EditText cityEditText;
    private TextView resultTextView;
    private RadioGroup unitsRadioGroup;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        cityEditText = findViewById(R.id.cityEditText);
            resultTextView = findViewById(R.id.resultTextView);
            unitsRadioGroup = findViewById(R.id.unitsRadioGroup);

            findViewById(R.id.searchButton).setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String cityName = cityEditText.getText().toString().trim();
                if (cityName.isEmpty()) {
                    cityEditText.setError("Please enter a city name");
                    return;
                }
                new GetWeatherTask().execute(cityName);
            }
        });

        findViewById(R.id.getWeatherButton).setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String cityName = cityEditText.getText().toString().trim();
                if (cityName.isEmpty()) {
                    cityEditText.setError("Please enter a city name");
                    return;
                }

                int selectedRadioButtonId = unitsRadioGroup.getCheckedRadioButtonId();
                String units = "imperial";
                if (selectedRadioButtonId == R.id.metricButton) {
                    units = "metric";
                }

                new GetWeatherTask().execute(cityName, units);
            }
        });
    }

    private class GetWeatherTask extends AsyncTask<String, Void, String> {

        @Override
        protected String doInBackground(String... params) {
            String cityName = params[0];
            String units = "imperial";
            if (params.length > 1) {
                units = params[1];
            }

            try {
                URL url = new URL(String.format("https://api.openweathermap.org/data/2.5/weather?q=%s&appid=615592e64a3088c21f7335f69f37655d&units=%s", cityName, units));
                HttpURLConnection connection = (HttpURLConnection) url.openConnection();

                BufferedReader reader = new BufferedReader(new InputStreamReader(connection.getInputStream()));

                StringBuilder json = new StringBuilder(1024);
                String tmp;
                while ((tmp = reader.readLine()) != null) {
                    json.append(tmp).append("\n");
                }
                reader.close();

                JSONObject data = new JSONObject(json.toString());

                // This value will be 404 if the request was not successful
                if (data.getInt("cod") != 200) {
                    return null;
                }

                String cityNameAndCountry = data.getString("name") + ", " + data.getJSONObject("sys").getString("country");

                JSONObject main = data.getJSONObject("main");

                String temperature = String.format("%.0f°", main.getDouble("temp"));
                String feelsLike = String.format("%.0f°", main.getDouble("feels_like"));
                String description = data.getJSONArray("weather").getJSONObject(0).getString("description");

                return cityNameAndCountry + "\nTemperature: " + temperature + "\nFeels like: " + feelsLike + "\nDescription: " + description;

            } catch (Exception e) {
                e.printStackTrace();
                return null;
            }
        }

        @Override
        protected void onPostExecute(String s) {
            super.onPostExecute(s);

            if (s == null) {
                resultTextView.setText("An error occurred. Please try again.");
            } else {
                resultTextView.setText(s);
            }
        }
    }
}
