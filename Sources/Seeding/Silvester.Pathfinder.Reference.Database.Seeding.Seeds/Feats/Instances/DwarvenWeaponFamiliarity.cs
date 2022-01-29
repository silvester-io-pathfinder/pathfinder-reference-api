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
    public class DwarvenWeaponFamiliarity : Template
    {
        public static readonly Guid ID = Guid.Parse("d795b9c2-7731-4011-a58d-cedf21774233");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dwarven Weapon Familiarity",
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
            yield return new TextBlock { Id = Guid.Parse("14b67760-97fd-4d23-b6c3-1bfae0bffb77"), Type = TextBlockType.Text, Text = $"Your kin have instilled in you an affinity for hard-hitting weapons, and you prefer these to more elegant arms. You are trained with the battle axe, pick, and warhammer." };
            yield return new TextBlock { Id = Guid.Parse("3f4e8885-6c1d-4261-b7a9-d178601cfa68"), Type = TextBlockType.Text, Text = $"You also gain access to all uncommon dwarf weapons. For the purpose of determining your proficiency, martial dwarf weapons are simple weapons and advanced dwarf weapons are martial weapons." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Dwarf.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("37b8c9cb-7b63-46ff-91a2-61381e59fcef"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
