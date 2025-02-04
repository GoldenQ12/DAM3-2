package com.example.examen;

import androidx.appcompat.app.AppCompatActivity;
import androidx.constraintlayout.widget.ConstraintLayout;
import android.content.Context;
import android.content.Intent;
import android.graphics.Canvas;
import android.graphics.Paint;
import android.graphics.Path;
import android.os.Bundle;
import android.util.Log;
import android.view.Menu;
import android.view.MenuItem;
import android.view.MotionEvent;
import android.view.View;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity implements View.OnTouchListener {
    private int corx, cory;
    private Lienzo fondo;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        System.out.println("HELLO WORLD");
        corx = 100;
        cory = 100;
        ConstraintLayout layout1 = findViewById(R.id.layout1);
        fondo = new Lienzo(this);
        fondo.setOnTouchListener(this);
        layout1.addView(fondo);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.menuactionbar, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        int id = item.getItemId();
        if (id == R.id.pantalla2) {
            Intent i = new Intent(this, pantalla2.class);
            startActivity(i);
            return true;
        }
        if (id == R.id.salir) {
            finish();
            return true;
        }
        if (id == R.id.pedro){
            Toast.makeText(this, "Hola mundo", Toast.LENGTH_SHORT).show();
            return true;
        }
        return super.onOptionsItemSelected(item);
    }

    @Override
    public boolean onTouch(View view, MotionEvent event) {
        corx = (int) event.getX();
        cory = (int) event.getY();
        System.out.println("onTouch: Touched" + event.getX());
        fondo.invalidate();
        return true;
    }


    class Lienzo extends View {
        public Lienzo(Context context) {
            super(context);
        }

        protected void onDraw(Canvas canvas) {
            // Get the width and height of the canvas
            int width = canvas.getWidth();
            int height = canvas.getHeight();

            // Calculate the center of the canvas
            float centerX = width / 2f;
            float centerY = height / 2f;

            // Create a path for the text
            Path camino = new Path();
            camino.addArc(centerX - 175, centerY - 75, centerX + 175, centerY + 75, -180, 180); // Adjusted arc to center

            // Create a paint object for the text
            Paint pincel1 = new Paint();
            pincel1.setARGB(255, 255, 0, 0);
            pincel1.setTextSize(50);

            // Draw the text on the path
            canvas.drawTextOnPath("Feliz Cumpleaños!", camino, 0, 0, pincel1);

            // Set up the paint for the circle
            pincel1.setStrokeWidth(4);
            pincel1.setStyle(Paint.Style.STROKE);

            // Draw the circle at the center of the screen
            canvas.drawCircle(corx, cory, 20, pincel1);
        }
    }
}