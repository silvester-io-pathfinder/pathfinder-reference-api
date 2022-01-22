using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GoldenBody : Template
    {
        public static readonly Guid ID = Guid.Parse("33ff7efa-8b2a-46d1-bab6-9ab960567ac4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Golden Body",
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
            yield return new TextBlock { Id = Guid.Parse("23886545-3cb9-40dc-9b6f-01e6b08c1797"), Type = TextBlockType.Text, Text = $"~ Access: secure Visitor's Pins or an alliance with Mengkare." };
            yield return new TextBlock { Id = Guid.Parse("c5efad09-7d47-46b7-9bd4-cc17b98920ff"), Type = TextBlockType.Text, Text = $"You perfect your body, refining the flex of every muscle and the bend of every joint to maximum efficiency. Your unarmed {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} gain the {ToMarkdownLink<Models.Entities.Trait>("deadly", Traits.Instances.Deadly.ID)} d12 trait, and you have fast healing 20, causing you to regain 20 HP at the start of each of your turns provided you have at least 1 HP." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4550a476-3470-4664-a813-af0ac17fed17"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
