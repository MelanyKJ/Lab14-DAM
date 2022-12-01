﻿using Database2022.Models;
using Database2022.Services;
using Database2022.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Database2022
{
    public partial class MainPage : ContentPage
    {        
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //PersonService service = new PersonService();
            EstudianteService service = new EstudianteService();
            //List<Person> people = new List<Person>();
            List<Estudiante> estudiantes = new List<Estudiante>();

            for (int i = 0; i < 5; i++)            
                //people.Add(new Person { LastName = txtLastName.Text, FirstName = txtName.Text });
                estudiantes.Add(new Estudiante { Nombre = txtNombre.Text, Apellido = txtApellido.Text, Direccion = txtDireccion.Text, Dni = txtDni.Text});

            //service.Create(new Person { LastName = txtLastName.Text, FirstName = txtName.Text });

            service.CreateRange(estudiantes);
            
            
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            //PersonService service = new PersonService();
            EstudianteService service = new EstudianteService();
            lvEstudiante.ItemsSource= service.Get();
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            //PersonService service = new PersonService();
            EstudianteService service=new EstudianteService();
            lvEstudiante.ItemsSource = service.GetByText(txtFilter.Text.Trim());
        }
    }
}