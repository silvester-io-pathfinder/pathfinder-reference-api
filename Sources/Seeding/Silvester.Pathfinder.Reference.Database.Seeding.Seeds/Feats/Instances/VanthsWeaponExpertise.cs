using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VanthsWeaponExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("52a2c900-a515-4989-ae51-788570d5d31a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vanth's Weapon Expertise",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1fc920ea-b96f-415c-a7d8-9d839a30a527"), Type = TextBlockType.Text, Text = $"Vanths themselves recognize you as an honorary reaper. Whenever you gain a class feature that grants you expert or greater proficiency in a given weapon or weapons, you also gain that proficiency in {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("bo staves", Items.MeleeWeapons.Instances.BoStaff.ID)}, {ToMarkdownLink<Models.Items.Instances.RangedWeapon>("longbows", Items.RangedWeapons.Instances.Longbow.ID)}, {ToMarkdownLink<Models.Items.Instances.RangedWeapon>("composite longbows", Items.RangedWeapons.Instances.CompositeLongbow.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("scythes", Items.MeleeWeapons.Instances.Scythe.ID)}, and {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("staves", Items.MeleeWeapons.Instances.Staff.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a71b10e8-ffe6-471e-bfe6-cd786659cf2a"), Feats.Instances.VanthsWeaponFamiliarity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e77b4da9-413e-44e1-b6f4-d56c92cd0cd8"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
