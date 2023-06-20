package com.example.travelplanner;
import android.content.Intent;
import android.os.Bundle;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;
import androidx.navigation.safe.args.generator.models.Destination;

public class DestinationDetailActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_destination_detail);

        // Get the destination ID from the intent
        Intent intent = getIntent();
        int destinationId = intent.getIntExtra("destination_id", 0);

        // Get the destination details based on the ID (Replace with your own logic)
        Destination destination = getDestinationDetails(destinationId);

        // Update the views with the destination details
        TextView destinationNameTextView = findViewById(R.id.destinationNameTextView);
        TextView destinationDescriptionTextView = findViewById(R.id.destinationDescriptionTextView);

        destinationNameTextView.setText(destination.getName());
        destinationDescriptionTextView.setText(destination.getDescription());
    }

    // Get the destination details based on the ID (Replace with your own logic)
    private Destination getDestinationDetails(int destinationId) {
        // Replace this with your own code to retrieve the destination details from your data source
        // For this example, we'll create a dummy Destination object
        return new Destination(destinationId, "Destination " + destinationId, "Description " + destinationId);
    }
}