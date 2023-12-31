﻿using StudentskaSluzba.Model.DAO;
using StudentskaSluzba.Model;
using StudentskaSluzba.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba.Controller
{
    public class StudentController
    {
        private StudentDAO _students;

        public StudentController(OcenaController ocenaController)
        {
            _students = new StudentDAO(ocenaController.GetAllOcene());
        }

        public List<Student> GetAllStudents()
        {
            return _students.GetAll();
        }

        public void Create(Student student)
        {
            _students.Add(student);
        }

        public void Delete(Student student)
        {
            _students.Remove(student);
        }

        public void Subscribe(IObserver observer)
        {
            _students.Subscribe(observer);
        }

        public void IzracunajProsek(Student student)
        {
            _students.IzracunajProsek(student);
        }
    }
}
