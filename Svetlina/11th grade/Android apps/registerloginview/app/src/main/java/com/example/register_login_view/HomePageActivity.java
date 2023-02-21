package com.example.register_login_view;

import android.os.Bundle;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;

public class HomePageActivity extends AppCompatActivity {

    private TextView textGreetings;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_homepage);

        textGreetings = findViewById(R.id.textGreetings);

        String email = getIntent().getStringExtra("email");

        textGreetings.setText("Welcome " + email + "!");


    }
}
