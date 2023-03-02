using System;

namespace TechJobsAuthentication.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Employer { get; set; }
        public string Skill { get; set; }

        public Job()
        {
        }

        public Job(string name, string employer, string skill)
        {
            Name = name;
            Employer = employer;
            Skill = skill;
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            return obj is Job @job &&
                   Id == @job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}