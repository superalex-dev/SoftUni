package com.example.weeklymealplanner;

import android.os.Bundle;
import android.view.View;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import com.example.weeklymealplanner.R;
import com.google.android.material.floatingactionbutton.FloatingActionButton;

import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity {

    private RecyclerView mealPlannerRecyclerView;
    private MealPlannerAdapter mealPlannerAdapter;
    private List<MealSlot> mealSlots;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        // Set up the toolbar
        Toolbar toolbar = findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

        // Initialize the meal slots list
        mealSlots = new ArrayList<>();

        // Set up the RecyclerView
        mealPlannerRecyclerView = findViewById(R.id.mealPlannerRecyclerView);
        mealPlannerRecyclerView.setLayoutManager(new LinearLayoutManager(this));
        mealPlannerAdapter = new MealPlannerAdapter(mealSlots);
        mealPlannerRecyclerView.setAdapter(mealPlannerAdapter);

        // Set up the Floating Action Button
        FloatingActionButton addRecipeFab = findViewById(R.id.addRecipeFab);
        addRecipeFab.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                openRecipeSelectionDialog();
            }
        });
    }

    private void openRecipeSelectionDialog() {
        // Implement your recipe selection dialog logic here
        // This could involve presenting a dialog, showing a list of recipes, and handling user selection
        // When a recipe is selected, add it to the mealSlots list and update the adapter

        // Example:
        Recipe selectedRecipe = getSelectedRecipe(); // Replace with your logic to get the selected recipe
        if (selectedRecipe != null) {
            MealSlot mealSlot = new MealSlot(selectedRecipe);
            mealSlots.add(mealSlot);
            mealPlannerAdapter.notifyDataSetChanged();
            Toast.makeText(this, "Recipe added to the meal planner", Toast.LENGTH_SHORT).show();
        }
    }
}
