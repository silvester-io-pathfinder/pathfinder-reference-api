using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ActionTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances
{
    public class SustainASpell : Template
    {
        public static readonly Guid ID = Guid.Parse("c8a05b52-8e51-4257-ad64-eb9de3daadf3");

        protected override Models.Entities.Action GetAction()
        {
            return new Models.Entities.Action
            {
                Id = ID,
                Name = "Sustain a Spell",
                Requirements = "You have at least one spell active with a sustained duration, and you are not fatigued.",
                ActionTypeId = OneAction.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("27918e16-383c-46e9-8525-ea4908422c44"), Text = "Choose one spell with a sustained duration you have in effect. The duration of that spell continues until the end of your next turn. Some spells might have slightly different or expanded effects if you sustain them. Sustaining a Spell for more than 10 minutes (100 rounds) ends the spell and makes you fatigued unless the spell lists a different maximum duration (such as �sustained up to 1 minute� or �sustained up to 1 hour�)." };
            yield return new TextBlock { Id = Guid.Parse("2ed6569f-92c3-493a-ba9d-c09d1dbaca65"), Text = "If your Sustain a Spell action is disrupted, the spell immediately ends." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Concentrate.ID;
        }
    }
}
