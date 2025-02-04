# AndroidManifest.xml ( app > src > main/AndroidManifest.xml )
1. android:theme="@style/Theme.AppCompat.Light.DarkActionBar"

# main > res :

## - raw => New -> Android Resource Directory -> raw
1. sonidos - videos

## - menu
1. Todas las action bar disponibles de tu aplicacion > menu resource file por cada actionbar
    -EjemploActionBar:

<?xml version="1.0" encoding="utf-8"?>
<menu xmlns:android="http://schemas.android.com/apk/res/android">

# A tener en cuenta -> android:id="@+id/pantalla2"
    <item
        android:id="@+id/pantalla2" 
        android:layout_width="wrap_content"
        android:layout_height="wrap_content"
        android:title="Ir a pantalla 2" />
    <item
        android:id="@+id/salir"
        android:layout_width="wrap_content"
        android:layout_height="wrap_content"
        android:title="Salir" />
    <item
        android:id="@+id/pedro"
        android:layout_width="wrap_content"
        android:layout_height="wrap_content"
        android:title="Pedro" />

</menu>

## - drawable

1. gifs en imagenes
2. xml (animacion) que quieras realizar [new -> android resource file -> xml] 
    -EjemploAnimacion: 

<?xml version="1.0" encoding="utf-8"?>
<animation-list xmlns:android="http://schemas.android.com/apk/res/android" android:oneshot="false">
    <item android:drawable="@drawable/tarta1" android:duration="80"/>
    <item android:drawable="@drawable/tarta2" android:duration="80"/>
    <item android:drawable="@drawable/tarta3" android:duration="80"/>
    <item android:drawable="@drawable/tarta4" android:duration="80"/>
</animation-list>

## Pantalla 1 - Methods
1. Crear clase Lienzo ( CV )

### OnCreate() -> (variables initX e initY, además de variable clase Lienzo)
- @Override
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


### onTouch() -> Implementa la interfaz View.OnClickListener()
1. Recoge posiciones del evento
2. Reconstruye la pantalla
- @Override
    public boolean onTouch(View view, MotionEvent event) {
        corx = (int) event.getX();
        cory = (int) event.getY();
        System.out.println("onTouch: Touched" + event.getX());
        fondo.invalidate();
        return true;
    }

### onCreateOptionsMenu -> CV Tal cual esta

### onOptionsItemSelected
- @Override
    public boolean onOptionsItemSelected(MenuItem item) {
###     A través del id del item sabrás en cual estas pulsando
### el return no se que es
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


## Pantalla 2 - Methods 

### onCreate -> (variables de ImageView para las imagenes estaticas, MediaPlayer para los audios -> AnimationDrawable para los animaciones)

@Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        View decorView = getWindow().getDecorView();

        int uiOptions = View.SYSTEM_UI_FLAG_FULLSCREEN;

        decorView.setSystemUiVisibility(uiOptions);
        
        mpCancion=MediaPlayer.create(this, R.raw.cumpleanos1);

        mp2=MediaPlayer.create(this, R.raw.soplido);

        mpCancion.start();

        setContentView(R.layout.activity_pantalla2);

        ivPersona=findViewById(R.id.ivPersona);

        ivPersona.setBackgroundResource(R.drawable.cara1);

        ivTarta=findViewById(R.id.ivTarta);

        ivTarta.setBackgroundResource(R.drawable.animaciontarta);

        aniTarta = (AnimationDrawable) ivTarta.getBackground();

        aniTarta.start();

        ivTarta.setOnTouchListener(this);

    }

1. CV hasta decorView, porque no tengo ni idea :)
2. instancias los mediaplayers y el media player de la cancion de cumpleaños, sonará al iniciar
3. instancias las animaciones y la de la tarta la inicias 
4. setBackgroundResource (puede ser bien una imagen estatica o bien el propio XML animado)
5. se inicia la animacion de la tarta y se activa la opcion de click dentro de la misma


### onTouch 
-    @Override
    public boolean onTouch(View v, MotionEvent m){
        aniTarta.stop();
        ivTarta.setBackgroundResource(R.drawable.animaciontarta);
        mp1.stop();
        ivPersona.setBackgroundResource(R.drawable.animacioncara);
        aniPersona = (AnimationDrawable) ivPersona.getBackground();
        aniPersona.start();
        mp2.start();
        return true;
    }

### onOptionsItemSelected
-   @Override
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
            ivTarta.setBackgroundResource(R.drawable.animaciontarta);
            aniTarta = (AnimationDrawable) ivTarta.getBackground();
            aniTarta.start();
            return true;

        }
        return super.onOptionsItemSelected(item);
    }
### onCreateOptionsMenu()
-   @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.actionbaranimacion, menu);
        return true;
    }

# Tener en cuenta, que para el if de id== r.id.reiniciar, puedes hacer esto, y te quedas mas tranquilo
###       Intent intent = getIntent();
###       finish(); // Finish the current activity
###       startActivity(intent); // Start the activity again


