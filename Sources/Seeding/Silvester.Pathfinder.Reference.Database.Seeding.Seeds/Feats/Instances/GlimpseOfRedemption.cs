using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GlimpseOfRedemption : Template
    {
        public static readonly Guid ID = Guid.Parse("5e636b5b-cb2f-400f-9aec-f708ae62f237");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Glimpse of Redemption",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An enemy damages your ally, and both are within 15 feet of you.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1db9edf1-c967-4470-9b8d-59b3a78c938e"), Type = TextBlockType.Text, Text = "Your foe hesitates under the weight of sin as visions of redemption play in their mind's eye. The foe must choose one of the following options:" };
            yield return new TextBlock { Id = Guid.Parse("d7d2c8d0-901a-4f99-bfd0-523883f56189"), Type = TextBlockType.Enumeration, Text = " : The ally is unharmed by the triggering damage." };
            yield return new TextBlock { Id = Guid.Parse("656ae4ef-660a-4607-8e53-628ab504b423"), Type = TextBlockType.Enumeration, Text = " : The ally gains resistance to all damage against the triggering damage equal to 2 + your level. After the damaging effect is applied, the enemy becomes enfeebled 2 until the end of its next turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d94db2da-347f-4c63-bc8e-07b5459530ee"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
