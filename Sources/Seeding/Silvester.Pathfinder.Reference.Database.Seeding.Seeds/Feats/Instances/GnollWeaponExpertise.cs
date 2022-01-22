using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GnollWeaponExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("97263b49-5543-43f6-adb4-8d2093542c73");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Gnoll Weapon Expertise",
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
            yield return new TextBlock { Id = Guid.Parse("5f2a01b4-3ee0-4753-91a2-9967f1c5b442"), Type = TextBlockType.Text, Text = $"Whenever you gain a class feature that grants you expert or greater proficiency in a given weapon or weapons, you also gain that proficiency in {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("flails", Items.MeleeWeapons.Instances.Flail.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("khopeshes", Items.MeleeWeapons.Instances.Khopesh.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("mambeles", Items.MeleeWeapons.Instances.Mambele.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("spears", Items.MeleeWeapons.Instances.Spear.ID)}, and {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("war flails", Items.MeleeWeapons.Instances.WarFlail.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4bd8b063-42f6-40a6-9bc6-97bf6c10cb56"), Feats.Instances.GnollWeaponPracticality.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d268120e-76c7-4767-a5e8-4710c06152f4"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
