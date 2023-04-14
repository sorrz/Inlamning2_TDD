# Inlämning 2
### Laboration för ProgFö50
#### TUC Sweden, Linköping, Dan Stjärnborg

----------------------------------

<p>
Produkter ska lagras i en textfil (ingen Json Serialization är tillåten)<br>
Följande data skall finns per produkt.<br>
-Produkt ID <br>
-Pris<br>
-PrisTyp<br>
-ProduktNamn<br>
</p>
<p>
Menyn Består av: <br>
1. Ny Kund<br>
2. Admin   // Valfri!<br>
3. Avsluta<br>
</p>
<p>
Endast två kommandon skall finns under "Ny Kund", <br>
antingen <produktid /> <antal /> för att lägga till en produkt.<br>
Eller <pay /> för att genomföra ett köp.<br>
Kvittot sparas och avändaren kommer tillbaka till Menyn.<br>
</p>
### Krav för G<br>
<p>
[x] Funktionalitet enlig specifikation. <br>
[x] Kvittot sparas vid PAY till filen RECEIPT_yyyyMMdd.txt <br>
med dagens datum. Hantering av flera kvitton i samma fil.<br>
[x] Fundera ut och implementera en särskiljare. (JSON ok för Kvitton)<br>
</p>
### Krav för VG<br>
<p>
[x] AdminTool för Update/Adjust Product<br>
[x] Add Product<br>
[x] Receipts need a Receipt No. This needs to increment with +1 for each<br>
[x] Receipts No should be persistent.<br>
[x] Adding Campaigns to modify prices for a product over a set time span.<br>
[x] Add Campaigns<br>
[x] Remove Campaigns<br> 
[x] A Single Product can have multiple Campaigns<br>
[x] Campaign Price is the price that shows and ends up on receipt<br>
</p>
### TODO! <br>
[-] JSON Serialize Receipts, scrapped<br>
[x] Add the AdminTool Menu<br>
[x] Add the adminTool functionality<br>
[ ] Build the Tests for ICampaign Interface<br>
[x] Build the ICampaign<br>
[x] Implement a CampaignRepository<br>
[x] Add the campaignList to either OrderRow or Product (what works best?)  (Ask Stefan Friday)<br>
[-] Fix Graphical resonably: on hold!<br>