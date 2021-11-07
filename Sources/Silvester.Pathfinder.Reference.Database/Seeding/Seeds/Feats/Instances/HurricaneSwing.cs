using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HurricaneSwing : Template
    {
        public static readonly Guid ID = Guid.Parse("3b193c2d-be90-474c-a42c-a60cb6db5272");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hurricane Swing",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You critically hit a foe with a Strike with a slashing weapon.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("22a764be-0e1f-4310-8942-a6a269d1d381"), Type = TextBlockType.Text, Text = "Choose either (spell: lightning bolt) or (spell: gust of wind). You (action: Cast the chosen Spell | Cast a Spell) as a 6th-level primal innate spell in the direction of the target of the triggering action." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e412473c-0b28-4f97-be26-983f1b1171f0"), Feats.Instances.StormsLash.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7133a345-cb88-449a-8b25-39b4ad7e5388"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
