package com.example.practica012;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;

public class MainActivity extends AppCompatActivity {
    private EditText etUrl;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        etUrl = findViewById(R.id.etUrl);
    }

    public void About(View v) {
        Intent i = new Intent(this, info2.class);
        i.putExtra("url", etUrl.getText().toString());
        startActivity(i);
    }


}