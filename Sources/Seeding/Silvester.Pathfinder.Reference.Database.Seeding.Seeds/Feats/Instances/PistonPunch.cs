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
    public class PistonPunch : Template
    {
        public static readonly Guid ID = Guid.Parse("4501b4f0-7957-498f-a598-3f0f206c33de");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Piston Punch",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("04b581e6-c029-4f0d-86c3-a5bfe973c70e"), Type = TextBlockType.Text, Text = $"You lash out with a powerful punch, extending your dynamo to a greater length in order to attack two creatures in a row. Make a single bludgeoning or piercing dynamo {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} and compare the attack roll result to the ACs of up to two foes. The first foe must be within your melee reach and the second foe must be adjacent to the first foe in a straight line away from you. Roll damage only once and apply it to each creature you hit. A Piston Punch counts as two attacks for your multiple attack penalty. Reduce the operational time of your sterling dynamo by 1 hour." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e594ac55-2eba-4da6-9c9b-1ae466b46701"), Feats.Instances.SterlingDynamoDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7c8eb81b-6cab-4dac-a684-5442e963a2fe"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
