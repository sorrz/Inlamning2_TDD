# Inlämning 2
### Laboration för ProgFö50

----------------------------------

<p>
Produkter ska lagras i en textfil (ingen Json Serialization är tillåten)
Följande data skall finns per produkt.
-Produkt ID 
-Pris
-PrisTyp
-ProduktNamn
</p>

<p>
Menyn Består av: 
1. Ny Kund
2. Admin   // Valfri!
3. Avsluta
</p>

<p>
Endast två kommandon skall finns under "Ny Kund", 
antingen <produktid> <antal> för att lägga till en produkt.
Eller <pay> för att genomföra ett köp.
Kvittot sparas och avändaren kommer tillbaka till Menyn.
</p>

### Krav för G
<p>
[x] Funktionalitet enligt ovan, enlig specifikation. 
[x] Kvittot sparas vid PAY till filen RECEIPT_yyyyMMdd.txt 
med dagens datum. Hantering av flera kvitton i samma fil.
[x] Fundera ut och implementera en särskiljare. (JSON ok för Kvitton)
</p>

### Krav för VG
<p>
[x] AdminTool för Update/Adjust Product
Note: Function Built, adding with AdminTools
[x] Add Product
Note: Function Built, adding with AdminTools
[x] Receipts need a Receipt No. This needs to increment with +1 for each
[x] Receipts No should be persistent.
[ ] Adding Campaigns to modify prices for a product over a set time span.
[ ] Add and Remove Campaigns
[ ] A Single Product can have multiple Campaigns
[x] Campaign Price is the price that shows and ends up on receipt
Note: Functionality buiilt, just need to imlement
</p>

### TODO! 
[ ] JSON Serialize Receipts
[ ] Add the adminTool functionality
[ ] Build the Tests for ICampaign Interface
[ ] Build the ICampaign
[ ] Implement a CampaignRepository 
[ ] Add the campaignList to either OrderRow or Product (what works best?)  (Ask Stefan Friday)
[ ] Fix Graphical resonably