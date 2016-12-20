#include "tezinski_graf.h"

int main() {

	tezinski_graf g;
	g.upisGrada("Cakovec");
	g.upisGrada("Varazdin");
	g.upisGrada("Koprivnica");
	g.upisGrada("Osijek");
	g.upisGrada("Zagreb");
	g.upisGrada("Rijeka");
	g.upisGrada("Split");

	g.spojiGradove("Cakovec", "Varazdin", 12);
	g.spojiGradove("Cakovec", "Koprivnica", 50);
	g.spojiGradove("Varazdin", "Zagreb", 85);
	g.spojiGradove("Osijek", "Zagreb", 282);
	g.spojiGradove("Koprivnica", "Osijek", 190);
	g.spojiGradove("Zagreb", "Rijeka", 161);
	g.spojiGradove("Zagreb", "Split", 408);

	g.ispisMatrice();



	return 0;
}