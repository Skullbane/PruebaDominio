using System;

namespace HospiEnCasa.App.Dominio
{

///<sumary> Class <c>Historia</c>
/// Modela una Historia en el sistema
///</sumary>

    public class Historia
    {
        ///Identificador único de la Historia
        public int Id{get;set;}
        ///Descripción detallada del diagnostico del Paciente
        public string Diagnostico{get;set;}
        ///Descripción de la cada y habitacion del Paciente
        public string Entorno{get;set;}
        ///Referencia la lista de sugerencias registrada en la Historia del Paciente
        public System.Collections.Generic.List<SugerenciaCuidado> Sugerencias{get;set;}
    }

}