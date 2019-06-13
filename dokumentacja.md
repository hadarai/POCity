# Projekt POCity

###### Makymilian Czudziak

### Instrukcja dla uzytkownika

#### Cel gry

Celem gracza jest zbudowanie miasta wartego jak największą ilośc punktów za punktowane budynki.
Budynki punktowane to:

- Mieszkalny - 5 pkt
- Komercyjny - 4 pkt
- Przemyslowy - 3 pkt

Budynki punktowane to budynki strefowe, których potrzeby zostały spełnione, w przeciwnym przypadku nie są punktowane.

#### Opis planszy i budynków

Gra rozgrywa się na mapie 20 na 20 pól. Na kadym z pól mozna wybudowac nieruchomośc.
Nieruchomości dzielą się następująco:

- Drogi:
  - Autostrady
  - Aleje
  - Zwykłe
- Budynki:
  - Strefowe:
    - Mieszkalne
    - Komercyjne
    - Przemyslowe
  - Specjalne:
    - Podstawowe:
      - Elektrownie
      - Wieze ciśnień
    - Publiczne:
      - Szpital
      - Posterunek Policji
      - Straz Pozarna
    - Inne:
      - Park
      - Szkoła

Budynki mozna stawiac tylko na pustych polach oraz przy drogach, czyli w sąsiedztwie bezpośrednim z nieruchomością typu "Droga".

Rola wszystkich Specjalnych budynków sprowadza się do zaspokajania potrzeb budynków strefowych. Kazdy budynek specjalny posiada promień, wewnątrz którego budynki strefowe mają spełnioną daną potrzebę.

###### np. Budynek Komercyjny potrzebuje prądu. Jeśli jest w odległości 7 od Wiezy Ciśnień to zaspokojoną potrzebę posiadania wody.

Promienie obsługi kolejnych budynków specjalnych:

- Podstawowe:
  - Elektrownie - 8
  - Wieze ciśnień - 7
- Publiczne:
  - Szpital - 10
  - Posterunek Policji - 10
  - Straz Pozarna - 10
- Inne:
  - Park - 4
  - Szkoła - 6

Potrzeby budynków Strefowych:

- Przemysłowy:
  - Prąd
  - Woda
  - Policja
  - Straz pozarna
  - Szpital
- Komercyjny:
  - To co przemyslowy
  - Park
- Mieszkalny
  - To co Komercyjny
  - Szkola

Potrzeby kazdego budynku Specjalnego:

- Prąd
- Woda

Jeśli budynek specjalny nie ma zaspokojonych potrzeb to jego promień obsługi wynosi 0 (jest nieoperatywny).
Nie ma możliwosci burzenia budynków. Dlatego należy je stawiać w przemyślany sposób.

#### Obsługa gry

Gra posiada interfejs całkowicie tekstowy. Natomiast cały czas po uruchomieniu gry wyświetlana jest cała plansza, złożona z budynków, które się na niej znajdują.
Użytkownik komunikuje się z grą komendami.
