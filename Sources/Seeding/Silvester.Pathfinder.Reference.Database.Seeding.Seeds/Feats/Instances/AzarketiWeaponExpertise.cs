using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AzarketiWeaponExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("19c9e9e3-74d8-4bf8-8b6c-804d28ded953");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Azarketi Weapon Expertise",
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
            yield return new TextBlock { Id = Guid.Parse("681336ac-4b47-421e-ab75-aab94bfd4f44"), Type = TextBlockType.Text, Text = $"Your mastery with weapons both above and below water is unmatched. Whenever you gain a class feature that grants you expert or greater proficiency in certain weapons, you also gain that proficiency in {ToMarkdownLink<Models.Items.Instances.RangedWeapon>("crossbows", Items.RangedWeapons.Instances.Crossbow.ID)}, {ToMarkdownLink<Models.Items.Instances.RangedWeapon>("hand crossbows", Items.RangedWeapons.Instances.HandCrossbow.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("longspears", Items.MeleeWeapons.Instances.Longspear.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("spears", Items.MeleeWeapons.Instances.Spear.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("tridents", Items.MeleeWeapons.Instances.Trident.ID)}, and all azarketi weapons in which you are trained." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4230b481-de64-40dc-98e5-070ee7183354"), Feats.Instances.AzarketiWeaponFamiliarity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("af336f03-ce5a-4745-a52a-0a19ec663fba"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
