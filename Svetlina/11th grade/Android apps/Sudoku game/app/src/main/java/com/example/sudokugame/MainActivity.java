package com.example.sudokugame;

import static com.example.sudokugame.R.id.buttonDelete;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageButton;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {
    TextView[][] matrix = new TextView[9][9];
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        ImageButton deleteButton = findViewById(buttonDelete);
        ImageButton editButton = findViewById(R.id.buttonEdit);
        for (int row = 0; row < 9; row++){
            for (int col = 0; col < 9; col++){
                int id = getResources().getIdentifier(String.format("txt_%d_%d", row, col), "id", getPackageName());
                TextView current = findViewById(id);
                matrix[row][col] = current;

            }

        }
        deleteButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                for (int row = 0; row < 9; row++){
                    for (int col = 0; col < 9; col++){
                        matrix[row][col].setText("");
                    }
                }
            }
        });
        editButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                for (int row = 0; row < 9; row++){
                    for (int col = 0; col < 9; col++){
                        matrix[row][col].setText("1");
                    }
                }
            }
        });



    }
}