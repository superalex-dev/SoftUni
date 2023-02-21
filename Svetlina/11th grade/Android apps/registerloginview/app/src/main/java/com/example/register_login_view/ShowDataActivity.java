package com.example.register_login_view;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;

public class ShowDataActivity extends AppCompatActivity {
    private TextView textViewEmail;
    private TextView textViewPassword;
    private Button buttonReturn;

    private Button buttonConfirm;

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
        buttonReturn = findViewById(R.id.buttonReturn);
        buttonConfirm = findViewById(R.id.buttonConfirm);
        buttonReturn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(ShowDataActivity.this, MainActivity.class);
                startActivity(intent);
            }
        });

        buttonConfirm.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(ShowDataActivity.this, ConfirmActivity.class);
                startActivity(intent);
            }
        });
    }
}
