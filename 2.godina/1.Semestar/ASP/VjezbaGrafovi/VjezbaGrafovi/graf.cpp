#include "graf.h"

graf::graf(void) //konstruktor
{
	start = NULL;
}

//vraca pokazivac na cvor sa zadanim podatkom
cvor *graf::vrati_cvor(char *podatak) const
{
	cvor *c = start;
	while (c != NULL && c->podatak != podatak)
		c = c->sljedeci;
	if (c == NULL)
		cout << "Greska, cvor nije pronadjen!";
	return c;
}

//vrati statuse cvorova na 0
void graf::reinicijaliziraj()
{
	for (cvor *c = start; c != NULL; c = c->sljedeci)
		c->status = 0;
}

//dodavanje novog cvora
void graf::dodaj_cvor(char *podatak)
{
	//kreiramo novi cvor
	cvor *novi = new cvor;
	novi->podatak = podatak;
	novi->status = 0;
	novi->susjedi = NULL;
	novi->sljedeci = NULL;
	//dodajemo cvor na kraj liste cvorova
	if (start == NULL)
		start = novi;
	else
	{
		cvor *c = start;
		while (c->sljedeci != NULL)
			c = c->sljedeci;
		c->sljedeci = novi;
	}
}

//dodavanje veze izmedju dva cvora
void graf::dodaj_vezu(char *podatak1, char *podatak2, int tip)
{
	veza *nova = new veza; //kreiramo novu vezu
	nova->susjed = vrati_cvor(podatak2); //nova veza gleda na cvor sa podatkom2
	nova->sljedeca = NULL;
	//dodajemo novu vezu na kraj liste susjedstva podatka1
	cvor *c = vrati_cvor(podatak1);
	if (c->susjedi == NULL)
		c->susjedi = nova;
	else
	{
		veza *v = c->susjedi; //pokazivac na prvog susjeda
		while (v->sljedeca != NULL)
			v = v->sljedeca;
		v->sljedeca = nova;
	}
	if (tip == 2) //ako je dvosmjerna veza, dodaj povratnu vezu
		dodaj_vezu(podatak2, podatak1, 1);
}

//ispis grafa
void graf::ispisi_graf() const
{
	for (cvor *c = start; c != NULL; c = c->sljedeci) //cvorovi
	{
		if (c == start)
			cout << "START\t";
		else
			cout << "\t";
		cout << "(" << c->podatak << ", " << c->status << ")\t-> ";
		for (veza *v = c->susjedi; v != NULL; v = v->sljedeca) //veze
			cout << v->susjed->podatak << ", ";
		cout << endl;
	}
	cout << endl;
}

graf::~graf(void) //destruktor
{
	while (start != NULL)
	{
		cvor *c = start->sljedeci;
		delete start;
		start = c;
	}
}

//bsf obilazak - koristi RED kao strukturu za zapisivanje cvorova kod obrade
void graf::bfs()
{
	char **red = new char*[50]; //red - niz polja karaktera
	int i = 1, j = 0; //kraj (i) i pocetak (j) reda 
	cvor *p = start; //pomocni cvor
	reinicijaliziraj(); //stavi statuse na 0
	red[0] = p->podatak; //push pocetni cvor u red
	p->status = 1; //obiljezi cvor
	while (true)
	{
		if (red[j] == NULL) //ponavljaj petlju dok red nije prazan
			break;
		p = vrati_cvor(red[j]); //vrati cvor prvog podatka u redu
		veza *k = p->susjedi; //dohvati listu susjedstva za prvog u redu
		while (k != NULL) //dok ima susjeda
		{
			cvor *q = k->susjed; //dohvati susjeda
			if (q->status == 0) //ako susjed nije obidjen
			{
				red[i++] = q->podatak; //stavi susjeda na kraj reda i povecaj i
				red[i] = NULL; //obiljezi sljedece polje u redu sa NULL jer nismo na pocetku
				q->status = 1; //obiljezi susjeda
			}
			k = k->sljedeca; //idi na sljedeceg susjeda
		}
		j++; //pomakni red naprijed
	}
	//ispis cvorova iz arhive reda
	cout << "Rezultati BFS obilaska:" << endl;
	for (j = 0; red[j] != NULL; j++)
		cout << red[j] << ", ";
	cout << endl;
}

//DFS obilazak - korisi STOG kao strukturu za zapisivanje èvorova kod obrade
void graf::dfs()
{
	char **stog = new char*[50]; //stog - niz polja karaktera
	int top = 1; //vrh stoga
	cout << "Rezultati DFS obilaska:" << endl;
	cvor *p = start; //pomocni cvor
	reinicijaliziraj(); //statusi na 0
	stog[0] = NULL; //zavrsetak stoga
	stog[top] = p->podatak; //podatak push na stog
	p->status = 1; //obiljezi cvor
	while (true)
	{
		if (stog[top] == NULL) //vrti petlju dok ima nesto na stogu
			break;
		p = vrati_cvor(stog[top]); //vrati cvor sa vrha stoga
		cout << stog[top] << ", "; //ispisi cvor
		top--; //korigiraj top
		veza *k = p->susjedi; //dohvati susjede
		while (k != NULL) //dok ima susjeda
		{
			cvor *q = k->susjed; //dohvati susjeda
			if (q->status == 0) //ako nije obiljezen savi ga na stog i obiljezi ga
			{
				stog[++top] = q->podatak;
				q->status = 1;
			}
			k = k->sljedeca;
		}
	}
	cout << endl;
}


