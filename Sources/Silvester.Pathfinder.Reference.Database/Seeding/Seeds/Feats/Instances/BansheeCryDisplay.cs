using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BansheeCryDisplay : Template
    {
        public static readonly Guid ID = Guid.Parse("691ef440-fcbd-4d71-b64b-1c9ada3ab204");

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
            yield return new TextBlock { Id = Guid.Parse("1882ded2-d9d1-48c4-807c-482ca1b7d6a2"), Type = TextBlockType.Text, Text = "You’ve learned how to pull off a sudden noisemaker at just the right moment in your display, a technique that can disrupt precise wording. You gain the Banshee Cry fireworks display." };
            yield return new TextBlock { Id = Guid.Parse("2c17e734-e119-4e6a-9814-a87a5f6e9196"), Type = TextBlockType.Text, Text = "~ Banshee Cry: REACTION **Trigger** A creature within 30 feet Casts a Spell that has a verbal component or Activates an Item using a command Activation; **Effect** You set off a firework to explode with a loud screech near the creature. The creature must attempt a Will save." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e55b2f59-0fa7-4f21-ae1c-9af43be68752"), Feats.Instances.FireworkTechnicianDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("8e574d06-49cc-431e-a2f0-3a286d19bb5b"),
                
                Success = "The creature is unaffected.",
                Failure = "The creature must use an additional action on the triggering action or activity, or it’s disrupted.",
                CriticalFailure = "The triggering action is disrupted.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("725a6f4e-6482-4efa-81b9-8b4657547cc1"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
