package com.example.register_login_view;

import android.os.Bundle;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;

public class ShowDataActivity extends AppCompatActivity {
    private TextView textViewEmail;
    private TextView textViewPassword;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_view);

        textViewEmail = findViewById(R.id.textViewEmail);
        textViewPassword = findViewById(R.id.textViewPassword);

        String email = getIntent().getStringExtra("email");
        String password = getIntent().getStringExtra("password");

        textViewEmail.setText(email);
        textViewPassword.setText(password);
    }
}
