﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace E_Commerce.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento us_nom del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/crearUsuarios", ReplyAction="*")]
        E_Commerce.ServiceReference1.crearUsuariosResponse crearUsuarios(E_Commerce.ServiceReference1.crearUsuariosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/crearUsuarios", ReplyAction="*")]
        System.Threading.Tasks.Task<E_Commerce.ServiceReference1.crearUsuariosResponse> crearUsuariosAsync(E_Commerce.ServiceReference1.crearUsuariosRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento listarUsuariosResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/listarUsuarios", ReplyAction="*")]
        E_Commerce.ServiceReference1.listarUsuariosResponse listarUsuarios(E_Commerce.ServiceReference1.listarUsuariosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/listarUsuarios", ReplyAction="*")]
        System.Threading.Tasks.Task<E_Commerce.ServiceReference1.listarUsuariosResponse> listarUsuariosAsync(E_Commerce.ServiceReference1.listarUsuariosRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento us_dni del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizarUsuario", ReplyAction="*")]
        E_Commerce.ServiceReference1.actualizarUsuarioResponse actualizarUsuario(E_Commerce.ServiceReference1.actualizarUsuarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizarUsuario", ReplyAction="*")]
        System.Threading.Tasks.Task<E_Commerce.ServiceReference1.actualizarUsuarioResponse> actualizarUsuarioAsync(E_Commerce.ServiceReference1.actualizarUsuarioRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento us_dni del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminarUsuario", ReplyAction="*")]
        E_Commerce.ServiceReference1.eliminarUsuarioResponse eliminarUsuario(E_Commerce.ServiceReference1.eliminarUsuarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminarUsuario", ReplyAction="*")]
        System.Threading.Tasks.Task<E_Commerce.ServiceReference1.eliminarUsuarioResponse> eliminarUsuarioAsync(E_Commerce.ServiceReference1.eliminarUsuarioRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento us_correo del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/validarUsuario", ReplyAction="*")]
        E_Commerce.ServiceReference1.validarUsuarioResponse validarUsuario(E_Commerce.ServiceReference1.validarUsuarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/validarUsuario", ReplyAction="*")]
        System.Threading.Tasks.Task<E_Commerce.ServiceReference1.validarUsuarioResponse> validarUsuarioAsync(E_Commerce.ServiceReference1.validarUsuarioRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class crearUsuariosRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="crearUsuarios", Namespace="http://tempuri.org/", Order=0)]
        public E_Commerce.ServiceReference1.crearUsuariosRequestBody Body;
        
        public crearUsuariosRequest() {
        }
        
        public crearUsuariosRequest(E_Commerce.ServiceReference1.crearUsuariosRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class crearUsuariosRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string us_nom;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string us_contra;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string us_correo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string us_dni;
        
        public crearUsuariosRequestBody() {
        }
        
        public crearUsuariosRequestBody(string us_nom, string us_contra, string us_correo, string us_dni) {
            this.us_nom = us_nom;
            this.us_contra = us_contra;
            this.us_correo = us_correo;
            this.us_dni = us_dni;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class crearUsuariosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="crearUsuariosResponse", Namespace="http://tempuri.org/", Order=0)]
        public E_Commerce.ServiceReference1.crearUsuariosResponseBody Body;
        
        public crearUsuariosResponse() {
        }
        
        public crearUsuariosResponse(E_Commerce.ServiceReference1.crearUsuariosResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class crearUsuariosResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string crearUsuariosResult;
        
        public crearUsuariosResponseBody() {
        }
        
        public crearUsuariosResponseBody(string crearUsuariosResult) {
            this.crearUsuariosResult = crearUsuariosResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class listarUsuariosRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="listarUsuarios", Namespace="http://tempuri.org/", Order=0)]
        public E_Commerce.ServiceReference1.listarUsuariosRequestBody Body;
        
        public listarUsuariosRequest() {
        }
        
        public listarUsuariosRequest(E_Commerce.ServiceReference1.listarUsuariosRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class listarUsuariosRequestBody {
        
        public listarUsuariosRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class listarUsuariosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="listarUsuariosResponse", Namespace="http://tempuri.org/", Order=0)]
        public E_Commerce.ServiceReference1.listarUsuariosResponseBody Body;
        
        public listarUsuariosResponse() {
        }
        
        public listarUsuariosResponse(E_Commerce.ServiceReference1.listarUsuariosResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class listarUsuariosResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string listarUsuariosResult;
        
        public listarUsuariosResponseBody() {
        }
        
        public listarUsuariosResponseBody(string listarUsuariosResult) {
            this.listarUsuariosResult = listarUsuariosResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class actualizarUsuarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="actualizarUsuario", Namespace="http://tempuri.org/", Order=0)]
        public E_Commerce.ServiceReference1.actualizarUsuarioRequestBody Body;
        
        public actualizarUsuarioRequest() {
        }
        
        public actualizarUsuarioRequest(E_Commerce.ServiceReference1.actualizarUsuarioRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class actualizarUsuarioRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string us_dni;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string us_correo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string us_nom;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string us_contrasena;
        
        public actualizarUsuarioRequestBody() {
        }
        
        public actualizarUsuarioRequestBody(string us_dni, string us_correo, string us_nom, string us_contrasena) {
            this.us_dni = us_dni;
            this.us_correo = us_correo;
            this.us_nom = us_nom;
            this.us_contrasena = us_contrasena;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class actualizarUsuarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="actualizarUsuarioResponse", Namespace="http://tempuri.org/", Order=0)]
        public E_Commerce.ServiceReference1.actualizarUsuarioResponseBody Body;
        
        public actualizarUsuarioResponse() {
        }
        
        public actualizarUsuarioResponse(E_Commerce.ServiceReference1.actualizarUsuarioResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class actualizarUsuarioResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string actualizarUsuarioResult;
        
        public actualizarUsuarioResponseBody() {
        }
        
        public actualizarUsuarioResponseBody(string actualizarUsuarioResult) {
            this.actualizarUsuarioResult = actualizarUsuarioResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class eliminarUsuarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="eliminarUsuario", Namespace="http://tempuri.org/", Order=0)]
        public E_Commerce.ServiceReference1.eliminarUsuarioRequestBody Body;
        
        public eliminarUsuarioRequest() {
        }
        
        public eliminarUsuarioRequest(E_Commerce.ServiceReference1.eliminarUsuarioRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class eliminarUsuarioRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string us_dni;
        
        public eliminarUsuarioRequestBody() {
        }
        
        public eliminarUsuarioRequestBody(string us_dni) {
            this.us_dni = us_dni;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class eliminarUsuarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="eliminarUsuarioResponse", Namespace="http://tempuri.org/", Order=0)]
        public E_Commerce.ServiceReference1.eliminarUsuarioResponseBody Body;
        
        public eliminarUsuarioResponse() {
        }
        
        public eliminarUsuarioResponse(E_Commerce.ServiceReference1.eliminarUsuarioResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class eliminarUsuarioResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string eliminarUsuarioResult;
        
        public eliminarUsuarioResponseBody() {
        }
        
        public eliminarUsuarioResponseBody(string eliminarUsuarioResult) {
            this.eliminarUsuarioResult = eliminarUsuarioResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class validarUsuarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="validarUsuario", Namespace="http://tempuri.org/", Order=0)]
        public E_Commerce.ServiceReference1.validarUsuarioRequestBody Body;
        
        public validarUsuarioRequest() {
        }
        
        public validarUsuarioRequest(E_Commerce.ServiceReference1.validarUsuarioRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class validarUsuarioRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string us_correo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string us_contraseña;
        
        public validarUsuarioRequestBody() {
        }
        
        public validarUsuarioRequestBody(string us_correo, string us_contraseña) {
            this.us_correo = us_correo;
            this.us_contraseña = us_contraseña;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class validarUsuarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="validarUsuarioResponse", Namespace="http://tempuri.org/", Order=0)]
        public E_Commerce.ServiceReference1.validarUsuarioResponseBody Body;
        
        public validarUsuarioResponse() {
        }
        
        public validarUsuarioResponse(E_Commerce.ServiceReference1.validarUsuarioResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class validarUsuarioResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string validarUsuarioResult;
        
        public validarUsuarioResponseBody() {
        }
        
        public validarUsuarioResponseBody(string validarUsuarioResult) {
            this.validarUsuarioResult = validarUsuarioResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : E_Commerce.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<E_Commerce.ServiceReference1.WebService1Soap>, E_Commerce.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        E_Commerce.ServiceReference1.crearUsuariosResponse E_Commerce.ServiceReference1.WebService1Soap.crearUsuarios(E_Commerce.ServiceReference1.crearUsuariosRequest request) {
            return base.Channel.crearUsuarios(request);
        }
        
        public string crearUsuarios(string us_nom, string us_contra, string us_correo, string us_dni) {
            E_Commerce.ServiceReference1.crearUsuariosRequest inValue = new E_Commerce.ServiceReference1.crearUsuariosRequest();
            inValue.Body = new E_Commerce.ServiceReference1.crearUsuariosRequestBody();
            inValue.Body.us_nom = us_nom;
            inValue.Body.us_contra = us_contra;
            inValue.Body.us_correo = us_correo;
            inValue.Body.us_dni = us_dni;
            E_Commerce.ServiceReference1.crearUsuariosResponse retVal = ((E_Commerce.ServiceReference1.WebService1Soap)(this)).crearUsuarios(inValue);
            return retVal.Body.crearUsuariosResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<E_Commerce.ServiceReference1.crearUsuariosResponse> E_Commerce.ServiceReference1.WebService1Soap.crearUsuariosAsync(E_Commerce.ServiceReference1.crearUsuariosRequest request) {
            return base.Channel.crearUsuariosAsync(request);
        }
        
        public System.Threading.Tasks.Task<E_Commerce.ServiceReference1.crearUsuariosResponse> crearUsuariosAsync(string us_nom, string us_contra, string us_correo, string us_dni) {
            E_Commerce.ServiceReference1.crearUsuariosRequest inValue = new E_Commerce.ServiceReference1.crearUsuariosRequest();
            inValue.Body = new E_Commerce.ServiceReference1.crearUsuariosRequestBody();
            inValue.Body.us_nom = us_nom;
            inValue.Body.us_contra = us_contra;
            inValue.Body.us_correo = us_correo;
            inValue.Body.us_dni = us_dni;
            return ((E_Commerce.ServiceReference1.WebService1Soap)(this)).crearUsuariosAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        E_Commerce.ServiceReference1.listarUsuariosResponse E_Commerce.ServiceReference1.WebService1Soap.listarUsuarios(E_Commerce.ServiceReference1.listarUsuariosRequest request) {
            return base.Channel.listarUsuarios(request);
        }
        
        public string listarUsuarios() {
            E_Commerce.ServiceReference1.listarUsuariosRequest inValue = new E_Commerce.ServiceReference1.listarUsuariosRequest();
            inValue.Body = new E_Commerce.ServiceReference1.listarUsuariosRequestBody();
            E_Commerce.ServiceReference1.listarUsuariosResponse retVal = ((E_Commerce.ServiceReference1.WebService1Soap)(this)).listarUsuarios(inValue);
            return retVal.Body.listarUsuariosResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<E_Commerce.ServiceReference1.listarUsuariosResponse> E_Commerce.ServiceReference1.WebService1Soap.listarUsuariosAsync(E_Commerce.ServiceReference1.listarUsuariosRequest request) {
            return base.Channel.listarUsuariosAsync(request);
        }
        
        public System.Threading.Tasks.Task<E_Commerce.ServiceReference1.listarUsuariosResponse> listarUsuariosAsync() {
            E_Commerce.ServiceReference1.listarUsuariosRequest inValue = new E_Commerce.ServiceReference1.listarUsuariosRequest();
            inValue.Body = new E_Commerce.ServiceReference1.listarUsuariosRequestBody();
            return ((E_Commerce.ServiceReference1.WebService1Soap)(this)).listarUsuariosAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        E_Commerce.ServiceReference1.actualizarUsuarioResponse E_Commerce.ServiceReference1.WebService1Soap.actualizarUsuario(E_Commerce.ServiceReference1.actualizarUsuarioRequest request) {
            return base.Channel.actualizarUsuario(request);
        }
        
        public string actualizarUsuario(string us_dni, string us_correo, string us_nom, string us_contrasena) {
            E_Commerce.ServiceReference1.actualizarUsuarioRequest inValue = new E_Commerce.ServiceReference1.actualizarUsuarioRequest();
            inValue.Body = new E_Commerce.ServiceReference1.actualizarUsuarioRequestBody();
            inValue.Body.us_dni = us_dni;
            inValue.Body.us_correo = us_correo;
            inValue.Body.us_nom = us_nom;
            inValue.Body.us_contrasena = us_contrasena;
            E_Commerce.ServiceReference1.actualizarUsuarioResponse retVal = ((E_Commerce.ServiceReference1.WebService1Soap)(this)).actualizarUsuario(inValue);
            return retVal.Body.actualizarUsuarioResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<E_Commerce.ServiceReference1.actualizarUsuarioResponse> E_Commerce.ServiceReference1.WebService1Soap.actualizarUsuarioAsync(E_Commerce.ServiceReference1.actualizarUsuarioRequest request) {
            return base.Channel.actualizarUsuarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<E_Commerce.ServiceReference1.actualizarUsuarioResponse> actualizarUsuarioAsync(string us_dni, string us_correo, string us_nom, string us_contrasena) {
            E_Commerce.ServiceReference1.actualizarUsuarioRequest inValue = new E_Commerce.ServiceReference1.actualizarUsuarioRequest();
            inValue.Body = new E_Commerce.ServiceReference1.actualizarUsuarioRequestBody();
            inValue.Body.us_dni = us_dni;
            inValue.Body.us_correo = us_correo;
            inValue.Body.us_nom = us_nom;
            inValue.Body.us_contrasena = us_contrasena;
            return ((E_Commerce.ServiceReference1.WebService1Soap)(this)).actualizarUsuarioAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        E_Commerce.ServiceReference1.eliminarUsuarioResponse E_Commerce.ServiceReference1.WebService1Soap.eliminarUsuario(E_Commerce.ServiceReference1.eliminarUsuarioRequest request) {
            return base.Channel.eliminarUsuario(request);
        }
        
        public string eliminarUsuario(string us_dni) {
            E_Commerce.ServiceReference1.eliminarUsuarioRequest inValue = new E_Commerce.ServiceReference1.eliminarUsuarioRequest();
            inValue.Body = new E_Commerce.ServiceReference1.eliminarUsuarioRequestBody();
            inValue.Body.us_dni = us_dni;
            E_Commerce.ServiceReference1.eliminarUsuarioResponse retVal = ((E_Commerce.ServiceReference1.WebService1Soap)(this)).eliminarUsuario(inValue);
            return retVal.Body.eliminarUsuarioResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<E_Commerce.ServiceReference1.eliminarUsuarioResponse> E_Commerce.ServiceReference1.WebService1Soap.eliminarUsuarioAsync(E_Commerce.ServiceReference1.eliminarUsuarioRequest request) {
            return base.Channel.eliminarUsuarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<E_Commerce.ServiceReference1.eliminarUsuarioResponse> eliminarUsuarioAsync(string us_dni) {
            E_Commerce.ServiceReference1.eliminarUsuarioRequest inValue = new E_Commerce.ServiceReference1.eliminarUsuarioRequest();
            inValue.Body = new E_Commerce.ServiceReference1.eliminarUsuarioRequestBody();
            inValue.Body.us_dni = us_dni;
            return ((E_Commerce.ServiceReference1.WebService1Soap)(this)).eliminarUsuarioAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        E_Commerce.ServiceReference1.validarUsuarioResponse E_Commerce.ServiceReference1.WebService1Soap.validarUsuario(E_Commerce.ServiceReference1.validarUsuarioRequest request) {
            return base.Channel.validarUsuario(request);
        }
        
        public string validarUsuario(string us_correo, string us_contraseña) {
            E_Commerce.ServiceReference1.validarUsuarioRequest inValue = new E_Commerce.ServiceReference1.validarUsuarioRequest();
            inValue.Body = new E_Commerce.ServiceReference1.validarUsuarioRequestBody();
            inValue.Body.us_correo = us_correo;
            inValue.Body.us_contraseña = us_contraseña;
            E_Commerce.ServiceReference1.validarUsuarioResponse retVal = ((E_Commerce.ServiceReference1.WebService1Soap)(this)).validarUsuario(inValue);
            return retVal.Body.validarUsuarioResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<E_Commerce.ServiceReference1.validarUsuarioResponse> E_Commerce.ServiceReference1.WebService1Soap.validarUsuarioAsync(E_Commerce.ServiceReference1.validarUsuarioRequest request) {
            return base.Channel.validarUsuarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<E_Commerce.ServiceReference1.validarUsuarioResponse> validarUsuarioAsync(string us_correo, string us_contraseña) {
            E_Commerce.ServiceReference1.validarUsuarioRequest inValue = new E_Commerce.ServiceReference1.validarUsuarioRequest();
            inValue.Body = new E_Commerce.ServiceReference1.validarUsuarioRequestBody();
            inValue.Body.us_correo = us_correo;
            inValue.Body.us_contraseña = us_contraseña;
            return ((E_Commerce.ServiceReference1.WebService1Soap)(this)).validarUsuarioAsync(inValue);
        }
    }
}
