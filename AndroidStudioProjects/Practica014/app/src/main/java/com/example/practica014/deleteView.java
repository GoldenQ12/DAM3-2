package com.example.practica014;

import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.RadioButton;
import android.widget.TextView;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;

public class deleteView extends AppCompatActivity implements View.OnClickListener {

    public String DATABASE_NAME = "practica014";

    private TextView tvTitle;
    private Button btnDelete;
    private RadioButton rbAlumnos, rbCursos;
    private EditText etField1;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_delete_view);

        btnDelete = findViewById(R.id.btnShow);

        rbAlumnos = findViewById(R.id.rbAlumnos);
        rbCursos = findViewById(R.id.rbCursos);

        etField1 = findViewById(R.id.etField1);

        tvTitle = findViewById(R.id.tvTitle);

        btnDelete.setOnClickListener(this);
        rbAlumnos.setOnClickListener(this);
        rbCursos.setOnClickListener(this);


    }

    @Override
    public void onClick(View v) {
        if (v.equals(btnDelete)) {
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

        etField1.setHint("Introduce el DNI para eliminar el alumno...");

    }

    private void CursosInfo(){
        tvTitle.setText("CURSOS");
        etField1.setHint("Introduce el identificador del curso para eliminarlo");

    }

    private void Alumnos() {

        try{
            AdminSQLiteOpenHelper admin = new AdminSQLiteOpenHelper(this, DATABASE_NAME, null, 1);
            SQLiteDatabase db = admin.getWritableDatabase();
            String dni = etField1.getText().toString();
            int regs = db.delete("Alumnos", "dni = ?", new String[] {dni});
            if (regs == 0 ) {
                Toast.makeText(this, "No se ha encontrando alumno con dni " + dni, Toast.LENGTH_LONG).show();
            } else {
                Toast.makeText(this, "Alumno eliminado correctamente ", Toast.LENGTH_LONG).show();
                etField1.setText("");
            }
        } catch (Exception ex) {
            tvTitle.setText(ex.getMessage());
            Toast.makeText(this, "Ha ocurrido un error " + ex.getMessage(), Toast.LENGTH_LONG).show();
        }
    }

    private void Cursos() {

        try{
            AdminSQLiteOpenHelper admin = new AdminSQLiteOpenHelper(this, DATABASE_NAME, null, 1);
            SQLiteDatabase db = admin.getWritableDatabase();
            String id_curso = etField1.getText().toString();
            db.delete("Cursos", "id_curso = ?", new String[] {id_curso});
            etField1.setText("");
            Toast.makeText(this, "Curso eliminado correctamente ", Toast.LENGTH_LONG).show();
        } catch (Exception ex) {
            Toast.makeText(this, "Ha ocurrido un error " + ex.getMessage(), Toast.LENGTH_LONG).show();
        }
    }
}