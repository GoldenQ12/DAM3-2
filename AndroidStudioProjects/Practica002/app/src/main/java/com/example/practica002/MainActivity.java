package com.example.practica002;

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

    public void verificar ( View v ) {
        String pass = etPass.getText().toString();
        if (pass.isEmpty()){
            Toast.makeText(this, "La contraseña está vacía", Toast.LENGTH_SHORT).show();
        }
    }
}