using System;
using System.ComponentModel.DataAnnotations;

namespace HospiEnCasa.App.Dominio
{

///<sumary> Class <c>Medico</c>
/// Modela un Medico en el sistema
///</sumary>

    public class Medico : Persona
    {
        ///Nombre de la Especialidad medica del Médico
        [Required(ErrorMessage = "Digite la Especialidad medica del Médico")]
        public string Especialidad{get;set;}
        ///Código unico del médico
        [Required(ErrorMessage = "Digite el Codigo del Médico")]
        public string Codigo{get;set;}
        ///Resgistro Unico Nacional del talento Humano
        public string RegistroRethus{get;set;}
        
    }

}