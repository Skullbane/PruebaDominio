using System;

namespace HospiEnCasa.App.Dominio
{

///<sumary> Class <c>Paciente</c>
/// Modela un Paciente en el sistema
///</sumary>

    public class Paciente : Persona
    {
        ///Coordenada de la dirección del Paciente
        public string Direccion{get;set;}
        public float Latitud{get;set;}
        public float Longitud{get;set;}
        ///Ciudad de residencia del Paciente
        public string Ciudad{get;set;}
        ///Fecha de nacimiento del Paciente
        public DateTime FechaNacimiento{get;set;}
        ///Relacion entre el Paciente y su FamiliarDesignado para cuidarlo
        public FamiliarDesignado Familiar{get;set;}
        ///Relacion entre el Paciente y la Enfermera asignada
        public Enfermera Enfermera{get;set;}
        ///Relacion entre el Paciente y el Medico que lo atiende
        public Medico Medico{get;set;}
        ///Relacion entre el Paciente y su Historia Clinica
        public Historia Historia{get;set;}
        ///<summary>
        ///Referencia a la lista de los signos vitales de un paciente
        ///</summary>
        ///<value></value>
        public System.Collections.Generic.List<SignoVital> SignosVitales{get;set;}
    }

}