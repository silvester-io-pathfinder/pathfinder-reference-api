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
    public class VanthsWeaponFamiliarity : Template
    {
        public static readonly Guid ID = Guid.Parse("5ae1f066-b56a-450e-abea-01b4816cdc35");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vanth's Weapon Familiarity",
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
            yield return new TextBlock { Id = Guid.Parse("1bbb7c1d-c1b8-474b-8b8f-0c27fb32f85f"), Type = TextBlockType.Text, Text = $"You seek to emulate vanth reapers' fighting styles. You are trained with {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("bo staves", Items.MeleeWeapons.Instances.BoStaff.ID)}, {ToMarkdownLink<Models.Items.Instances.RangedWeapon>("longbows", Items.RangedWeapons.Instances.Longbow.ID)}, {ToMarkdownLink<Models.Items.Instances.RangedWeapon>("composite longbows", Items.RangedWeapons.Instances.CompositeLongbow.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("scythes", Items.MeleeWeapons.Instances.Scythe.ID)}, and {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("staves", Items.MeleeWeapons.Instances.Staff.ID)}." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("a3eaad80-bb51-41ed-bc4a-912d101d88d1"), Traits.Instances.Duskwalker.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("95b72f81-dab1-44c4-910e-d76bc9267001"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
