package com.example.ue.patryk_prosta_apllikacja;

import android.content.Intent;
import android.graphics.Color;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.ListView;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity implements AdapterView.OnItemSelectedListener {

    //tworzenie odpowiednich elementów
    Spinner spiner;
    Button but;
    TextView view;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_simply_application);

        //przypisywanie poszczegolnych elementów
        spiner=(Spinner)findViewById(R.id.spinner);
        view = (TextView)findViewById(R.id.textView);
        but = (Button)findViewById(R.id.button);

        //tworzenie listy dla spinnera i wykorzystanie itemów z string.xml(tak jak Pan mówił na zajęciach by korzystać
        //z tego string-a
        ArrayAdapter adapter= ArrayAdapter.createFromResource(this,R.array.Tablica,android.R.layout.simple_spinner_item);
        spiner.setAdapter(adapter);
        spiner.setOnItemSelectedListener(this);



        //otwieranie nowej aktywnosci
        but.setOnClickListener(new View.OnClickListener() {

            @Override
            public void onClick(View v) {

                Intent intent = new Intent(MainActivity.this, Main2Activity.class);
                startActivity(intent);

            }
        });

    }


    @Override
    public void onItemSelected(AdapterView<?> parent, View view, int position, long id) {

        //przypisywanie odpowiednich elementów
        TextView mytext = (TextView)findViewById(R.id.textView);
        ListView list=(ListView) findViewById(R.id.list );
        String[] innatab;

        switch((int)id)
        {
            case 0:
                //czyści pole tekstowe oraz liste jeśli była wcześniej już używana
                mytext.setText(null);
                list.setAdapter(null);
                break;
            case 1:
                list.setAdapter(null);
                //Uruchamia komunikat
                Toast.makeText(this, "Wybrano: o F1 ", Toast.LENGTH_SHORT).show();
                //ustawienie koloru i wielkośći czcionki oraz zmiana tekstu w TextView
                mytext.setTextSize(15);
                mytext.setTextColor(Color.GREEN);
                mytext.setText("Witam o to w mojej aplikacji, którą zrobiłem na zaliczenie. Znajdzie się tutaj spis kilku seriali, anime jak i kilka zespołów muzycznych. Mam nadzieje że aplikacja się spodobała!");
                break;
            case 2:
                Toast.makeText(this, "Wybrano: Zespoły ", Toast.LENGTH_SHORT).show();
                innatab=null;
                list.setAdapter(null);
                //tworzenie tablicy oraz ja wypełnia
                innatab=getResources().getStringArray(R.array.Zespoly);
                ArrayAdapter<String> adapter2=new  ArrayAdapter<String>(this,android.R.layout.simple_list_item_1,innatab);
                list.setAdapter(adapter2);
                mytext.setTextColor(Color.BLACK);
                mytext.setTextSize(30);
                mytext.setText(null);

                break;

            case 3:
                list.setAdapter(null);
                innatab=null;
                mytext.setText(null);
                innatab=getResources().getStringArray(R.array.Seriale);
                ArrayAdapter<String> adapter3=new  ArrayAdapter<String>(this,android.R.layout.simple_list_item_1,innatab);
                list.setAdapter(adapter3);
                Toast.makeText(this, "Wybrano: Seriale ", Toast.LENGTH_SHORT).show();
                break;

            case 4:
                list.setAdapter(null);
                innatab=null;
                mytext.setText(null);
                innatab=getResources().getStringArray(R.array.Anime);
                ArrayAdapter<String> adapter4=new  ArrayAdapter<String>(this,android.R.layout.simple_list_item_1,innatab);
                list.setAdapter(adapter4);
                Toast.makeText(this, "Wybrano: Anime ", Toast.LENGTH_SHORT).show();
                break;

        }

    }




    @Override
    public void onNothingSelected(AdapterView<?> parent) {

        //Określa co trzeba robic kiedy nic nie wybierzemy

    }
}