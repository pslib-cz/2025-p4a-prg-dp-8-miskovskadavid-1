Návrhový vzor Fasáda se používá ke zjednodušení práce se složitým systémem, který se skládá z více vzájemně provázaných subsystémů. Uživatel systému nemusí znát detaily jejich implementace ani správné pořadí volání jednotlivých metod.

Proč jsme ji zvolili v této implementaci:
Systém herní mise se skládá z několika samostatných subsystémů (mapa, postavy, inventář, zvuk, HUD), které mají rozdílná rozhraní. Fasáda poskytuje jedno jednotné rozhraní pro spuštění celé mise jedním příkazem, čímž snižuje chybovost a zjednodušuje používání systému, přičemž subsystémy zůstávají dostupné i pro pokročilé uživatele.
