using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArcaneFists : Template
    {
        public static readonly Guid ID = Guid.Parse("9d98ad37-6952-4324-a6ce-19e0a979a859");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Arcane Fists",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8d475224-83eb-4eb5-a6e6-a95fdc76b825"), Type = TextBlockType.Text, Text = "Your physical training encompasses unarmed combat forms. The damage die for your fist changes to 1d6 instead of 1d4. You don’t take the normal –2 circumstance penalty when making a lethal attack with your fist or any other unarmed attacks. Your unarmed attacks gain the (trait: arcane) trait, making them magical. At 5th level, you also gain the critical specialization effects of unarmed attacks in the brawling group and weapons in the brawling group." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f7d3a264-3285-4b0a-a28c-b82125d91e3c"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
