using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShatteringStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("3126d905-a2f6-4258-877d-6b1bf15fc83a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shattering Strike",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An improvised weapon that you are wielding becomes broken as a result of a critical success on an Improvised Pummel.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("61e10391-c96d-4d97-93cb-c2fb4fa7d8d4"), Type = TextBlockType.Text, Text = "The improvised weapon shatters, destroying it completely but dealing an additional 3d6 piercing damage to the creature you hit with the (feat: Improvised Pummel). This extra damage you apply on the critical hit doesn’t double from the critical hit, as normal." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("80492f1f-8123-4ee7-96b8-f0a1514815cc"), Feats.Instances.ImprovisedPummel.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bb4bcd15-063d-4687-93fa-ef1a9a3017ea"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
