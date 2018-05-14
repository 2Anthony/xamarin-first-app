using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MyFirstApp.Models
{
    public class Actividad
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string detalle { get; set; }

        public List<Actividad> permanence = new List<Actividad>();

        public Actividad crear_activity()
        {
            Actividad o = new Actividad();
            o.id = 1;
            o.titulo = "Some";
            o.detalle = "Descripcion";
            return o;
        }
        public Activity editar_activity(int id, string titulo, string detalle)
        {
            return new Activity();
        }
    }
}