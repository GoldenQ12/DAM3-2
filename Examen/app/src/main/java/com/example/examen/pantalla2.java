package com.example.examen;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

import android.app.ActionBar;
import android.content.Intent;
import android.graphics.drawable.AnimationDrawable;
import android.media.MediaPlayer;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.MotionEvent;
import android.view.View;
import android.widget.ImageView;
import android.widget.Toast;

public class pantalla2 extends AppCompatActivity implements View.OnTouchListener{
    private ImageView ivTarta, ivPersona;
    private AnimationDrawable aniTarta, aniPersona;
    private MediaPlayer mp1,mp2;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        View decorView = getWindow().getDecorView();

        int uiOptions = View.SYSTEM_UI_FLAG_FULLSCREEN;

        decorView.setSystemUiVisibility(uiOptions);

        mp1=MediaPlayer.create(this, R.raw.cumpleanos1);
        mp2=MediaPlayer.create(this, R.raw.soplido);
        mp1.start();
        setContentView(R.layout.activity_pantalla2);
        ivPersona=findViewById(R.id.ivPersona);
        ivPersona.setBackgroundResource(R.drawable.cara1);
        ivTarta=findViewById(R.id.ivTarta);
        ivTarta.setBackgroundResource(R.drawable.animaciontarta);
        aniTarta = (AnimationDrawable) ivTarta.getBackground();
        aniTarta.start();
        ivTarta.setOnTouchListener(this);
    }

    @Override
    public boolean onTouch(View v, MotionEvent m){
        aniTarta.stop();
        ivTarta.setBackgroundResource(R.drawable.tarta5);
        mp1.stop();
        ivPersona.setBackgroundResource(R.drawable.animacioncara);
        aniPersona = (AnimationDrawable) ivPersona.getBackground();
        aniPersona.start();
        mp2.start();
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        int id = item.getItemId();
        if (id == R.id.volver) {
            finish();
            return true;
        }
        if (id == R.id.reiniciar) {
            mp1=MediaPlayer.create(this, R.raw.cumpleanos1);
            mp1.start();
            ivPersona.setBackgroundResource(R.drawable.cara1);
            mp1.stop();
            ivTarta.setBackgroundResource(R.drawable.animaciontarta);
            aniTarta = (AnimationDrawable) ivTarta.getBackground();
            aniTarta.start();
            return true;
        }
        return super.onOptionsItemSelected(item);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.actionbaranimacion, menu);
        return true;
    }
}