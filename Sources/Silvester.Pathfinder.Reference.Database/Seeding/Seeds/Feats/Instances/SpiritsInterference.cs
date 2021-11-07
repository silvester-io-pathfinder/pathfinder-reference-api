using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpiritsInterference : Template
    {
        public static readonly Guid ID = Guid.Parse("dfd6d5c0-672b-4d03-81b7-f650351bf5a0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spirits' Interference",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9f83ec92-f4c3-46e7-a460-7ec263d5b99a"), Type = TextBlockType.Text, Text = "You call forth protective spirits to ward off ranged attacks. Until your rage ends, anyone making a ranged attack against you must succeed at a DC 5 flat check or the attack misses with no effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInstinct(Guid.Parse("8d4c34fb-08b2-4ae8-aa6f-a4df96c257f6"), Instincts.Instances.SpiritInstinct.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5df18fe8-b837-4c32-89fb-aa30969810e9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
