using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DruidElementalistKeepTempestSurge : Template
    {
        public static readonly Guid ID = Guid.Parse("c1b4bf8b-24a6-4459-a020-2418341a9d50");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Druid Elementalist - Keep Tempest Surge",
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
            yield return new TextBlock { Id = Guid.Parse("aaed095c-3080-4d17-b406-d52d4e9c47ce"), Type = TextBlockType.Text, Text = $"You choose not to replace your starting order spell, {ToMarkdownLink<Models.Entities.Spell>("tempest surge", Spells.Instances.TempestSurge.ID)}, with {ToMarkdownLink<Models.Entities.Spell>("updraft", Spells.Instances.Updraft.ID)}." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0b883aa8-62a8-442a-9932-179c291dc0dc"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
