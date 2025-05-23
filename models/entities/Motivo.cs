using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PPAI_backend.models.entities
{
    public class Motivo
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string? Comentario { get; set; } // significa que es opcional (puede ser null)

        public string obtenerMotivoFueraServicio()
        {
            return $"Motivo ID: {Id} - {Descripcion} - Comentario: {Comentario}";
        }



    }
}