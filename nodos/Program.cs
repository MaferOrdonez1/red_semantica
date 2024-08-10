namespace RedSemanticaEjemploClase
{
    public class Program
    {
        static void Main(string[] args)
        {
            RedSemantica red = new RedSemantica();

            //NODOS

            //animales
            Nodo perro = red.CrearNodo("Perro");
            Nodo avestruz = red.CrearNodo("Avestruz");
            Nodo albatros = red.CrearNodo("Albatros");
            Nodo ballena = red.CrearNodo("Ballena");
            Nodo tigre = red.CrearNodo("Tigre");


            Nodo animal = red.CrearNodo("Animal");
            //subacategorías
            Nodo mamifero = red.CrearNodo("Mamifero");
            Nodo ave = red.CrearNodo("Ave");

            //perro 
            Nodo tiene = red.CrearNodo("Tiene");
            Nodo cuatroPatas = red.CrearNodo("Cuatro Patas");

            //avestruz
            Nodo largas = red.CrearNodo("Largas");
            Nodo no_puede = red.CrearNodo("no puede");

            //albotros
            Nodo muy_bien = red.CrearNodo("muy bien");

            //ballena
            Nodo piel = red.CrearNodo("piel");
            Nodo mar = red.CrearNodo("mar");

            //tigre
            Nodo carne = red.CrearNodo("carne");

            //animal
            Nodo vida = red.CrearNodo("vida");
            Nodo sentir = red.CrearNodo("sentir");
            Nodo moverse = red.CrearNodo("moverse");

            //mamifero
            Nodo leche = red.CrearNodo("leche");
            Nodo pelo = red.CrearNodo("pelo");

            //ave
            Nodo bien = red.CrearNodo("bien");
            Nodo plumas = red.CrearNodo("plumas");
            Nodo huevos = red.CrearNodo("huevos");


            //ARCOS

            //perro
            perro.AgregarArco(animal, "es un");
            perro.AgregarArco(cuatroPatas, "tiene");

            //avestruz
            avestruz.AgregarArco(largas, "patas");
            avestruz.AgregarArco(noPuede, "vuela");

            //albotros
            albatros.AgregarArco(muyBien, "vuela");

            //ballena
            ballena.AgregarArco(piel, "tiene");
            ballena.AgregarArco(mar, "vive_en");

            //tigre
            tigre.AgregarArco(carne, "come");

            //animal
            animal.AgregarArco(vida, "tiene");
            animal.AgregarArco(sentir, "puede");
            animal.AgregarArco(moverse, "puede");
            animal.AgregarArco(ave, "tipo_de");
            animal.AgregarArco(mamifero, "tipo_de");

            //ave
            ave.AgregarArco(bien, "vuela");
            ave.AgregarArco(plumas, "tiene");
            ave.AgregarArco(huevos, "pone");
            ave.AgregarArco(avestruz, "tipo_de");
            ave.AgregarArco(albatros, "tipo_de");

            //mamifero
            mamifero.AgregarArco(leche, "da");
            mamifero.AgregarArco(pelo, "tiene");
            mamifero.AgregarArco(ballena, "tipo_de");
            mamifero.AgregarArco(tigre, "tipo_de");

            red.MostrarRed();

        }
    }

    public class Nodo
    {
        public string Etiqueta { get; set; }
        public List<Arco> Arcos { get; set; }

        public Nodo(string etiqueta)
        {
            Etiqueta = etiqueta;
            Arcos = new List<Arco>();
        }

        public void AgregarArco(Nodo destino, string etiquetaArco)
        {
            Arcos.Add(new Arco(this, destino, etiquetaArco));
        }
    }


    public class Arco
    {
        public Nodo Origen { get; set; }
        public Nodo Destino { get; set; }
        public string Etiqueta { get; set; }

        public Arco(Nodo origen, Nodo destino, string etiqueta)
        {
            Origen = origen;
            Destino = destino;
            Etiqueta = etiqueta;
        }

        public override string ToString()
        {
            return $"{Origen.Etiqueta} -- {Etiqueta} --> {Destino.Etiqueta}";
        }
    }


    public class RedSemantica
    {
        public List<Nodo> Nodos { get; set; }

        public RedSemantica()
        {
            Nodos = new List<Nodo>();
        }

        public Nodo CrearNodo(string etiqueta)
        {
            var nodo = new Nodo(etiqueta);
            Nodos.Add(nodo);
            return nodo;
        }

        public void MostrarRed()
        {
            foreach (Nodo nodo in Nodos)
            {
                foreach (var arco in nodo.Arcos)
                {
                    Console.WriteLine(arco);
                }
            }
        }
    }
}