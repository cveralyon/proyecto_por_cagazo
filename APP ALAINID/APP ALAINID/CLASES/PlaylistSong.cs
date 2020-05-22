﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto
{
    [Serializable]
    public class PlaylistSong
    {
        private string nombrePlaylist;
        private List<Song> listplay = new List<Song>();

        public string NombrePlaylist { get => nombrePlaylist; set => nombrePlaylist = value; }
        public List<Song> Listplay { get => listplay; set => listplay = value; }

        public PlaylistSong(string _nombrepl)
        {
            this.NombrePlaylist = _nombrepl;
        }
        public string InformationPLL()
        {
            string stringaux1 = " ";
            if (Listplay.Count == 0)
            {
                return "No hay canciones en la playlist";
            }
            else
            {
                stringaux1 += "Nombre Playlist: " + NombrePlaylist + "\n";
                for (int i = 0; i < Listplay.Count; i++)
                {
                    stringaux1 += "Cancion" + " " + (i + 1) + "\n";
                    stringaux1 += "============ \n";
                    stringaux1 += Listplay[i].Informacioncancion() + "\n";
                    stringaux1 += " ";
                }
                return stringaux1;
            }
        }
    }
}

