using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public static class DataProvider
{

    public class Resident
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
     
    }

    public class Payment
    {
        public int Id { get; set; }
        public string PaymentType { get; set; }
        public int PaymentSum { get; set; }
        public DateTime PaymentDate { get; set; }
    }
    const string Directory = @"C:\Users\Lenovo\Desktop\";
    const string ErrorsFileName = Directory + "errors.log";
    static Dictionary<string, string> fileNames = new Dictionary<string, string>
    {
        {"residents",Directory + "residents.txt" },
        {"payments",Directory+"payments.txt" }
    };
    public static Dictionary<int, Resident> Residents = new Dictionary<int, Resident>();
    public static List<Payment> Payments = new List<Payment>();

    public static bool ReadData()
    {
        Residents.Clear();
        Payments.Clear();
        var errorMessage = new StringBuilder();
        foreach (string name in fileNames.Values)
        {
            if (!File.Exists(name))
            {
                errorMessage.AppendLine($"File {name} not found");
                File.AppendAllText(ErrorsFileName, errorMessage.ToString());
                return false;
            }
        }
        var fileName = fileNames["residents"];
        using (var reader = new StreamReader(fileName))
        {
            var lineNumber = 0;
            while (!reader.EndOfStream)
            {
                var words = reader.ReadLine().Split(new[] { ' ', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                lineNumber++;
                if (words.Length != 3 || !int.TryParse(words[0], out var id) || Residents.ContainsKey(id))
                    errorMessage.AppendLine($"Invalid data in line #{lineNumber} in {fileName}");
                else
                    Residents[id] = new Resident { Id = id, LastName = words[1], Address = words[2] };
            }
        }
       
              

        fileName = fileNames["payments"];
        var lines = File.ReadAllLines(fileName);
        for(int i = 0; i < lines.Length; i++)
        {
            var words=Regex.Split(lines[i],@"\s+").Where(w=>!string.IsNullOrEmpty(w)).ToArray();
            if (words.Length != 4 || !int.TryParse(words[0], out var residentId) ||
                !Residents.ContainsKey(residentId) || !int.TryParse(words[2], out var paymentSum) ||
                !DateTime.TryParse(words[3], out var paymentDate))
                errorMessage.AppendLine($"Invalid data in line #{i} in {fileName}");
            else
                Payments.Add(new Payment { Id = residentId, PaymentType = words[1], PaymentSum = int.Parse(words[2]), PaymentDate = paymentDate });
        }
        if (errorMessage.Length > 0)
        {
            File.AppendAllText(ErrorsFileName, errorMessage.ToString());
            Console.Error.WriteLine(errorMessage);
            return false;
        }
        return true; 
    }
    public static Dictionary<string, string> Users = new Dictionary<string, string>
    {
        {"user","password1" },
        {"admin","password2" }
    };
}























/*
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public static class DataProvider
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Speciality { get; set; }
    }

    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
    }

    public class Visit
    {
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public DateTime VisitDate { get; set; }
    }

    const string DataDir = @"C:\Users\Lenovo\Desktop\";
    const string errorsFileName = DataDir + "errors.log";

    static Dictionary<string, string> fileNames = new Dictionary<string, string>
    {
        {"doctors", DataDir + "doctors.txt" },
        {"patients", DataDir + "patients.txt" },
        {"visits", DataDir + "visits.txt" }
    };

    public static Dictionary<int, Doctor> Doctors;
    public static Dictionary<int, Patient> Patients;
    public static List<Visit> Visits;

    public static bool ReadData()
    {
        Doctors = new Dictionary<int, Doctor>();
        Patients = new Dictionary<int, Patient>();
        Visits = new List<Visit>();

        var errorMessages = new StringBuilder();

        foreach (string name in fileNames.Values)
        {
            if (!File.Exists(name))
            {
                errorMessages.AppendLine($"File {name} not found. Data reading process failed");
                File.AppendAllText(errorsFileName, errorMessages.ToString());
                return false;
            }
        }

        var fileName = fileNames["doctors"];
        using (var reader = new StreamReader(fileName))
        {
            var lineNumber = 0;
            while (!reader.EndOfStream)
            {
                var words = reader.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                lineNumber++;
                if (words.Length != 3 || !int.TryParse(words[0], out var id) || Doctors.ContainsKey(id))
                    errorMessages.AppendLine($"Invalid data in line #{lineNumber} in {fileName}");
                else
                    Doctors[id] = new Doctor { Id = id, Name = words[1], Speciality = words[2] };
            }
        }

        fileName = fileNames["patients"];
        using (var reader = new StreamReader(fileName, Encoding.GetEncoding(1251)))
        {
            var lineNumber = 0;
            while (!reader.EndOfStream)
            {
                var words = reader.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                lineNumber++;
                if (words.Length != 3 || !int.TryParse(words[0], out var id) || Patients.ContainsKey(id) ||
                    !DateTime.TryParse(words[2], out var birthDate))
                    errorMessages.AppendLine($"Invalid data in line #{lineNumber} in {fileName}");
                else
                    Patients[id] = new Patient { Id = id, Name = words[1], BirthDate = birthDate };
            }
        }

        fileName = fileNames["visits"];
        var lines = File.ReadAllLines(fileName);
        for (int i = 0; i < lines.Length; i++)
        {
            var words = Regex.Split(lines[i], @"\s+").Where(w => !string.IsNullOrEmpty(w)).ToArray();
            if (words.Length != 3 || !int.TryParse(words[0], out var doctorId) || !Doctors.ContainsKey(doctorId) ||
                !int.TryParse(words[1], out var patientId) || !Patients.ContainsKey(patientId) ||
                !DateTime.TryParse(words[2], out var visitDate))
                errorMessages.AppendLine($"Invalid data in line #{i} in {fileName}");
            else
                Visits.Add(new Visit { DoctorId = doctorId, PatientId = patientId, VisitDate = visitDate });
        }
        if (errorMessages.Length > 0)
        {
            File.AppendAllText(errorsFileName, errorMessages.ToString());
            Console.Error.WriteLine(errorMessages);
            return false;
        }
        return true;
    }

    public static Dictionary<string, string> Users = new Dictionary<string, string>
    {
        {"user1", "password1" },
        {"admin", "password2" }
    };
}

*/

















