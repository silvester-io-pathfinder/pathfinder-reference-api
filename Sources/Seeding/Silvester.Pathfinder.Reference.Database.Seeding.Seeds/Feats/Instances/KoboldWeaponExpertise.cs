using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class KoboldWeaponExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("3dc776f9-1882-41f1-90e2-1183169d719a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Kobold Weapon Expertise",
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
            yield return new TextBlock { Id = Guid.Parse("276917da-30ec-48bd-b9e9-9848bd968808"), Type = TextBlockType.Text, Text = $"Whenever you gain a class feature that grants you expert or greater proficiency in a given weapon or weapons, you also gain that proficiency in the {ToMarkdownLink<Models.Items.Instances.RangedWeapon>("crossbow", Items.RangedWeapons.Instances.Crossbow.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("greatpick", Items.MeleeWeapons.Instances.Greatpick.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("light pick", Items.MeleeWeapons.Instances.LightPick.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("pick", Items.MeleeWeapons.Instances.Pick.ID)}, and {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("spear", Items.MeleeWeapons.Instances.Spear.ID)}, as well as any kobold weapons in which you are trained." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("9b590fe4-6ea4-49af-bbc7-7efd181833e6"), Feats.Instances.KoboldWeaponFamiliarity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2dd5059f-0b15-41d8-b16e-56b041172381"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
