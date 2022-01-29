using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MetamagicMastery : Template
    {
        public static readonly Guid ID = Guid.Parse("c912053e-9249-4216-b979-7ea34de9ca46");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Metamagic Mastery",
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
            yield return new TextBlock { Id = Guid.Parse("4972e5db-1272-44b1-bcb4-729903745283"), Type = TextBlockType.Text, Text = $"Altering your spells doesn't take any longer than casting them normally. You can use {ToMarkdownLink<Models.Entities.Trait>("metamagic", Traits.Instances.Metamagic.ID)} single actions as free actions." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9d2b0c6e-eb72-40be-8e22-6c29be158d93"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
