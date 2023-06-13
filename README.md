# esim3
## Periytyminen

Luokka voi periä jonkin toisen luokan.
Esim. 
public class Cat : Animal 
{
....
}
Edellä Cat-luokka perii Animal-luokan.
Tällöin Cat-luokalla on kaikki Animal luokan 
ominaisuudet (muuttujat ja metodit), jotka ovat
public,protected tai internal tyyppiä.

C#:ssa luokka voi periä vain yhden luokan ja yhden interfacen.
-Abstrakti luokka=luokka, josta ei voi tehdä oliota. Mutta se voidaan periyttää.

-Interface=hieman kuin luokka, mutta siinä määritetään vain
metodien rakenne(=palautusarvo ja parametrit). Toteuttavan ("Perivän") luokan pitää toteuttaa interfacen metodit.
Yleensä nimi alkaa I-kirjaimella.

##Access modifiers

-mistä luokkaan/muuttujaan/metodiin pääsee käsiksi
kts. https://www.w3schools.com/cs/cs_access_modifiers.php
-public
-private
-protected
-internal