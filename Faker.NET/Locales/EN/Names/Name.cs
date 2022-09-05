﻿namespace Faker.NET.Locales.EN.Names
{
    public static class Name
    {
        public static string FirstName
        {
            get
            {
                return firstName.Get();
            }
        }

        public static string LastName
        {
            get
            {
                return lastName.Get();
            }
        }

        public static string FullName
        {
            get
            {
                return $"{firstName.Get()} {lastName.Get()}";
            }
        }

        public static string Suffix
        {
            get
            {
                return suffix.Get();
            }
        }

        public static string Prefix
        {
            get
            {
                return prefix.Get();
            }
        }

        public static string JobTitle
        {
            get
            {
                return title.Get();
            }
        }

        public static string Email
        {
            get
            {
                return email.Get(FullName);
            }
        }

        private static FirstName firstName = new FirstName();
        private static LastName lastName = new LastName();
        private static Suffix suffix = new Suffix();
        private static Prefix prefix = new Prefix();
        private static Title title = new Title();
        private static Email email = new Email();
    }
}