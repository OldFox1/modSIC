﻿/*
 * Modulo Open Distributed SCAP Infrastructure Collector (modSIC)
 * 
 * Copyright (c) 2011-2014, Modulo Solutions for GRC.
 * All rights reserved.
 * 
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions are met:
 * 
 *   * Redistributions of source code must retain the above copyright notice,
 *     this list of conditions and the following disclaimer.
 *   * Redistributions in binary form must reproduce the above copyright 
 *     notice, this list of conditions and the following disclaimer in the
 *     documentation and/or other materials provided with the distribution.
 *   * Neither the name of Modulo Security, LLC nor the names of its
 *     contributors may be used to endorse or promote products derived from
 *     this software without specific  prior written permission.
 * 
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
 * AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
 * IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
 * ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE
 * LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
 * CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
 * SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
 * INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
 * CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
 * ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
 * POSSIBILITY OF SUCH DAMAGE.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modulo.Collect.Probe.Common;
using Modulo.Collect.OVAL.Definitions.Windows;
using Modulo.Collect.OVAL.Definitions;
using Modulo.Collect.OVAL.SystemCharacteristics;
using Modulo.Collect.OVAL.Common;
using Modulo.Collect.Probe.Windows.WMI;
using System.Management;

namespace Modulo.Collect.Probe.Windows.Probes.WMI.Wmi57
{
    [ProbeCapability(OvalObject="wmi57", PlataformName=FamilyEnumeration.windows)]
    public class Wmi57Prober: ProbeBase, IProbe
    {
        private TargetInfo TargetInfo;

        protected override OVAL.Definitions.set GetSetElement(OVAL.Definitions.ObjectType objectType)
        {
            return ((wmi57_object)objectType).Items.OfType<set>().FirstOrDefault();
        }

        protected override void OpenConnectionProvider(IList<IConnectionProvider> connectionContext, TargetInfo target)
        {
            this.TargetInfo = target;
        }

        protected override void ConfigureObjectCollector()
        {
            if (base.ItemTypeGenerator == null)
                base.ItemTypeGenerator = new Wmi57ItemTypeGenerator();

            if (base.ObjectCollector == null)
                base.ObjectCollector = new Wmi57ObjectCollector(this.TargetInfo);
        }


        protected override OVAL.SystemCharacteristics.ItemType CreateItemTypeWithErrorStatus(string errorMessage)
        {
            var messageType = new MessageType() { level = MessageLevelEnumeration.error, Value = errorMessage };
            return new wmi57_item() { status = StatusEnumeration.error, message = new MessageType[] { messageType } };
        }

        protected override IEnumerable<OVAL.Definitions.ObjectType> GetObjectsOfType(IEnumerable<OVAL.Definitions.ObjectType> objectTypes)
        {
            throw new NotImplementedException();
        }
    }
}
