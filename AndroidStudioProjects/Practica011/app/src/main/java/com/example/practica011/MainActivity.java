package com.example.practica011;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {
    private EditText etPass;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        etPass = findViewById(R.id.etPass);
    }

    public void About(View v) {
        Intent i = new Intent(this, info.class);
        try {
            String pass = etPass.getText().toString();
            if (pass.equals("abc123")) {
                startActivity(i);
            } else if (pass.isEmpty()) {
                Toast.makeText(this, "No hay valores introducidos", Toast.LENGTH_LONG).show();
            } else {
                Toast.makeText(this, "Contraseña incorrecta", Toast.LENGTH_LONG).show();
            }
        } catch (Exception ex) {
            ex.getMessage();
        }
    }


}