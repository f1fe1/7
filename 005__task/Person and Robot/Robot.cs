using _005__task.Interfaces;
using _005__task.Validator_and_Rules;
using System;

namespace _005__task.Person_and_Robot
{
    internal class Robot : IRobot
    {
        private string _model = "Undefined";
        private string _id = "Undefined";
        public Robot(string _model, string _id)
        {
            this.Model = _model;
            this.Id = _id;
        }
        public string Model
        {
            get => _model;
            private set
            {
                Validator.ValidNotEmpty(value, nameof(this.Model));
                this._model = value;
            }
        }
        public string Id
        {
            get => _id;
            private set
            {
                Validator.ValidNotEmpty(value, nameof(this.Id));
                Validator.ValidIsOnlyDigit(value, nameof(this._id));
                this._id = value;
            }
        }
    }
}
