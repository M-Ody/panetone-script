﻿using ScriptsLoader.Utils;

namespace PanetoneScript.PSLog
{
    public class Error : Logable
    {
        public Error(string message)
        {
            Message = message;
        }

        public override void Print()
        {
            Debug.LogError(Message);
        }
    }
}
