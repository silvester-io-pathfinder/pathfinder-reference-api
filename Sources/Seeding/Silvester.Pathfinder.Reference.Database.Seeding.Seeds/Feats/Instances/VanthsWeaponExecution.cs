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
    public class VanthsWeaponExecution : Template
    {
        public static readonly Guid ID = Guid.Parse("2ec39e60-265f-4c6f-902c-cd95c743ae9e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vanth's Weapon Execution",
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
            yield return new TextBlock { Id = Guid.Parse("2b707dc8-b792-4925-821e-038bba02b26a"), Type = TextBlockType.Text, Text = $"You've trained in the finer points of dealing death. Whenever you critically hit using a {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("bo staff", Items.MeleeWeapons.Instances.BoStaff.ID)}, {ToMarkdownLink<Models.Items.Instances.RangedWeapon>("longbow", Items.RangedWeapons.Instances.Longbow.ID)}, {ToMarkdownLink<Models.Items.Instances.RangedWeapon>("composite longbow", Items.RangedWeapons.Instances.CompositeLongbow.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("scythe", Items.MeleeWeapons.Instances.Scythe.ID)}, or {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("staff", Items.MeleeWeapons.Instances.Staff.ID)}, you apply the weapon's critical specialization effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("5556d346-56b4-41b0-9797-4d929fe0f9d0"), Feats.Instances.VanthsWeaponFamiliarity.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Duskwalker.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("14bc5ae4-86a5-4a2d-ab7c-72e943dce903"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
