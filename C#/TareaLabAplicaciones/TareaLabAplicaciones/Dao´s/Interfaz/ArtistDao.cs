using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaLabAplicaciones.Dao_s.Implementacion
{
    interface ArtistDao
    {
        //interfaces que se usaran para reaizar consultas y actualizaciones con el objeto Artist
        String getQuery();
        List<Artist> getArtists();
        Artist searchArtist(String name);
        Artist searchArtist(Company company);
        Artist searchArtist(String name, Company company);
        int deleteArtist(String name);
        int updateArtist(String name, String company, String sales);
        int addArtist(String name, String company, String sales);
    } 
}
