package com.example.practica005;

import android.os.Bundle;
import android.view.View;
import android.widget.CheckBox;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;

public class MainActivity extends AppCompatActivity {

    private EditText etNum1, etNum2;
    private CheckBox cbSum, cbMin;
    private TextView tvResult;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        etNum1 = findViewById(R.id.etNum1);
        etNum2 = findViewById(R.id.etNum2);
        tvResult = findViewById(R.id.tvResult);
        cbSum = findViewById(R.id.cbSum);
        cbMin = findViewById(R.id.cbMin);


    }

    public void Operar(View v ){
        try {
            int val1 = Integer.parseInt(etNum1.getText().toString());
            int val2 = Integer.parseInt(etNum2.getText().toString());
            String res = "";
            if (cbSum.isChecked()) {
                int suma = val1 + val2;
                res+= "La suma es " + suma;
            }
            if (cbMin.isChecked()) {
                int resta = val1 - val2;
                res+= " La resta es " + resta;
            }
            tvResult.setText(res);
        } catch (Exception ex){
            Toast.makeText(this, "No hay valores validos", Toast.LENGTH_SHORT).show();
        }

    }
}