using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SorcererElementalistAir : Template
    {
        public static readonly Guid ID = Guid.Parse("53818dff-9551-4eef-9143-ddfa7fbe39a3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sorcerer Elementalist - Air",
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
            yield return new TextBlock { Id = Guid.Parse("0c2bc833-8c75-4c09-85bb-ddf9e44a0bc7"), Type = TextBlockType.Text, Text = $"You replace your initial bloodline spell with the initial air elemental focus spell ({ToMarkdownLink<Models.Entities.Spell>("updraft", Spells.Instances.Updraft.ID)}), and your advanced bloodline spell (if you get it) with the advanced air elemental focus spell ({ToMarkdownLink<Models.Entities.Spell>("powerful inhalation", Spells.Instances.PowerfulInhalation.ID)})." };
            yield return new TextBlock { Id = Guid.Parse("a06c6e1f-6c4d-4cf1-976b-87fe3965a683"), Type = TextBlockType.Text, Text = $"You can only select this option if your bloodline's elemental type is air." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2507eec8-17bc-440d-b43a-aea41c8a7269"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
