# **GRUPA 8: TimPadobranci**
## **Tema: e-Taxi**

![logo2](https://user-images.githubusercontent.com/37378671/37659146-7aa819ea-2c4f-11e8-957f-176e84353c55.jpg)

## **Članovi tima:**
1. Nedić Marko
2. Pejović Petar
3. Plakalović Anja

# **Opis teme**
e-Taxi je aplikacija koja omogućava jednostavnu i sigurnu vožnju do željenog odredišta u što kraćem vremenskom roku, pri pristupačnim cijenama.\
Koliko puta Vam se desilo da taksi čekate predugo? Uz ovu aplikaciju zaboravite na čekanje – pouzdan prevoz je tu za Vas već za par minuta.\
Svrha aplikacije je omogućiti unapređeniji i jednostavniji prevoz klijenta/klijenata od trenutne lokacije (tačke A) do precizno definiranog odredišta (tačke B). Pored toga što je povoljna za klijente, vožnja uz e-Taxi je isplativa i za vozače. Uz par dodira na ekran svog pametnog telefona imate mogućnost da se registrujete kao vozač i ispunite svoje profesionalne ciljeve uz fleksibilan raspored koji sami određujete.\
Bilo da Vam treba svakodnevna vožnja do posla, vožnja izvan grada ili poseban prevoz za veći broj osoba – za Vas je tu e-Taxi.

# **Procesi**

## **Registracija klijenta**
Prilikom registracije klijent navodi lične podatke kao što su:\
•	Ime\
•	Prezime\
•	E-mail\
•	Godište\
•	Spol\
•	Šifra (uz potvrdu iste)\
Pri tome, moguće je izabrati i profilnu sliku, iako je ovo polje neobavezno.\
Napomena: Samo punoljetni klijenti (18+) se mogu registrovati.

## **Registracija vozača**
Registracija vozača uključuje navođenje osnovnih podataka kao što su:\
•	Ime\
•	Prezime\
•	E-mail\
•	Datum rođenja\
•	JMBG\
•	Kontakt telefon\
•	Adresa stanovanja\
•	Radno iskustvo\
•	Broj kreditne kartice\
•	Šifra (uz potvrdu iste), itd.

## **Odobravanje zahtjeva za registraciju**
Admin u zavisnosti od potrebe za novim zaposlenicima kao i o cjelokupnom dojmu o vozaču koji se registrovao ima mogućnost da odobri ili ne odobri poslani zahtjev. U slučaju da je zahtjev odobren, vozač postaje novi zaposlenik firme e-Taxi.\
Bitno je napomenuti da admin ima mogućnost odobravanja zahtjeva za registraciju samo kod vozača, ali ne i kod korisnika(klijenta).

## **Uređivanje profila vozača**
Nakon što je registracija vozača odobrena od strane admina, vozač uređuje vlastiti profil postavljajući dodatne informacije kao što su:\
•	Model automobila\
•	Link automobila\
•	Broj sjedišta u automobilu\
•	Model pametnog telefona\
•	Profilna slika\
•	Govorni jezici, itd.\
Bitno je napomenuti da se na profilu vozača nalazi i ocjena koja predstavlja ukupan dojam klijenata o tom vozaču.

## **Blokiranje profila vozača**
Admin ima mogućnost da blokira određenog vozača u zavisnosti od ukupnog dojma klijenata, odnosno rejtinga tj. ocjene vozača. Pored toga, admin ima mogućnost i da odblokira vozača što omogućava scenarij u slučaju da vozač dobije suspenziju od npr. dva mjeseca, može se ponovo registrovati kao vozač tek nakon dva mjeseca.

## **Pristup profilima vozača/klijenata**
Admin ima pristup svim profilima vozača.\
Vozači imaju pristup isključivo vlastitom profilu.\
Klijent također ima pristup vlastitom profilu, kao i profilima svih vozača.

## **Zahtjev za uslugu**
Klijent najprije šalje zahtjev za uslugu, koja uključuje podatke o pojedinostima vožnje i o željenoj destinaciji kao što su:\
•	Grad\
•	Adresa\
•	Broj osoba koje se prevoze\
Dok se trenutna lokacija klijenta određuje pomoću Bing Maps platforme. Svaki od vozača, koji su trenutno slobodni, koji se nalaze u datom gradu i koji zadovoljavaju traženi broj sjedišta, dobija zahtjev za navedenu vožnju u obliku notifikacije na profil. Vozači sami odlučuju kojeg klijenta će uslužiti. Nakon prihvatanja zahtjeva, svim ostalim vozačima se data notifikacija gasi čime je osigurana nemogućnost da više vozača prihvati istu rutu. Vozač koji je prihvatio zahtjev, posjeduje opciju uvida u trenutnu lokaciju klijenta u obliku forme na kojoj se otvara Bing Maps.

## **Oznaka kraja vožnje**
Nakon dolaska na željenu destinaciju koju je precizirao klijent, vozač na dugme označava kraj vožnje. Plaćanje se vrši isključivo gotovinom, a cijena se određuje na osnovu pređene kilometraže.

## **Upitnik o vožnji**
Nakon završene vožnje, klijent ima mogućnost da u određenom vremenskom roku ispuni kratki upitnik o vožnji koji se sastoji od ocjene vozača i komentara koji trebaju sadržavati ukupni dojam o vozaču i uslugama firme e-Taxi.

## **Uvid u historiju poslovanja**
Admin posjeduje uvid u cjelokupnu historiju, informacije, kao i statističke podatke koji se tiču poslovanja firme e-Taxi. Vozač ima pristup svim prethodno obavljenim vožnjama u kojima je on bio sudionik, analogno kao i klijent.

## **Potvrda licence vozača**
Vozač je dužan jednom mjesečno potvrditi svoju licencu tako što mu se sa računa čije se stanje vidi u aplikaciji, skida određena svota novca.

## **Pogodnosti stalnih korisnika**
Atribut stalnog korisnika dobijaju oni korisnici koji imaju preko X potvrđenih vožnji, te oni imaju određeni popust na usluge. (npr. X=10)

# **Funkcionalnosti**
•	Mogućnost registracije klijenta\
•	Mogućnost registracije vozača\
•	Mogućnost zapošljavanja putem aplikacije\
•	Mogućnost prijave u sistem sa različitim privilegijama\
•	Mogućnost naručivanja vožnje\
•	Mogućnost ocjenjivanja kvaliteta vožnje\
•	Mogućnost pristupa i pregleda ranijih vožnji\
•	Mogućnost blokiranja profila vozača od strane admina\
•	Mogućnost korištenja Bing Maps platforme kroz aplikaciju za određivanje lokacije\
•	Mogućnost jednostavnog prekida uposlenja u firmi (brisanje profila vozača)\
•	Mogućnost pristupa precizno definiranom cjenovniku vožnje\
•	Mogućnost pristupa cjelokupnoj ocjeni svakog od vozača\
•	Mogućnost ostvarivanja dodatnih popusta kao i atributa stalnog korisnika\

# **Akteri**
• Administrator (admin) - Osoba koja nadgleda cjelokupni sistem, te koja ima uvid u historiju poslovanja firme.\
• Vozač - Osoba koja je uposlenik firme e-Taxi, te ima zadatak da po želji klijenta vrši usluge vožnje po unaprijed određenim rutama.\
• Klijent (korisnik) -  Osoba koja koristi navedene usluge koje pruža aplikacija, ali bez dodatnih popusta.\
• Stalni klijent (stalni korisnik) - Osoba koja koristi navedene usluge koje pruža aplikacija, uz dodatne popuste.\
• e-Taxi sistem – Sporedni akter koji predstavlja način komuniciranja korisnika (klijenta, vozača, administratora i same aplikacije).




