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
    public class AzarketiWeaponFamiliarity : Template
    {
        public static readonly Guid ID = Guid.Parse("9fd15dcc-e5e2-4f22-b67d-dee5ced2017c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Azarketi Weapon Familiarity",
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
            yield return new TextBlock { Id = Guid.Parse("0022754c-b0db-4c05-a4d9-e35414981e3c"), Type = TextBlockType.Text, Text = $"You are familiar with weapons that excel underwater. You are trained with {ToMarkdownLink<Models.Items.Instances.RangedWeapon>("crossbows", Items.RangedWeapons.Instances.Crossbow.ID)}, {ToMarkdownLink<Models.Items.Instances.RangedWeapon>("hand crossbows", Items.RangedWeapons.Instances.HandCrossbow.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("longspears", Items.MeleeWeapons.Instances.Longspear.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("spears", Items.MeleeWeapons.Instances.Spear.ID)}, and {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("tridents", Items.MeleeWeapons.Instances.Trident.ID)}. In addition, you gain access to all uncommon azarketi weapons. For the purpose of determining your proficiency, martial azarketi weapons are simple weapons and advanced azarketi weapons are martial weapons." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("16b444ae-8a2d-4905-a708-e2098b245dab"), Traits.Instances.Azarketi.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d0c742c6-a414-4110-ba55-efb5ec909cf2"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
