package com.example.practica013;

import android.content.ContentValues;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;

public class MainActivity extends AppCompatActivity implements View.OnClickListener {

    private Button btnAlta, btnConsultaCod, btnConsultaDesc, btnBajaCod, btnMod;
    private EditText etCodigo, etDescripcion, etPrecio;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        etCodigo = findViewById(R.id.etCodigo);
        etDescripcion = findViewById(R.id.etDesc);
        etPrecio = findViewById(R.id.etDescripcion);

        btnAlta = findViewById(R.id.btnAlta);
        btnConsultaCod = findViewById(R.id.btnConsultaCod);
        btnConsultaDesc = findViewById(R.id.btnConsultaDesc);
        btnBajaCod = findViewById(R.id.btnBajaCod);
        btnMod = findViewById(R.id.btnMod);

        btnAlta.setOnClickListener(this);
        btnConsultaCod.setOnClickListener(this);
        btnConsultaDesc.setOnClickListener(this);
        btnBajaCod.setOnClickListener(this);
        btnMod.setOnClickListener(this);


    }

    @Override
    public void onClick(View v) {
        if (v.equals(btnAlta)) {
            alta();
        } else if (v.equals(btnConsultaCod)) {
            ConsultarPorCodigo();
        } else if (v.equals(btnConsultaDesc)) {
            ConsultarPorDescripcion();
        } else if (v.equals(btnBajaCod)){
            BajarPorCodigo();
        } else if (v.equals(btnMod)){
            Modificar();
        }
    }

    private Button getBtnAlta() {
        return btnAlta;
    }

    public void alta() {
        AdminSQLLiteOpenHelper admin = new AdminSQLLiteOpenHelper(this, "practica013", null, 1);
        SQLiteDatabase db = admin.getWritableDatabase();
        ContentValues registro = new ContentValues();
        try{
            registro.put("codigo", etCodigo.getText().toString());
            registro.put("descripcion", etDescripcion.getText().toString());
            registro.put("precio", etPrecio.getText().toString());
            db.insert("Articulos", null, registro);
            etCodigo.setText("");
            etDescripcion.setText("");
            etPrecio.setText("");
            Toast.makeText(this, "Se cargaron los datos correctamente!", Toast.LENGTH_LONG).show();
        } catch (Exception ex){
            Toast.makeText(this, "Ha habido un error al cargar los datos" + ex.getMessage(), Toast.LENGTH_LONG).show();
        }
    }

    public void ConsultarPorCodigo(){
        try{
            AdminSQLLiteOpenHelper admin = new AdminSQLLiteOpenHelper(this, "practica013", null, 1);
            SQLiteDatabase db = admin.getWritableDatabase();
            String cod = etCodigo.getText().toString();
            Cursor fila = db.rawQuery(
                    "SELECT descripcion, precio FROM Articulos WHERE codigo=" + cod, null);
            if (fila.moveToFirst()){
                etDescripcion.setText(fila.getString(0));
                etPrecio.setText(fila.getString(1));
            } else{
                Toast.makeText(this, "No existe un articulo con dicho codigo", Toast.LENGTH_LONG).show();
            }
        } catch (Exception ex) {
            Toast.makeText(this, "No existe un articulo con dicho codigo", Toast.LENGTH_LONG).show();
        }


    }

    public void ConsultarPorDescripcion(){
        try{
            AdminSQLLiteOpenHelper admin = new AdminSQLLiteOpenHelper(this, "practica013", null, 1);
            SQLiteDatabase db = admin.getWritableDatabase();
            String descri = etDescripcion.getText().toString();
            Cursor fila = db.rawQuery(
                    "SELECT codigo, precio FROM Articulos WHERE descripcion=" + "'" +  descri + "'" , null);
            if (fila.moveToFirst()){
                etDescripcion.setText(fila.getString(0));
                etPrecio.setText(fila.getString(1));
            } else{
                Toast.makeText(this, "No existe un articulo con dicho codigo", Toast.LENGTH_LONG).show();
            }
        } catch (Exception ex) {
            Toast.makeText(this, "No existe un articulo con dicho codigo", Toast.LENGTH_LONG).show();
        }

    }

    public void BajarPorCodigo(){
        try{
            AdminSQLLiteOpenHelper admin = new AdminSQLLiteOpenHelper(this, "practica013", null, 1);
            SQLiteDatabase db = admin.getWritableDatabase();
            String cod = etCodigo.getText().toString();
            int cant = db.delete("Articulos", "codigo= " + cod, null);
            etDescripcion.setText("");
            etCodigo.setText("");
            etPrecio.setText("");
            if (cant == 1){
                Toast.makeText(this, "Se borro el articulo con dicho codigo", Toast.LENGTH_SHORT).show();
            } else{
                Toast.makeText(this, "No existe un articulo con ese codigo", Toast.LENGTH_SHORT).show();
            }
        } catch (Exception ex) {
            Toast.makeText(this, "No existe un articulo con ese codigo", Toast.LENGTH_SHORT).show();
        }

    }

    public void Modificar(){
        try{
            AdminSQLLiteOpenHelper admin = new AdminSQLLiteOpenHelper(this, "practica013", null, 1);
            SQLiteDatabase db = admin.getWritableDatabase();
            ContentValues registro = new ContentValues();
            registro.put("codigo", etCodigo.getText().toString());
            registro.put("descripcion", etDescripcion.getText().toString());
            registro.put("precio", etPrecio.getText().toString());
            int cant = db.update("Articulos", registro, "codigo=" + etCodigo.getText().toString(),null);
            if (cant == 1){
                Toast.makeText(this, "Se modificaron los datos correctamente", Toast.LENGTH_SHORT).show();
            } else{
                Toast.makeText(this, "No existe un articulo con el codigo ingresado", Toast.LENGTH_SHORT).show();
            }
        } catch (Exception ex){
            Toast.makeText(this, "No existe un articulo con el codigo ingresado", Toast.LENGTH_SHORT).show();
        }
    }

}