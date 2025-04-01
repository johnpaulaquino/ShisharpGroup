using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BMS.backend.models.base_model;
using BMS.backend.models.residents_model;


namespace BMS.backend.data_validation {
    public class UserInfoValidation {
        private readonly string EmailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        private readonly string PhonePattern = @"^(09|\+639)\d{9}$";
        private readonly string ImagePattern = @"^.+\.(jpg|jpeg|png|webp)$";

        public UserInfoValidation() { }
        public void ValidateUser(User _User) {
            bool IsValid = Regex.IsMatch(_User.Email, EmailPattern);

            if (_User.Email.Length < 0) {
                throw new Exception("Email should not be empty!");
            }

            if (!IsValid) {
                throw new Exception("Invalid Email address!");
            }
            if (_User.Password.Length < 0) {
                throw new Exception("Password should not be empty!");
            }

            if (_User.Password.Length < 8) {
                throw new Exception("Password should at least 8 characters!");
            }

            if (_User.Role.Length < 0) {
                throw new Exception("Role should not be empty!");
            }


        } // end of first validation

        public void ValidatePersonalInfo(PersonalInformation _Personalinfo) {

            if (_Personalinfo.Firstname.Length < 0) {
                throw new Exception("Firstname should not be empty!");
            }
            if (_Personalinfo.Lastname.Length < 0) {
                throw new Exception("Lastname should not be empty!");
            }
            if (_Personalinfo.Gender.Length < 0) {
                throw new Exception("Gender should not be empty!");
            }


        }

        public void ValidateAddInfo(AdditionalInfo _AdditionalInfo) {
            bool IsPhoneValid = Regex.IsMatch(_AdditionalInfo.ContactNo, PhonePattern);
            if (_AdditionalInfo.CivilStatus.Length < 0) {
                throw new Exception("Educational Attaintment should not be empty!");
            }
            if (_AdditionalInfo.EducAttain.Length < 0) {
                throw new Exception("Educational Attaintment should not be empty!");
            }
            if (_AdditionalInfo.Religion.Length < 0) {
                throw new Exception("Religion should not be empty!");
            }

            if (_AdditionalInfo.ContactNo.Length < 0) {
                throw new Exception("Contact No. should not be empty!");
            }
            if (!IsPhoneValid) {
                throw new Exception("Invalid Phone number!");
            }

            if (_AdditionalInfo.ProofOfResidency == null) {
                throw new Exception("Proof of Residency should not be empty!");
            }

        }

        public void ValdiateRequestDocs(ResidentDocumentRequest _RequestDocs) {
            if (_RequestDocs.DocumentType.Length < 0) {
                throw new Exception("Document Type should not be empty!");
            }
            if (_RequestDocs.Purpose.Length < 0) {
                throw new Exception("Pupose of requesting document should not be empty!");
            }
        }
        public void ValidateFileType(string _FilePath) {
            bool IsExtensionValid = Regex.IsMatch(_FilePath, ImagePattern);

            if (!IsExtensionValid) {
                throw new Exception("File Extension should [.jpg, .jpeg, .png, .webp]!");
            }
        }
    }
}