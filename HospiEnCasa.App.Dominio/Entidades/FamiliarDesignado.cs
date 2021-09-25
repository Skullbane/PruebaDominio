using System;

namespace HospiEnCasa.App.Dominio
{

///<sumary> Class <c>FamiliarDesignado</c>
/// Modela un familiar designado en el sistema
///</sumary>

    public class FamiliarDesignado : Persona
    {
        ///Parentesco con el enfermo
        public string Parentesco{get;set;}
        ///Dirección de correo electronico
        public string Correo{get;set;}
        
    }

}