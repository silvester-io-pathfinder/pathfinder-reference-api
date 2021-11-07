using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FarabellusFlip : Template
    {
        public static readonly Guid ID = Guid.Parse("12395a6a-a2b3-4222-bc40-f0da09d72b26");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Farabellus Flip",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An enemy targets you with a melee Strike.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("df8af5b5-859c-4b25-9efa-a1bab1f03aae"), Type = TextBlockType.Text, Text = "~ Access: Member of the Pathfinder Society." };
            yield return new TextBlock { Id = Guid.Parse("2686ffa8-cada-467a-ae45-1f30f8a2bb7b"), Type = TextBlockType.Text, Text = "Surprisingly agile even in a breastplate and carrying a full rucksack, Marcos Farabellus developed this evasive maneuver during one of his many adventures. Flinging your body into a twisting somersault, you gain a +2 circumstance bonus to your AC against the triggering attack. If the attack still hits you, you can (action: Step) to an open space that&#39;s still within the triggering enemy&#39;s reach, turning the impact of the blow into momentum." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("6794f61a-0297-4da2-91d1-695dcf6f23f6"), Proficiencies.Instances.Trained.ID, Skills.Instances.Acrobatics.ID);
            builder.HaveSpecificArmorCategorySpecificProficiency(Guid.Parse("7c4e9fc2-45db-48ec-9b35-e6a3fd733774"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.Medium.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8e493baa-067c-4b45-b829-dd5991ada0eb"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
