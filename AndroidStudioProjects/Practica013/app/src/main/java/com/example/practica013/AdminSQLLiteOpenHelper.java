package com.example.practica013;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

import androidx.annotation.Nullable;

public class AdminSQLLiteOpenHelper extends SQLiteOpenHelper {

    public AdminSQLLiteOpenHelper (@Nullable Context context, @Nullable String database, @Nullable SQLiteDatabase.CursorFactory cursorFactory, int version){
        super(context, database, cursorFactory, version);
    }

    @Override
    public void onCreate(SQLiteDatabase db) {
        db.execSQL("CREATE TABLE Articulos(codigo int primary key" +
                ", descripcion text" +
                ", precio real)");
    }

    @Override
    public void onUpgrade(SQLiteDatabase sqLiteDatabase, int i, int i1) {

    }
}
