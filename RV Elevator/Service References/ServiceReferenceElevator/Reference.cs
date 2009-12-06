﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RV_Elevator.ServiceReferenceElevator {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceElevator.Service1Soap")]
    public interface Service1Soap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        RV_Elevator.ServiceReferenceElevator.HelloWorldResponse HelloWorld(RV_Elevator.ServiceReferenceElevator.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MovementControl", ReplyAction="*")]
        void MovementControl();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DoorControl", ReplyAction="*")]
        bool DoorControl(int open, double floor, int peopletime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ExceptionHandling", ReplyAction="*")]
        void ExceptionHandling();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Alarm", ReplyAction="*")]
        bool Alarm(int weight, int time);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public RV_Elevator.ServiceReferenceElevator.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(RV_Elevator.ServiceReferenceElevator.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public RV_Elevator.ServiceReferenceElevator.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(RV_Elevator.ServiceReferenceElevator.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface Service1SoapChannel : RV_Elevator.ServiceReferenceElevator.Service1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class Service1SoapClient : System.ServiceModel.ClientBase<RV_Elevator.ServiceReferenceElevator.Service1Soap>, RV_Elevator.ServiceReferenceElevator.Service1Soap {
        
        public Service1SoapClient() {
        }
        
        public Service1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        RV_Elevator.ServiceReferenceElevator.HelloWorldResponse RV_Elevator.ServiceReferenceElevator.Service1Soap.HelloWorld(RV_Elevator.ServiceReferenceElevator.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            RV_Elevator.ServiceReferenceElevator.HelloWorldRequest inValue = new RV_Elevator.ServiceReferenceElevator.HelloWorldRequest();
            inValue.Body = new RV_Elevator.ServiceReferenceElevator.HelloWorldRequestBody();
            RV_Elevator.ServiceReferenceElevator.HelloWorldResponse retVal = ((RV_Elevator.ServiceReferenceElevator.Service1Soap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        public void MovementControl() {
            base.Channel.MovementControl();
        }
        
        public bool DoorControl(int open, double floor, int peopletime) {
            return base.Channel.DoorControl(open, floor, peopletime);
        }
        
        public void ExceptionHandling() {
            base.Channel.ExceptionHandling();
        }
        
        public bool Alarm(int weight, int time) {
            return base.Channel.Alarm(weight, time);
        }
    }
}
