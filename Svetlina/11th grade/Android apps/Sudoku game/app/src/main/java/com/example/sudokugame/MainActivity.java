package com.example.sudokugame;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.TextView;
import android.widget.Toast;

import java.util.HashSet;

public class MainActivity extends AppCompatActivity {
    TextView[][] sudokuMatrix = new TextView[9][9];
    TextView[] keypadButtons = new TextView[9];
    boolean hasCurrentlySelected = false;
    TextView currentlySelected = null;
    String currentTextStorage = "";
    int[][] sudokuValues = new int[9][9];
    boolean[][] isFixed = new boolean[9][9];
    int currentRow;
    int currentCol;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        for (int row = 0; row < 9; row++) {
            for (int col = 0; col < 9; col++) {
                int id = getResources().getIdentifier(String.format("txt_%d_%d", row, col), "id", getPackageName());
                final TextView current = findViewById(id);
                sudokuMatrix[row][col] = current;
                final int currentRow = row;
                final int currentCol = col;
                isFixed[row][col] = false;
                int finalRow = row;
                int finalCol = col;
                current.setOnClickListener(new View.OnClickListener() {
                    @Override
                    public void onClick(View view) {
                        final int currentRow = finalRow;
                        final int currentCol = finalCol;
                        if (!isFixed[currentRow][currentCol]) {
                            if (!hasCurrentlySelected) {
                                currentlySelected = current;
                                currentTextStorage = current.getText().toString();
                                current.setBackgroundColor(9489401);
                                hasCurrentlySelected = true;
                            } else {
                                currentlySelected.setBackgroundColor(16777215);
                                currentlySelected = current;
                                currentTextStorage = current.getText().toString();
                                current.setBackgroundColor(9489401);
                            }
                        }
                    }
                });

            }
        }
        for (int i = 1; i <= 9; i++) {
            int id = getResources().getIdentifier(String.format("btn_%d", i), "id", getPackageName());
            final TextView current = findViewById(id);
            keypadButtons[i - 1] = current;
            current.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View view) {
                    if (hasCurrentlySelected) {
                        int value = Integer.parseInt(current.getText().toString());                        if (isValidMove(currentRow, currentCol, value)) {
                            sudokuValues[currentRow][currentCol] = value;
                            currentlySelected.setText(current.getText());
                            hasCurrentlySelected = false;
                            currentlySelected.setBackgroundColor(16777215);
                            checkSudoku();
                        }
                    }
                }
            });
        }
        View editKey = findViewById(getResources().getIdentifier("btn_edit", "id", getPackageName()));
        editKey.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (hasCurrentlySelected) {
                    hasCurrentlySelected = false;
                    currentlySelected.setBackgroundColor(16777215);
                }
            }
        });
        View deleteKey = findViewById(getResources().getIdentifier("btn_delete", "id", getPackageName()));
        deleteKey.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (hasCurrentlySelected) {
                    sudokuValues[currentRow][currentCol] = 0;
                    currentlySelected.setText("");
                    hasCurrentlySelected = false;
                    currentlySelected.setBackgroundColor(16777215);
                }
            }
        });
    }

    private boolean isValidMove(int row, int col, int value) {
        for (int i = 0; i < 9; i++) {
            if (sudokuValues[row][i] == value) {
                return false;
            }
        }
        for (int i = 0; i < 9; i++) {
            if (sudokuValues[i][col] == value) {
                return false;
            }
        }
        int subgridRow = row / 3 * 3;
        int subgridCol = col / 3 * 3;
        for (int i = subgridRow; i < subgridRow + 3; i++) {
            for (int j = subgridCol; j < subgridCol + 3; j++) {
                if (sudokuValues[i][j] == value) {
                    return false;
                }
            }
        }
        return true;
    }

    private void checkSudoku() {
        boolean solved = true;
        for (int i = 0; i < 9; i++) {
            for (int j = 0; j < 9; j++) {
                if (sudokuValues[i][j] == 0) {
                    solved = false;
                    break;
                }
            }
        }
        if (solved) {
            for (int i = 0; i < 9; i++) {
                HashSet<Integer> rows = new HashSet<>();
                HashSet<Integer> cols = new HashSet<>();
                HashSet<Integer> subgrids = new HashSet<>();
                for (int j = 0; j < 9; j++) {
                    if (!rows.add(sudokuValues[i][j])) {
                        solved = false;
                        break;
                    }
                    if (!cols.add(sudokuValues[j][i])) {
                        solved = false;
                        break;
                    }
                    int subgridRow = (i / 3) * 3 + j / 3;
                    int subgridCol = (i % 3) * 3 + j % 3;
                    if (!subgrids.add(sudokuValues[subgridRow][subgridCol])) {
                        solved = false;
                        break;
                    }
                }
            }
        }
        if (solved) {
            Toast.makeText(this, "Sudoku solved!", Toast.LENGTH_SHORT).show();
        }
    }
}