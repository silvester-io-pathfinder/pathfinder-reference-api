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
    public class ImprovedPoisonWeapon : Template
    {
        public static readonly Guid ID = Guid.Parse("d6362da1-7e1c-4341-b9b3-3d6d81aa0ec3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Improved Poison Weapon",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("82ffb9b0-94ac-4087-9c45-5e478b4b2c7c"), Type = TextBlockType.Text, Text = $"You deliver poisons in ways that maximize their harmful effects. When you apply a simple poison with {ToMarkdownLink<Models.Entities.Feat>("Poison Weapon", Feats.Instances.PoisonWeapon.ID)}, the poison deals 2d4 poison damage instead of 1d4 poison damage. You don't waste a poison you apply with {ToMarkdownLink<Models.Entities.Feat>("Poison Weapon", Feats.Instances.PoisonWeapon.ID)} on a critically failed attack roll." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c876d0bd-0d15-450a-8a5f-fd9d9ae9cb39"), Feats.Instances.PoisonWeapon.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("459f101b-1172-440c-8a2e-9a078ed5f152"), Traits.Instances.Rogue.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("63e5540b-8901-432c-add0-a440b3e75850"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
