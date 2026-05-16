using System.Collections.Generic;

namespace ImtahanSistemi
{
    public class Person
    {
        private int _id;
        private string _ad;
        private string _soyad;
        private List<Result> _neticeler = new List<Result>();

        public int GetId()
        {
            return _id;
        }

        public void SetId(int id)
        {
            if (id > 0)
            {
                _id = id;
            }
        }

        public string GetAd()
        {
            return _ad;
        }

        public void SetAd(string ad)
        {
            if (string.IsNullOrWhiteSpace(ad) == false)
            {
                _ad = ad.Trim();
            }
        }

        public string GetSoyad()
        {
            return _soyad;
        }

        public void SetSoyad(string soyad)
        {
            if (string.IsNullOrWhiteSpace(soyad) == false)
            {
                _soyad = soyad.Trim();
            }
        }

        public List<Result> GetNeticeler()
        {
            return _neticeler;
        }

        public string TamAd()
        {
            return _ad + " " + _soyad;
        }
    }

    public class Student : Person 
    {
        private string _email;

        public string GetEmail()
        {
            return _email;
        }

        public void SetEmail(string email)
        {
            _email = email;
        }
    }

    public class Teacher : Person 
    {
    }
}
