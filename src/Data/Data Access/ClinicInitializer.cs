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
                        TimeCreated = new DateTime(0, 0, 0, 10, 0, 0),
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
                        TimeCreated = new DateTime(0, 0, 0, 0, 0, 0),
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
                        TimeCreated = new DateTime(0, 0, 0, 0, 0, 0),
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
                        TimeCreated = new DateTime(0, 0, 0, 12, 30, 0),
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
