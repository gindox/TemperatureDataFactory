// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Newtonsoft.Json;

namespace TemperatureDataFactory
{
    public class MessageBody
    {
        [JsonProperty("InstanceId")]
        public int InstanceId { get; set; }

        [JsonProperty("machine")]
        public Machine Machine { get; set; }
        [JsonProperty("ambient")]
        public Ambient Ambient { get; set; }
        [JsonProperty("timeCreated")]
        public string TimeCreated { get; set; }
        [JsonProperty("machineCode")]
        public string MachineCode {get; set; }
    }

    [JsonObject("machine")]
    public class Machine
    {
        [JsonProperty("temperature")]
        public double Temperature { get; set; }
        [JsonProperty("pressure")]
        public double Pressure { get; set; }
    }

    [JsonObject("ambient")]
    public class Ambient
    {
        [JsonProperty("temperature")]
        public double Temperature { get; set; }
        [JsonProperty("humidity")]
        public int Humidity { get; set; }
    }
}// Copyright (c) Microsoft. All rights reserved.
namespace SimulatedTemperatureSensor
{
    using System;
    using Newtonsoft.Json;

    // NOTE: IF CHANGING ANYTHING IN THIS FILE, UPDATE MESSAGEBODY.CS IN TEMPERATURE FILTER
    // TODO Put message body in a common lib

    /// <summary>
    ///Body:
    ///{
    ///  “machine”:{
    ///    “temperature”:,
    ///    “pressure”:
    ///  },
    ///  “ambient”:{
    ///    “temperature”: ,
    ///    “humidity”:
    ///  }
    ///  “timeCreated”:”UTC iso format”
    ///}
    ///Units and types:
    ///Temperature: double, C
    ///Humidity: int, %
    ///Pressure: double, psi
    /// </summary>
    class MessageBody
    {
        [JsonProperty(PropertyName = "machine")]
        public Machine Machine { get; set; }

        [JsonProperty(PropertyName = "ambient")]
        public Ambient Ambient { get; set; }

        [JsonProperty(PropertyName = "timeCreated")]
        public DateTime TimeCreated { get; set; }
    }

    class Machine
    {
        [JsonProperty(PropertyName = "temperature")]
        public double Temperature { get; set; }

        [JsonProperty(PropertyName = "pressure")]
        public double Pressure { get; set; }
    }

    class Ambient
    {
        [JsonProperty(PropertyName = "temperature")]
        public double Temperature { get; set; }

        [JsonProperty(PropertyName = "humidity")]
        public int Humidity { get; set; }
    }
}
