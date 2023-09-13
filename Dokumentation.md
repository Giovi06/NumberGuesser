# Projekt-Dokumentation
#LA1300


Giovanni Innamorato, Giuliano Martullo, Steven Salie
| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|  16.08     | 0.0.1   |  Wir haben unser wissen zu C# wieder aufgefrischt und haben die Planung erstellt. |
|   23.08    | 0.0.2     |   Wir haben noch recherchiert und uns danach ans Programmieren gemacht                                                           |
|     30.8  | 0.0.3   |     Wir sind mit unseren Aufgaben fertig geworden                                                         |
|06.09| 1.0.0|Wir haben unsere Codes zusammengefügt und auf Fehler getestet.|

## 1 Informieren

### 1.1 Ihr Projekt

Unser Projekt ist ein Randomnumber Guesser mit Hilfe von C# zu programmieren.
### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |       muss          |   F | Als User möchte ich, eine Zufällige Zahl erraten können, damit ich das Spiel gewinnen kann|
|   2   |      muss           |  Q    |         Als User möchte ich, dass mir gesagt wird wenn ich zu hoch/tief geraten habe, damit das Spiel einfacher ist.                           |
|  3    |        muss         |   Q   |             Als Spieler möchte ich, dass ich das Spiel erneut spielen kann, damit ich Zeit sparen kann                       |
|   4   |        muss         |   F   |            Als Spieler möchte ich, zu Zweit spielen können, damit ich mit meinen Freunden spielen kann                         |
|   5   |      kann           |   Q   |       Als Spieler möchte ich, dass ich einen Schwereren Spielmodus spielen kann, damit ich mir eine Herausforderung stellen kann                             |
| 6     |        muss         |   F   |        Als Spieler möchte ich, dass ich anstatt Zahlen Buchstaben raten kann, damit es Abwechslungsreicher ist.                          |




### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
|1.1	|Das Spiel wurde gestartet.|	Keine spezifische Eingabe erforderlich.|	Eine zufällige Zahl wurde generiert.|
|2.1|	Das Spiel läuft, und eine zufällige Zahl wurde generiert.|	Der Benutzer gibt eine falsche Zahl ein.|Eine Nachricht, die besagt, dass die Zahl falsch ist und ob sie höher oder niedriger ist als die gesuchte Zahl.|
|1.2|	Das Spiel läuft, und eine zufällige Zahl wurde generiert.|	Der Benutzer gibt die richtige Zahl ein.|	Eine Nachricht, die besagt, dass der Benutzer das Spiel gewonnen hat.|
|3.1| Spiel beendet| ("Nochmal spielen") "True"| Neues Spiel wird gestartet|
|4.1|Programm gestartet|("Möchtest du den Zweispielermodus spielen") "True"| Zweispielermodus wird gestartet|
|5.1| Zahl wurde in unter sieben Versuchen erraten|("Möchest du den Hardcore-Modus spielen?")"True"|Schwerer Modus wird gestartet|
|6.1|Programm gestartet|("Möchtest du mit Buchstaben spielen?") "True"|Alphabet-Modus wird gestartet|




## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
|  1 ,2,3|   06.09    |     Giovanni, Giuliano, Steven      |    Grundstruktur des Spiels erstellen          |     120 Min          |
| 4  |   06.09    |   Giuliano        |    Zweispieler-Modus erstellen             |   180 Min        |
| 5  |   06.09    |    Giovanni       |      Hardcore-Modus erstellen        |         180    Min  |
|  6 |   06.09    |     Steven      |     Alphabet-Modus erstellen         |        180      Min |

Total: 660 Min




## 3 Realisieren

| AP-№ | Datum | Zuständig | Tatsächliche Zeit | 
| ---- | ----- | --------- | ------------- | 
| 1.A  |    23.08  |    Alle       |   30            |                  
| 2.A  |    23.08   |     Alle      |   25            |      
| 3.A  |     23.08  |     Alle      |     40          |                   
| 4.A  |     30.08  |     Giuliano      |       200        |                   
| 5.A  |     30.08  |     Giovanni      |       170        |   
| 6.A  |    30.08   |      Steven     |      190         |                   




## 4 Kontrollieren

### 4.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |  06.09     |     OK     |   Alle     |
| 1.2 |   06.09      |     OK     |      Alle  |
| 2.1 |   06.09      |     OK     |    Alle    |
| 3.1 |  06.09       |    OK      |     Alle   |
| 4.1|  06.09       |    OK      |   Steven     |
| 5.1 | 06.09        |    OK      |   Giuliano     |
| 6.1|  06.09       |     OK     |   Giovanni     |


