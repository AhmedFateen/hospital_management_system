using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CIE206_DBproject_0
{
   
    public class StoredProcedures
    {

        public static string ViewAllRoom = "sp_viewAllRooms";
        public static string ViewAllPatients = "sp_viewAllPatients";
        public static string ViewAllCases = "sp_viewAllCases";
        public static string ViewAllEmployees = "sp_viewAllEmployees";
        public static string ViewMedicalRecord = "sp_viewMedicalRecord";
        //
        public static string num_patient_room = "sp_num_patient_room";
        public static string viewPatient = "spViewPatient";
        public static string viewEmployee = "spViewEmployee";
        public static string addPatient = "spAddPatient";
        public static string addEmployee = "spAddEmployee";
        public static string updatePatient = "spUpdatePatient";
        public static string updateEmployee = "spUpdateEmployee";
        public static string deletePatient = "spDeletePatient";
        public static string deleteEmployee = "spDeleteEmployee";
        public static string addRoom = "spAddRoom";
        public static string deleteRoom = "spDeleteRoom";
        public static string viewRoom = "spViewRoom";
        public static string updateRoom = "spUpdateRoom";
        public static string addCase = "spAddCase";
        public static string viewCase = "spViewCase";
        public static string updateCase = "spUpdateCase";
        public static string deleteCase = "spDeleteCase";
        public static string addDoctorAttend = "spAdd_Doctor_Attend";
        public static string deleteDoctorAttend = "spDelete_Doctor_Attend";
        public static string updateDoctorAttend = "spUpdate_Doctor_Attend";
        public static string viewDoctorAttend = "spViewDoctorAttend";
        public static string addPatientAttend = "spAdd_Patient_attend";
        public static string deletePatientAttend = "spDelete_Patient_attend";
        public static string update_Patient_attend = "spUpdate_Patient_attend";
        public static string viewPatientAttend = "spViewPatientAttend";
        public static string addLabTest = "spAddLabTest";
        public static string viewLabTest = "spView_LabTest";
        public static string deleteLabTest = "spDelete_LabTest";
        public static string update_LabTest = "spUpdate_LabTest";
        public static string addTreatment = "spAddTreatment";
        public static string viewTreatment = "spView_Treatment";
        public static string deleteTreatment = "spDelete_Treatment";
        public static string update_Treatment = "spUpdate_Treatment";
        public static string addSurgery = "spAddSurgery";
        public static string viewSurgery = "spView_Surgery";
        public static string deleteSurgery = "spDelete_Surgery";
        public static string updateSurgery = "spUpdateSurgery";
        public static string assign = "spAdd_AssignCaseToRoom";
        public static string viewAssign = "spView_AssignCaseToRoom";
        public static string deleteAssign = "spDelete_AssignCaseToRoom";
        public static string updateAssign = "spUpdate_AssignCaseToRoom";
        public static string addGovern = "spAddGovern";
        public static string viewGovern = "spViewGovern";
        public static string deleteGovern = "spDeleteGovern";
        public static string updateGovern = "spUpdateGovern";
        public static string PatientViewUsernamePassword = "spView_username_password_patient";
        public static string EmployeeViewUsernamePassword = "spView_username_password_employee";

        public static string AddDoctor = "spAddDoctor";
        public static string AddNurse = "spAddNurse";



            
    }
}
