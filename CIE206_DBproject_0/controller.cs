using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//
using System.Data;
using System.Windows.Forms;


namespace CIE206_DBproject_0
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }


        public DataTable ViewAllRoom()
        {
            string query = "select DISTINCT * from room; ";
            return dbMan.ExecuteReaderAll(query);
        }
        public DataTable ViewAllEmployees()
        {
            string query = "select DISTINCT * from employee; ";
            return dbMan.ExecuteReaderAll(query);
        }
        public DataTable ViewAllCases()
        {
            string query = "select DISTINCT * from hcase;";
            return dbMan.ExecuteReaderAll(query);
        }

        public DataTable ViewMedicalRecord(int PID)
        {
            string StoredProcedureName = StoredProcedures.ViewMedicalRecord;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PID", PID);

            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable ViewAllPatients()
        {
            string query = "select DISTINCT * from patient;";
            return dbMan.ExecuteReaderAll(query);
        }

        public int num_patient_room(int RID)
        {
            string StoredProcedureName = StoredProcedures.num_patient_room;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@RID", RID);

            return (Int32)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public DataTable ViewPatient(int PID)
        {
            string StoredProcedureName = StoredProcedures.viewPatient;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PID", PID);

            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }
        public DataTable ViewEmployee(int EID)
        {
            string StoredProcedureName = StoredProcedures.viewEmployee;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@EID", EID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }
        public int AddPatient(int PID, string first_name, string last_name, char gender, string birthdate, string Pusername, string Ppassword, string contact_num, string Paddress)
        {
            string StoredProcedureName = StoredProcedures.addPatient;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PID", PID);
            Parameters.Add("@first_name", first_name);
            Parameters.Add("@last_name", last_name);
            Parameters.Add("@gender", gender);
            Parameters.Add("@birthdate", birthdate);
            Parameters.Add("@Pusername", Pusername);
            Parameters.Add("@Ppassword", Ppassword);
            Parameters.Add("@contact_num", contact_num);

            Parameters.Add("@Paddress", Paddress);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int AddEmployee(int EID, string first_name, string last_name, bool Estatus, string Eusername, string Epassword, string birthdate, string contact_num, string Paddress, char gender, string Etype)
        {
            string StoredProcedureName = StoredProcedures.addEmployee;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@EID", EID);
            Parameters.Add("@first_name", first_name);
            Parameters.Add("@last_name", last_name);
            Parameters.Add("@Estatus", Estatus);
            Parameters.Add("@Eusername", Eusername);
            Parameters.Add("@Epassword", Epassword);
            Parameters.Add("@birthdate", birthdate);
            Parameters.Add("@contact_num", contact_num);
            Parameters.Add("@Paddress", Paddress);
            Parameters.Add("@gender", gender);
            Parameters.Add("@Etype", Etype);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int UpdatePatient(int PID, string first_name, string last_name, char gender, string birthdate, string Pusername, string Ppassword, string contact_num, string Paddress)
        {
            string StoredProcedureName = StoredProcedures.updatePatient;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PID", PID);
            Parameters.Add("@first_name", first_name);
            Parameters.Add("@last_name", last_name);
            Parameters.Add("@gender", gender);
            Parameters.Add("@birthdate", birthdate);
            Parameters.Add("@Pusername", Pusername);
            Parameters.Add("@Ppassword", Ppassword);
            Parameters.Add("@contact_num", contact_num);
            Parameters.Add("@Paddress", Paddress);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int UpdateEmployee(int EID, string first_name, string last_name, bool Estatus, string Eusername, string Epassword,string birthdate, string contact_num, string Paddress, char gender, string Etype)
        {
            string StoredProcedureName = StoredProcedures.updateEmployee;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@EID", EID);
            Parameters.Add("@first_name", first_name);
            Parameters.Add("@last_name", last_name);
            Parameters.Add("@Estatus", Estatus);
            Parameters.Add("@Eusername", Eusername);
            Parameters.Add("@Epassword", Epassword);
            Parameters.Add("@birthdate", birthdate);
            Parameters.Add("@contact_num", contact_num);
            Parameters.Add("@Paddress", Paddress);
            Parameters.Add("@gender", gender);
            Parameters.Add("@Etype", Etype);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int DeletePatient(int PID)
        {
            string StoredProcedureName = StoredProcedures.deletePatient;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PID", PID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }

        public int DeleteEmployee(int EID)
        {
            string StoredProcedureName = StoredProcedures.deleteEmployee;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@EID", EID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }

        public int AddRoom(int RID, int current_num_of_patients, int capacity, string r_type)
        {
            string StoredProcedureName = StoredProcedures.addRoom;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@RID", RID);
            Parameters.Add("@current_num_of_patients", current_num_of_patients);
            Parameters.Add("@capacity", capacity);
            Parameters.Add("@r_type", r_type);




            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int DeleteRoom(int RID)
        {
            string StoredProcedureName = StoredProcedures.deleteRoom;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@RID", RID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }

        public DataTable ViewRoom(int RID)
        {
            string StoredProcedureName = StoredProcedures.viewRoom;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@RID", RID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }

        public int UpdateRoom(int RID, int current_num_of_patients, int capacity, string r_type)
        {
            string StoredProcedureName = StoredProcedures.updateRoom;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@RID", RID);
            Parameters.Add("@current_num_of_patients", current_num_of_patients);
            Parameters.Add("@capacity", capacity);
            Parameters.Add("@r_type", r_type);
           
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int AddCase(int case_num, string diagnosis, bool c_status, string casedate)
        {
            string StoredProcedureName = StoredProcedures.addCase;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@case_num", case_num);
            Parameters.Add("@diagnosis", diagnosis);
            Parameters.Add("@c_status", c_status);
            Parameters.Add("@casedate", casedate);


            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable ViewCase(int case_num)
        {
            string StoredProcedureName = StoredProcedures.viewCase;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@case_num", case_num);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }

        public int UpdateCase(int case_num, string diagnosis, bool c_status, string case_date)
        {
            string StoredProcedureName = StoredProcedures.updateCase;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@case_num", case_num);
            Parameters.Add("@diagnosis", diagnosis);
            Parameters.Add("@c_status", c_status);
            Parameters.Add("@casedate", case_date);


            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int DeleteCase(int case_num)
        {
            string StoredProcedureName = StoredProcedures.deleteCase;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@case_num", case_num);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }

        public int AddDoctorAttend(string Ddate, int DID, int a_case_number)
        {
            string StoredProcedureName = StoredProcedures.addDoctorAttend;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Ddate", Ddate);
            Parameters.Add("@DID", DID);
            Parameters.Add("@a_case_number", a_case_number);



            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int DeleteDoctorAttend(int DID,int a_case_number)
        {
            string StoredProcedureName = StoredProcedures.deleteDoctorAttend;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@DID", DID);
            Parameters.Add("a_case_number", a_case_number);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }

        public int UpdateDoctorAttend(string Ddate, int DID, int a_case_number)
        {
            string StoredProcedureName = StoredProcedures.updateDoctorAttend;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@DID", DID);
            Parameters.Add("@a_case_number", a_case_number);
            Parameters.Add("@Ddate", Ddate);


            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }


        public DataTable ViewDoctorAttend(int DID, int a_case_number)
        {
            string StoredProcedureName = StoredProcedures.viewDoctorAttend;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@DID", DID);
            Parameters.Add("@a_case_number", a_case_number);

            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }

        public int AddPatientAttend(string Ddate, int PID, int a_case_number)
        {
            string StoredProcedureName = StoredProcedures.addPatientAttend;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Ddate", Ddate);
            Parameters.Add("@PID", PID);
            Parameters.Add("@a_case_number", a_case_number);



            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int DeletePatientAttend(int PID, int a_case_number)
        {
            string StoredProcedureName = StoredProcedures.deletePatientAttend;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PID", PID);
            Parameters.Add("a_case_number", a_case_number);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }

        public int UpdatePatientAttend(string Ddate, int PID, int a_case_number)
        {
            string StoredProcedureName = StoredProcedures.update_Patient_attend;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PID", PID);
            Parameters.Add("@a_case_number", a_case_number);
            Parameters.Add("@Ddate", Ddate);


            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }


        public DataTable ViewPatientAttend(int PID, int a_case_number)
        {
            string StoredProcedureName = StoredProcedures.viewPatientAttend;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@DID", PID);
            Parameters.Add("@a_case_number", a_case_number);

            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }

        public int AddLabTest(int LID, string L_name, bool L_status, int case_num)
        {
            string StoredProcedureName = StoredProcedures.addLabTest;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@LID", LID);
            Parameters.Add("@L_name", L_name);
            Parameters.Add("@L_status", L_status);
            Parameters.Add("@case_num", case_num);


            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable ViewLabTest(int LID, int case_num)
        {
            string StoredProcedureName = StoredProcedures.viewLabTest;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@LID", LID);
            Parameters.Add("@case_num", case_num);

            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }
        public int DeleteLabTest(int LID,int case_num)
        {
            string StoredProcedureName = StoredProcedures.deleteLabTest;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@LID", LID);
            Parameters.Add("@case_num", case_num);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }
        public int UpdateLabTest(int LID, string L_name, bool L_status, int case_num)
        {
            string StoredProcedureName = StoredProcedures.update_LabTest;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@LID", LID);
            Parameters.Add("@L_name", L_name);
            Parameters.Add("@L_status", L_status);
            Parameters.Add("@case_num", case_num);


            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int AddTreatment(string T_name, int case_num)
        {
            string StoredProcedureName = StoredProcedures.addTreatment;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@T_name", T_name);
            Parameters.Add("@case_num", case_num);


            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable ViewTreatment(int case_num)
        {
            string StoredProcedureName = StoredProcedures.viewTreatment;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@case_num", case_num);

            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }
        public int DeleteTreatment(int case_num)
        {
            string StoredProcedureName = StoredProcedures.deleteTreatment;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@case_num", case_num);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }
        public int UpdateTreatment(string T_name, int case_num)
        {
            string StoredProcedureName = StoredProcedures.update_Treatment;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@case_num", case_num);
            Parameters.Add("@T_name", T_name);
           


            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int AddSurgery(int S_ID, string S_name, bool S_status, int case_num)
        {
            string StoredProcedureName = StoredProcedures.addSurgery;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@S_ID", S_ID);
            Parameters.Add("@S_name", S_name);
            Parameters.Add("@S_status", S_status);
            Parameters.Add("@case_num", case_num);


            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable ViewSurgery(int S_ID, int case_num)
        {
            string StoredProcedureName = StoredProcedures.viewSurgery;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@S_ID", S_ID);
            Parameters.Add("@case_num", case_num);

            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }

        public int DeleteSurgery(int S_ID, int case_num)
        {
            string StoredProcedureName = StoredProcedures.deleteSurgery;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@S_ID", S_ID);
            Parameters.Add("@case_num", case_num);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }
        public int UpdateSurgery(int S_ID, string S_name, bool S_status, int case_num)
        {
            string StoredProcedureName = StoredProcedures.updateSurgery;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@S_ID", S_ID);
            Parameters.Add("@S_name", S_name);
            Parameters.Add("@S_status", S_status);
            Parameters.Add("@case_num", case_num);


            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int AddAssign(int case_num, int RID, string checkin, string checkout)
        {
            string StoredProcedureName = StoredProcedures.assign;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@case_num", case_num);
            Parameters.Add("@RID", RID);
            Parameters.Add("@checkin", checkin);
            Parameters.Add("@checkout", checkout);


            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable ViewAssign(int case_num , int RID)
        {
            string StoredProcedureName = StoredProcedures.viewAssign;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@case_num", case_num);
            Parameters.Add("@RID", RID);

            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }

        public int DeleteAssign(int case_num, int RID)
        {
            string StoredProcedureName = StoredProcedures.deleteAssign;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@case_num", case_num);
            Parameters.Add("@RID", RID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }
        public int UpdateAssign(int case_num, int RID, string checkin, string checkout)
        {
            string StoredProcedureName = StoredProcedures.updateAssign;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@case_num", case_num);
            Parameters.Add("@RID", RID);
            Parameters.Add("@checkin", checkin);
            Parameters.Add("@checkout", checkout);


            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int AddGovern(int RID, int NID, string g_date)
        {
            string StoredProcedureName = StoredProcedures.addGovern;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@RID", RID);
            Parameters.Add("@NID", NID);
            Parameters.Add("@g_date", g_date);


            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable ViewGovern(int RID, int NID)
        {
            string StoredProcedureName = StoredProcedures.viewGovern;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@RID", RID);
            Parameters.Add("@NID", NID);

            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }
        public int DeleteGovern(int RID, int NID)
        {
            string StoredProcedureName = StoredProcedures.deleteGovern;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@RID", RID);
            Parameters.Add("@NID", NID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }
        public int UpdateGovern(int RID, int NID, string g_date)
        {
            string StoredProcedureName = StoredProcedures.updateGovern;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@RID", RID);
            Parameters.Add("@NID", NID);
            Parameters.Add("@g_date", g_date);


            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable ViewPatientUsernamePassword()
        {
            string StoredProcedureName = StoredProcedures.PatientViewUsernamePassword;


            return dbMan.ExecuteReader(StoredProcedureName, null);

        }
        public DataTable ViewEmployeeUsernamePassword()
        {
            string StoredProcedureName = StoredProcedures.EmployeeViewUsernamePassword;


            return dbMan.ExecuteReader(StoredProcedureName, null);

        }

        public int AddDoctor(int DID, string specialization)
        {
            string StoredProcedureName = StoredProcedures.AddDoctor;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@DID", DID);
            Parameters.Add("@specialization", specialization);
            


            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int AddNurse(int NID, string specialization)
        {
            string StoredProcedureName = StoredProcedures.AddNurse;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@NID", NID);
            Parameters.Add("@specialization", specialization);



            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

    }





}
