# CSluokkaharjoituksia 
Esimerkkejä ja harjoituksia C# luokista ja olioista. 

## Luokkien periytyminen
Luokka voi periä toiselta luokalta kenttiä ja metodeja. Luokkaa, jonka ominaisuuksia peritän (inheritance) kutsutaan yliluokaksi (superclass, parent class) ja perivää luokkaa aliluokaksi (sub class, child class): Perimisen keskeinen idea on se, ettäyliluokassa määriteltyjä ominaisuuksia (kenttiä) ja metodeja ei tarvitse enää määritellä aliluokassa, riittä että kerrotaan niiden periytyvän yliluokasta.  Yliluokalla ja aliluokalla voi olla saman nimisiä metodeja, jotka toimivat eri tavalla. Tätä kutsutaan metodien ylikirjoittamiseksi (method overload). Aiemmissa versioissa aliluokassa määritelty metodi, joka on kirjoitettu eritavala kuin yliluokassa, syrjäytti aliluokan saman nimisen metodin. Uusimmat kääntäjät eivät kuitenkaan toimi näin. Aliluokan metodi voi myös syrjäyttää yliluokan metodin silloin, kun yliluokan metodi on määritetty virtuaaliseksi (virtual) ja aliluokassa metodi on määritelty syrjäyttäväksi (overload). Toinen vaihtoehto on käyttää aliluokan metodin määrityksessä 'new' -komentoa yliluokan metodin syrjäyttämiseksi. Jos 'new' jätetään pois, aliluokka syrjäyttää edelleen yliluokan (toisin kuin dokumentaatiossa lukee). Seuraavassa esimerkissä on kolme luokkaa: yliluokka lemmikinomistajalle, sekä kaksi aliluokkaa kissan- ja koiran omistajalle. 

***csharp

***
