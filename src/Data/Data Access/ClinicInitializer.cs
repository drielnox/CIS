using CIS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace CIS.Data.DataAccess
{
    internal class ClinicInitializer : DropCreateDatabaseAlways<ClinicModel>
    {
        protected override void Seed(ClinicModel context)
        {
            var titles = new List<TitleTable> 
            { 
                new TitleTable
                {
                    Identifier = 1,
                    Abbreviation = "MR",
                    Description = "Mister"
                },
                new TitleTable
                {
                    Identifier = 2,
                    Abbreviation = "MRS",
                    Description = "Missis"
                }
            };

            context.Titles.AddRange(titles);

            var logins = new List<UserTable>
            {
                new UserTable
                {
                    Identifier = 1,
                    LastName = "Tadese",
                    FirstName = "Micheal",
                    Username = "olu",
                    Password = "1234",
                    ModuleAccess = "admin",
                    StaffId = null
                },
                new UserTable
                {
                    Identifier = 2,
                    LastName = "User",
                    FirstName = "Test",
                    Username = "user",
                    Password = "pass",
                    ModuleAccess = "Default",
                    StaffId = null
                },
            };

            context.Users.AddRange(logins);

            var clinicList = new List<ClinicTable>
            {
                new ClinicTable
                {
                    Identifier = 1,
                    InternalCode = "C01",
                    Title = "Dr",
                    LastName = "Orlando",
                    FirstName = "GP",
                    Specialty = "Consultation",
                    Department = "Lagos",
                    Address = "0",
                    Telephone = string.Empty,
                    Email = null,
                    CreatedAt = new DateTime(2013, 8, 28, 15, 6, 20),
                    ModifiedAt = null
                },
                new ClinicTable
                {
                    Identifier = 2,
                    InternalCode = "C02",
                    Title = "Surgeon",
                    LastName = "Test2",
                    FirstName = "Aliko",
                    Specialty = "General Surgery",
                    Department = "Surgery",
                    Address = "Ikeja",
                    Telephone = "13452",
                    Email = "Doc@Aliko.com",
                    CreatedAt = new DateTime(2013, 8, 27, 2, 7, 33),
                    ModifiedAt = new DateTime(2013, 8, 28, 15, 32, 25)
                },
                new ClinicTable
                {
                    Identifier = 3,
                    InternalCode = "C03",
                    Title = "Mrs.",
                    LastName = string.Empty,
                    FirstName = string.Empty,
                    Specialty = string.Empty,
                    Department = string.Empty,
                    Address = "0",
                    Telephone = string.Empty,
                    Email = null,
                    CreatedAt = new DateTime(2013, 8, 27, 2, 16, 44),
                    ModifiedAt = new DateTime(2013, 8, 28, 15, 11, 21)
                },
            };

            context.Clinicians.AddRange(clinicList);

            var listPatient = new List<PatientTable> 
            { 
                new PatientTable
                {
                    Identifier = 1,
                    HospitalNumber = "H1",
                    Title = "Mr",
                    FirstName = "Test",
                    LastName = "Mike",
                    MiddleName = "O.",
                    Gender = "Male",
                    BirthDate = new DateTime(2012, 12, 1),
                    Phone = 8013,
                    MobilePhone = 8023,
                    Email = "o@a.com",
                    HomeAddress = "1, xyz street",
                    City = "yaba",
                    State = "lagos",
                    MaritalStatus = "Single",
                    PatientConsultant = "Dr Test",
                    Nationality = "nig",
                    StateOfOrigin = "oyo",
                    Hometown = "ibd",
                    PlaceOfBirth = "lag",
                    Religion = "xtian",
                    Occupation = "IT Pro",
                    OfficeAddress = "island",
                    Photo = null,
                    NationalIdType = "Driver's Licence",
                    NationalIdNumber = "000",
                    NextOfKin = "Test Carol",
                    AddressNextOfKin = "Ikeja",
                    PhoneNextOfKin = 804,
                    EmailNextOfKin = "c@t.com",
                    NextOfKinRelationship = "Sister",
                    NameOfFather = "Tadese",
                    NameOfMother = "Bick.",
                    HealthInsuranceProvider = "nhis",
                    AddressHealthInsuranceProvider = "abuja",
                    PhoneHealthInsuranceProvider = 12345,
                    EmailHealthInsuranceProvider = "n@h.com",
                    DateRegistred = null,
                    UserCreated = null,
                    DateAmended = new DateTime(2013, 8, 30, 13, 6, 31),
                    UserAmended = null,
                },
                new PatientTable
                {
                    Identifier = 2,
                    HospitalNumber = "H2a",
                    Title = "Mr.",
                    FirstName = "Gab",
                    LastName = "Fred",
                    MiddleName = "M",
                    Gender = "M",
                    BirthDate = new DateTime(2006, 1, 20),
                    Phone = 801,
                    MobilePhone = 8012,
                    Email = "m@gab.com",
                    HomeAddress = "abc",
                    City = "Ikeja",
                    State = "Lagos",
                    MaritalStatus = "Single",
                    PatientConsultant = null,
                    Nationality = string.Empty,
                    StateOfOrigin = string.Empty,
                    Hometown = string.Empty,
                    PlaceOfBirth = string.Empty,
                    Religion = string.Empty,
                    Occupation = string.Empty,
                    OfficeAddress = string.Empty,
                    Photo = null,
                    NationalIdType = string.Empty,
                    NationalIdNumber = string.Empty,
                    NextOfKin = string.Empty,
                    AddressNextOfKin = string.Empty,
                    PhoneNextOfKin = 0,
                    EmailNextOfKin = string.Empty,
                    NextOfKinRelationship = string.Empty,
                    NameOfFather = string.Empty,
                    NameOfMother = string.Empty,
                    HealthInsuranceProvider = string.Empty,
                    AddressHealthInsuranceProvider = string.Empty,
                    PhoneHealthInsuranceProvider = 0,
                    EmailHealthInsuranceProvider = string.Empty,
                    DateRegistred = null,
                    UserCreated = null,
                    DateAmended = new DateTime(2013, 8, 30, 9, 17, 43),
                    UserAmended = null,
                },
            };

            context.Patients.AddRange(listPatient);

            var listAppointment = new List<AppointmentTable>
            {
                new AppointmentTable()
                    {
                        Identifier = 1,
                        ClinicianId = "C01",
                        ClinicianName = "Dr Test",
                        PatientId = 1,
                        HospitalNumber = "H1",
                        PatientName = "Test Mike",
                        DateCreated = new DateTime(2013, 9, 06),
                        TimeCreated = new DateTime(2000, 1, 1, 10, 0, 0),
                        Purpose = "Consultation",
                        PatientAttented = null,
                        Arrived = null,
                        Departed = null,
                        Result = null,
                        CreatedAt = new DateTime(2013, 9, 01, 20, 11, 41),
                        ModifiedAt = null,
                    },
                new AppointmentTable()
                    {
                        Identifier = 2,
                        ClinicianId = "C01",
                        ClinicianName = "Dr Test",
                        PatientId = 2,
                        HospitalNumber = "H2a",
                        PatientName = "Mtest2 Gab",
                        DateCreated = new DateTime(2013, 9, 27),
                        TimeCreated = new DateTime(2000, 1, 1, 0, 0, 0),
                        Purpose = string.Empty,
                        PatientAttented = null,
                        Arrived = null,
                        Departed = null,
                        Result = null,
                        CreatedAt = new DateTime(2013, 09, 08, 18, 21, 18),
                        ModifiedAt = null,
                    },
                new AppointmentTable()
                    {
                        Identifier = 3,
                        ClinicianId = "C02",
                        ClinicianName = "Surgeon Test2",
                        PatientId = 1,
                        HospitalNumber = "H1",
                        PatientName = "Test Mike",
                        DateCreated = new DateTime(2015, 4, 21),
                        TimeCreated = new DateTime(2000, 1, 1, 0, 0, 0),
                        Purpose = "consultation",
                        PatientAttented = null,
                        Arrived = null,
                        Departed = null,
                        Result = null,
                        CreatedAt = new DateTime(2015, 4, 15, 20, 22, 20),
                        ModifiedAt = null,
                    },
                new AppointmentTable()
                    {
                        Identifier = 4,
                        ClinicianId = "C01",
                        ClinicianName = "Dr Test",
                        PatientId = 1,
                        HospitalNumber = "H1",
                        PatientName = "Test Mike",
                        DateCreated = new DateTime(2015, 4, 21),
                        TimeCreated = new DateTime(2000, 1, 1, 12, 30, 0),
                        Purpose = "consultation",
                        PatientAttented = null,
                        Arrived = null,
                        Departed = null,
                        Result = null,
                        CreatedAt = new DateTime(2015, 4, 15, 20, 33, 21),
                        ModifiedAt = null,
                    },
            };

            context.Appointments.AddRange(listAppointment);

            base.Seed(context);
        }
    }
}
