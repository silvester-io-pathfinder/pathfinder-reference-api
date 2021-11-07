using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImpossibleStriker : Template
    {
        public static readonly Guid ID = Guid.Parse("eebead1d-890c-4b78-909b-87caa32d3872");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Impossible Striker",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5eba2c6d-69d7-4224-8b9a-bffc3c1245b9"), Type = TextBlockType.Text, Text = "Your attacks are swift and deadly beyond explanation. Nothing can prevent you from making a sneak attack, even if your opponent can see every blow coming. Instead of dealing the damage from (feat: Sly Striker), you can deal your full sneak attack damage to a target even if the target isn’t flat-footed." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6bb0987c-987f-47e7-a3b5-f57aae4271a2"), Feats.Instances.SlyStriker.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("baf94b11-50ce-4f4e-97c9-eb70c8dc0b42"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
