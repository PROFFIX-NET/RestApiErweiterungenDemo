PROFFIX REST API Erweiterungen Demo Anwesenheitsliste 
======================================================
Diese Demo zeigt eine verwaltete PROFFIX REST API Erweiterung auf Basis des [*PROFFIX REST API Erweiterungen Template*](https://github.com/PROFFIX-NET/RestApiErweiterungenTemplate)
In dieser Erweiterung wird eine Liste von Mitarbeitern von der Erweiterung zurückgegeben, inklusive des Stempelstatus und EingestempeltSeit.

Anforderungen an die Entwicklungsumgebung
-----------------------------------------
- Lokale PROFFIX Installation mit SQL Server
    - Lizenzierte Zeitverwaltung
- Lokale PROFFIX REST API Version 2.6 oder neuer
    - Lizenzierte Zeitverwaltung
- Visual Studio 2017 (Windows, Edition egal)

Entwicklungsumgebung in Betrieb nehmen
--------------------------------------
Nach erfolgreicher Installation von Visual Studio, inkl. SQL-Server, sowie PROFFIX und der PROFFIX REST API (lokal) ist dieses Demo-Projekt herunter zu laden und die Solution mit Visual Studio 2017 zu öffnen.

Debugging
---------
Um die Aufrufe einer lokal installierten PROFFIX REST API in die lokale Entwicklungsumgebung weiterzuleiten, kann eine nicht verwaltete Erweiterung verwendet werden, welche die Anfragen an *http://localhost:5000* weiterleitet. Eine solche nicht verwaltete Erweiterung befindet sich bereits verwendungsfähig in diesem Repository. 
In dem man das Projekt ausführt, startet die Erweiterung lokal und kann Aufrufe an *http://localhost:5000* entgegennehmen und verarbeiten.

Erweiterung erstellen (ZIP-Archiv erstellen)
--------------------------------------------
Die Erweiterung kann im Visual Studio durch einen Klick unter `Build → Publish {ProjektName} → Publish` erstellt werden. Das erstellte Erweiterungsarchiv befindet sich im Projekt-Verzeichnis unter `bin\Release` und kann via PROFFIX REST API Konfiguration installiert werden.