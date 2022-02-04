using System;
namespace EDIFICIO
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*
			Residente r1 = new Residente("Carlos ",23,"1259136","77123512","Masculino","Soltero","Bolivia",0,"Estudiante");
			Residente r2 = new Residente("Ana",30,"94582521","67852712","Femenino","Casada","Peru",1,"Trabajadora");
			Residente r3 = new Residente("Jhon",29,"12991670","62114242","Masculino","Soltero","Bolivia", 0,"Estudiante");
			Residente r4 = new Residente("Pedro",45,"8959360","77123512","Masculino","Casado","Mexico",2,"Trabajador");
			Residente[] resV = new Residente[4];
			resV[0] = r1;
			resV[1] = r2;
			resV[2] = r3;
			resV[3] = r4;
			
			Telefono t1 = new Telefono("22425059","Tigo");
			Telefono t2 = new Telefono("2255925","Entel");
			Telefono t3 = new Telefono("2195275","Viva");
			Telefono [] telV = new Telefono[3];
			telV[0] = t1;
			telV[1] = t2;
			telV[2] = t3;
			
			Apartamento ap1 = new Apartamento("Anticretico",300,t1);
			Apartamento ap2 = new Apartamento("Alquiler",250,t2);
			Apartamento ap3 = new Apartamento("Anticretico",500,t3);
			Apartamento [] apv = new Apartamento[3];
			apv[0] = ap1;
			apv[1] = ap2;
			apv[2] = ap3;
			
			Mantenimiento m1 = new Mantenimiento("Liang",27,"1057252","77528124","Masculino","Casado","Electricista",3);
			Mantenimiento m2 = new Mantenimiento("Gabriel",35,"8053765","66928214","Masculino","Soltero","Obrero",6);
			Mantenimiento [] manV = new Mantenimiento[2];
			manV[0] = m1;
			manV[1] = m2;
			
			Ambulancia am1 = new Ambulancia("80km/h","Rojo");
			Ambulancia am2 = new Ambulancia("75km/h","Blanco");
			Ambulancia[] amV = new Ambulancia[2];
			amV[0] = am1;
			amV[1] = am2;
			
			Medico me1 = new Medico("Laura",25,"10595825","6862621","Femenino","Soltera","Cardiologa",1,amV);
			Medico me2 = new Medico("Jorge",52,"8862962","7275271","Masculino","Casado","Dermatologo",0,null);
			Medico[] meV = new Medico[2];
			meV[0] = me1;
			meV[1] = me2;
			*/
			
			
			Console.WriteLine("=====================A) INSTANCIAR 3 RESIDENTES Y PASARLO  A UN APARTAMENTO==================================");
			
			// A) INSTANCIAR 3 RESIDENTES Y PASARLO  A UN APARTAMENTO
			Residente r1 = new Residente("Carlos ",23,"1259136","77123512","Masculino","Soltero","Bolivia",0,"Estudiante");
			Residente r2 = new Residente("Ana",30,"94582521","67852712","Femenino","Casada","Peru",1,"Trabajadora");
			Residente r3 = new Residente("Jhon",29,"12991670","62114242","Masculino","Soltero","Bolivia", 0,"Estudiante");
			Residente[] resV = new Residente[4];
			resV[0] = r1;
			resV[1] = r2;
			resV[2] = r3;
			Telefono t12 = new Telefono("22425059","Tigo");
			Apartamento apar = new Apartamento("Anticretico",500,3,resV,t12,0,null);
			apar.mostrarA();
			
			Console.WriteLine("========================B) GUARDAR LOS RESIDENTES EN UNA LISTA DE CONSERJE===============================");
			
			
	
			// B) GUARDAR LOS RESIDENTES EN UNA LISTA DE CONSERJE
			Lista l = new Lista();
			l.agregResid(apar);
			Conserje c1 = new Conserje("Juan",46,"885291","7341235","Masculino","Casado","Buena",65,50,l);
			c1.mostrarC();
			
			
			Console.WriteLine("====================C) Añadir 3 residentes mas a la lista.===================================");
			// C) Añadir 2 residentes mas a la lista.
			l.agregResid(3,resV);
			l.mostrarL();
			
			Console.WriteLine("=================// D) SOBRECARGAR EL OPERADOR ++ PARA SUBIR EL PRECIO DEL APARTAMENTO======================================");
			// D) SOBRECARGAR EL OPERADOR ++ PARA SUBIR EL PRECIO DEL APARTAMENTO
			apar++;
			apar.mostrarA();
			
			Console.WriteLine("===================E) DE UNA LISTA BORRAR 2 RESIDENTES====================================");
			// E) DE UNA LISTA BORRAR 2 RESIDENTES
			l.borrarResidU();
			l.borrarResidU();
			l.mostrarL();
			
			Console.WriteLine("===============F) INSTANCIAR 2 MÉDICOS UNO CON AMBULANCIA Y EL OTRO SIN AMBULANCIA=========================================");
			// F INSTANCIAR 2 MÉDICOS UNO CON AMBULANCIA Y EL OTRO SIN AMBULANCIA
			Ambulancia am1 = new Ambulancia("80km/h","Rojo");
			Ambulancia am2 = new Ambulancia("75km/h","Blanco");
			Ambulancia[] amV = new Ambulancia[2];
			amV[0] = am1;
			amV[1] = am2;
			Medico me1 = new Medico("Laura",25,"10595825","6862621","Femenino","Soltera","Cardiologa",1,amV);
			Medico me2 = new Medico("Jorge",52,"8862962","7275271","Masculino","Casado","Dermatologo",0,null);
			me1.mostrarM();
			me2.mostrarM();
			
			Console.WriteLine("===================G) INSTANCIAR 2 PERSONAL DE MANTENIMIENTO====================================");
			
			// G) INSTANCIAR 2 PERSONAL DE MANTENIMIENTO
			Mantenimiento m1 = new Mantenimiento("Liang",27,"1057252","77528124","Masculino","Casado","Electricista",3);
			Mantenimiento m2 = new Mantenimiento("Gabriel",35,"8053765","66928214","Masculino","Soltero","Obrero",6);
			m1.mostrarMan();
			m2.mostrarMan();
			
			Console.WriteLine("==================H) CREAR UN ADMINISTRATIVO, CONTRATANDO 1 CONSERJE, 2 MEDICOS Y 2 PERSONAL DE MANTENIMIENTO=====================================");
			
			// H) CREAR UN ADMINISTRATIVO, CONTRATANDO 1 CONSERJE, 2 MEDICOS Y 2 PERSONAL DE MANTENIMIENTO.
			Medico[] meV = new Medico[2];
			meV[0] = me1;
			meV[1] = me2;
			Mantenimiento [] manV = new Mantenimiento[2];
			manV[0] = m1;
			manV[1] = m2;
			Administrador ad = new Administrador("Gerardo",46,"7791261","7212516","Masculino","Casado","Mayor San Andres",14,2500,c1,2,meV,2,manV);
			ad.mostrarADM();
			
			Console.WriteLine("====================I) INSTANCIAR UN EDIFICIO COMPLETO===================================");
			// I) INSTANCIAR UN EDIFICIO COMPLETO
			Telefono t1 = new Telefono("22425059","Tigo");
			Telefono t2 = new Telefono("2255925","Entel");
			Telefono t3 = new Telefono("2195275","Viva");
			
			Apartamento ap1 = new Apartamento("Anticretico",300,t1);
			Apartamento ap2 = new Apartamento("Alquiler",250,t2);
			Apartamento ap3 = new Apartamento("Anticretico",500,t3);
			Apartamento [] apV = new Apartamento[3];
			apV[0] = ap1;
			apV[1] = ap2;
			apV[2] = ap3;
		
			Administrador admin = new Administrador("FRANCO",50,"6291731","75421251","Masculino","Casado","Catolica",14,3000,c1,2,meV,2,manV);
			Edificio e = new Edificio("LAPLUS","Residencial","El Alto","ladrillo",12,3,apV,admin);
			e.mostrarE();
			
			Console.ReadKey();
		}
	}
}