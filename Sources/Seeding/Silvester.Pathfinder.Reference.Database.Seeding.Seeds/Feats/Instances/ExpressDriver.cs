using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExpressDriver : Template
    {
        public static readonly Guid ID = Guid.Parse("355904aa-4abd-4111-8a39-01ea14a143f1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Express Driver",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("569033b6-ecac-4f73-a04a-f5a1d2a8a99a"), Type = TextBlockType.Text, Text = $"You can optimize your vehicle's performance, coaxing extra speed and choosing paths to avoid slowdowns. When calculating your travel speed for the day while piloting a vehicle, you can attempt a Driving Lore check to increase your vehicle's travel speed. The DC is determined by the GM but is typically based on the vehicle's piloting DC or a difficulty based on the environment, whichever is harder. On a success, increase your vehicle's travel speed by half. This has no effect on your vehicle's movement in encounters." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("999c9e45-abe5-484d-8c55-763b5c4b1910"), Feats.Instances.TrickDriverDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("4bf6773b-0d28-41dd-83d7-6927781977c6"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("dc463be9-4e0c-43fc-b961-56ece14ab385"), Traits.Instances.Exploration.ID);
            builder.Add(Guid.Parse("ca1cf6e0-e24f-4d5c-aadc-0459f1f3bc0b"), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1c613e87-4cab-4303-bf12-53e39fe77c2a"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
