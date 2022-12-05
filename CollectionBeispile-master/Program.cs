using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionBeispile {
    class Program {
        static void Main ( string [ ] args ) {
            ArrayList al = new ArrayList ( );
            al.Add ( "MeinString" );
            al.Add ( "MeinAndererString" );
            al.Add ( new object() );

            Console.WriteLine ( al.Count);
            for (int i=0 ; i<al.Count ; i++ ) {
                Console.WriteLine ( al[i]);
            }

            List<string> StringList = new List<string> ( );
            StringList.Add ( "Robert");
            StringList.Add ( "Gänsefüßchen");

            foreach ( string einString in StringList ) {
                Console.WriteLine ( einString );
            }
            Console.WriteLine ( "=================================");
            Stack<string> einStackObjekt = new Stack<string> ( );
            einStackObjekt.Push ( "Karte_01" );
            einStackObjekt.Push ( "Karte_02" );
            einStackObjekt.Push ( "Karte_03" );

            Console.WriteLine ( einStackObjekt.Peek());
            einStackObjekt.Pop ( );
            Console.WriteLine ( einStackObjekt.Peek ( ) );

            einStackObjekt.Pop ( );
            Console.WriteLine ( einStackObjekt.Peek ( ) );
            Console.WriteLine ( "================================");

            Queue<string> warteschlange = new Queue<string> ( );
            warteschlange.Enqueue ( "Karte_01");
            warteschlange.Enqueue ( "Karte_02");
            warteschlange.Enqueue ( "Karte_03");

            Console.WriteLine ( warteschlange.Peek());
            //warteschlange.Dequeue ( );
            Console.WriteLine ( warteschlange.Peek ( ) );
            //warteschlange.Dequeue ( );
            Console.WriteLine ( warteschlange.Peek ( ) );

            Console.WriteLine ( "==========================");

            List<string> eineListe = warteschlange.ToList();

            foreach ( string einEintrag in eineListe ) {
                Console.WriteLine (einEintrag);
            }
            Console.WriteLine ("===========================");
            // Golferproblem
            Bus bus = new Bus ( );
            bus.Einsteigen ( new Golfer ( ) { Name="Sebastian"} );
            bus.Einsteigen ( new Golfer ( ) { Name="Selim"} );
            bus.Einsteigen ( new Golfer ( ) { Name="Burcu"} );
            bus.Einsteigen ( new Golfer ( ) { Name="Sven"} );

            Golfer g1 = bus.Aussteigen ( );
            Console.WriteLine ( g1.Name);

            Golfer g2 = bus.Aussteigen ( );
            Console.WriteLine ( g2.Name);

            Golfer g3 = bus.Aussteigen ( );
            Console.WriteLine ( g3.Name );

            //Golfer g4 = bus.Aussteigen ( );
            //Console.WriteLine ( g4.Name );
            Console.WriteLine ( bus.WerSteigtAlsNaechsterAus().Name);

            Console.Read ( );
        }
    }
}
