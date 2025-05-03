using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BrgyMs.backend.database.repositories;
using BrgyMs.backend.models.base_model;
using BrgyMs.backend.models.bo_model;
using BrgyMs.backend.models.residents_docs;
using BrgyMS.backend.models;
using BrgyMS.backend.models.base_model;


namespace BrgyMs.backend.data_validation {
    public class UserInfoValidation {
        private readonly string EmailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        private readonly string PhonePattern = @"^(09|\+639)\d{9}$";
        private readonly string ImagePattern = @"^.+\.(jpg|jpeg|png|bmp|gif|tiff)$";
        private readonly ResidentRepository _ResidentRepo = new ResidentRepository();
        public UserInfoValidation() { }

        //validate the User info with the confrim passsword, usually used in the signup
        public async Task ValidateUser(User _User, string ConfirmPassword) {
            bool IsValid = Regex.IsMatch(_User.Email, EmailPattern);

            try {
                Dictionary<string, string> IsExist = await _ResidentRepo.GetEmail(_User.Email);

                if (_User.Email.Length < 0) {
                    throw new Exception("Email should not be empty!");
                }

                if (!IsValid) {
                    throw new Exception("Invalid Email address!");
                }

                if (IsExist != null) {
                    if (IsExist.ContainsKey("email")) {
                        throw new Exception("Email is already exist, Email must be unique!");
                    }
                }

                if (string.IsNullOrEmpty(_User.Username)) {
                    throw new Exception("Username should not be empty!");
                }

                if (_User.Password.Length < 0) {
                    throw new Exception("Password should not be empty!");
                }

                if (_User.Password.Length < 8) {
                    throw new Exception("Password should at least 8 characters!");
                }
                if (!string.Equals(_User.Password, ConfirmPassword)) {
                    throw new Exception("Password and confirm password does not match!");
                }
            }
            catch (System.Exception) {
                throw;
            }


        } // end of first validation

        //validate the User info
        public void ValidateUser(User _User) {
            bool IsValid = Regex.IsMatch(_User.Email, EmailPattern);

            if (_User.Email.Length < 0) {
                throw new Exception("Email should not be empty!");
            }

            if (!IsValid) {
                throw new Exception("Invalid Email address!");
            }

            if (string.IsNullOrEmpty(_User.Username)) {
                throw new Exception("Username should not be empty!");
            }

            if (_User.Password.Length < 0) {
                throw new Exception("Password should not be empty!");
            }

            if (_User.Password.Length < 8) {
                throw new Exception("Password should at least 8 characters!");
            }

        } // end of first validation


        //validate personal information
        public void ValidatePersonalInfo(PersonalInformation _Personalinfo) {

            if (string.IsNullOrEmpty(_Personalinfo.Firstname)) {
                throw new Exception("Firstname should not be empty!");
            }
            if (string.IsNullOrEmpty(_Personalinfo.Lastname)) {
                throw new Exception("Lastname should not be empty!");
            }
            if (string.IsNullOrEmpty(_Personalinfo.Gender)) {
                throw new Exception("Gender should not be empty!");
            }
            if (string.Equals(_Personalinfo.Gender, "--Select--")) {
                throw new Exception("Please specify your gender!");
            }
            if (string.Equals(_Personalinfo.Gender, "--Select--")) {
                throw new Exception("Please specify your gender!");
            }
        }
        //validate the additional info

        public void ValidateAddInfoForSignup(AdditionalInfo _AdditionalInfo) {
            bool IsPhoneValid = Regex.IsMatch(_AdditionalInfo.ContactNo, PhonePattern);

            if (string.Equals(_AdditionalInfo.CivilStatus, "--Select--")) {
                throw new Exception("Please specify your Civil status!");
            }
            if (string.Equals(_AdditionalInfo.EducAttain, "--Select--")) {
                throw new Exception("Please specify your Educational Attaintment!");
            }
            if (string.Equals(_AdditionalInfo.ResidentType, "--Select--")) {
                throw new Exception("Please specify your Resident type!");
            }
            if (string.IsNullOrEmpty(_AdditionalInfo.Religion)) {
                throw new Exception("Religion should not be empty!");
            }
            if (string.IsNullOrEmpty(_AdditionalInfo.ContactNo)) {
                throw new Exception("Contact No. should not be empty!");
            }
            if (!IsPhoneValid) {
                throw new Exception("Invalid Phone number!");
            }
            if (_AdditionalInfo.ProofOfResidency == null) {
                throw new Exception("Please upload your proof of residency!");
            }

        }
        public void ValidateAddInfoForUpdate(AdditionalInfo _AdditionalInfo) {
            bool IsPhoneValid = Regex.IsMatch(_AdditionalInfo.ContactNo, PhonePattern);

            if (string.Equals(_AdditionalInfo.CivilStatus, "--Select--")) {
                throw new Exception("Please specify your Civil status!");
            }
            if (string.Equals(_AdditionalInfo.EducAttain, "--Select--")) {
                throw new Exception("Please specify your Educational Attaintment!");
            }
            if (string.Equals(_AdditionalInfo.ResidentType, "--Select--")) {
                throw new Exception("Please specify your Resident type!");
            }
            if (string.IsNullOrEmpty(_AdditionalInfo.Religion)) {
                throw new Exception("Religion should not be empty!");
            }
            if (string.IsNullOrEmpty(_AdditionalInfo.ContactNo)) {
                throw new Exception("Contact No. should not be empty!");
            }
            if (!IsPhoneValid) {
                throw new Exception("Invalid Phone number!");
            }
        }

