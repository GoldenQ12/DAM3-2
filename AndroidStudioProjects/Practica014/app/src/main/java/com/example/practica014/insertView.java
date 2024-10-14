package com.example.practica014;

import android.content.ContentValues;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.RadioButton;
import android.widget.TextView;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;

public class insertView extends AppCompatActivity implements View.OnClickListener {

    public String DATABASE_NAME = "practica014";

    private TextView tvTitle;
    private Button btnInsert;
    private RadioButton rbAlumnos, rbCursos;
    private EditText etField1, etField2, etField3, etField4;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_insert_view);

        btnInsert = findViewById(R.id.btnShow);

        rbAlumnos = findViewById(R.id.rbAlumnos);
        rbCursos = findViewById(R.id.rbCursos);

        etField1 = findViewById(R.id.etField1);
        etField2 = findViewById(R.id.etField2);
        etField3 = findViewById(R.id.etField3);
        etField4 = findViewById(R.id.etField4);

        tvTitle = findViewById(R.id.tvTitle);

        btnInsert.setOnClickListener(this);
        rbAlumnos.setOnClickListener(this);
        rbCursos.setOnClickListener(this);


    }

    @Override
    public void onClick(View v) {
        if (v.equals(btnInsert)) {
            if (rbAlumnos.isChecked()) {
                Alumnos();
            } else if (rbCursos.isChecked()) {
                Cursos();
            }
        } else if (v.equals(rbAlumnos)) {
            AlumnosInfo();
        } else if (v.equals(rbCursos)) {
            CursosInfo();
        }
    }

    private void AlumnosInfo(){


        tvTitle.setText("ALUMNOS");

        etField1.setHint("Introduce el DNI...");
        etField2.setHint("Introduce el nombre...");
        etField3.setHint("Introduce la edad...");
        etField4.setHint("Introduce el identificador del curso... ( si esta cursando ) ");

        etField3.setVisibility(View.VISIBLE);
        etField4.setVisibility(View.VISIBLE);
    }

    private void CursosInfo(){
        tvTitle.setText("CURSOS");
        etField1.setHint("Introduce el identificador del curso...");
        etField2.setHint("Introduce el nombre del curso...");

        etField3.setVisibility(View.INVISIBLE);
        etField4.setVisibility(View.INVISIBLE);
    }

    private void Alumnos() {

        try{
            AdminSQLiteOpenHelper admin = new AdminSQLiteOpenHelper(this, DATABASE_NAME, null, 1);
            SQLiteDatabase db = admin.getWritableDatabase();
            ContentValues alumno = new ContentValues();
            alumno.put("dni", etField1.getText().toString());
            alumno.put("nombre", etField2.getText().toString());
            alumno.put("edad", etField3.getText().toString());
            alumno.put("id_curso", etField4.getText().toString());
            db.insert("Alumnos", null, alumno);
            etField1.setText("");
            etField2.setText("");
            etField3.setText("");
            etField4.setText("");
            Toast.makeText(this, "Alumno guardado correctamente ", Toast.LENGTH_LONG).show();
        } catch (Exception ex) {
            tvTitle.setText(ex.getMessage());
            Toast.makeText(this, ex.getMessage(), Toast.LENGTH_LONG).show();
        }
    }

    private void Cursos() {

        try{
            AdminSQLiteOpenHelper admin = new AdminSQLiteOpenHelper(this, DATABASE_NAME, null, 1);
            SQLiteDatabase db = admin.getWritableDatabase();
            ContentValues curso = new ContentValues();
            curso.put("id_curso", etField1.getText().toString());
            curso.put("curso", etField2.getText().toString());
            db.insert("Cursos", null, curso);
            etField1.setText("");
            etField2.setText("");
            Toast.makeText(this, "Curso guardado correctamente ", Toast.LENGTH_LONG).show();
        } catch (Exception ex) {
            Toast.makeText(this, "Ha ocurrido un error " + ex.getMessage(), Toast.LENGTH_LONG).show();
        }
    }
}