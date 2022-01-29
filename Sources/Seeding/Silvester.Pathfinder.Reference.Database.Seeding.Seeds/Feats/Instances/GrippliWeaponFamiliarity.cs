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
    public class GrippliWeaponFamiliarity : Template
    {
        public static readonly Guid ID = Guid.Parse("e06d71b1-e9c6-4afe-a6d7-b964c7c7519c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Grippli Weapon Familiarity",
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
            yield return new TextBlock { Id = Guid.Parse("662a7587-59e1-4c55-888f-df36d44759f6"), Type = TextBlockType.Text, Text = $"You've trained with weapons ideally suited to marshes and dense forests. You are trained with {ToMarkdownLink<Models.Items.Instances.RangedWeapon>("blowguns", Items.RangedWeapons.Instances.Blowgun.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("hatchets", Items.MeleeWeapons.Instances.Hatchet.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("scythes", Items.MeleeWeapons.Instances.Scythe.ID)}, {ToMarkdownLink<Models.Items.Instances.RangedWeapon>("shortbows", Items.RangedWeapons.Instances.Shortbow.ID)}, and {ToMarkdownLink<Models.Items.Instances.RangedWeapon>("composite shortbows", Items.RangedWeapons.Instances.CompositeShortbow.ID)}." };
            yield return new TextBlock { Id = Guid.Parse("8aa2cdac-f29f-4575-b916-007924f5a25f"), Type = TextBlockType.Text, Text = $"You also gain access to all uncommon grippli weapons. For the purpose of determining your proficiency, martial grippli weapons are simple weapons, and advanced grippli weapons are martial weapons." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Grippli.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9a21a877-d80e-46e9-a198-680b796956de"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
