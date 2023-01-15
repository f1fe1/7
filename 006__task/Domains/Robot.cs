using _006__task.Interfaces;
using _006__task.Validator_and_Rules;
using System;

namespace _006__task.Domains
{
    internal class Robot : IRobot
    {
        private string _model;
        private string _id;
        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }
        public virtual string Model
        {
            get => _model;  
            set
            {
                Validator.EmptyOrNull(value, nameof(this.Model));
                _model = value;
            }
        }
        public virtual string Id
        {
            get => _id;
            set
            {
                Validator.EmptyOrNull(value, nameof(Id));
                Validator.OnlyDigit(value, nameof(Id));
                this._id = value;
            }
        }
    }
}
