using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DeepSeededFear : Template
    {
        public static readonly Guid ID = Guid.Parse("e68901ff-8298-4659-8285-eeabb7e17430");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Deep-Seeded Fear",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d7ee1518-0bf4-4121-be03-ec10d38501a1"), Type = TextBlockType.Text, Text = "You gain a +2 status bonus to your Intimidation checks and don’t take any penalties for not sharing a language when (action: Demoralizing|Demoralize) foes who can perceive your armament’s essence form. When you manifest the essence form, you can attempt to (action: Demoralize) an enemy who can perceive the manifestation." };
            yield return new TextBlock { Id = Guid.Parse("8fbd2308-40da-4438-87d9-1f5e4be42748"), Type = TextBlockType.Text, Text = "__Corruption Flaw__ If you attempt to (action: Demoralize) an enemy, your (action: Demoralize) also targets the ally closest to you.get. This (action: Strike) uses the same multiple attack penalty as the missed (action: Strike) and doesn’t count toward your multiple attack penalty." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9d726f04-a646-4229-bc91-1635fe206632"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
