﻿/*
 * Modulo Open Distributed SCAP Infrastructure Collector (modSIC)
 * 
 * Copyright (c) 2011-2014, Modulo Solutions for GRC.
 * All rights reserved.
 * 
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions are met:
 * 
 * - Redistributions of source code must retain the above copyright notice,
 *   this list of conditions and the following disclaimer.
 *   
 * - Redistributions in binary form must reproduce the above copyright 
 *   notice, this list of conditions and the following disclaimer in the
 *   documentation and/or other materials provided with the distribution.
 *   
 * - Neither the name of Modulo Security, LLC nor the names of its
 *   contributors may be used to endorse or promote products derived from
 *   this software without specific  prior written permission.
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
 * */
using System;
using System.Collections.Generic;
using Modulo.Collect.Probe.Common.Extensions;
using System.Linq;

namespace Modulo.Collect.Probe.Unix.SSHCollectors
{
    public class PasswdInfo
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Uid { get; set; }
        public string Gid { get; set; }
        public string Gecos { get; set; }
        public string HomeDir { get; set; }
        public string Shell { get; set; }

        public override string ToString()
        {
            return String.Format("{0} ({1}): uid {2}, gid {3}", UserName, String.IsNullOrEmpty(Gecos) ? "no full name" : Gecos, Uid, Gid);
        }
    }

    public class PasswordCollector
    {
        public SshCommandLineRunner CommandRunner { get; set; }

        private PasswdInfo parsePasswdInfo(string line)
        {
            PasswdInfo retInfo = null;
            char[] elemseps = { ':' };
            string[] ffields = line.Split(elemseps);
            if (ffields.GetUpperBound(0) == 6)
            {
                retInfo = new PasswdInfo();
                retInfo.UserName = ffields[0];
                retInfo.Password = ffields[1];
                retInfo.Uid = ffields[2];
                retInfo.Gid = ffields[3];
                retInfo.Gecos = ffields[4];
                retInfo.HomeDir = ffields[5];
                retInfo.Shell = ffields[6];
            }
            return retInfo;
        }

        public virtual Dictionary<string, PasswdInfo> GetTargetPasswdInfo()
        {
            var commandResultLines = CommandRunner.ExecuteCommand("cat /etc/passwd").SplitStringByDefaultNewLine();
            var allPasswordInfo = commandResultLines.Select(cmdLine => parsePasswdInfo(cmdLine));
            return allPasswordInfo.Where(pwdInfo => pwdInfo != null).ToDictionary(x => x.UserName, x => x);
            
            //foreach (string line in commandResultLines)
            //{
            //    PasswdInfo thisInfo = parsePasswdInfo(line);
            //    if (thisInfo != null)
            //        retList[thisInfo.UserName] = thisInfo;
            //}

            //return retList;
        }
    }
}
