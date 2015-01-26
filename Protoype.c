#include <stdlib.h>
#include <stdio.h>

float saisie();

unsigned short plus();
float reglement(float facture);

int main()
{
	int choix;
	float somme;
	
	while(1)
	{
		printf ("\1 - emporter\n2 - sur place\n3 - plus\n4 - quitter\n");
		
		fflush(stdin);
		scanf("%d",&choix);
		
		switch(choix)
		{
			case 1 :
				reglement(saisie());
			break;
			
			case 2 :
				reglement(saisie()*0.9);
			break;
			
			case 3 :
				plus();
			break;
			
			case 4 :
				return 0;
			break;
			
			default:
				printf("1, 2, 3, ou 4");
				return 0;
			break;
		}
	}
}


float saisie()
{
	int i=0,y;
	float liste[], somme=0;
	
	do
	{
		printf("Saisissez le prix de l'article,saisissez 0 pour terminer la saisie");
		fflush(stdin);
		scanf("%d",&liste[i])
		i++;
	}
	while(!(liste[i-1]==0));
	
	for(y=0,y<i,y++)
	{
		somme+=liste[y];
	}
	return somme;
}

float reglement(float facture)
{
	int choix;
	float monnaie;
	
	printf("Total TC = %.2f euro\nmode de payement: 1-CB 2-cheque 3-espece ou TR",facture);
	fflush(stdin);
	scanf("%d",&choix);
	
	switch (choix)
	{
		case 1  :

		case 2  :
			printf("\npayement effectue");
			return 0;
		break;
		
		case 3 :
			printf("entrez la monnaie du client:");
			fflush(stdin);
			scanf("%f",&monnaie);
			while(1)
			{
				if(facture<monnaie || facture == monnaie)
				{
					printf("rendre: %.2f",monnaie-facture);
					return 0;
				}
				
				if (monnaie<facture)
				{
					printf("il reste %.2f",facture - monnaie);
				}
			}
	}
}