using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionBeispile {
    class Bus {
        private Queue<Golfer> golferPlaetze = new Queue<Golfer> ( );

        public void Einsteigen ( Golfer g) {
            golferPlaetze.Enqueue (g);
        }

        public Golfer Aussteigen ( ) {
            return golferPlaetze.Dequeue ( );
        }

        public Golfer WerSteigtAlsNaechsterAus ( ) {
            return golferPlaetze.Peek ( );
        }
    }
}
