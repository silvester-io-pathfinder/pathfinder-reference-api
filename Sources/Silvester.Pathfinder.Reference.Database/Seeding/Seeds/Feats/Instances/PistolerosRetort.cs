using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PistolerosRetort : Template
    {
        public static readonly Guid ID = Guid.Parse("c802363e-cb4c-4a62-af08-10b471ebb5c7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pistolero's Retort",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A foe within the first range increment of the one- handed firearm or one-handed crossbow you're wielding critically fails an attack roll against you.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f11926e5-96ce-4557-ad9e-44cf03b9ecad"), Type = TextBlockType.Text, Text = "You punish your foe’s failure with a shot. Make a (action: Strike) against the triggering foe with a one-handed firearm or one-handed crossbow." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8833d74a-b804-4b7b-9bbd-f6db1d808c38"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
