# roguelikeUnityGame

TODO:
1) ~~Aby pociski przenikały przez statki ale znikały przy kolizji.~~ -done
2) ~~Dodać podstawowego mobka co leci w lewo, strzela i znika gdy za ekran przejdzie~~ - done
3) Ogarnąć tworzenie scenaruszy tzn. że teraz poleci 5 gówno mobków, potem 3 silniejsze, możliwość wyboru ubgradeu i boss itp- w miare dodane acz troche prowizorka xd
4) Coś zrobić aby mobek nie przesuwał gracza oraz też aby gracz nie mógł mobka zablokować przed dotarciem do krawędzi ekranu :V
5) ~~Ui typu hp i staty z boku czy cuś~~ -(jeśli trzeba dodać coś jeszcze na ten moment, napiszcie) - done 
  -~~Z boku takie rzeczy jak dmg, speed gracza. Zapewne ta lista będzie się rozrastać gdy doda sie upgrade'y~~ - done
      -Pomyśleć nad zastąpieniem tekstu jakimiś grafikami
6) ~~Podstawowe menu~~ - done 
7) ~~Kilka przykładowych upgrade'ów na start aby można było dalej na nich operować~~. {p. dmgUp, speedUp, bullets++, ??? }
      Dodałem klasę abstrakcyjną wraz z kilkoma przykładowymi upgrade'ami. https://www.youtube.com/watch?v=PkNRPOrtyls&ab_channel=BMo (Dodać więcej opierając się na tym)
      
9) ~~Menu wyboru upgrade'u~~ - done (klawisz "Q")
       ~~Tekst się pojawia w rogu ekranu :V
       Połączyć menu z falami i upgradeami.
10) ~~Dash pozwalający unikać pocisków bo bez tego troche mało dynamiczna oraz trudna :V plus dzięki temu więcej~~ upgrade'ów można dodać
      **Dash zrobiony jako blink czyli natychmiastowe przemieszczenie-uważać aby gracz w ścianę nie wszczedł**
      Można dodać powidok gracza pokazujący gdzie się znajdzie po dashu/blinku i widoczny tylko wtedy gdy dash nie jest na cooldownie
      
11) ~~Menu pauzy~~ - done
12) Kamera powinna zawsze pokazywać plansze po której gracz może się poruszać nie zależnie od rozmiaru ekranu
13) ~~Ekran po śmierci gracza, zmiana scen przy użyciu przycisków~~
14) Naprawić timer by startował przy starcie rozgrywki, dodać go do statystyk, dodać do klasy Statistics tak by można było pobierać dane do wyświetlania
15) Laser aktualnie przysłania stateczek, zrobić go pod stateczkiem
16) Tarczownik nie reaguje na kolizję z tarczą z asseta, ponadto nadal widać tarczę tą białą, domyślną.
