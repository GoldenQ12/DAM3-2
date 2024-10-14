package com.example.practica014;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

import androidx.annotation.Nullable;

public class AdminSQLiteOpenHelper extends SQLiteOpenHelper {

    public AdminSQLiteOpenHelper (@Nullable Context context, @Nullable String database_name, @Nullable SQLiteDatabase.CursorFactory cursorFactory, int version){
        super(context,database_name,cursorFactory,version);
    }

    @Override
    public void onCreate(SQLiteDatabase db) {
        db.execSQL("CREATE TABLE Cursos(id_curso text PRIMARY KEY," +
                "curso text)");
        db.execSQL("CREATE TABLE Alumnos(dni text PRIMARY KEY," +
                "nombre text," +
                "edad int," +
                "id_curso text," +
                "FOREIGN KEY(id_curso) REFERENCES Cursos(id_curso))");

    }

    @Override
    public void onUpgrade(SQLiteDatabase sqLiteDatabase, int i, int i1) {

    }
}
