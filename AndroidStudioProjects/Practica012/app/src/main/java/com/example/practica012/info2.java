package com.example.practica012;

import android.os.Bundle;
import android.view.View;
import android.webkit.WebView;
import android.widget.Button;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class info2 extends AppCompatActivity {
    private WebView wbInfo;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_info2);

        wbInfo = findViewById(R.id.webView);
        try{
            Bundle bundle = getIntent().getExtras();
            String data = bundle.getString("url");
            wbInfo.loadUrl("https://" + data);
        } catch (Exception ex) {
            Toast.makeText(this, "No hay valores", Toast.LENGTH_LONG);
        }
    }

    public void Back (View v){
        finish();
    }
}