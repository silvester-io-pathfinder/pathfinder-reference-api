using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RedMantisAssassinDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("8de07624-db5f-4e67-b4b1-e8d0402574a9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Red Mantis Assassin Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the Red Mantis assassin archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("640970bd-2c3d-4ebe-b7ed-9e9e59f59033"), Type = TextBlockType.Text, Text = "~ Access: You are from Mediogalti Island." };
            yield return new TextBlock { Id = Guid.Parse("25e9d061-7c42-4650-a65a-ef40c3070abc"), Type = TextBlockType.Text, Text = "You have learned how to stalk your foes and slay them with a sawtooth sabre. You become trained in Stealth and Assassin Lore; if you were already trained, you become an expert instead. Whenever your proficiency in any weapon increases to expert or beyond, you also gain that new proficiency with sawtooth sabers." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMeleeWeaponSpecificProficiency(Guid.Parse("44b08fcb-54bf-4722-87d9-8e61d31bbf70"), Proficiencies.Instances.Trained.ID, Items.MeleeWeapons.Instances.SawtoothSaber.ID);
            builder.HaveSpecificDeity(Guid.Parse("636fba60-7e09-4cf5-b460-8eff260e24ad"), Deities.Instances.Achaekek.ID);
            builder.HaveSpecificAlignment(Guid.Parse("2f835a7e-ce37-48ed-ba98-10843ee277fb"), Alignments.Instances.LawfulEvil.ID);
            builder.Manual(Guid.Parse("336ce42f-8be8-4f12-8622-8e40e30fb334"), "Member of the Red Mantis assassins.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6a3ad350-6f09-4992-90ac-1020522fc51f"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
