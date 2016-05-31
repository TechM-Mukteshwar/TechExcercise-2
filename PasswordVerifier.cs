using System;

namespace PasswordKata
{
    public class PasswordVerifier
    {
        private readonly string _password;

        public PasswordVerifier(string password)
        {
            _password = password;
        }

        public bool Verify()
        {
            int validConditions = 0;
            bool isContainUpperCase = false;
            if (_password.Length > 8)
            {
                validConditions++;//1st condition
            }
            if (!string.IsNullOrEmpty(_password))
            {
                validConditions++;//2nd condition
            }
            foreach (char c in _password)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    validConditions++;//3rd condition
                    break;
                }
            }
            foreach (char c in _password)
            {
                if (c >= 'a' && c <= 'z')
                {
                    validConditions++;//4th condition
                    break;
                }
            }

            foreach (char c in _password)
            {
                if (c >= '0' && c <= '9')
                {
                    validConditions++;//5th condition
                    break;
                }
            }
            if (!isContainUpperCase)
                if (validConditions < 3)
                    return false;
            return true;
        }
    }
}

