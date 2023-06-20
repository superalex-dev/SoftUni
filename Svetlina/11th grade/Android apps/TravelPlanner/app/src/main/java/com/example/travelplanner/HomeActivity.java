package com.example.travelplanner;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;
import androidx.navigation.safe.args.generator.models.Destination;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import java.util.ArrayList;
import java.util.List;

public class HomeActivity extends AppCompatActivity implements DestinationAdapter.OnItemClickListener {

    private RecyclerView recyclerView;
    private DestinationAdapter adapter;
    private List<Destination> destinationList;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_home);

        // Initialize the RecyclerView
        recyclerView = findViewById(R.id.recyclerView);
        recyclerView.setLayoutManager(new LinearLayoutManager(this));

        // Create a list of destinations
        destinationList = createDestinationList();

        // Create and set the adapter
        adapter = new DestinationAdapter(destinationList, this);
        recyclerView.setAdapter(adapter);
    }

    @Override
    public void onItemClick(int position) {
        // Handle item click event
        Destination clickedDestination = destinationList.get(position);
        Toast.makeText(this, "Clicked: " + clickedDestination.getName(), Toast.LENGTH_SHORT).show();

        // Start DestinationDetailActivity and pass data
        Intent intent = new Intent(this, DestinationDetailActivity.class);
        intent.putExtra("destination_id", String.valueOf(clickedDestination.getId()));
        startActivity(intent);
    }

    // Create a list of destinations (Replace with your own data source)
    private List<Destination> createDestinationList() {
        List<Destination> destinations = new ArrayList<>();
        destinations.add(new Destination(1, "Destination 1", "Description 1"));
        destinations.add(new Destination(2, "Destination 2", "Description 2"));
        destinations.add(new Destination(3, "Destination 3", "Description 3"));
        // Add more destinations as needed
        return destinations;
    }
}