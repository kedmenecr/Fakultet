#include <iostream>
#pragma once

using namespace std;

class tezinski_graf
{
private:
	int matrica[7][7];
	string gradovi[7];
public:
	tezinski_graf();
	~tezinski_graf();

	void upisGrada(string n);
	void spojiGradove(string grad_A, string grad_B, int udaljenost);
	int odrediUdaljenost(string Grad_A, string Grad_B);
	void ispisMatrice();
	
};

