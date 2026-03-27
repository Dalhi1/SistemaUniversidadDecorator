using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaUniversidadDecorator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCarrera.Items.Add("Ing. Sistemas");
            cmbCarrera.Items.Add("Ing. Informatica");
            cmbCarrera.Items.Add("Ing. Ciberseguridad");
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            TecnmComponent carrera = null;

            if (cmbCarrera.SelectedIndex == 0)
                carrera = new IngSC();
            else if (cmbCarrera.SelectedIndex == 1)
                carrera = new IngI();
            else if (cmbCarrera.SelectedIndex == 2)
                carrera = new IngC();
            else
            {
                MessageBox.Show("Selecciona una carrera");
                return;
            }

            if (chkFisica.Checked)
                carrera = new Fisica(carrera);

            if (chkCalculo.Checked)
                carrera = new Calculo(carrera);

            if (chkProgramacion.Checked)
                carrera = new Programacion(carrera);

            if (chkIngles.Checked)
                carrera = new Ingles(carrera);

            if (chkTutoria.Checked)
                carrera = new Tutoria(carrera);

            txtResultado.Clear();

            txtResultado.AppendText($"CARRERA: {carrera.Descripcion}\r\n");
            txtResultado.AppendText($"CLAVE: {carrera.Clave}\r\n\r\n");

            txtResultado.AppendText("MATERIAS:\r\n");
            txtResultado.AppendText("====================================\r\n");

            foreach (var m in carrera.ObtenerMaterias())
            {
                txtResultado.AppendText($"{m.Nombre} | {m.Clave} | Maestro: {m.Maestro}\r\n");

                txtResultado.AppendText("   Materiales:\r\n");

                foreach (var material in m.Materiales)
                {
                    txtResultado.AppendText("   - " + material.ObtenerDescripcion() + "\r\n");
                }

                txtResultado.AppendText("\r\n");
            }

            cmbCarrera.SelectedIndex = -1;

            chkFisica.Checked = false;
            chkCalculo.Checked = false;
            chkProgramacion.Checked = false;
            chkIngles.Checked = false;
            chkTutoria.Checked = false;
        }
    }

    public class Materia
    {
        public string Clave { get; set; }
        public string Nombre { get; set; }
        public string Maestro { get; set; }

        
        public List<IMaterial> Materiales { get; set; } = new List<IMaterial>();
    }

    public abstract class TecnmComponent
    {
        public abstract string Clave { get; }
        public abstract string Descripcion { get; }
        public abstract List<Materia> ObtenerMaterias();
    }

    public class IngSC : TecnmComponent
    {
        public override string Clave => "ISC";
        public override string Descripcion => "Ingenieria en Sistemas Computacionales";

        public override List<Materia> ObtenerMaterias()
        {
            return new List<Materia>();
        }
    }

    public class IngI : TecnmComponent
    {
        public override string Clave => "INF";
        public override string Descripcion => "Ingenieria en Informatica";

        public override List<Materia> ObtenerMaterias()
        {
            return new List<Materia>();
        }
    }

    public class IngC : TecnmComponent
    {
        public override string Clave => "ICB";
        public override string Descripcion => "Ingenieria en Ciberseguridad";

        public override List<Materia> ObtenerMaterias()
        {
            return new List<Materia>();
        }
    }

    public abstract class AgregadoDecorator : TecnmComponent
    {
        protected TecnmComponent _tecnm;

        public AgregadoDecorator(TecnmComponent t)
        {
            _tecnm = t;
        }

        public override string Clave => _tecnm.Clave;
        public override string Descripcion => _tecnm.Descripcion;

        public override List<Materia> ObtenerMaterias()
        {
            return _tecnm.ObtenerMaterias();
        }
    }

    public class Fisica : AgregadoDecorator
    {
        public Fisica(TecnmComponent t) : base(t) { }

        public override List<Materia> ObtenerMaterias()
        {
            var lista = base.ObtenerMaterias();

            var materia = new Materia
            {
                Clave = "FIS101",
                Nombre = "Fisica",
                Maestro = "Dr. Lopez"
            };

            
            materia.Materiales.Add(new Libro("Fisica Serway"));
            materia.Materiales.Add(new Libro("Fisica Universitaria - Sears y Zemansky"));

            lista.Add(materia);

            return lista;
        }
    }

    public class Calculo : AgregadoDecorator
    {
        public Calculo(TecnmComponent t) : base(t) { }

        public override List<Materia> ObtenerMaterias()
        {
            var lista = base.ObtenerMaterias();

            var materia = new Materia
            {
                Clave = "MAT101",
                Nombre = "Calculo Diferencial",
                Maestro = "Dra. Perez"
            };

            materia.Materiales.Add(new Libro("Calculo Stewart"));
            materia.Materiales.Add(new Libro("Calculo Larson"));

            lista.Add(materia);

            return lista;
        }
    }

    public class Programacion : AgregadoDecorator
    {
        public Programacion(TecnmComponent t) : base(t) { }

        public override List<Materia> ObtenerMaterias()
        {
            var lista = base.ObtenerMaterias();

            var materia = new Materia
            {
                Clave = "PRO101",
                Nombre = "Programacion",
                Maestro = "Ing. Torres"
            };

            
            materia.Materiales.Add(new Libro("Clean Code"));
            materia.Materiales.Add(new Libro("The Pragmatic Programmer"));
            materia.Materiales.Add(new Libro("C# Avanzado"));

            lista.Add(materia);

            return lista;
        }
    }

    public class Ingles : AgregadoDecorator
    {
        public Ingles(TecnmComponent t) : base(t) { }

        public override List<Materia> ObtenerMaterias()
        {
            var lista = base.ObtenerMaterias();

            var materia = new Materia
            {
                Clave = "ING101",
                Nombre = "Ingles",
                Maestro = "Mtro. Garcia"
            };

            
            materia.Materiales.Add(new Libro("English Grammar in Use"));
            materia.Materiales.Add(new Libro("Oxford English Dictionary"));
            materia.Materiales.Add(new Libro("Basic English Conversation"));

            lista.Add(materia);

            return lista;
        }
    }

    public class Tutoria : AgregadoDecorator
    {
        public Tutoria(TecnmComponent t) : base(t) { }

        public override List<Materia> ObtenerMaterias()
        {
            var lista = base.ObtenerMaterias();

            var materia = new Materia
            {
                Clave = "TUT101",
                Nombre = "Tutoria",
                Maestro = "Lic. Ramirez"
            };

           
            materia.Materiales.Add(new Libro("Guia del Estudiante"));
            materia.Materiales.Add(new Libro("Desarrollo Personal y Academico"));
            materia.Materiales.Add(new Libro("Habitos de Estudio Efectivos"));

            lista.Add(materia);

            return lista;
        }
    }
    // ===== BRIDGE =====
    public interface IMaterial
    {
        string ObtenerDescripcion();
    }

    public class Libro : IMaterial
    {
        private string nombre;

        public Libro(string nombre)
        {
            this.nombre = nombre;
        }

        public string ObtenerDescripcion()
        {
            return "Libro: " + nombre;
        }
    }
}
