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
    public class GravityWeapon : Template
    {
        public static readonly Guid ID = Guid.Parse("922cc8f0-375d-4044-98fc-dc12ff07ab41");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Gravity Weapon",
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
            yield return new TextBlock { Id = Guid.Parse("78010ee1-7949-42af-937a-442de1b698d7"), Type = TextBlockType.Text, Text = $"Your expertise with your weapons and commitment to taking out your targets lends you magical power. You gain the {ToMarkdownLink<Models.Entities.Spell>("gravity weapon", Spells.Instances.GravityWeapon.ID)} warden spell and a focus pool of 1 Focus Point." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Ranger.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6e3dae6b-de92-4139-9700-0a9bf7849884"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