        // validate the address
        public void ValidateAddress(Address _Address) {
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


        //validate request documents
        public void ValdiateRequestDocs(ResidentDocumentRequest _RequestDocs) {
            if (string.IsNullOrEmpty(_RequestDocs.DocumentType)) {
                throw new Exception("Please specify the document you are requesting!");
            }
            if (string.IsNullOrEmpty(_RequestDocs.Purpose)) {
                throw new Exception("Please specify the purpose!");
            }
        }

        //validate the file extension of a file
        public void ValidateFileType(string _FilePath) {
            bool IsExtensionValid = Regex.IsMatch(_FilePath, ImagePattern);

            if (!IsExtensionValid) {
                throw new Exception("File Extension should [jpg, jpeg, png, bmp, gif, tiff]!");
            }
        }

        //this will set as empty string to all data that can be null in personal information
        public void SetEmptyStringThatCanAcceptNullForPInfo(PersonalInformation _PersonalInfo) {
            if (string.IsNullOrEmpty(_PersonalInfo.Middlename)) {
                _PersonalInfo.Middlename = "";
            }
            if (string.Equals(_PersonalInfo.Suffix, "--Select--")) {
                _PersonalInfo.Suffix = "";
            }
        } //end of function

        //this will set as empty string to all data that can be null in address
        public void SetEmptyStringThatCanAcceptNullForAddress(Address address) {

            if (string.IsNullOrEmpty(address.SubdivisionName)) {
                address.SubdivisionName = "";
            }
            if (string.IsNullOrEmpty(address.LotNo)) {
                address.LotNo = "";
            }
            if (string.IsNullOrEmpty(address.BlockNumber)) {
                address.BlockNumber = "";
            }
        } //end of function

        public void ValidateBlotter(BlotterInformation blotter) {

            if (string.Equals(blotter.ComplainantId, blotter.RespondentId)) {
                throw new Exception("Invalid Blotter, can't blotter itself!");
            }

            if (string.Equals(blotter.ComplainantId, "--Select--")) {
                throw new Exception("Please specify the Complainant name");
            }

            if (string.IsNullOrEmpty(blotter.ComplainantId)) {
                throw new Exception("Please specify the Respondent name");
            }


            if (string.Equals(blotter.RespondentId, "--Select--")) {
                throw new Exception("Please specify the Respondent name");
            }
            if (string.IsNullOrEmpty(blotter.RespondentId)) {
                throw new Exception("Please specify the Respondent name");
            }
            if (string.IsNullOrEmpty(blotter.Statements)) {
                throw new Exception("Please spcify the statements!");
            }
        } // end


        public void ValidateAnnoucnement(AnnouncementsModel announcement) {
            if (string.IsNullOrEmpty(announcement.Title)) {
                throw new Exception("Please spcify the title!");
            }

            if (string.IsNullOrEmpty(announcement.Details)) {
                throw new Exception("Please spcify the details!");
            }
        }// end

        public void ValidatebarangayOfficials(OfficialsInfo officialsInfo) {
            try {
                if (string.IsNullOrEmpty(officialsInfo.Position) || string.Equals(officialsInfo.Position, "--Select--")) {
                    throw new Exception("Please specify the position!");
                }
                if (officialsInfo.TermStart > officialsInfo.TermEnd) {
                    throw new Exception("Invalid date range, start date should be less than to end date!");

                }
                if (string.IsNullOrEmpty(officialsInfo.Status) ||
                    string.Equals(officialsInfo.Status, "--Select--")) {
                    throw new Exception("Please specify the status!");
                }


            }
            catch (Exception) {
                throw;
            }
        }

    }
}