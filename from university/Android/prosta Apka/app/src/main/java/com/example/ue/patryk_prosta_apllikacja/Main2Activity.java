package com.example.ue.patryk_prosta_apllikacja;

import android.content.Intent;
import android.graphics.Color;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.LinearLayout;
import android.widget.RadioGroup;
import android.widget.Switch;
import android.widget.TextView;
import android.widget.Button;


public class Main2Activity extends AppCompatActivity {

    //tworzenie elementów
    RadioGroup radioGroup;
    TextView v1;
    TextView v2;
    Button but;
    Switch sw;

    public void myFancyMethod(View v) {
        LinearLayout li=(LinearLayout)findViewById(R.id.my);
        if (sw.isChecked()){

            li.setBackgroundColor(Color.YELLOW);
        }

        else
            li.setBackgroundColor(Color.WHITE);
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main2);

        //przypisywanie elementów z layoutem
        radioGroup = (RadioGroup) findViewById(R.id.wybierzID);
        v1 = (TextView) findViewById(R.id.listwyn);
        v2 = (TextView) findViewById(R.id.listnazwa);
        sw = (Switch) findViewById(R.id.switch1);



        //po zazanczeniu jednego z radioboxów zostanie wykonana jeden z przypadków ze switcha
        radioGroup.setOnCheckedChangeListener(new RadioGroup.OnCheckedChangeListener() {
            @Override
            public void onCheckedChanged(RadioGroup group, int checkedId) {
                switch (checkedId) {
                    case R.id.radioklas:
                        v1.setText(null);
                        v2.setText(null);
                        String[] zespoly = {"-Anime", "-DareDevil", "-RedBull","-Pomarańcz"};
                        String[] pkt = {"Animowany", "Serial", "Napój","Owoc"};
                        int arraySize = zespoly.length;
                        for (int i = 0; i < arraySize; i++) {
                            v1.append(zespoly[i] + "\n");
                            v2.append(pkt[i] + "\n");
                        }
                        break;
                    case R.id.radiotor:
                        v1.setText(null);
                        v2.setText(null);
                        String[] tory = {"Róża","szklanka","Samochód", "Samolot"};
                        String[] data = {"Roślina", "narzędzie", "Pojazd", "Pojazd"};
                        int innearray = tory.length;
                        for (int i = 0; i < innearray; i++) {
                            //Tworzę kreske przy wypisaniu
                            v1.append(tory[i] + "|\n");
                            v2.append(data[i] + "\n");
                        }
                        break;
                    default:
                        v1.setText(null);
                        v2.setText(null);
                }


            }
        });






    }
}
