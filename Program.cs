using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.cviceni_9
{
	class Program
	{
		static void Main(string[] args)
		{
			DataClasses1DataContext db = new DataClasses1DataContext();

			Student Boccherini = new Student() { Name = "Luigi", Surname = "Boccherini", Birthday = new DateTime(1763, 02, 19), ID = 10 };
			Student Gluck = new Student() { Name = "Christoph", Surname = "Gluck", Birthday = new DateTime(1764, 07, 02), ID = 11 };
			Student Beethoven = new Student() { Name = "Ludwig", Surname = "van Beethoven", Birthday = new DateTime(1770, 12, 17), ID = 12 };
			Student Bach =  new Student() { Name = "Johann", Surname = "Bach", Birthday = new DateTime(1765, 09, 05), ID = 13 };
			Student Salieri = new Student() { Name = "Antonio", Surname = "Salieri", Birthday = new DateTime(1750, 08, 18), ID = 14 };
			Student Mozart = new Student() { Name = "Wolfgang", Surname = "Mozart", Birthday = new DateTime(1763, 12, 20), ID = 15 };
			Student Haydn = new Student() { Name = "Joseph", Surname = "Haydn", Birthday = new DateTime(1762, 01, 04), ID = 16};


			Subject MusicTheory = new Subject() { Title = "MusicTheory", Shortcut = "MT" };
			Subject Notation = new Subject() { Title = "Notation", Shortcut = "Not" };
			Subject Practice = new Subject() { Title = "Practice", Shortcut = "Pr", };
			Subject Orchestration = new Subject() { Title = "Orchestration", Shortcut = "Orchestr" };

			// vložení objektů Student a Subject do příslušných tabulek
			db.Students.InsertOnSubmit(Boccherini);
			db.Students.InsertOnSubmit(Gluck);
			db.Students.InsertOnSubmit(Beethoven);
			db.Students.InsertOnSubmit(Bach);
			db.Students.InsertOnSubmit(Haydn);
			db.Students.InsertOnSubmit(Salieri);
			db.Students.InsertOnSubmit(Mozart);
			//---------------------------------------------------------
			db.Subjects.InsertOnSubmit(MusicTheory);
			db.Subjects.InsertOnSubmit(Notation);
			db.Subjects.InsertOnSubmit(Practice);
			db.Subjects.InsertOnSubmit(Orchestration);
			db.SubmitChanges();


			
			// vytvoření nových objektů reprezentujících vazbu - Student-Subject
			Connection Mozart_Orchestr = new Connection() {IDS = Mozart.ID, Shortcuts = Orchestration.Shortcut };
			Connection Boccherini_Orchestr = new Connection() {IDS = Boccherini.ID, Shortcuts = Orchestration.Shortcut };
			Connection Gluck_Orchestr = new Connection() {IDS = Gluck.ID, Shortcuts = Orchestration.Shortcut};
			Connection Beethoven_Orchestr = new Connection() {IDS = Beethoven.ID,Shortcuts = Orchestration.Shortcut};
			Connection Haydn_Orchestr = new Connection() {IDS = Haydn.ID, Shortcuts = Orchestration.Shortcut};

			db.Connections.InsertOnSubmit(Mozart_Orchestr);
			db.Connections.InsertOnSubmit(Boccherini_Orchestr);
			db.Connections.InsertOnSubmit(Gluck_Orchestr);
			db.Connections.InsertOnSubmit(Beethoven_Orchestr);
			db.Connections.InsertOnSubmit(Haydn_Orchestr);
			db.SubmitChanges();



		}
	}


}


