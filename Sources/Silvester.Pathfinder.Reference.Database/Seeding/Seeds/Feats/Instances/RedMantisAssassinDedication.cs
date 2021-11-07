using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RedMantisAssassinDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("cda78d2b-503d-4194-b1dc-55219e0e64b5");

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
            yield return new TextBlock { Id = Guid.Parse("e3788d0e-1879-459d-a2e8-b3c58a1eccc5"), Type = TextBlockType.Text, Text = "~ Access: You are from Mediogalti Island." };
            yield return new TextBlock { Id = Guid.Parse("6c3ee088-46de-48a7-8ddd-fb213241e868"), Type = TextBlockType.Text, Text = "You have learned how to stalk your foes and slay them with a sawtooth sabre. You become trained in Stealth and Assassin Lore; if you were already trained, you become an expert instead. Whenever your proficiency in any weapon increases to expert or beyond, you also gain that new proficiency with sawtooth sabers." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMeleeWeaponSpecificProficiency(Guid.Parse("aa8f2db0-4ad0-4ab1-b67f-2792619c4230"), Proficiencies.Instances.Trained.ID, MeleeWeapons.Instances.SawtoothSaber.ID);
            builder.HaveSpecificDeity(Guid.Parse("6dcb0638-bedd-4f7a-847b-0fd228f23500"), Deities.Instances.Achaekek.ID);
            builder.HaveSpecificAlignment(Guid.Parse("03ff53f5-7b89-49a8-831c-302ad860d3d4"), Alignments.Instances.LawfulEvil.ID);
            builder.Manual(Guid.Parse("45a18fa2-dd3b-4115-be05-9b622fc5bfe7"), "Member of the Red Mantis assassins.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("210d5814-783a-4d83-a012-13c20b80e61c"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
