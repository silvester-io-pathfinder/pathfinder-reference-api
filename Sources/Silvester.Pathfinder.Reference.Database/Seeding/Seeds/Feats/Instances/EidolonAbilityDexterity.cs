using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EidolonAbilityDexterity : Template
    {
        public static readonly Guid ID = Guid.Parse("d84efc39-0fac-4fb6-8440-dac15c50b2f7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eidolon Ability - Dexterity",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("042dd7b4-9ef1-4e43-a894-79d755f81483"), Type = TextBlockType.Text, Text = "Your eidolon&#39;s Dexterity ability score increases by 2, or by 1 if it&#39;s already 18 or above." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e9e1f81c-966c-41b9-a20c-106b70812b1c"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
