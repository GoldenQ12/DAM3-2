package com.example.practica003;

import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;

public class MainActivity extends AppCompatActivity {

    private EditText etNum1, etNum2;
    private TextView tvResult;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        etNum1 = findViewById(R.id.etNum1);
        etNum2 = findViewById(R.id.etNum2);
        tvResult = findViewById(R.id.tvResult);

    }

    public void Sumar(View v ){
        try {
            int val1 = Integer.parseInt(etNum1.getText().toString());
            int val2 = Integer.parseInt(etNum2.getText().toString());
            int result = val1 + val2;
            String resultText = String.valueOf(result);
            tvResult.setText(resultText);
        } catch (Exception ex){
            Toast.makeText(this, "No hay valores validos", Toast.LENGTH_SHORT).show();
        }

    }
}