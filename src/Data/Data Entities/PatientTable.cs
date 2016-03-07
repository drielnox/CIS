using System;
using System.Runtime.Serialization;

namespace CIS.Data.Entities
{
    [DataContract]
    public class PatientTable
    {
        [DataMember]
        public int Identifier { get; set; }
        [DataMember]
        public string HospitalNumber { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string OtherName { get; set; }
        [DataMember]
        public string Gender { get; set; }
        [DataMember]
        public DateTime BirthDate { get; set; }
        [DataMember]
        public int Phone { get; set; }
        [DataMember]
        public string HomeAddress { get; set; }
        [DataMember]
        public string MaritalStatus { get; set; }
        [DataMember]
        public string MiddleName { get; set; }
        [DataMember]
        public int MobilePhone { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string State { get; set; }
        [DataMember]
        public string PatientConsultant { get; set; }
        [DataMember]
        public string Nationality { get; set; }
        [DataMember]
        public string StateOfOrigin { get; set; }
        [DataMember]
        public string Hometown { get; set; }
        [DataMember]
        public string PlaceOfBirth { get; set; }
        [DataMember]
        public string Religion { get; set; }
        [DataMember]
        public string Occupation { get; set; }
        [DataMember]
        public string OfficeAddress { get; set; }
        [DataMember]
        public string NationalIdType { get; set; }
        [DataMember]
        public string NationalIdNumber { get; set; }
        [DataMember]
        public string NextOfKin { get; set; }
        [DataMember]
        public string AddressNextOfKin { get; set; }
        [DataMember]
        public int PhoneNextOfKin { get; set; }
        [DataMember]
        public string EmailNextOfKin { get; set; }
        [DataMember]
        public string NextOfKinRelationship { get; set; }
        [DataMember]
        public string NameOfFather { get; set; }
        [DataMember]
        public string NameOfMother { get; set; }
        [DataMember]
        public string HealthInsuranceProvider { get; set; }
        [DataMember]
        public string AddressHealthInsuranceProvider { get; set; }
        [DataMember]
        public int PhoneHealthInsuranceProvider { get; set; }
        [DataMember]
        public string EmailHealthInsuranceProvider { get; set; }
        [DataMember]
        public DateTime? DateRegistred { get; set; }
        [DataMember]
        public DateTime? DateAmended { get; set; }
        [DataMember]
        public byte[] Photo { get; set; }
        [DataMember]
        public string UserCreated { get; set; }
        [DataMember]
        public string UserAmended { get; set; }
    }
}
