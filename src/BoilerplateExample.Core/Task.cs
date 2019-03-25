using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;

namespace BoilerplateExample
{
    public class Task : Entity, IHasCreationTime
    {
        public const int MixTitleLength = 256;
        public const int MixDescrioptionLength = 64 * 1024;

        
        public string Title { get; set; }
        public string Description { get; set; }

        public DateTime CreationTime { get; set; }
        public TaskState State { get; set; }

        public Task()
        {
            CreationTime = Clock.Now;
            State = TaskState.Open;
        }

        public Task(string title, string description = null) : this()
        {
            Title = title;
            Description = description;
        }
        
    }

    public enum TaskState : byte
    {
       Open = 0,
        Complited = 1
    }
}
