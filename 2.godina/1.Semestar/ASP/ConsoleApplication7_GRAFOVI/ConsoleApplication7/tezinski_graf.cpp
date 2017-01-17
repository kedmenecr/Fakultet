#include "tezinski_graf.h"



tezinski_graf::tezinski_graf()
{
	for (int i = 0; i < 7; i++) {
		for (int x = 0; x < 7; x++) {
			matrica[i][x] = 0;
		}
	}
}


tezinski_graf::~tezinski_graf()
{
}

void tezinski_graf::upisGrada(string n) {
	for (int i = 0; i < 7; i++) {
		if (gradovi[i] == "") {
			gradovi[i] = n;
			break;
		}
	}
}

void tezinski_graf::spojiGradove(string grad_A, string grad_B, int udaljenost) {
	int la = 0;
	int lb = 0;

	while (gradovi[la] != grad_A)
		la++;

	while (gradovi[lb] != grad_B)
		lb++;

	matrica[la][lb] = udaljenost;
	matrica[lb][la] = udaljenost;
}



void tezinski_graf :: ispisMatrice(){
	for (int i = 0; i < 7; i++) {
		for (int x = 0; x < 7; x++) {
			cout << matrica[i][x] <<"\t";
		}
		cout << endl;
	}

}



