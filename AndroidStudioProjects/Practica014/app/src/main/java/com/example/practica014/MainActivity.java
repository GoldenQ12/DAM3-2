package com.example.practica014;

import android.content.Intent;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.ImageButton;
import android.widget.ListView;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.RecyclerView;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity implements View.OnClickListener {
    public String DATABASE_NAME = "practica014";

    private ImageButton ibtnDel, ibtnAdd, ibtnUpdate;
    private Button btnAlumnos, btnCursos;
    private ListView lvRegs;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        AdminSQLiteOpenHelper admin = new AdminSQLiteOpenHelper(this, DATABASE_NAME, null, 1);
        SQLiteDatabase db = admin.getWritableDatabase();
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        btnAlumnos = findViewById(R.id.btnAlumnos);
        btnCursos = findViewById(R.id.btnCursos);

        ibtnDel = findViewById(R.id.ibtnDel);
        ibtnUpdate = findViewById(R.id.iBtnUpdate);
        ibtnAdd = findViewById(R.id.ibtnAdd);

        lvRegs = findViewById(R.id.lvRegs);


        btnAlumnos.setOnClickListener(this);
        btnCursos.setOnClickListener(this);

        ibtnAdd.setOnClickListener(this);
        ibtnUpdate.setOnClickListener(this);
        ibtnDel.setOnClickListener(this);
    }


    @Override
    public void onClick(View v) {
        if (v.equals(ibtnAdd)){
            AddWindow();
        } else if (v.equals(ibtnUpdate)) {
            UpdateWindow();
        } else if (v.equals(ibtnDel)) {
            DeleteWindow();
        } else if (v.equals(btnAlumnos)) {
            ArrayList<String> alumnos = ObtenerDatosAlumnos();
            ArrayAdapter<String> adapter = new ArrayAdapter<>(this, android.R.layout.simple_list_item_1, alumnos);
            lvRegs.setAdapter(adapter);
        } else if (v.equals(btnCursos)){
            ArrayList<String> cursos = ObtenerDatosCursos();
            ArrayAdapter<String> adapter = new ArrayAdapter<>(this, android.R.layout.simple_list_item_1, cursos);
            lvRegs.setAdapter(adapter);
        }
    }



    //Metodo de obtener datos

    public ArrayList<String> ObtenerDatosAlumnos () {
        try{
            AdminSQLiteOpenHelper admin = new AdminSQLiteOpenHelper(this, DATABASE_NAME, null, 1);
            SQLiteDatabase db = admin.getWritableDatabase();
            ArrayList<String> alumnos = new ArrayList<>();
            Cursor cursor = db.rawQuery("SELECT * FROM Alumnos", null);
            if (cursor.moveToFirst()) {
                do{
                    String dni = cursor.getString(cursor.getColumnIndex("dni"));
                    String nombre = cursor.getString(cursor.getColumnIndex("nombre"));
                    int edad = cursor.getInt(cursor.getColumnIndex("edad"));
                    String id_curso = cursor.getString(cursor.getColumnIndex("id_curso"));
                    if (id_curso == null || id_curso.isEmpty()) id_curso = "No esta matriculado a ningún curso";
                    alumnos.add(" DNI - " + dni +
                            "\n Nombre - " + nombre +
                            "\n Edad - " + edad +
                            "\n Curso - " + id_curso);
                } while (cursor.moveToNext());
            }
            cursor.close();
            return alumnos;
        } catch (Exception ex ) {
            Toast.makeText(this, "Ha ocurrido un error" + ex.getMessage(), Toast.LENGTH_SHORT).show();
        }

        return null;
    }

    //Metodos de ventanas

    public ArrayList<String> ObtenerDatosCursos(){
        try{
            AdminSQLiteOpenHelper admin = new AdminSQLiteOpenHelper(this, DATABASE_NAME, null, 1);
            SQLiteDatabase db = admin.getWritableDatabase();
            ArrayList<String> cursos = new ArrayList<>();
            Cursor cursor = db.rawQuery("SELECT * FROM Cursos", null);
            if (cursor.moveToFirst()) {
                do{
                    String id_curso = cursor.getString("id_curso");
                    String curso = cursor.getString("curso");
                    cursos.add(id_curso +
                            " - " + curso);
                } while (cursor.moveToNext());
            }
            cursor.close();
            return cursos;
        } catch (Exception ex ) {
            Toast.makeText(this, "Ha ocurrido un error" + ex.getMessage(), Toast.LENGTH_SHORT).show();
        }

        return null;
    }
    public void AddWindow(){
        Intent i = new Intent(this, insertView.class);
        startActivity(i);
    }

    public void UpdateWindow(){
        Intent i = new Intent(this, updateView.class);
        startActivity(i);
    }

    public void DeleteWindow(){
        Intent i = new Intent(this, deleteView.class);
        startActivity(i);
    }

}