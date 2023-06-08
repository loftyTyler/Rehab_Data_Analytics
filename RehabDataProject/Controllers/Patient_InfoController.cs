using Microsoft.AspNetCore.Mvc;
using RehabDataProject.Data;
using RehabDataProject.Models;

namespace RehabDataProject.Controllers
{
    public class Patient_InfoController : Controller
    {
        private readonly ApplicationDbContext _db;

        public Patient_InfoController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Patient_Info> objPatientsList = _db.Patients_Info;
            return View(objPatientsList);
        }
        //For Old Patient Data
        public IActionResult IndexPatientsOld()
        {
            IEnumerable<PatientOld> objOldPatientsList = _db.PatientsOld;
            return View(objOldPatientsList);
        }
        //GET
        public IActionResult Create()
        {
            
            return View();
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Patient_Info obj)
        {
            if (ModelState.IsValid)
            {
                var patientOld = new PatientOld
                {

                    Name = obj.Name,
                    KneeROM = obj.KneeROM,
                    KneeStrength = obj.KneeStrength,
                    LowerbackExtROM = obj.LowerbackExtROM,
                    LowerBackFlexionROM = obj.LowerBackFlexionROM,
                    PainFreeWeightLifted = obj.PainFreeWeightLifted,
                };
                _db.PatientsOld.Add(patientOld);
                _db.Patients_Info.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Patient Created Successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }
		//GET
		public IActionResult Edit(int? id)
		{
            if(id == null || id == 0)
            {
                return NotFound();
            }
            var patientFromDb = _db.Patients_Info.Find(id);

            if(patientFromDb == null)
            {
                return NotFound();
            }
			return View(patientFromDb);
		}
        //POST
        [HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Edit(Patient_Info obj)
		{
			if (ModelState.IsValid)
			{
                var patientOld = new PatientOld
                {
                    
                    Name = obj.Name,
                    KneeROM = obj.KneeROM,
                    KneeStrength = obj.KneeStrength,
                    LowerbackExtROM = obj.LowerbackExtROM,
                    LowerBackFlexionROM = obj.LowerBackFlexionROM,
                    PainFreeWeightLifted = obj.PainFreeWeightLifted,
                };
                _db.PatientsOld.Add(patientOld);
				_db.Patients_Info.Update(obj);               
				_db.SaveChanges();
                TempData["success"] = "Patient Updated Successfully";
				return RedirectToAction("Index");
			}
			return View(obj);
		}

        //Retrieve specific patient data
        public IActionResult IndexOldList(int? id)
        {
            var patientInfo = _db.Patients_Info.Find(id);
            if (patientInfo == null)
            {
                return NotFound();
            }
            var name = patientInfo.Name;
            var oldPatients = _db.PatientsOld.Where(p => p.Name == name).ToList();
            return View(oldPatients);

        }

        public IActionResult GraphData(string name)
        {
           
            var patientData = _db.PatientsOld.Where(p => p.Name == name).ToList();
            //New Code
            //List<DateTime> dataList = new List<DateTime>();
            //List<double> kneeRom = new List<double>();

            //foreach ( var patient in patientData )
            //{
            //    dataList.Add(patient.DateUpdated);
            //    kneeRom.Add(patient.KneeROM);
            //}
            
            return View(patientData);
            //Figure out how to get the model to the view to be graphed
            //End of New Code
            //return View(patientData);
        }


    }
}
