package com.example.practica009;

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
    private EditText etNumber;
    private int num;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        etNumber = findViewById(R.id.etNumber);
        GenerateNumber();
    }

    public void Adivinar(View v) {
        try{
            String inputText = etNumber.getText().toString();
            int value = Integer.parseInt(inputText);
            if (value == num){
                Toast.makeText(this, "Muy bien, ese es el numero mostrado", Toast.LENGTH_LONG).show();
                GenerateNumber();
            } else{
                Toast.makeText(this, "Vaya, ese no es el numero mostrado", Toast.LENGTH_LONG).show();
            }
        } catch (Exception ex) {
            Toast.makeText(this, "No hay valores introducidos", Toast.LENGTH_LONG).show();
        }
    }

    public void GenerateNumber () {
        num = (int) (Math.random() * 100001);
        String guess = String.valueOf(num);
        Toast.makeText(this, guess, Toast.LENGTH_LONG).show();
    }
}