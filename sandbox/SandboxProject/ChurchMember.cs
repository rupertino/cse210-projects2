﻿using System;

namespace SandboxProject
{
    public class ChurchMember : Person
    {
        private string _calling = "";
        public string GetCalling()
        {
            return _calling;
        }
        public void SetCalling(string calling)
        {
            _calling = calling;
        }

        public string GetChurchMemberInfo()
        {
            return $"{_firstName} {_lastName}, {_calling}";
        }
        
        
        

    }
}
