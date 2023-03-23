# Inlämning 2
### Laboration för ProgFö50

----------------------------------

<p>
Produkter ska lagras i en textfil (ingen Json Serialization är tillåten)<br>
Följande data skall finns per produkt.<br>
-Produkt ID <br>
-Pris<br>
-PrisTyp<br>
-ProduktNamn<br>
</p>
<br>
<p>
Menyn Består av: <br>
1. Ny Kund<br>
2. Admin   // Valfri!<br>
3. Avsluta<br>
</p>
<br>
<p>
Endast två kommandon skall finns under "Ny Kund", <br>
antingen <produktid> <antal> för att lägga till en produkt.<br>
Eller <pay> för att genomföra ett köp.<br>
Kvittot sparas och avändaren kommer tillbaka till Menyn.<br>
</p>
<br>
### Krav för G<br>
<p>
[x] Funktionalitet enligt ovan, enlig specifikation. <br>
[x] Kvittot sparas vid PAY till filen RECEIPT_yyyyMMdd.txt <br>
med dagens datum. Hantering av flera kvitton i samma fil.<br>
[x] Fundera ut och implementera en särskiljare. (JSON ok för Kvitton)<br>
</p>
<br>
### Krav för VG<br>
<p>
[x] AdminTool för Update/Adjust Product<br>
Note: Function Built, adding with AdminTools<br>
[x] Add Product<br>
Note: Function Built, adding with AdminTools<br>
[x] Receipts need a Receipt No. This needs to increment with +1 for each<br>
[x] Receipts No should be persistent.<br>
[ ] Adding Campaigns to modify prices for a product over a set time span.<br>
[ ] Add and Remove Campaigns<br>
[ ] A Single Product can have multiple Campaigns<br>
[x] Campaign Price is the price that shows and ends up on receipt<br>
Note: Functionality buiilt, just need to imlement<br>
</p>
<br>
### TODO! <br>
[ ] JSON Serialize Receipts<br>
[ ] Add the adminTool functionality<br>
[ ] Build the Tests for ICampaign Interface<br>
[ ] Build the ICampaign<br>
[ ] Implement a CampaignRepository <br>
[ ] Add the campaignList to either OrderRow or Product (what works best?)  (Ask Stefan Friday)<br>
[ ] Fix Graphical resonably<br>