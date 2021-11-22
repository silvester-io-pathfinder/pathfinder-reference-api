using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BansheeCryDisplay : Template
    {
        public static readonly Guid ID = Guid.Parse("5b9e269d-169f-4d06-ab7b-f8acee85727d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Banshee Cry Display",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d5d5ebb2-62ce-4892-9cbe-690452319af1"), Type = TextBlockType.Text, Text = "You've learned how to pull off a sudden noisemaker at just the right moment in your display, a technique that can disrupt precise wording. You gain the Banshee Cry fireworks display." };
            yield return new TextBlock { Id = Guid.Parse("0be9c7ea-9403-45e2-b1fd-6931652334f4"), Type = TextBlockType.Text, Text = "~ Banshee Cry: REACTION **Trigger** A creature within 30 feet Casts a Spell that has a verbal component or Activates an Item using a command Activation; **Effect** You set off a firework to explode with a loud screech near the creature. The creature must attempt a Will save." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("df073566-680f-4856-8d96-2fe4ab97ef74"), Feats.Instances.FireworkTechnicianDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("8907c390-31c9-4a8d-a4b4-7d021d792b77"),
                
                Success = "The creature is unaffected.",
                Failure = "The creature must use an additional action on the triggering action or activity, or it's disrupted.",
                CriticalFailure = "The triggering action is disrupted.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("187d3fb5-4acc-4724-80fd-81a97de4fd8a"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
