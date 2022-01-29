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
    public class DualWeaponReload : Template
    {
        public static readonly Guid ID = Guid.Parse("77ad7701-4e3a-4b83-8bce-90f23a10ecd5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dual-Weapon Reload",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7e4ca79e-3aaf-4407-aeb6-5f3c4f093f43"), Type = TextBlockType.Text, Text = $"You carry your ammunition in a way that allows you to reload while holding two weapons. You {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} to reload a one-handed ranged weapon you're holding. Unlike most {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} actions, you don't need a free hand to reload your ranged weapon in this way." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1dc92555-5d9d-413e-8376-90f06341e9ae"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
