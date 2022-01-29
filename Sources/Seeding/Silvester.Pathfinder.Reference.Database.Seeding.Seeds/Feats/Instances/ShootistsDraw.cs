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
    public class ShootistsDraw : Template
    {
        public static readonly Guid ID = Guid.Parse("958dad3e-5db3-48cb-b998-52061eac160d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shootist's Draw",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per round"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2bb35e14-1cb2-4b06-8a6f-40c4c88fd207"), Type = TextBlockType.Text, Text = $"You {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} to draw a {ToMarkdownLink<Models.Items.Instances.RangedWeapon>("hand crossbow", Items.RangedWeapons.Instances.HandCrossbow.ID)} and {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with it, or you {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with a loaded {ToMarkdownLink<Models.Items.Instances.RangedWeapon>("hand crossbow", Items.RangedWeapons.Instances.HandCrossbow.ID)} you're already holding and then {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} to stow it." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6209b044-4a57-4593-b483-32749e690fc0"),
                SourceId = Sources.Instances.AbominationVaults.ID,
                Page = -1
            };
        }
    }
}
