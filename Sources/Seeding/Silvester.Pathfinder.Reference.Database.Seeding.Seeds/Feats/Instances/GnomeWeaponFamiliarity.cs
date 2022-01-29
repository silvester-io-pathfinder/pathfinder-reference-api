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
    public class GnomeWeaponFamiliarity : Template
    {
        public static readonly Guid ID = Guid.Parse("8bc4e49e-c586-4841-91f4-fd7e67925a74");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Gnome Weapon Familiarity",
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
            yield return new TextBlock { Id = Guid.Parse("37d6be4d-2f6c-47bb-9b7a-3da04389047e"), Type = TextBlockType.Text, Text = $"You favor unusual weapons tied to your people, such as blades with curved and peculiar shapes. You are trained with the glaive and kukri." };
            yield return new TextBlock { Id = Guid.Parse("04abd352-4fc4-4975-914d-3e83dabe66b4"), Type = TextBlockType.Text, Text = $"In addition, you gain access to all uncommon gnome weapons. For the purpose of determining your proficiency, martial gnome weapons are simple weapons and advanced gnome weapons are martial weapons." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Gnome.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eb4b6857-c2cf-437e-a407-b156add1d886"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
