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
    public class GrippliWeaponInnovator : Template
    {
        public static readonly Guid ID = Guid.Parse("1f53b7ea-a2fe-4f64-8fcf-6789e7de0ef6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Grippli Weapon Innovator",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("679503e4-dd27-4248-8599-49bf71e04824"), Type = TextBlockType.Text, Text = $"You've learned devious ways to make the most of your grippli weapons. Whenever you critically hit using a {ToMarkdownLink<Models.Items.Instances.RangedWeapon>("blowguns", Items.RangedWeapons.Instances.Blowgun.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("hatchets", Items.MeleeWeapons.Instances.Hatchet.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("scythes", Items.MeleeWeapons.Instances.Scythe.ID)}, {ToMarkdownLink<Models.Items.Instances.RangedWeapon>("shortbows", Items.RangedWeapons.Instances.Shortbow.ID)}, {ToMarkdownLink<Models.Items.Instances.RangedWeapon>("composite shortbows", Items.RangedWeapons.Instances.CompositeShortbow.ID)}, or grippli weapon, you apply the weapon's critical specialization effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("8bd7b7a1-1e25-4892-b3ad-8295356c7af2"), Feats.Instances.GrippliWeaponFamiliarity.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("60ad7e4e-5ad9-4706-9b2b-0e4f12c660a1"), Traits.Instances.Grippli.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8e784117-22c5-4e0e-a529-ee3ba5d823ec"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
