package com.example.practica006;

import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;

public class MainActivity extends AppCompatActivity {

    private EditText etNum1, etNum2;
    private Spinner spinnerOperaciones;
    private TextView tvResult;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        etNum1 = findViewById(R.id.etNum1);
        etNum2 = findViewById(R.id.etNum2);
        tvResult = findViewById(R.id.tvResult);
        spinnerOperaciones = findViewById(R.id.spinner);
        String [] opciones = {"sumar", "restar", "multiplicar", "dividir"};
        ArrayAdapter<String> adapter = new ArrayAdapter<String>(this, android.R.layout.simple_spinner_item, opciones);
        spinnerOperaciones.setAdapter(adapter);

    }

    public void Operar(View v ){
        try {
            int val1 = Integer.parseInt(etNum1.getText().toString());
            int val2 = Integer.parseInt(etNum2.getText().toString());
            String res = "";
            String selec = spinnerOperaciones.getSelectedItem().toString();
            switch (selec){
                case "sumar":
                    int suma = val1 + val2;
                    res = String.valueOf(suma);
                    break;
                case "restar":
                    int resta = val1 - val2;
                    res = String.valueOf(resta);
                    break;
                case "multiplicar":
                    int multi = val1 * val2;
                    res = String.valueOf(multi);
                    break;
                case "dividir":
                    int div = val1 / val2;
                    res = String.valueOf(div);
                    break;
                case "default":
                    Toast.makeText(this, "No World", Toast.LENGTH_SHORT).show();
            }

            tvResult.setText(res);
        } catch (Exception ex){
            Toast.makeText(this, "No hay valores validos", Toast.LENGTH_SHORT).show();
        }

    }
}