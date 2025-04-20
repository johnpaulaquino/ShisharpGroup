using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BrgyMs.backend.models.base_model;
using BrgyMs.backend.models.residents_model;


namespace BrgyMs.backend.data_validation {
    public class UserInfoValidation {
        private readonly string EmailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        private readonly string PhonePattern = @"^(09|\+639)\d{9}$";
        private readonly string ImagePattern = @"^.+\.(jpg|jpeg|png|webp)$";

        public UserInfoValidation() { }
        public void ValidateUser(User _User, string ConfirmEmail,
           string ConfirmPassword) {
            bool IsValid = Regex.IsMatch(_User.Email, EmailPattern);

            if (_User.Email.Length < 0) {
                throw new Exception("Email should not be empty!");
            }

            if (!IsValid) {
                throw new Exception("Invalid Email address!");
            }

            if (!string.Equals(_User.Email, ConfirmEmail))
            {
                throw new Exception("Email and confirm email does not match!");
            }

            if (_User.Password.Length < 0) {
                throw new Exception("Password should not be empty!");
            }

            if (_User.Password.Length < 8) {
                throw new Exception("Password should at least 8 characters!");
            }
            if (!string.Equals(_User.Password, ConfirmPassword))
            {
                throw new Exception("Password and confirm password does not match!");
            }

        } // end of first validation

        public void ValidateUser(User _User)
        {
            bool IsValid = Regex.IsMatch(_User.Email, EmailPattern);

            if (_User.Email.Length < 0) 
            {
                throw new Exception("Email should not be empty!");
            }

            if (!IsValid)
            {
                throw new Exception("Invalid Email address!");
            }
            if (_User.Password.Length < 0)
            {
                throw new Exception("Password should not be empty!");
            }

            if (_User.Password.Length < 8)
            {
                throw new Exception("Password should at least 8 characters!");
            }

        } // end of first validation

        public void ValidatePersonalInfo(PersonalInformation _Personalinfo) {

            if (string.IsNullOrEmpty( _Personalinfo.Firstname)) {
                throw new Exception("Firstname should not be empty!");
            }
            if (string.IsNullOrEmpty(_Personalinfo.Lastname)) {
                throw new Exception("Lastname should not be empty!");
            }
            if (string.IsNullOrEmpty(_Personalinfo.Gender)) {
                throw new Exception("Gender should not be empty!");
            }
            if (string.Equals(_Personalinfo.Gender, "--Select--"))
            {
                throw new Exception("Please specify your gender!");
            }
            if (string.Equals(_Personalinfo.Gender, "--Select--"))
            {
                throw new Exception("Please specify your gender!");
            }


        }

        public void ValidateAddInfo(AdditionalInfo _AdditionalInfo) {
            bool IsPhoneValid = Regex.IsMatch(_AdditionalInfo.ContactNo, PhonePattern);
            if (string.Equals(_AdditionalInfo.CivilStatus,"--Select--")) {
                throw new Exception("Please specify your Civil status!");
            }
            if (string.Equals(_AdditionalInfo.EducAttain,"--Select--")) {
                throw new Exception("Please specify your Educational Attaintment!");
            }
            if (string.IsNullOrEmpty(_AdditionalInfo.Religion)) {
                throw new Exception("Religion should not be empty!");
            }
            if (string.Equals(_AdditionalInfo.ResidentType, "--Select--"))
            {
                throw new Exception("PLease specify your Resident type!");
            }
            if (string.IsNullOrEmpty(_AdditionalInfo.ContactNo)) {
                throw new Exception("Contact No. should not be empty!");
            }
            if (!IsPhoneValid) {
                throw new Exception("Invalid Phone number!");
            }

            if (_AdditionalInfo.ProofOfResidency == null) {
                throw new Exception("Proof of Residency should not be empty!");
            }

        }
        public void ValidateAddress (Address _Address) {
            bool IsHouseNoDigits = Regex.IsMatch(_Address.HouseNumber, @"\d");
            bool IsLotNoDigits = Regex.IsMatch(_Address.LotNo, @"\d");
            bool IsBlockNoDigits = Regex.IsMatch(_Address.LotNo, @"\d");
            if (string.IsNullOrEmpty(_Address.HouseNumber)) {
                throw new Exception("House No. should not be empty!");
            }
            if (!IsHouseNoDigits) {
                throw new Exception("House No. should be digits!");
            }
            if (string.IsNullOrEmpty(_Address.Street)) {
                throw new Exception("Street should not be empty!");
            }
            if (!string.IsNullOrEmpty(_Address.LotNo)) {
                if (!IsLotNoDigits) {
                    throw new Exception("Lot No. should be digits!");
                }
            }
            if (!string.IsNullOrEmpty(_Address.BlockNumber)) {
                if (!IsBlockNoDigits) {
                    throw new Exception("Block No. should be digits!");
                }
            }
        }

        public void ValdiateRequestDocs(ResidentDocumentRequest _RequestDocs) {
            if (string.IsNullOrEmpty(_RequestDocs.DocumentType)) {
                throw new Exception("Document Type should not be empty!");
            }
            if (string.IsNullOrEmpty(_RequestDocs.Purpose)) {
                throw new Exception("Pupose of requesting document should not be empty!");
            }
        }
        public void ValidateFileType(string _FilePath) {
            bool IsExtensionValid = Regex.IsMatch(_FilePath, ImagePattern);

            if (!IsExtensionValid) {
                throw new Exception("File Extension should [.jpg, .jpeg, .png, .webp]!");
            }
        }
        public void SetEmptyStringThatCanAcceptNull(PersonalInformation _PersonalInfo)
        {
            if (string.IsNullOrEmpty(_PersonalInfo.Middlename))
            {
                _PersonalInfo.Middlename = "";
            }
            if (string.Equals(_PersonalInfo.Suffix, "--Select--"))
            {
                _PersonalInfo.Suffix = "";
            }
        }
    }
}