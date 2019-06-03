using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaLabAplicaciones.Dao_s.Implementacion;
using TareaLabAplicaciones.DataSource;

namespace TareaLabAplicaciones
{
    class Controller
    {
        private Artist artist;
        private ArtistDao artistDao;
        //constructor
        public Controller()
        {
            
            
            artistDao = new ArtistDaoImpl();

        }

        //obtiene la ultima Intruccion Query del ArtistDaoImpl
        public String getQuery()
        {
            return artistDao.getQuery();
        }
        //obtiene la lista de todos los artistas a traves del objeto ArtistDaoImpl
        public List<Artist> getArtists()
        {
            return artistDao.getArtists();
        }

        //borra el artista actual a traves del objeto ArtistDaoImpl
        public int deleteArtist()
        {
            return artistDao.deleteArtist(Artist.Name);
        }
        //busca un artista por nombre a traves del objeto ArtistDaoImpl y lo asigna al objeto artist
        public Artist searchArtist(String name)
        {
            artist = artistDao.searchArtist(name);
            return artist;
        }
        //busca un artista por nombre y compañia a traves del objeto ArtistDaoImpl y lo asigna al objeto artist
        public Artist searchArtist(String name, Company company)
        {
            artist = artistDao.searchArtist(name, company);
            return artist;
        }
        //agrega un artista por medio del objeto ArtistDaoImpl
        public int addArtist(String name, String company, String sales)
        {
            return artistDao.addArtist(name, company, sales);
        }
        //actualiza la compañia y las ventas del artista actual por medio del objeto ArtistDaoImpl
        public int updateArtist(String name, String company, String sales)
        {
            return artistDao.updateArtist(name, company, sales);
        }
        //busca un artista por compañia a traves del objeto ArtistDaoImpl y lo asigna al objeto artist
        public Artist searchArtist(Company company)
        {
            artist = artistDao.searchArtist(company);
            return artist;
        }
        internal Artist Artist
        {
            get
            {
                return artist;
            }

            set
            {
                artist = value;
            }
        }

    }
}
