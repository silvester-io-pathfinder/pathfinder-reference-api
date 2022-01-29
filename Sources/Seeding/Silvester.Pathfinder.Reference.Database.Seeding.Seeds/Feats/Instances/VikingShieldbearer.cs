using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VikingShieldbearer : Template
    {
        public static readonly Guid ID = Guid.Parse("0131d120-ab4c-48ed-afce-318869d0bc1d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Viking Shieldbearer",
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
            yield return new TextBlock { Id = Guid.Parse("726530b5-cd10-4360-8cad-1e6b1b43bc45"), Type = TextBlockType.Text, Text = $"~ Access: Ulfen ethnicity" };
            yield return new TextBlock { Id = Guid.Parse("ed25f82b-6a1e-49ac-bc1b-5e85a577bd14"), Type = TextBlockType.Text, Text = $"You trained with shields and weapons as soon as you were old enough to hold them, eager to win honor and glory for yourself. You gain the {ToMarkdownLink<Models.Entities.Feat>("Shield Block", Feats.Instances.ShieldBlock.ID)} reaction and are trained in your choice of the battle axe or longsword." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("6850d6bf-7e8d-448d-abc3-113f51f53371"), Traits.Instances.Human.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("25e4ecfe-5067-4b7d-9078-c35fe44d6133"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
