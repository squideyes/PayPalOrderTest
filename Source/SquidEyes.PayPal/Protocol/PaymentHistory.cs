#region Copyright, Author Details and Related Context
//<notice lastUpdateOn="4/19/2013">
//  <assembly>SquidEyes.PayPal</assembly>
//  <description>A simple PayPal order-placement library</description>
//  <copyright>
//    Copyright (C) 2013 Louis S. Berman

//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.

//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.

//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see http://www.gnu.org/licenses/.
//  </copyright>
//  <author>
//    <fullName>Louis S. Berman</fullName>
//    <email>louis@squideyes.com</email>
//    <website>http://squideyes.com</website>
//  </author>
//</notice>
#endregion 

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace SquidEyes.PayPal
{
    internal class PaymentHistory : AbstractResource
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Payment> payments { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? count { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string next_id { get; set; }
    }
}
