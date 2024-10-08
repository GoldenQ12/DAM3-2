package com.example.practica010;

import android.os.Bundle;
import android.view.Gravity;
import android.view.LayoutInflater;
import android.view.View;
import android.widget.Button;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity implements View.OnClickListener {

    private Button btn1, btn2, btn3;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        btn1 = findViewById(R.id.btn1);
        btn2 = findViewById(R.id.btn2);
        btn3 = findViewById(R.id.btn3);
    }

    public void onClick(View view) {
        if (btn1 == view){
            try{
                Toast.makeText(this, "Mensaje 1 ", Toast.LENGTH_SHORT).show();
            } catch (Exception ex) {
                Toast.makeText(this, "Error" + ex.getMessage(), Toast.LENGTH_SHORT).show();
            }
        }
        if (btn2 == view ){
            try{
                Toast toast = Toast.makeText(this, "Mensaje 2 ", Toast.LENGTH_SHORT);
                toast.setGravity(Gravity.CENTER_VERTICAL, 0 ,0);
                toast.show();

            } catch (Exception ex){
                Toast.makeText(this, "Error" + ex.getMessage(), Toast.LENGTH_SHORT).show();

            }
        }
        if (btn3 == view){
            try{
                LayoutInflater inflater = getLayoutInflater();
                View layout = inflater.inflate(R.layout.toast1, null);
                Toast toast = new Toast(getApplicationContext());
                toast.setGravity(Gravity.CENTER_VERTICAL, 0 , 0);
                toast.setDuration(Toast.LENGTH_LONG);
                toast.setView(layout);
                toast.show();

            } catch (Exception ex){
                Toast.makeText(this, "Error" + ex.getMessage(), Toast.LENGTH_SHORT).show();
            }
        }
    }
}