﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentalCar.Client.MyAddVehicleWorkFlow {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyAddVehicleWorkFlow.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Add", ReplyAction="http://tempuri.org/IService/AddResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="returnValueRows")]
        int Add(RentalCar.Core.Models.VehicleDTO vehicleDataParam);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Add", ReplyAction="http://tempuri.org/IService/AddResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="returnValueRows")]
        System.Threading.Tasks.Task<int> AddAsync(RentalCar.Core.Models.VehicleDTO vehicleDataParam);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : RentalCar.Client.MyAddVehicleWorkFlow.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<RentalCar.Client.MyAddVehicleWorkFlow.IService>, RentalCar.Client.MyAddVehicleWorkFlow.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Add(RentalCar.Core.Models.VehicleDTO vehicleDataParam) {
            return base.Channel.Add(vehicleDataParam);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(RentalCar.Core.Models.VehicleDTO vehicleDataParam) {
            return base.Channel.AddAsync(vehicleDataParam);
        }
    }
}