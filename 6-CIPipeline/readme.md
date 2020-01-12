# Omgeving

We zijn begonnen met de CI Pipeline in Jenkins. Na daarmee verschillende problemen te hebben gehad zijn we toch wat alternatieven gaan proberen. 
Uiteindelijk zijn we terecht gekoen op GoCD. 

# Configuratie

De configuratie van de pipeline is te vinden in de root folder van deze Git repository. Het bestand met de naam test.gopipeline.json.
De pipeline bestaat uit één stage met meerdere jobs. 

# Server

Omdat het ons leuk leek (en omdat we niet alle programma's op alle laptops wilden installeren) hebben we een Windows VM opgestart in Azure.

Het GoCD Dashboard hebben we blootgesteld op https://elu2-3-testing-avans.westeurope.cloudapp.azure.com:8154/go.
Hier konden alle teamgenoten de status van de pipeline checken en nieuwe builds maken.  