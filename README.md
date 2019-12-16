# home-codeingStandardsRefactoring-JRIE
## Was ist Refactoring?

Um den Code für andere sowie für sich selbst verständlicher und leichter leselich zu machen, sollte man ihn umstrukturieren. Diesen Vorgang nennt man Refactoring. 
Ohne Refactoring ist die Suche nach Fehlern und die spätere Bearbeitung sehr mühsam.

## Vorteile / Nachteile

### Vorteile

- Der Code ist für sich selbst und für andere leicht lesbar und verständlich
- Theoretisch kann die Performance durch die Einsparung unnötiger Zeichen gesteigert werden

### Nachteile

- Wenn man die falschen Zeichen löscht, kann das Skript zerstört werden. Deshalb bei jeder Änderung commiten und testen.

## Refactoring-Schritte

Bevor das eigentliche Refactoring beginnt, muss man einen sogenannten Testcase definieren. Dieser ist ein Testablauf um das Skript auf die Funktionstüchtigkeit zu prüfen. Nach jeder Änderung muss getestet werden, ob das Skript noch funktioniert. Wenn es funktioniert, commit mit message, wenn nicht, Fehler suchen.

## Prinzipien und Lehrsätze

DRY - Mehrfache Nennungen von Code verhindern, also mit Variablen arbeiten
KISS - Der Code soll so einfach wie möglich gestaltet werden
YAGNI - "Extras", die nicht unbedingt für die Funktion des Programms nötig sind, sollen entfernt werden
Principle of Least Surprise - Die Funktionen sollten so sein, wie man es sich erwartet
SoC - Der Code sollte in klare Abschnitte gegliedert sein
Single Responsibility Principle - Klassen sollten nur für eine Sache zuständig sein und nicht mehrere Funktionen erfüllen

## Bad Code Smells?

Funktioniert der Code, ist aber von der Form/Struktur her ungünstig, sollte das geändert werden. Ansonsten "smelled" der Code.

## 10 Code Smells, die eigene Projekte betreffen?

### Kommentare
Keine unnötigen Kommentare

### Aussagekräftige Namen
Variablen- und Klassennamen sollten ihren Zweck beschreiben

### Keine Coderedundanz
Ein Code sollte nur einmal vorkommen.

### Methoden kurz halten
Methoden am besten so kurz wie möglich halten.

### Nichts unnötig Verschachteln
Unnötige Verschachtelungen machen den Code unübersichtlich

# README

## Development Platform

- OS: MacOS 10.14.1
- Unity Version: 2019.1.14f1
- Visual Studio Code Version: 1.33.0
- Scripting Runtime Version: .NET 4.x Equivalent
- API Compatibility Level: .NET 2.0

## Testcase
Über ein Hindernis springen, gegen das zweite laufen.

## Copyright Game

SantaRun by smeerws
